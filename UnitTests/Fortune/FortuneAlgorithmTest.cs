#define BRUTE_FORCE_TEST

using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System;
using NUnit.Framework.Legacy;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class FortuneAlgorithmTest
    {
        [Test]
        public void NoPoints()
        {
            List<VoronoiSite> points = new List<VoronoiSite>();

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(0, edges.Count);
        }

        [Test]
        public void OnePoint()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(300, 300)
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(0, edges.Count);
        }

        [TestCase(-100, 300)]
        [TestCase(300, -100)]
        [TestCase(700, 300)]
        [TestCase(300, 700)]
        [TestCase(-100, -100)]
        [TestCase(700, -100)]
        [TestCase(700, 700)]
        [TestCase(-100, 700)]
        public void PointOutsideBoundsAlone(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y)
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(0, edges.Count);
            ClassicAssert.AreEqual(0, points[0].Cell.Count());
        }

        [TestCase(-100, 300)]
        [TestCase(300, -100)]
        [TestCase(700, 300)]
        [TestCase(300, 700)]
        [TestCase(-100, -100)]
        [TestCase(700, -100)]
        [TestCase(700, 700)]
        [TestCase(-100, 700)]
        public void PointOutsideBoundsAgainstInBoundsPoint(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y),
                new VoronoiSite(300, 300)
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(1, edges.Count);
            ClassicAssert.AreEqual(1, points[0].Cell.Count());
            ClassicAssert.AreEqual(1, points[1].Cell.Count());
        }

        [TestCase(-1000, 300)]
        [TestCase(300, -1000)]
        [TestCase(7000, 300)]
        [TestCase(300, 7000)]
        [TestCase(-1000, -1000)]
        [TestCase(7000, -1000)]
        [TestCase(7000, 7000)]
        [TestCase(-1000, 7000)]
        public void PointFarOutsideBoundsAgainstInBoundsPoint(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y),
                new VoronoiSite(300, 300)
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(0, edges.Count);
            ClassicAssert.AreEqual(0, points[0].Cell.Count());
            ClassicAssert.AreEqual(0, points[1].Cell.Count());
        }

        [TestCase(0, 300)]
        [TestCase(300, 0)]
        [TestCase(600, 300)]
        [TestCase(300, 600)]
        [TestCase(0, 0)]
        [TestCase(600, 0)]
        [TestCase(600, 600)]
        [TestCase(0, 600)]
        public void PointOnBoundsAlone(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y)
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(0, edges.Count);
            ClassicAssert.AreEqual(0, points[0].Cell.Count());
        }

        [TestCase(0, 300)]
        [TestCase(300, 0)]
        [TestCase(600, 300)]
        [TestCase(300, 600)]
        [TestCase(0, 0)]
        [TestCase(600, 0)]
        [TestCase(600, 600)]
        [TestCase(0, 600)]
        public void PointOnBoundsAgainstInBoundsPoint(double x, double y)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x, y),
                new VoronoiSite(300, 300)
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(1, edges.Count);
            ClassicAssert.AreEqual(1, points[0].Cell.Count());
            ClassicAssert.AreEqual(1, points[1].Cell.Count());
        }
        
        [Test]
        public void FourPointsOutsideBounds()
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(-100, 300),
                new VoronoiSite(300, -100),
                new VoronoiSite(800, 300),
                new VoronoiSite(300, 800)
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(4, edges.Count);
        }
        
        [TestCase(-100, -100, -200, -200)]
        [TestCase(-100, 700, -200, 800)]
        [TestCase(700, 700, 800, 800)]
        [TestCase(700, -100, 800, -200)]
        [TestCase(700, 300, 800, 300)]
        [TestCase(300, 700, 300, 800)]
        [TestCase(-100, 300, -200, 300)]
        [TestCase(300, -100, 300, -200)]
        public void TwoPointsOutsideBoundsTogether(double x1, double y1, double x2, double y2)
        {
            List<VoronoiSite> points = new List<VoronoiSite>
            {
                new VoronoiSite(x1, y1),
                new VoronoiSite(x2, y2)
            };

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();
            
            ClassicAssert.AreEqual(0, edges.Count);
        }

#if BRUTE_FORCE_TEST
        /// <summary>
        /// Ideally, we don't want to run this because it's random and not repeatable.
        /// </summary>
        [Test]
        [Repeat(10000)]
        public void RandomPointFractionalBruteforce()
        {
            Random random = new Random();
            
            int count = 100 + random.Next(100);
    
            List<VoronoiSite> points = new List<VoronoiSite>(count);
    
            for (int j = 0; j < count; j++)
            {
                points.Add(new VoronoiSite(random.NextDouble() * 3000 - 1500, random.NextDouble() * 3000 - 1500));
            }
    
            VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges);
            
            // These are really slow and only work on in-bounds values:
            // CollectionAssert.AllItemsAreNotNull(edges);
            //     
            // foreach (VoronoiSite point in points)
            // {
            //     Assert.NotNull(point.cell);
            //     CollectionAssert.IsNotEmpty(point.cell);
            //     CollectionAssert.AllItemsAreNotNull(point.cell);
            //     foreach (VoronoiEdge edge in point.cell)
            //     {
            //         CollectionAssert.Contains(edges, edge);
            //         Assert.NotNull(edge.Left);
            //         Assert.NotNull(edge.Right);
            //     }
            // }
            
            Assert.Pass();
        }
        
        /// <summary>
        /// Ideally, we don't want to run this because it's random and not repeatable.
        /// </summary>
        [Test]
        [Repeat(10000)]
        public void RandomPointWholeBruteforce()
        {
            Random random = new Random();
            
            int count = 10 + random.Next(10);
    
            List<VoronoiSite> points = new List<VoronoiSite>(count);
    
            for (int j = 0; j < count; j++)
            {
                points.Add(new VoronoiSite(random.Next(3000) - 1500, random.Next(3000) - 1500));
            }
    
            VoronoiPlane.TessellateOnce(points, 0, 0, 600, 600, BorderEdgeGeneration.DoNotMakeBorderEdges);
            
            Assert.Pass();
        }
#endif
    }
}