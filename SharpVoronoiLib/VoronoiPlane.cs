using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using SharpVoronoiLib.Exceptions;

namespace SharpVoronoiLib
{
    /// <summary>
    /// An Euclidean plane where a Voronoi diagram can be constructed from <see cref="VoronoiSite"/>s
    /// producing a tesselation of cells with <see cref="VoronoiEdge"/> line segments and <see cref="VoronoiPoint"/> vertices.
    /// </summary>
    public class VoronoiPlane
    {
        [PublicAPI]
        public List<VoronoiSite>? Sites { get; private set; }

        [PublicAPI]
        public List<VoronoiEdge>? Edges
        {
            get
            {
                if (_edges == null)
                    throw new VoronoiNotTessellatedException();
                
                return _edges;
            }
        }

        // todo: add Points

        [PublicAPI]
        public double MinX { get; }

        [PublicAPI]
        public double MinY { get; }

        [PublicAPI]
        public double MaxX { get; }

        [PublicAPI]
        public double MaxY { get; }


        private List<VoronoiEdge>? _edges;

        private RandomUniformPointGeneration? _randomUniformPointGeneration;
        private RandomGaussianPointGeneration? _randomGaussianPointGeneration;
        
        private ITessellationAlgorithm? _tessellationAlgorithm;
        
        private IBorderClippingAlgorithm? _borderClippingAlgorithm;
        
        private IBorderClosingAlgorithm? _borderClosingAlgorithm;
        
        private IRelaxationAlgorithm? _relaxationAlgorithm;
        
        private ISiteMergingAlgorithm? _siteMergingAlgorithm;
        
        private INearestSiteLookup? _nearestSiteLookupAlgorithm;
        
        private BorderEdgeGeneration _lastBorderGeneration;


        public VoronoiPlane(double minX, double minY, double maxX, double maxY)
        {
            if (minX >= maxX) throw new ArgumentException();
            if (minY >= maxY) throw new ArgumentException();

            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }


        [PublicAPI]
        public void SetSites(List<VoronoiSite> sites)
        {
            if (sites == null) throw new ArgumentNullException(nameof(sites));

            Sites = sites;

            _edges = null;
        }

        /// <summary>
        ///
        /// The generated sites are guaranteed not to lie on the border of the plane (although they may be very close).
        /// </summary>
        [PublicAPI]
        public List<VoronoiSite> GenerateRandomSites(int amount, PointGenerationMethod method = PointGenerationMethod.Uniform)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));


            IPointGenerationAlgorithm algorithm = GetPointGenerationAlgorithm(method);

            List<VoronoiSite> sites = algorithm.Generate(MinX, MinY, MaxX, MaxY, amount);
            
            Sites = sites;

            _edges = null;
            
            return sites;
        }

        [PublicAPI]
        public List<VoronoiEdge> Tessellate(BorderEdgeGeneration borderGeneration = BorderEdgeGeneration.MakeBorderEdges)
        {
            if (Sites == null) throw new VoronoiDoesntHaveSitesException();

            
            _lastBorderGeneration = borderGeneration;

            // Tessellate
            
            if (_tessellationAlgorithm == null)
                _tessellationAlgorithm = new FortunesTessellation();

            List<VoronoiEdge> edges = _tessellationAlgorithm.Run(Sites, MinX, MinY, MaxX, MaxY);

            // Clip

            // todo: make clipping optional
            
            if (_borderClippingAlgorithm == null)
                _borderClippingAlgorithm = new GenericClipping();
            
            edges = _borderClippingAlgorithm.Clip(edges, MinX, MinY, MaxX, MaxY);

            // Enclose
            
            if (borderGeneration == BorderEdgeGeneration.MakeBorderEdges)
            {
                if (_borderClosingAlgorithm == null)
                    _borderClosingAlgorithm = new GenericBorderClosing();

                edges = _borderClosingAlgorithm.Close(edges, MinX, MinY, MaxX, MaxY, Sites);
            }
            
            // Done

            _edges = edges;
            
            return edges;
        }

        [PublicAPI]
        public List<VoronoiEdge> Relax(int iterations = 1, float strength = 1.0f, bool reTessellate = true)
        {
            if (Sites == null) throw new VoronoiDoesntHaveSitesException();
            if (Edges == null) throw new VoronoiNotTessellatedException();
            if (iterations < 1) throw new ArgumentOutOfRangeException(nameof(iterations));
            if (strength <= 0f || strength > 1f) throw new ArgumentOutOfRangeException(nameof(strength));

            
            if (_relaxationAlgorithm == null)
                _relaxationAlgorithm = new LloydsRelaxation();

            for (int i = 0; i < iterations; i++)
            {
                // Relax once
                _relaxationAlgorithm.Relax(Sites, MinX, MinY, MaxX, MaxY, strength);

                if (i < iterations - 1 || // always have to tessellate if this isn't the last iteration, otherwise this makes no sense
                    reTessellate)
                {
                    // Re-tesselate with the new site locations
                    Tessellate(_lastBorderGeneration); // will set Edges
                }
            }

            return Edges;
        }

        [PublicAPI]
        public List<VoronoiSite> MergeSites(VoronoiSiteMergeQuery mergeQuery)
        {
            if (Sites == null) throw new VoronoiDoesntHaveSitesException();
            if (Edges == null) throw new VoronoiNotTessellatedException();
            if (mergeQuery == null) throw new ArgumentNullException(nameof(mergeQuery));
            

            if (_siteMergingAlgorithm == null)
                _siteMergingAlgorithm = new GenericSiteMergingAlgorithm();

            _siteMergingAlgorithm.MergeSites(Sites, Edges, mergeQuery);

            return Sites;
        }

        [PublicAPI]
        public VoronoiSite GetNearestSiteTo(double x, double y)
        {
            if (Sites == null) throw new VoronoiDoesntHaveSitesException();
            if (Edges == null) throw new VoronoiNotTessellatedException();
            
            
            if (_nearestSiteLookupAlgorithm == null)
                _nearestSiteLookupAlgorithm = new BruteForceNearestSiteLookup();

            return _nearestSiteLookupAlgorithm.GetNearestSiteTo(Sites, x, y);
        }


        [PublicAPI]
        public static List<VoronoiEdge> TessellateRandomSitesOnce(int numberOfSites, double minX, double minY, double maxX, double maxY, BorderEdgeGeneration borderGeneration = BorderEdgeGeneration.MakeBorderEdges)
        {
            if (numberOfSites < 0) throw new ArgumentOutOfRangeException(nameof(numberOfSites));


            VoronoiPlane plane = new VoronoiPlane(minX, minY, maxX, maxY);

            plane.GenerateRandomSites(numberOfSites);
            
            return plane.Tessellate(borderGeneration);
        }

        [PublicAPI]
        public static List<VoronoiEdge> TessellateOnce(List<VoronoiSite> sites, double minX, double minY, double maxX, double maxY, BorderEdgeGeneration borderGeneration = BorderEdgeGeneration.MakeBorderEdges)
        {
            if (sites == null) throw new ArgumentNullException(nameof(sites));


            VoronoiPlane plane = new VoronoiPlane(minX, minY, maxX, maxY);

            plane.SetSites(sites);
            
            return plane.Tessellate(borderGeneration);
        }
        

        private IPointGenerationAlgorithm GetPointGenerationAlgorithm(PointGenerationMethod pointGenerationMethod)
        {
            return pointGenerationMethod switch
            {
                PointGenerationMethod.Uniform  => _randomUniformPointGeneration ??= new RandomUniformPointGeneration(),
                PointGenerationMethod.Gaussian => _randomGaussianPointGeneration ??= new RandomGaussianPointGeneration(),

                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }


    public enum BorderEdgeGeneration
    {
        DoNotMakeBorderEdges = 0,
        MakeBorderEdges = 1
    }
}
