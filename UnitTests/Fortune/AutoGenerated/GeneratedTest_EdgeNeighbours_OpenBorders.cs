using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

#pragma warning disable
// ReSharper disable All

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiEdge"/>`s have expected neighbouring edges.
    /// Specifically, that the <see cref="VoronoiEdge.Neighbours"/> contains the expected <see cref="VoronoiEdge"/>`s.
    /// These tests are run without generating the border edges, i.e. <see cref="BorderEdgeGeneration.DoNotMakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_EdgeNeighbours_OpenBorders
    {
        [Test]
        public void NoPoints()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        [Test]
        public void OnePointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        1                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        [Test]
        public void OnePointOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 500), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |         1                                        
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 800), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                        1                         
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 500), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                       1          
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 200), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                        1                         
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        [Test]
        public void OnePointArbitrary()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 700), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |         1                                        
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 800), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                  1               
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 300), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                       1          
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointArbitrary"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointArbitrary_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 200), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |              1                                   
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        [Test]
        public void OnePointOnBorderCentered()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 500), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 1                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 1000), // #1
            };

            // 1000 ↑                        1                         
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 500), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                 1
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderCentered"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderCentered_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 0), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └------------------------1------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        [Test]
        public void OnePointOnBorderOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 700), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 1                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 1000), // #1
            };

            // 1000 ↑                                  1               
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 300), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                 1
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 0), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └--------------1----------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 700), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                 1
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 0), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └----------------------------------1--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 300), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 1                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointOnBorderOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointOnBorderOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 1000), // #1
            };

            // 1000 ↑              1                                   
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        [Test]
        public void OnePointInCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 0), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 1-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 1000), // #1
            };

            // 1000 1                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 1000), // #1
            };

            // 1000 ↑                                                 1
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        /// <summary>
        /// This test basically repeats <see cref="OnePointInCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void OnePointInCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 0), // #1
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                                                  
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------1
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 0 == edges.Count, "Expected: edge count 0");
            Assume.That(() => null != edges);

            // Assert

            // There are no edges, so nothing to check
            Assert.Pass();
        }

        [Test]
        public void TwoPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(500, 300), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                        1                         
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 A-------------------------------------------------B
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                        2                         
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 500), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 500, 1000, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(300, 500), // #2
            };

            // 1000 ↑                        A                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              2         |         1               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------B------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 1000, 500, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 1000, 500, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void TwoPointsVerticalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(500, 500), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                        1                         
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        2                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsVerticalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsHorizontalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(500, 500), // #2
            };

            // 1000 ↑                                  A               
            //      |                                  |               
            //  900 |                                  |               
            //      |                                  |               
            //  800 |                                  |               
            //      |                                  |               
            //  700 |                                  |               
            //      |                                  |               
            //  600 |                                  |               
            //      |                                  |               
            //  500 |                        2         |         1     
            //      |                                  |               
            //  400 |                                  |               
            //      |                                  |               
            //  300 |                                  |               
            //      |                                  |               
            //  200 |                                  |               
            //      |                                  |               
            //  100 |                                  |               
            //      |                                  |               
            //    0 └----------------------------------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void ThreeConcentricPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(500, 100), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                        1                         
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        2                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 C-------------------------------------------------D
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                        3                         
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 300, 1000, 300), "Expected: has edge C-D"); // C-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 300, 1000, 300); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(100, 500), // #3
            };

            // 1000 ↑              C                   A               
            //      |              |                   |               
            //  900 |              |                   |               
            //      |              |                   |               
            //  800 |              |                   |               
            //      |              |                   |               
            //  700 |              |                   |               
            //      |              |                   |               
            //  600 |              |                   |               
            //      |              |                   |               
            //  500 |    3         |         2         |         1     
            //      |              |                   |               
            //  400 |              |                   |               
            //      |              |                   |               
            //  300 |              |                   |               
            //      |              |                   |               
            //  200 |              |                   |               
            //      |              |                   |               
            //  100 |              |                   |               
            //      |              |                   |               
            //    0 └--------------D-------------------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 1000, 300, 0), "Expected: has edge C-D"); // C-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 300, 1000, 300, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void FourConcentricPointsVerticalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 800), // #1
                new VoronoiSite(500, 600), // #2
                new VoronoiSite(500, 400), // #3
                new VoronoiSite(500, 200), // #4
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                        1                         
            //      |                                                  
            //  700 A-------------------------------------------------B
            //      |                                                  
            //  600 |                        2                         
            //      |                                                  
            //  500 C-------------------------------------------------D
            //      |                                                  
            //  400 |                        3                         
            //      |                                                  
            //  300 E-------------------------------------------------F
            //      |                                                  
            //  200 |                        4                         
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 500), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 0, 300, 1000, 300), "Expected: has edge E-F"); // E-F

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1000, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 500, 1000, 500); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 300, 1000, 300); // E-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="FourConcentricPointsVerticalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourConcentricPointsHorizontalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 500), // #1
                new VoronoiSite(600, 500), // #2
                new VoronoiSite(400, 500), // #3
                new VoronoiSite(200, 500), // #4
            };

            // 1000 ↑              E         C         A               
            //      |              |         |         |               
            //  900 |              |         |         |               
            //      |              |         |         |               
            //  800 |              |         |         |               
            //      |              |         |         |               
            //  700 |              |         |         |               
            //      |              |         |         |               
            //  600 |              |         |         |               
            //      |              |         |         |               
            //  500 |         4    |    3    |    2    |    1          
            //      |              |         |         |               
            //  400 |              |         |         |               
            //      |              |         |         |               
            //  300 |              |         |         |               
            //      |              |         |         |               
            //  200 |              |         |         |               
            //      |              |         |         |               
            //  100 |              |         |         |               
            //      |              |         |         |               
            //    0 └--------------F---------D---------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 1000, 500, 0), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 300, 1000, 300, 0), "Expected: has edge E-F"); // E-F

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1000, 700, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 500, 1000, 500, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 300, 1000, 300, 0); // E-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void TwoDiagonalPointsAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(700, 300), // #2
            };

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |              1                  ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |                       ,·'                        
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                  2               
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 A'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 700), // #1
                new VoronoiSite(300, 300), // #2
            };

            // 1000 A,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                  1               
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |              2                  '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 1000, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(600, 400), // #2
            };

            // 1000 ↑                                      ,B          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 |         1                  ,·'                   
            //      |                          ,'                      
            //  700 |                       ,·'                        
            //      |                     ,'                           
            //  600 |                  ,·'                             
            //      |                ,'                                
            //  500 |             ,·'                                  
            //      |           ,'                                     
            //  400 |        ,·'                  2                    
            //      |      ,'                                          
            //  300 |   ,·'                                            
            //      | ,'                                               
            //  200 A'                                                 
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 200, 800, 1000), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 200, 800, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(400, 400), // #2
            };

            // 1000 ↑         A,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                  1          
            //      |                     ',                           
            //  700 |                       '·,                        
            //      |                          ',                      
            //  600 |                            '·,                   
            //      |                               ',                 
            //  500 |                                 '·,              
            //      |                                    ',            
            //  400 |                   2                  '·,         
            //      |                                         ',       
            //  300 |                                           '·,    
            //      |                                              ',  
            //  200 |                                                'B
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 200, 1000, 1000, 200), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 200, 1000, 1000, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 200), // #1
                new VoronoiSite(400, 600), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                ,A
            //      |                                              ,'  
            //  700 |                                           ,·'    
            //      |                                         ,'       
            //  600 |                   2                  ,·'         
            //      |                                    ,'            
            //  500 |                                 ,·'              
            //      |                               ,'                 
            //  400 |                            ,·'                   
            //      |                          ,'                      
            //  300 |                       ,·'                        
            //      |                     ,'                           
            //  200 |                  ,·'                  1          
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------B'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 800, 200, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 800, 200, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoDiagonalPointsOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoDiagonalPointsOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200), // #1
                new VoronoiSite(600, 600), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 B,                                                 
            //      | ',                                               
            //  700 |   '·,                                            
            //      |      ',                                          
            //  600 |        '·,                  2                    
            //      |           ',                                     
            //  500 |             '·,                                  
            //      |                ',                                
            //  400 |                  '·,                             
            //      |                     ',                           
            //  300 |                       '·,                        
            //      |                          ',                      
            //  200 |         1                  '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'A---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 800, 0, 0, 800), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 800, 0, 0, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void TwoPointsAgainstCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 400), // #1
                new VoronoiSite(600, 800), // #2
            };

            // 1000 A,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                  2                    
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,                        
            //      |                          ',                      
            //  400 |         1                  '·,                   
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 1000, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(400, 800), // #1
                new VoronoiSite(800, 400), // #2
            };

            // 1000 ↑                                                ,A
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                   1                  ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |                       ,·'                        
            //      |                     ,'                           
            //  400 |                  ,·'                  2          
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 B'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 600), // #1
                new VoronoiSite(400, 200), // #2
            };

            // 1000 B,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 |                  '·,                  1          
            //      |                     ',                           
            //  500 |                       '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                   2                  '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 1000), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 200), // #1
                new VoronoiSite(200, 600), // #2
            };

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |         2                  ,·'                   
            //      |                          ,'                      
            //  500 |                       ,·'                        
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                  1                    
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 A'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void TwoPointsAgainstCornerSlanted()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 900), // #2
            };

            // 1000 A,,                                                
            //      |  ''·,,                                           
            //  900 |       ''·,,                      2               
            //      |            ''·,,                                 
            //  800 |                 ''·,,                            
            //      |                      ''·,,                       
            //  700 |                           ''·,,                  
            //      |                                ''·,,             
            //  600 |                                     ''·,,        
            //      |                                          ''·,,   
            //  500 |                        1                      ''B
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 500), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 1000, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(900, 300), // #2
            };

            // 1000 ↑                                                 A
            //      |                                                ' 
            //  900 |                                              ,'  
            //      |                                             ,    
            //  800 |                                            ·     
            //      |                                           '      
            //  700 |                                         ,'       
            //      |                                        ,         
            //  600 |                                       ·          
            //      |                                      '           
            //  500 |                        1           ,'            
            //      |                                   ,              
            //  400 |                                  ·               
            //      |                                 '                
            //  300 |                               ,'           2     
            //      |                              ,                   
            //  200 |                             ·                    
            //      |                            '                     
            //  100 |                          ,'                      
            //      |                         ,                        
            //    0 └------------------------B------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 500, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 100), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 B,,                      1                         
            //      |  ''·,,                                           
            //  400 |       ''·,,                                      
            //      |            ''·,,                                 
            //  300 |                 ''·,,                            
            //      |                      ''·,,                       
            //  200 |                           ''·,,                  
            //      |                                ''·,,             
            //  100 |              2                      ''·,,        
            //      |                                          ''·,,   
            //    0 └-----------------------------------------------''A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 500), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 0, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(100, 700), // #2
            };

            // 1000 ↑                        B                         
            //      |                       '                          
            //  900 |                     ,'                           
            //      |                    ,                             
            //  800 |                   ·                              
            //      |                  '                               
            //  700 |    2           ,'                                
            //      |               ,                                  
            //  600 |              ·                                   
            //      |             '                                    
            //  500 |           ,'           1                         
            //      |          ,                                       
            //  400 |         ·                                        
            //      |        '                                         
            //  300 |      ,'                                          
            //      |     ,                                            
            //  200 |    ·                                             
            //      |   '                                              
            //  100 | ,'                                               
            //      |,                                                 
            //    0 A-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 500, 1000), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 500, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 900), // #2
            };

            // 1000 ↑                                               ,,A
            //      |                                          ,,·''   
            //  900 |              2                      ,,·''        
            //      |                                ,,·''             
            //  800 |                           ,,·''                  
            //      |                      ,,·''                       
            //  700 |                 ,,·''                            
            //      |            ,,·''                                 
            //  600 |       ,,·''                                      
            //      |  ,,·''                                           
            //  500 B''                      1                         
            //      |                                                  
            //  400 |                                                  
            //      |                                                  
            //  300 |                                                  
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 500), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 1000, 0, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(900, 700), // #2
            };

            // 1000 ↑                        B                         
            //      |                         '                        
            //  900 |                          ',                      
            //      |                            ,                     
            //  800 |                             ·                    
            //      |                              '                   
            //  700 |                               ',           2     
            //      |                                 ,                
            //  600 |                                  ·               
            //      |                                   '              
            //  500 |                        1           ',            
            //      |                                      ,           
            //  400 |                                       ·          
            //      |                                        '         
            //  300 |                                         ',       
            //      |                                           ,      
            //  200 |                                            ·     
            //      |                                             '    
            //  100 |                                              ',  
            //      |                                                , 
            //    0 └-------------------------------------------------A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 500, 1000), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 0, 500, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 100), // #2
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                  
            //      |                                                  
            //  600 |                                                  
            //      |                                                  
            //  500 |                        1                      ,,B
            //      |                                          ,,·''   
            //  400 |                                     ,,·''        
            //      |                                ,,·''             
            //  300 |                           ,,·''                  
            //      |                      ,,·''                       
            //  200 |                 ,,·''                            
            //      |            ,,·''                                 
            //  100 |       ,,·''                      2               
            //      |  ,,·''                                           
            //    0 A''-----------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 500), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 0, 1000, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="TwoPointsAgainstCornerSlanted"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void TwoPointsAgainstCornerSlanted_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(100, 300), // #2
            };

            // 1000 A                                                  
            //      |'                                                 
            //  900 | ',                                               
            //      |   ,                                              
            //  800 |    ·                                             
            //      |     '                                            
            //  700 |      ',                                          
            //      |        ,                                         
            //  600 |         ·                                        
            //      |          '                                       
            //  500 |           ',           1                         
            //      |             ,                                    
            //  400 |              ·                                   
            //      |               '                                  
            //  300 |    2           ',                                
            //      |                  ,                               
            //  200 |                   ·                              
            //      |                    '                             
            //  100 |                     ',                           
            //      |                       ,                          
            //    0 └------------------------B------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 1 == edges.Count, "Expected: edge count 1");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 500, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 1000, 500, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void ThreeConcentricPointsDiagonalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(800, 200), // #3
            };

            // 1000 ↑                                 ,D               
            //      |                               ,'                 
            //  900 |                            ,·'                   
            //      |                          ,'                      
            //  800 |         1             ,·'                        
            //      |                     ,'                           
            //  700 |                  ,·'                           ,C
            //      |                ,'                            ,'  
            //  600 |             ,·'                           ,·'    
            //      |           ,'                            ,'       
            //  500 |        ,·'             2             ,·'         
            //      |      ,'                            ,'            
            //  400 |   ,·'                           ,·'              
            //      | ,'                            ,'                 
            //  300 A'                           ,·'                   
            //      |                          ,'                      
            //  200 |                       ,·'             3          
            //      |                     ,'                           
            //  100 |                  ,·'                             
            //      |                ,'                                
            //    0 └--------------B'---------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 300, 700, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 700), "Expected: has edge B-C"); // B-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 300, 700, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 300, 0, 1000, 700); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(200, 200), // #3
            };

            // 1000 ↑              A,                                  
            //      |                ',                                
            //  900 |                  '·,                             
            //      |                     ',                           
            //  800 |                       '·,             1          
            //      |                          ',                      
            //  700 B,                           '·,                   
            //      | ',                            ',                 
            //  600 |   '·,                           '·,              
            //      |      ',                            ',            
            //  500 |        '·,             2             '·,         
            //      |           ',                            ',       
            //  400 |             '·,                           '·,    
            //      |                ',                            ',  
            //  300 |                  '·,                           'D
            //      |                     ',                           
            //  200 |         3             '·,                        
            //      |                          ',                      
            //  100 |                            '·,                   
            //      |                               ',                 
            //    0 └---------------------------------'C--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 1000, 1000, 300), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 700, 700, 0), "Expected: has edge B-C"); // B-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 1000, 1000, 300); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 700, 700, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(600, 400), // #3
            };

            // 1000 ↑                            ,D                  ,C
            //      |                          ,'                  ,'  
            //  900 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  800 |         1        ,·'                 ,·'         
            //      |                ,'                  ,'            
            //  700 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  600 |        ,·'        2        ,·'                   
            //      |      ,'                  ,'                      
            //  500 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //  400 A'                 ,·'        3                    
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 B'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 400, 600, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge B-C"); // B-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 400, 600, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 0, 1000, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(400, 400), // #3
            };

            // 1000 B,                  A,                             
            //      | ',                  ',                           
            //  900 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  800 |        '·,                 '·,        1          
            //      |           ',                  ',                 
            //  700 |             '·,                 '·,              
            //      |                ',                  ',            
            //  600 |                  '·,        2        '·,         
            //      |                     ',                  ',       
            //  500 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //  400 |                   3        '·,                 'D
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 400), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge B-C"); // B-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 1000, 1000, 400); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 1000, 1000, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 200), // #1
                new VoronoiSite(600, 400), // #2
                new VoronoiSite(400, 600), // #3
            };

            // 1000 ↑                                                ,B
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                   3        ,·'                 ,A
            //      |                          ,'                  ,'  
            //  500 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  400 |                  ,·'        2        ,·'         
            //      |                ,'                  ,'            
            //  300 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  200 |        ,·'                 ,·'        1          
            //      |      ,'                  ,'                      
            //  100 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //    0 C'------------------D'----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 600, 400, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 0), "Expected: has edge B-C"); // B-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 600, 400, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 1000, 1000, 0, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreeConcentricPointsDiagonalOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreeConcentricPointsDiagonalOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 200), // #1
                new VoronoiSite(400, 400), // #2
                new VoronoiSite(600, 600), // #3
            };

            // 1000 C,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 D,                 '·,        3                    
            //      | ',                  ',                           
            //  500 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  400 |        '·,        2        '·,                   
            //      |           ',                  ',                 
            //  300 |             '·,                 '·,              
            //      |                ',                  ',            
            //  200 |         1        '·,                 '·,         
            //      |                     ',                  ',       
            //  100 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //    0 └----------------------------'A------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 0, 0, 600), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 1000), "Expected: has edge B-C"); // B-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 0, 0, 600); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 1000, 0, 0, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void FourConcentricPointsDiagonalAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 800), // #1
                new VoronoiSite(400, 600), // #2
                new VoronoiSite(600, 400), // #3
                new VoronoiSite(800, 200), // #4
            };

            // 1000 ↑                            ,F                  ,E
            //      |                          ,'                  ,'  
            //  900 |                       ,·'                 ,·'    
            //      |                     ,'                  ,'       
            //  800 |         1        ,·'                 ,·'         
            //      |                ,'                  ,'            
            //  700 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  600 |        ,·'        2        ,·'                 ,D
            //      |      ,'                  ,'                  ,'  
            //  500 |   ,·'                 ,·'                 ,·'    
            //      | ,'                  ,'                  ,'       
            //  400 A'                 ,·'        3        ,·'         
            //      |                ,'                  ,'            
            //  300 |             ,·'                 ,·'              
            //      |           ,'                  ,'                 
            //  200 |        ,·'                 ,·'        4          
            //      |      ,'                  ,'                      
            //  100 |   ,·'                 ,·'                        
            //      | ,'                  ,'                           
            //    0 B'------------------C'----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 400, 600, 1000), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge B-E"); // B-E
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 600), "Expected: has edge C-D"); // C-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 400, 600, 1000); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 0, 1000, 1000); // B-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 400, 0, 1000, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="FourConcentricPointsDiagonalAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourConcentricPointsDiagonalAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(600, 600), // #2
                new VoronoiSite(400, 400), // #3
                new VoronoiSite(200, 200), // #4
            };

            // 1000 B,                  A,                             
            //      | ',                  ',                           
            //  900 |   '·,                 '·,                        
            //      |      ',                  ',                      
            //  800 |        '·,                 '·,        1          
            //      |           ',                  ',                 
            //  700 |             '·,                 '·,              
            //      |                ',                  ',            
            //  600 C,                 '·,        2        '·,         
            //      | ',                  ',                  ',       
            //  500 |   '·,                 '·,                 '·,    
            //      |      ',                  ',                  ',  
            //  400 |        '·,        3        '·,                 'F
            //      |           ',                  ',                 
            //  300 |             '·,                 '·,              
            //      |                ',                  ',            
            //  200 |         4        '·,                 '·,         
            //      |                     ',                  ',       
            //  100 |                       '·,                 '·,    
            //      |                          ',                  ',  
            //    0 └----------------------------'D------------------'E
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 400), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge B-E"); // B-E
            Assume.That(() => HasEdge(edges, 0, 600, 600, 0), "Expected: has edge C-D"); // C-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 1000, 1000, 400); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 1000, 1000, 0); // B-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 600, 600, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void ThreePointsInAWedgeTowardsCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 ↑                                                ,D
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                                 ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 |              1        ,·'                        
            //      |                     ,'                           
            //  400 B-------------------A'                             
            //      |                   |                              
            //  300 |              2    |    3                         
            //      |                   |                              
            //  200 |                   |                              
            //      |                   |                              
            //  100 |                   |                              
            //      |                   |                              
            //    0 └-------------------C-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 0, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 400, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 1000), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 0, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 400, 400, 400, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 400, 400, 1000, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 400)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 ↑                   B                              
            //      |                   |                              
            //  900 |                   |                              
            //      |                   |                              
            //  800 |                   |                              
            //      |                   |                              
            //  700 |              2    |    1                         
            //      |                   |                              
            //  600 C-------------------A,                             
            //      |                     ',                           
            //  500 |              3        '·,                        
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                                 '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 400, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 0, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 0), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 400, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 400, 600, 0, 600); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 400, 600, 1000, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 600)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 ↑                             C                    
            //      |                             |                    
            //  900 |                             |                    
            //      |                             |                    
            //  800 |                             |                    
            //      |                             |                    
            //  700 |                        3    |    2               
            //      |                             |                    
            //  600 |                            ,A-------------------B
            //      |                          ,'                      
            //  500 |                       ,·'        1               
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'                                  
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 D'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 600, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 0, 0), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 1000, 600); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 600, 600, 600, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 600, 600, 0, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 600)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 D,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,                                  
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |                       '·,        3               
            //      |                          ',                      
            //  400 |                            'A-------------------C
            //      |                             |                    
            //  300 |                        1    |    2               
            //      |                             |                    
            //  200 |                             |                    
            //      |                             |                    
            //  100 |                             |                    
            //      |                             |                    
            //    0 └-----------------------------B-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 600, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 400), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 0, 1000), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 600, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 600, 400, 1000, 400); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 600, 400, 0, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 400)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 800), // #1
                new VoronoiSite(100, 400), // #2
                new VoronoiSite(500, 400), // #3
            };

            // 1000 ↑                                 ,D               
            //      |                               ,'                 
            //  900 |                            ,·'                   
            //      |                          ,'                      
            //  800 |    1                  ,·'                        
            //      |                     ,'                           
            //  700 |                  ,·'                             
            //      |                ,'                                
            //  600 B--------------A'                                  
            //      |              |                                   
            //  500 |              |                                   
            //      |              |                                   
            //  400 |    2         |         3                         
            //      |              |                                   
            //  300 |              |                                   
            //      |              |                                   
            //  200 |              |                                   
            //      |              |                                   
            //  100 |              |                                   
            //      |              |                                   
            //    0 └--------------C----------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 600, 0, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 600, 300, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 600, 700, 1000), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 600, 0, 600); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 300, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 700, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 300, 600, 300, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 0, 600)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 700, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 300, 600, 700, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 0, 600)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 600, 300, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 900), // #1
                new VoronoiSite(400, 900), // #2
                new VoronoiSite(400, 500), // #3
            };

            // 1000 ↑                             B                    
            //      |                             |                    
            //  900 |                   2         |         1          
            //      |                             |                    
            //  800 |                             |                    
            //      |                             |                    
            //  700 C-----------------------------A,                   
            //      |                               ',                 
            //  600 |                                 '·,              
            //      |                                    ',            
            //  500 |                   3                  '·,         
            //      |                                         ',       
            //  400 |                                           '·,    
            //      |                                              ',  
            //  300 |                                                'D
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 700, 600, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 700, 0, 700), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 700, 1000, 300), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 700, 600, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 0, 700)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 1000, 300)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 600, 700, 0, 700); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 600, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 1000, 300)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 600, 700, 1000, 300); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 600, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 700, 0, 700)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 200), // #1
                new VoronoiSite(900, 600), // #2
                new VoronoiSite(500, 600), // #3
            };

            // 1000 ↑                                  C               
            //      |                                  |               
            //  900 |                                  |               
            //      |                                  |               
            //  800 |                                  |               
            //      |                                  |               
            //  700 |                                  |               
            //      |                                  |               
            //  600 |                        3         |         2     
            //      |                                  |               
            //  500 |                                  |               
            //      |                                  |               
            //  400 |                                 ,A--------------B
            //      |                               ,'                 
            //  300 |                            ,·'                   
            //      |                          ,'                      
            //  200 |                       ,·'                  1     
            //      |                     ,'                           
            //  100 |                  ,·'                             
            //      |                ,'                                
            //    0 └--------------D'---------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 400, 1000, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 400, 700, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 400, 300, 0), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 400, 1000, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 700, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 300, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 700, 400, 700, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 1000, 400)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 300, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 700, 400, 300, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 1000, 400)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 400, 700, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 100), // #1
                new VoronoiSite(600, 100), // #2
                new VoronoiSite(600, 500), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 D,                                                 
            //      | ',                                               
            //  600 |   '·,                                            
            //      |      ',                                          
            //  500 |        '·,                  3                    
            //      |           ',                                     
            //  400 |             '·,                                  
            //      |                ',                                
            //  300 |                  'A-----------------------------C
            //      |                   |                              
            //  200 |                   |                              
            //      |                   |                              
            //  100 |         1         |         2                    
            //      |                   |                              
            //    0 └-------------------B-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 300, 400, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 300, 1000, 300), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 300, 0, 700), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 300, 400, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 1000, 300)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 0, 700)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 400, 300, 1000, 300); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 400, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 0, 700)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 400, 300, 0, 700); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 400, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 300, 1000, 300)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 800), // #1
                new VoronoiSite(900, 400), // #2
                new VoronoiSite(500, 400), // #3
            };

            // 1000 ↑              D,                                  
            //      |                ',                                
            //  900 |                  '·,                             
            //      |                     ',                           
            //  800 |                       '·,                  1     
            //      |                          ',                      
            //  700 |                            '·,                   
            //      |                               ',                 
            //  600 |                                 'A--------------B
            //      |                                  |               
            //  500 |                                  |               
            //      |                                  |               
            //  400 |                        3         |         2     
            //      |                                  |               
            //  300 |                                  |               
            //      |                                  |               
            //  200 |                                  |               
            //      |                                  |               
            //  100 |                                  |               
            //      |                                  |               
            //    0 └----------------------------------C--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 600, 1000, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 600, 700, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 600, 300, 1000), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 600, 1000, 600); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 700, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 300, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 700, 600, 700, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 1000, 600)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 300, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 700, 600, 300, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 1000, 600)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 600, 700, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 100), // #1
                new VoronoiSite(400, 100), // #2
                new VoronoiSite(400, 500), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                  
            //      |                                                  
            //  700 |                                                ,D
            //      |                                              ,'  
            //  600 |                                           ,·'    
            //      |                                         ,'       
            //  500 |                   3                  ,·'         
            //      |                                    ,'            
            //  400 |                                 ,·'              
            //      |                               ,'                 
            //  300 C-----------------------------A'                   
            //      |                             |                    
            //  200 |                             |                    
            //      |                             |                    
            //  100 |                   2         |         1          
            //      |                             |                    
            //    0 └-----------------------------B-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 300, 600, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 300, 0, 300), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 300, 1000, 700), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 300, 600, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 0, 300)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 1000, 700)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 600, 300, 0, 300); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 600, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 1000, 700)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 600, 300, 1000, 700); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 600, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 300, 0, 300)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 200), // #1
                new VoronoiSite(100, 600), // #2
                new VoronoiSite(500, 600), // #3
            };

            // 1000 ↑              C                                   
            //      |              |                                   
            //  900 |              |                                   
            //      |              |                                   
            //  800 |              |                                   
            //      |              |                                   
            //  700 |              |                                   
            //      |              |                                   
            //  600 |    2         |         3                         
            //      |              |                                   
            //  500 |              |                                   
            //      |              |                                   
            //  400 B--------------A,                                  
            //      |                ',                                
            //  300 |                  '·,                             
            //      |                     ',                           
            //  200 |    1                  '·,                        
            //      |                          ',                      
            //  100 |                            '·,                   
            //      |                               ',                 
            //    0 └---------------------------------'D--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 400, 0, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 400, 300, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 400, 700, 0), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 400, 0, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 300, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 700, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 300, 400, 300, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 0, 400)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 700, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 300, 400, 700, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 0, 400)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 400, 300, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsCornerOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsCornerOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 900), // #1
                new VoronoiSite(600, 900), // #2
                new VoronoiSite(600, 500), // #3
            };

            // 1000 ↑                   B                              
            //      |                   |                              
            //  900 |         1         |         2                    
            //      |                   |                              
            //  800 |                   |                              
            //      |                   |                              
            //  700 |                  ,A-----------------------------C
            //      |                ,'                                
            //  600 |             ,·'                                  
            //      |           ,'                                     
            //  500 |        ,·'                  3                    
            //      |      ,'                                          
            //  400 |   ,·'                                            
            //      | ,'                                               
            //  300 D'                                                 
            //      |                                                  
            //  200 |                                                  
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 700, 400, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 700, 1000, 700), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 700, 0, 300), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 700, 400, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 1000, 700)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 0, 300)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 400, 700, 1000, 700); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 400, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 0, 300)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 400, 700, 0, 300); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 400, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 700, 1000, 700)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  400 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 B'-----------------------------------------------'C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 500, 1000, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 500, 500, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(500, 300), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 B,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        '·,                                       
            //      |           ',                                     
            //  700 |             '·,        3                         
            //      |                ',                                
            //  600 |                  '·,                             
            //      |                     ',                           
            //  500 |              1        #A------------------------D
            //      |                     ,'                           
            //  400 |                  ,·'                             
            //      |                ,'                                
            //  300 |             ,·'        2                         
            //      |           ,'                                     
            //  200 |        ,·'                                       
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 C'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 500, 0, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 C,                                               ,B
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  600 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  500 |              2        'A'        3               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 500, 0, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideAroundMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideAroundMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 ↑                                                ,C
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                      ,·'         
            //      |                                    ,'            
            //  700 |                        2        ,·'              
            //      |                               ,'                 
            //  600 |                            ,·'                   
            //      |                          ,'                      
            //  500 D------------------------A#        1               
            //      |                          ',                      
            //  400 |                            '·,                   
            //      |                               ',                 
            //  300 |                        3        '·,              
            //      |                                    ',            
            //  200 |                                      '·,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 500, 1000, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 500, 0, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(300, 300), // #3
            };

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  200 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //    0 └---------B'---------------------------'C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 200, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 800, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 300, 500, 1000), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 200, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 300, 800, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 300, 500, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(300, 700), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 B,                                                 
            //      | ',                                               
            //  700 |   '·,        3                                   
            //      |      ',                                          
            //  600 |        '·,                                       
            //      |           ',                                     
            //  500 |    1        #A----------------------------------D
            //      |           ,'                                     
            //  400 |        ,·'                                       
            //      |      ,'                                          
            //  300 |   ,·'        2                                   
            //      | ,'                                               
            //  200 C'                                                 
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 0, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 0, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 500, 1000, 500), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 0, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 300, 500, 0, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 1000, 500)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 300, 500, 1000, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(700, 700), // #3
            };

            // 1000 ↑         C,                           ,B          
            //      |           ',                       ,'            
            //  900 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  800 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  700 |              2        'A'        3               
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 700, 800, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 200, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 700, 500, 0), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 700, 800, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 700, 200, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 700, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(700, 300), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                                ,C
            //      |                                              ,'  
            //  700 |                                  2        ,·'    
            //      |                                         ,'       
            //  600 |                                      ,·'         
            //      |                                    ,'            
            //  500 D----------------------------------A#        1     
            //      |                                    ',            
            //  400 |                                      '·,         
            //      |                                         ',       
            //  300 |                                  3        '·,    
            //      |                                              ',  
            //  200 |                                                'B
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 800), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 500, 0, 500), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 500, 1000, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 700, 500, 1000, 800); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 0, 500)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 700, 500, 0, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(300, 700), // #3
            };

            // 1000 ↑                        D                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |              3        ,A,        2               
            //      |                     ,'   ',                      
            //  600 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  500 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //  400 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  300 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //  200 B'                                               'C
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 700, 0, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 1000, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 700, 500, 1000), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 700, 0, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 200)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 700, 1000, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 200)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 700, 500, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 200)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 200)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 700), // #3
            };

            // 1000 ↑         B,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                             
            //      |                     ',                           
            //  700 |                       '·,        3               
            //      |                          ',                      
            //  600 |                            '·,                   
            //      |                               ',                 
            //  500 |                        1        #A--------------D
            //      |                               ,'                 
            //  400 |                            ,·'                   
            //      |                          ,'                      
            //  300 |                       ,·'        2               
            //      |                     ,'                           
            //  200 |                  ,·'                             
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------C'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 500, 200, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 200, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 500), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 500, 200, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 700, 500, 200, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 700, 500, 1000, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 200, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(700, 300), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 C,                                               ,B
            //      | ',                                           ,'  
            //  700 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  600 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  500 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  400 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  300 |              2        'A'        3               
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 0, 800), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 1000, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 800)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 500, 300, 0, 800); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 800)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 500, 300, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 800)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 800)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsInAWedgeTowardsSideOffsetIntoMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsInAWedgeTowardsSideOffsetIntoMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 300), // #3
            };

            // 1000 ↑                                      ,C          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 |                            ,·'                   
            //      |                          ,'                      
            //  700 |              2        ,·'                        
            //      |                     ,'                           
            //  600 |                  ,·'                             
            //      |                ,'                                
            //  500 D--------------A#        1                         
            //      |                ',                                
            //  400 |                  '·,                             
            //      |                     ',                           
            //  300 |              3        '·,                        
            //      |                          ',                      
            //  200 |                            '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'B---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 800, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 800, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-D"); // A-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 800, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            edge = FindEdge(edges, 300, 500, 800, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            edge = FindEdge(edges, 300, 500, 0, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 800, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
        }

        [Test]
        public void FourPointsSurroundingAPointInMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 500), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(500, 300), // #3
                new VoronoiSite(700, 500), // #4
                new VoronoiSite(500, 700), // #5
            };

            // 1000 E,                                               ,H
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        5        ,·'              
            //      |                ',             ,'                 
            //  600 |                  'A---------D'                   
            //      |                   |         |                    
            //  500 |              2    |    1    |    4               
            //      |                   |         |                    
            //  400 |                  ,B---------C,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 F'-----------------------------------------------'G
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 400, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 600, 400), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 600, 400, 600, 600), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 600, 600, 400, 600), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 400, 600, 0, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 400, 400, 0, 0), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 0), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 1000), "Expected: has edge D-H"); // D-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 400, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600)), "Expected: edge A-B neighbours D-A"); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0)), "Expected: edge A-B neighbours B-F"); // A-B neighbours B-F
            edge = FindEdge(edges, 400, 400, 600, 400); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600)), "Expected: edge B-C neighbours C-D"); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 0)), "Expected: edge B-C neighbours B-F"); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0)), "Expected: edge B-C neighbours C-G"); // B-C neighbours C-G
            edge = FindEdge(edges, 600, 400, 600, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400)), "Expected: edge C-D neighbours B-C"); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600)), "Expected: edge C-D neighbours D-A"); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 0)), "Expected: edge C-D neighbours C-G"); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000)), "Expected: edge C-D neighbours D-H"); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 600, 400, 600); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400)), "Expected: edge D-A neighbours A-B"); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600)), "Expected: edge D-A neighbours C-D"); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 1000)), "Expected: edge D-A neighbours A-E"); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 1000)), "Expected: edge D-A neighbours D-H"); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 600, 0, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600)), "Expected: edge A-E neighbours D-A"); // A-E neighbours D-A
            edge = FindEdge(edges, 400, 400, 0, 0); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 400, 400)), "Expected: edge B-F neighbours A-B"); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400)), "Expected: edge B-F neighbours B-C"); // B-F neighbours B-C
            edge = FindEdge(edges, 600, 400, 1000, 0); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 400)), "Expected: edge C-G neighbours B-C"); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600)), "Expected: edge C-G neighbours C-D"); // C-G neighbours C-D
            edge = FindEdge(edges, 600, 600, 1000, 1000); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 600, 600)), "Expected: edge D-H neighbours C-D"); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 600)), "Expected: edge D-H neighbours D-A"); // D-H neighbours D-A
        }

        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 300), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(500, 100), // #3
                new VoronoiSite(700, 300), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 E,                                               ,H
            //      | ',                                           ,'  
            //  700 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  600 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  500 |             '·,        5        ,·'              
            //      |                ',             ,'                 
            //  400 |                  'A---------D'                   
            //      |                   |         |                    
            //  300 |              2    |    1    |    4               
            //      |                   |         |                    
            //  200 |                  ,B---------C,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //    0 └---------F'---------------------------'G---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 400, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 200, 600, 200), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 600, 200, 600, 400), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 600, 400, 400, 400), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 400, 400, 0, 800), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 400, 200, 200, 0), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 600, 200, 800, 0), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 800), "Expected: has edge D-H"); // D-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 400, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400)), "Expected: edge A-B neighbours D-A"); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0)), "Expected: edge A-B neighbours B-F"); // A-B neighbours B-F
            edge = FindEdge(edges, 400, 200, 600, 200); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400)), "Expected: edge B-C neighbours C-D"); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 200, 0)), "Expected: edge B-C neighbours B-F"); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0)), "Expected: edge B-C neighbours C-G"); // B-C neighbours C-G
            edge = FindEdge(edges, 600, 200, 600, 400); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200)), "Expected: edge C-D neighbours B-C"); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400)), "Expected: edge C-D neighbours D-A"); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 800, 0)), "Expected: edge C-D neighbours C-G"); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800)), "Expected: edge C-D neighbours D-H"); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 400, 400, 400); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200)), "Expected: edge D-A neighbours A-B"); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400)), "Expected: edge D-A neighbours C-D"); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 800)), "Expected: edge D-A neighbours A-E"); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 800)), "Expected: edge D-A neighbours D-H"); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 400, 0, 800); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400)), "Expected: edge A-E neighbours D-A"); // A-E neighbours D-A
            edge = FindEdge(edges, 400, 200, 200, 0); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 200)), "Expected: edge B-F neighbours A-B"); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200)), "Expected: edge B-F neighbours B-C"); // B-F neighbours B-C
            edge = FindEdge(edges, 600, 200, 800, 0); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 200, 600, 200)), "Expected: edge C-G neighbours B-C"); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400)), "Expected: edge C-G neighbours C-D"); // C-G neighbours C-D
            edge = FindEdge(edges, 600, 400, 1000, 800); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 200, 600, 400)), "Expected: edge D-H neighbours C-D"); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 400)), "Expected: edge D-H neighbours D-A"); // D-H neighbours D-A
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 500), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(100, 500), // #3
                new VoronoiSite(300, 300), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑                                      ,E          
            //      |                                    ,'            
            //  900 |                                 ,·'              
            //      |                               ,'                 
            //  800 F,                           ,·'                   
            //      | ',                       ,'                      
            //  700 |   '·,        2        ,·'                        
            //      |      ',             ,'                           
            //  600 |        'B---------A'                             
            //      |         |         |                              
            //  500 |    3    |    1    |    5                         
            //      |         |         |                              
            //  400 |        ,C---------D,                             
            //      |      ,'             ',                           
            //  300 |   ,·'        4        '·,                        
            //      | ,'                       ',                      
            //  200 G'                           '·,                   
            //      |                               ',                 
            //  100 |                                 '·,              
            //      |                                    ',            
            //    0 └--------------------------------------'H---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 200, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 200, 600, 200, 400), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 200, 400, 400, 400), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 400, 400, 400, 600), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 400, 600, 800, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 200, 600, 0, 800), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 200, 400, 0, 200), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 400, 400, 800, 0), "Expected: has edge D-H"); // D-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 200, 600); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600)), "Expected: edge A-B neighbours D-A"); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800)), "Expected: edge A-B neighbours B-F"); // A-B neighbours B-F
            edge = FindEdge(edges, 200, 600, 200, 400); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400)), "Expected: edge B-C neighbours C-D"); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 0, 800)), "Expected: edge B-C neighbours B-F"); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200)), "Expected: edge B-C neighbours C-G"); // B-C neighbours C-G
            edge = FindEdge(edges, 200, 400, 400, 400); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400)), "Expected: edge C-D neighbours B-C"); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600)), "Expected: edge C-D neighbours D-A"); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 0, 200)), "Expected: edge C-D neighbours C-G"); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0)), "Expected: edge C-D neighbours D-H"); // C-D neighbours D-H
            edge = FindEdge(edges, 400, 400, 400, 600); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600)), "Expected: edge D-A neighbours A-B"); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400)), "Expected: edge D-A neighbours C-D"); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 800, 1000)), "Expected: edge D-A neighbours A-E"); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 800, 0)), "Expected: edge D-A neighbours D-H"); // D-A neighbours D-H
            edge = FindEdge(edges, 400, 600, 800, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600)), "Expected: edge A-E neighbours D-A"); // A-E neighbours D-A
            edge = FindEdge(edges, 200, 600, 0, 800); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 600)), "Expected: edge B-F neighbours A-B"); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400)), "Expected: edge B-F neighbours B-C"); // B-F neighbours B-C
            edge = FindEdge(edges, 200, 400, 0, 200); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 600, 200, 400)), "Expected: edge C-G neighbours B-C"); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400)), "Expected: edge C-G neighbours C-D"); // C-G neighbours C-D
            edge = FindEdge(edges, 400, 400, 800, 0); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 200, 400, 400, 400)), "Expected: edge D-H neighbours C-D"); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 400, 600)), "Expected: edge D-H neighbours D-A"); // D-H neighbours D-A
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(500, 900), // #3
                new VoronoiSite(300, 700), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑         G,                           ,F          
            //      |           ',                       ,'            
            //  900 |             '·,        3        ,·'              
            //      |                ',             ,'                 
            //  800 |                  'C---------B'                   
            //      |                   |         |                    
            //  700 |              4    |    1    |    2               
            //      |                   |         |                    
            //  600 |                  ,D---------A,                   
            //      |                ,'             ',                 
            //  500 |             ,·'        5        '·,              
            //      |           ,'                       ',            
            //  400 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  300 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //  200 H'                                               'E
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 600, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 800, 400, 800), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 400, 800, 400, 600), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 400, 600, 600, 600), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 200), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 600, 800, 800, 1000), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 400, 800, 200, 1000), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 400, 600, 0, 200), "Expected: has edge D-H"); // D-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 600, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600)), "Expected: edge A-B neighbours D-A"); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000)), "Expected: edge A-B neighbours B-F"); // A-B neighbours B-F
            edge = FindEdge(edges, 600, 800, 400, 800); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600)), "Expected: edge B-C neighbours C-D"); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 800, 1000)), "Expected: edge B-C neighbours B-F"); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000)), "Expected: edge B-C neighbours C-G"); // B-C neighbours C-G
            edge = FindEdge(edges, 400, 800, 400, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800)), "Expected: edge C-D neighbours B-C"); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600)), "Expected: edge C-D neighbours D-A"); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 200, 1000)), "Expected: edge C-D neighbours C-G"); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200)), "Expected: edge C-D neighbours D-H"); // C-D neighbours D-H
            edge = FindEdge(edges, 400, 600, 600, 600); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800)), "Expected: edge D-A neighbours A-B"); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600)), "Expected: edge D-A neighbours C-D"); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 200)), "Expected: edge D-A neighbours A-E"); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 200)), "Expected: edge D-A neighbours D-H"); // D-A neighbours D-H
            edge = FindEdge(edges, 600, 600, 1000, 200); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600)), "Expected: edge A-E neighbours D-A"); // A-E neighbours D-A
            edge = FindEdge(edges, 600, 800, 800, 1000); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 800)), "Expected: edge B-F neighbours A-B"); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800)), "Expected: edge B-F neighbours B-C"); // B-F neighbours B-C
            edge = FindEdge(edges, 400, 800, 200, 1000); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 800, 400, 800)), "Expected: edge C-G neighbours B-C"); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600)), "Expected: edge C-G neighbours C-D"); // C-G neighbours C-D
            edge = FindEdge(edges, 400, 600, 0, 200); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 800, 400, 600)), "Expected: edge D-H neighbours C-D"); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 600)), "Expected: edge D-H neighbours D-A"); // D-H neighbours D-A
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsSurroundingAPointOffsetFromMiddle"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsSurroundingAPointOffsetFromMiddle_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(900, 500), // #3
                new VoronoiSite(700, 700), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 ↑         H,                                       
            //      |           ',                                     
            //  900 |             '·,                                  
            //      |                ',                                
            //  800 |                  '·,                           ,G
            //      |                     ',                       ,'  
            //  700 |                       '·,        4        ,·'    
            //      |                          ',             ,'       
            //  600 |                            'D---------C'         
            //      |                             |         |          
            //  500 |                        5    |    1    |    3     
            //      |                             |         |          
            //  400 |                            ,A---------B,         
            //      |                          ,'             ',       
            //  300 |                       ,·'        2        '·,    
            //      |                     ,'                       ',  
            //  200 |                  ,·'                           'F
            //      |                ,'                                
            //  100 |             ,·'                                  
            //      |           ,'                                     
            //    0 └---------E'--------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 800, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 800, 400, 800, 600), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 800, 600, 600, 600), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 600, 600, 600, 400), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 600, 400, 200, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 800, 400, 1000, 200), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 800, 600, 1000, 800), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 600, 600, 200, 1000), "Expected: has edge D-H"); // D-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 800, 400); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400)), "Expected: edge A-B neighbours D-A"); // A-B neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200)), "Expected: edge A-B neighbours B-F"); // A-B neighbours B-F
            edge = FindEdge(edges, 800, 400, 800, 600); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600)), "Expected: edge B-C neighbours C-D"); // B-C neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 1000, 200)), "Expected: edge B-C neighbours B-F"); // B-C neighbours B-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800)), "Expected: edge B-C neighbours C-G"); // B-C neighbours C-G
            edge = FindEdge(edges, 800, 600, 600, 600); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600)), "Expected: edge C-D neighbours B-C"); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400)), "Expected: edge C-D neighbours D-A"); // C-D neighbours D-A
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 1000, 800)), "Expected: edge C-D neighbours C-G"); // C-D neighbours C-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000)), "Expected: edge C-D neighbours D-H"); // C-D neighbours D-H
            edge = FindEdge(edges, 600, 600, 600, 400); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(4, edge.Neighbours.Count(), "Expected: edge neighbour count 4");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400)), "Expected: edge D-A neighbours A-B"); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600)), "Expected: edge D-A neighbours C-D"); // D-A neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 200, 0)), "Expected: edge D-A neighbours A-E"); // D-A neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 200, 1000)), "Expected: edge D-A neighbours D-H"); // D-A neighbours D-H
            edge = FindEdge(edges, 600, 400, 200, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400)), "Expected: edge A-E neighbours D-A"); // A-E neighbours D-A
            edge = FindEdge(edges, 800, 400, 1000, 200); // B-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 400)), "Expected: edge B-F neighbours A-B"); // B-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600)), "Expected: edge B-F neighbours B-C"); // B-F neighbours B-C
            edge = FindEdge(edges, 800, 600, 1000, 800); // C-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 400, 800, 600)), "Expected: edge C-G neighbours B-C"); // C-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600)), "Expected: edge C-G neighbours C-D"); // C-G neighbours C-D
            edge = FindEdge(edges, 600, 600, 200, 1000); // D-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 800, 600, 600, 600)), "Expected: edge D-H neighbours C-D"); // D-H neighbours C-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 600, 400)), "Expected: edge D-H neighbours D-A"); // D-H neighbours D-A
        }

        [Test]
        public void FourEquidistantPointsInASquareAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(700, 700), // #4
            };

            // 1000 ↑                        B                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |              1         |         4               
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 C------------------------A------------------------E
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |              2         |         3               
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 500, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 500, 500, 0, 500); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        [Test]
        public void FourEquidistantPointsInARectangleAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(400, 800), // #1
                new VoronoiSite(400, 200), // #2
                new VoronoiSite(600, 200), // #3
                new VoronoiSite(600, 800), // #4
            };

            // 1000 ↑                        B                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                   1    |    4                    
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 C------------------------A------------------------E
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                   2    |    3                    
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 500, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 500, 500, 0, 500); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 500, 500, 500, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 500, 1000, 500); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARectangleAroundMiddle"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARectangleAroundMiddle_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 600), // #1
                new VoronoiSite(200, 600), // #2
                new VoronoiSite(200, 400), // #3
                new VoronoiSite(800, 400), // #4
            };

            // 1000 ↑                        C                         
            //      |                        |                         
            //  900 |                        |                         
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 |         2              |              1          
            //      |                        |                         
            //  500 D------------------------A------------------------B
            //      |                        |                         
            //  400 |         3              |              4          
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |                        |                         
            //      |                        |                         
            //    0 └------------------------E------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 1000, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 500, 500, 500, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 500, 500, 0, 500); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 0)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 500, 500, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 500)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 500, 1000)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 500)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        [Test]
        public void FourEquidistantPointsInAKiteAroundMiddle()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(500, 300), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 B,                                               ,E
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  600 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  500 |              4        #A#        2               
            //      |                     ,'   ',                      
            //  400 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  300 |             ,·'        3        '·,              
            //      |           ,'                       ',            
            //  200 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  100 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //    0 C'-----------------------------------------------'D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 500, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 500, 500, 0, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 500, 500, 1000, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 500, 1000, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 0)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 100), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(500, 700), // #4
            };

            // 1000 ↑    B                                             
            //      |     '                                            
            //  900 |      ',                                          
            //      |        ,                                         
            //  800 |         ·                                        
            //      |          '                                       
            //  700 |           ',           4                      ,,E
            //      |             ,                            ,,·''   
            //  600 |              ·                      ,,·''        
            //      |               '                ,,·''             
            //  500 |    1           ',         ,,·''                  
            //      |                  ,   ,,·''                       
            //  400 |                 ,,A''                            
            //      |            ,,·''   '                             
            //  300 |       ,,·''         ',           3               
            //      |  ,,·''                ,                          
            //  200 C''                      ·                         
            //      |                         '                        
            //  100 |              2           ',                      
            //      |                            ,                     
            //    0 └-----------------------------D-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 100, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 0, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 600, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 700), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 100, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 200)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 700)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 400, 400, 0, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 100, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 700)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 400, 400, 600, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 100, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 200)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 700)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 400, 400, 1000, 700); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 100, 1000)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 200)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 600, 0)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(100, 700), // #2
                new VoronoiSite(300, 300), // #3
                new VoronoiSite(700, 500), // #4
            };

            // 1000 ↑         C                                        
            //      |          '                                       
            //  900 |           ',           1                      ,,B
            //      |             ,                            ,,·''   
            //  800 |              ·                      ,,·''        
            //      |               '                ,,·''             
            //  700 |    2           ',         ,,·''                  
            //      |                  ,   ,,·''                       
            //  600 |                 ,,A''                            
            //      |            ,,·''   '                             
            //  500 |       ,,·''         ',           4               
            //      |  ,,·''                ,                          
            //  400 D''                      ·                         
            //      |                         '                        
            //  300 |              3           ',                      
            //      |                            ,                     
            //  200 |                             ·                    
            //      |                              '                   
            //  100 |                               ',                 
            //      |                                 ,                
            //    0 └----------------------------------E--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 900), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 200, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 0, 400), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 600, 700, 0), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 1000, 900); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 400)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 700, 0)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 400, 600, 200, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 900)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 400)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 700, 0)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 400, 600, 0, 400); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 900)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 700, 0)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 400, 600, 700, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 900)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 200, 1000)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 400)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 900), // #2
                new VoronoiSite(300, 700), // #3
                new VoronoiSite(500, 300), // #4
            };

            // 1000 ↑                   D                              
            //      |                    '                             
            //  900 |                     ',           2               
            //      |                       ,                          
            //  800 |                        ·                      ,,C
            //      |                         '                ,,·''   
            //  700 |              3           ',         ,,·''        
            //      |                            ,   ,,·''             
            //  600 |                           ,,A''                  
            //      |                      ,,·''   '                   
            //  500 |                 ,,·''         ',           1     
            //      |            ,,·''                ,                
            //  400 |       ,,·''                      ·               
            //      |  ,,·''                            '              
            //  300 E''                      4           ',            
            //      |                                      ,           
            //  200 |                                       ·          
            //      |                                        '         
            //  100 |                                         ',       
            //      |                                           ,      
            //    0 └--------------------------------------------B----→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 900, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 800), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 400, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 600, 0, 300), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 900, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 800)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 300)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 600, 600, 1000, 800); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 900, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 300)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 600, 600, 400, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 900, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 800)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 300)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 600, 600, 0, 300); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 900, 0)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 800)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 400, 1000)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(900, 300), // #2
                new VoronoiSite(700, 700), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 ↑              E                                   
            //      |               '                                  
            //  900 |                ',                                
            //      |                  ,                               
            //  800 |                   ·                              
            //      |                    '                             
            //  700 |                     ',           3               
            //      |                       ,                          
            //  600 |                        ·                      ,,D
            //      |                         '                ,,·''   
            //  500 |              4           ',         ,,·''        
            //      |                            ,   ,,·''             
            //  400 |                           ,,A''                  
            //      |                      ,,·''   '                   
            //  300 |                 ,,·''         ',           2     
            //      |            ,,·''                ,                
            //  200 |       ,,·''                      ·               
            //      |  ,,·''                            '              
            //  100 B''                      1           ',            
            //      |                                      ,           
            //    0 └---------------------------------------C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 0, 100), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 800, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 600), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 400, 300, 1000), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 0, 100); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 600)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 300, 1000)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 600, 400, 800, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 100)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 600)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 300, 1000)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 600, 400, 1000, 600); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 100)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 300, 1000)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 600, 400, 300, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 100)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 800, 0)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 600)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 100), // #2
                new VoronoiSite(300, 300), // #3
                new VoronoiSite(500, 700), // #4
            };

            // 1000 ↑                                            B     
            //      |                                           '      
            //  900 |                                         ,'       
            //      |                                        ,         
            //  800 |                                       ·          
            //      |                                      '           
            //  700 E,,                      4           ,'            
            //      |  ''·,,                            ,              
            //  600 |       ''·,,                      ·               
            //      |            ''·,,                '                
            //  500 |                 ''·,,         ,'           1     
            //      |                      ''·,,   ,                   
            //  400 |                           ''A,,                  
            //      |                            '   ''·,,             
            //  300 |              3           ,'         ''·,,        
            //      |                         ,                ''·,,   
            //  200 |                        ·                      ''C
            //      |                       '                          
            //  100 |                     ,'           2               
            //      |                    ,                             
            //    0 └-------------------D-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 900, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 400, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 400, 0, 700), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 400, 900, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 200)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 0)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 700)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 600, 400, 1000, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 900, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 0)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 700)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 600, 400, 400, 0); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 900, 1000)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 200)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 0, 700)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 600, 400, 0, 700); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 900, 1000)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 1000, 200)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 400, 400, 0)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(100, 300), // #2
                new VoronoiSite(300, 700), // #3
                new VoronoiSite(700, 500), // #4
            };

            // 1000 ↑                                  E               
            //      |                                 '                
            //  900 |                               ,'                 
            //      |                              ,                   
            //  800 |                             ·                    
            //      |                            '                     
            //  700 |              3           ,'                      
            //      |                         ,                        
            //  600 D,,                      ·                         
            //      |  ''·,,                '                          
            //  500 |       ''·,,         ,'           4               
            //      |            ''·,,   ,                             
            //  400 |                 ''A,,                            
            //      |                  '   ''·,,                       
            //  300 |    2           ,'         ''·,,                  
            //      |               ,                ''·,,             
            //  200 |              ·                      ''·,,        
            //      |             '                            ''·,,   
            //  100 |           ,'           1                      ''B
            //      |          ,                                       
            //    0 └---------C---------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 100), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 200, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 0, 600), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 400, 700, 1000), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 400, 1000, 100); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 200, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 600)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 700, 1000)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 400, 400, 200, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 100)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 600)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 700, 1000)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 400, 400, 0, 600); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 100)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 200, 0)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 700, 1000)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 400, 400, 700, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 1000, 100)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 200, 0)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 400, 0, 600)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 900), // #2
                new VoronoiSite(700, 700), // #3
                new VoronoiSite(500, 300), // #4
            };

            // 1000 ↑                             D                    
            //      |                            '                     
            //  900 |              2           ,'                      
            //      |                         ,                        
            //  800 C,,                      ·                         
            //      |  ''·,,                '                          
            //  700 |       ''·,,         ,'           3               
            //      |            ''·,,   ,                             
            //  600 |                 ''A,,                            
            //      |                  '   ''·,,                       
            //  500 |    1           ,'         ''·,,                  
            //      |               ,                ''·,,             
            //  400 |              ·                      ''·,,        
            //      |             '                            ''·,,   
            //  300 |           ,'           4                      ''E
            //      |          ,                                       
            //  200 |         ·                                        
            //      |        '                                         
            //  100 |      ,'                                          
            //      |     ,                                            
            //    0 └----B--------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 100, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 0, 800), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 600, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 300), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 600, 100, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 800)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 300)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 400, 600, 0, 800); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 100, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 1000)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 300)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 400, 600, 600, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 100, 0)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 800)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 1000, 300)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 400, 600, 1000, 300); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 100, 0)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 0, 800)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 600, 600, 1000)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourEquidistantPointsInARotatedSquareOffset"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourEquidistantPointsInARotatedSquareOffset_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(900, 700), // #2
                new VoronoiSite(700, 300), // #3
                new VoronoiSite(300, 500), // #4
            };

            // 1000 ↑                                       C          
            //      |                                      '           
            //  900 B,,                      1           ,'            
            //      |  ''·,,                            ,              
            //  800 |       ''·,,                      ·               
            //      |            ''·,,                '                
            //  700 |                 ''·,,         ,'           2     
            //      |                      ''·,,   ,                   
            //  600 |                           ''A,,                  
            //      |                            '   ''·,,             
            //  500 |              4           ,'         ''·,,        
            //      |                         ,                ''·,,   
            //  400 |                        ·                      ''D
            //      |                       '                          
            //  300 |                     ,'           3               
            //      |                    ,                             
            //  200 |                   ·                              
            //      |                  '                               
            //  100 |                ,'                                
            //      |               ,                                  
            //    0 └--------------E----------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 0, 900), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 800, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 400), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 600, 300, 0), "Expected: has edge A-E"); // A-E

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 600, 0, 900); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 800, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 400)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 300, 0)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            edge = FindEdge(edges, 600, 600, 800, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 900)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 400)), "Expected: edge A-C neighbours A-D"); // A-C neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 300, 0)), "Expected: edge A-C neighbours A-E"); // A-C neighbours A-E
            edge = FindEdge(edges, 600, 600, 1000, 400); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 900)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 800, 1000)), "Expected: edge A-D neighbours A-C"); // A-D neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 300, 0)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 600, 600, 300, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 0, 900)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 800, 1000)), "Expected: edge A-E neighbours A-C"); // A-E neighbours A-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 600, 1000, 400)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
        }

        [Test]
        public void FivePointsInAForkedTallCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 900), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(300, 100), // #3
                new VoronoiSite(700, 100), // #4
                new VoronoiSite(700, 700), // #5
            };

            // 1000 ↑         C,                           ,D          
            //      |           ',                       ,'            
            //  900 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  800 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  700 |              2        'B'        5               
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 E------------------------A------------------------F
            //      |                        |                         
            //  300 |                        |                         
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |              3         |         4               
            //      |                        |                         
            //    0 └------------------------G------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 400, 500, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 200, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 700, 800, 1000), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 500, 400, 0, 400), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 500, 400, 1000, 400), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 500, 400, 500, 0), "Expected: has edge A-G"); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 400, 500, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count(), "Expected: edge neighbour count 5");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000)), "Expected: edge A-B neighbours B-D"); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400)), "Expected: edge A-B neighbours A-F"); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0)), "Expected: edge A-B neighbours A-G"); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 700, 200, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 800, 1000)), "Expected: edge B-C neighbours B-D"); // B-C neighbours B-D
            edge = FindEdge(edges, 500, 700, 800, 1000); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700)), "Expected: edge B-D neighbours A-B"); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 200, 1000)), "Expected: edge B-D neighbours B-C"); // B-D neighbours B-C
            edge = FindEdge(edges, 500, 400, 0, 400); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400)), "Expected: edge A-E neighbours A-F"); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0)), "Expected: edge A-E neighbours A-G"); // A-E neighbours A-G
            edge = FindEdge(edges, 500, 400, 1000, 400); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700)), "Expected: edge A-F neighbours A-B"); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400)), "Expected: edge A-F neighbours A-E"); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 0)), "Expected: edge A-F neighbours A-G"); // A-F neighbours A-G
            edge = FindEdge(edges, 500, 400, 500, 0); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 500, 700)), "Expected: edge A-G neighbours A-B"); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 0, 400)), "Expected: edge A-G neighbours A-E"); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 400, 1000, 400)), "Expected: edge A-G neighbours A-F"); // A-G neighbours A-F
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 500), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(100, 700), // #3
                new VoronoiSite(100, 300), // #4
                new VoronoiSite(700, 300), // #5
            };

            // 1000 ↑                   E                              
            //      |                   |                              
            //  900 |                   |                              
            //      |                   |                              
            //  800 |                   |                            ,C
            //      |                   |                          ,'  
            //  700 |    3              |              2        ,·'    
            //      |                   |                     ,'       
            //  600 |                   |                  ,·'         
            //      |                   |                ,'            
            //  500 G-------------------A--------------B#        1     
            //      |                   |                ',            
            //  400 |                   |                  '·,         
            //      |                   |                     ',       
            //  300 |    4              |              5        '·,    
            //      |                   |                          ',  
            //  200 |                   |                            'D
            //      |                   |                              
            //  100 |                   |                              
            //      |                   |                              
            //    0 └-------------------F-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 500, 700, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 800), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 200), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 400, 500, 400, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 400, 500, 400, 0), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 400, 500, 0, 500), "Expected: has edge A-G"); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 500, 700, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count(), "Expected: edge neighbour count 5");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200)), "Expected: edge A-B neighbours B-D"); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0)), "Expected: edge A-B neighbours A-F"); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500)), "Expected: edge A-B neighbours A-G"); // A-B neighbours A-G
            edge = FindEdge(edges, 700, 500, 1000, 800); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 200)), "Expected: edge B-C neighbours B-D"); // B-C neighbours B-D
            edge = FindEdge(edges, 700, 500, 1000, 200); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500)), "Expected: edge B-D neighbours A-B"); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 800)), "Expected: edge B-D neighbours B-C"); // B-D neighbours B-C
            edge = FindEdge(edges, 400, 500, 400, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0)), "Expected: edge A-E neighbours A-F"); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500)), "Expected: edge A-E neighbours A-G"); // A-E neighbours A-G
            edge = FindEdge(edges, 400, 500, 400, 0); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500)), "Expected: edge A-F neighbours A-B"); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000)), "Expected: edge A-F neighbours A-E"); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 0, 500)), "Expected: edge A-F neighbours A-G"); // A-F neighbours A-G
            edge = FindEdge(edges, 400, 500, 0, 500); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 700, 500)), "Expected: edge A-G neighbours A-B"); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 1000)), "Expected: edge A-G neighbours A-E"); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 400, 500, 400, 0)), "Expected: edge A-G neighbours A-F"); // A-G neighbours A-F
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 100), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(700, 900), // #3
                new VoronoiSite(300, 900), // #4
                new VoronoiSite(300, 300), // #5
            };

            // 1000 ↑                        G                         
            //      |                        |                         
            //  900 |              4         |         3               
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 |                        |                         
            //      |                        |                         
            //  600 F------------------------A------------------------E
            //      |                        |                         
            //  500 |                        |                         
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 |              5        ,B,        2               
            //      |                     ,'   ',                      
            //  200 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  100 |             ,·'        1        '·,              
            //      |           ,'                       ',            
            //    0 └---------D'---------------------------'C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 600, 500, 300), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 800, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 300, 200, 0), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 500, 600, 1000, 600), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 500, 600, 0, 600), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 500, 600, 500, 1000), "Expected: has edge A-G"); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 600, 500, 300); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count(), "Expected: edge neighbour count 5");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0)), "Expected: edge A-B neighbours B-D"); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600)), "Expected: edge A-B neighbours A-F"); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000)), "Expected: edge A-B neighbours A-G"); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 300, 800, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 200, 0)), "Expected: edge B-C neighbours B-D"); // B-C neighbours B-D
            edge = FindEdge(edges, 500, 300, 200, 0); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300)), "Expected: edge B-D neighbours A-B"); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 800, 0)), "Expected: edge B-D neighbours B-C"); // B-D neighbours B-C
            edge = FindEdge(edges, 500, 600, 1000, 600); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600)), "Expected: edge A-E neighbours A-F"); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000)), "Expected: edge A-E neighbours A-G"); // A-E neighbours A-G
            edge = FindEdge(edges, 500, 600, 0, 600); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300)), "Expected: edge A-F neighbours A-B"); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600)), "Expected: edge A-F neighbours A-E"); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 1000)), "Expected: edge A-F neighbours A-G"); // A-F neighbours A-G
            edge = FindEdge(edges, 500, 600, 500, 1000); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 500, 300)), "Expected: edge A-G neighbours A-B"); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 1000, 600)), "Expected: edge A-G neighbours A-E"); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 600, 0, 600)), "Expected: edge A-G neighbours A-F"); // A-G neighbours A-F
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedTallCross"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedTallCross_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 500), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(900, 300), // #3
                new VoronoiSite(900, 700), // #4
                new VoronoiSite(300, 700), // #5
            };

            // 1000 ↑                             F                    
            //      |                             |                    
            //  900 |                             |                    
            //      |                             |                    
            //  800 D,                            |                    
            //      | ',                          |                    
            //  700 |   '·,        5              |              4     
            //      |      ',                     |                    
            //  600 |        '·,                  |                    
            //      |           ',                |                    
            //  500 |    1        #B--------------A-------------------G
            //      |           ,'                |                    
            //  400 |        ,·'                  |                    
            //      |      ,'                     |                    
            //  300 |   ,·'        2              |              3     
            //      | ,'                          |                    
            //  200 C'                            |                    
            //      |                             |                    
            //  100 |                             |                    
            //      |                             |                    
            //    0 └-----------------------------E-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 500, 300, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 0, 200), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 300, 500, 0, 800), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 600, 500, 600, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 600, 500, 600, 1000), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 600, 500, 1000, 500), "Expected: has edge A-G"); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 500, 300, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count(), "Expected: edge neighbour count 5");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800)), "Expected: edge A-B neighbours B-D"); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000)), "Expected: edge A-B neighbours A-F"); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500)), "Expected: edge A-B neighbours A-G"); // A-B neighbours A-G
            edge = FindEdge(edges, 300, 500, 0, 200); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 800)), "Expected: edge B-C neighbours B-D"); // B-C neighbours B-D
            edge = FindEdge(edges, 300, 500, 0, 800); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500)), "Expected: edge B-D neighbours A-B"); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 200)), "Expected: edge B-D neighbours B-C"); // B-D neighbours B-C
            edge = FindEdge(edges, 600, 500, 600, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000)), "Expected: edge A-E neighbours A-F"); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500)), "Expected: edge A-E neighbours A-G"); // A-E neighbours A-G
            edge = FindEdge(edges, 600, 500, 600, 1000); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500)), "Expected: edge A-F neighbours A-B"); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0)), "Expected: edge A-F neighbours A-E"); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 1000, 500)), "Expected: edge A-F neighbours A-G"); // A-F neighbours A-G
            edge = FindEdge(edges, 600, 500, 1000, 500); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 300, 500)), "Expected: edge A-G neighbours A-B"); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 0)), "Expected: edge A-G neighbours A-E"); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 500, 600, 1000)), "Expected: edge A-G neighbours A-F"); // A-G neighbours A-F
        }

        [Test]
        public void FivePointsInAForkedStubbyCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(300, 100), // #3
                new VoronoiSite(700, 100), // #4
                new VoronoiSite(700, 500), // #5
            };

            // 1000 C,                                               ,D
            //      | ',                                           ,'  
            //  900 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  800 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  700 |             '·,        1        ,·'              
            //      |                ',             ,'                 
            //  600 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //  500 |              2        'B'        5               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 E------------------------A------------------------F
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |              3         |         4               
            //      |                        |                         
            //    0 └------------------------G------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 500, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 500, 300, 0, 300), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 300), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-G"); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 500, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count(), "Expected: edge neighbour count 5");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-B neighbours B-D"); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300)), "Expected: edge A-B neighbours A-F"); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0)), "Expected: edge A-B neighbours A-G"); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 500, 0, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge B-C neighbours B-D"); // B-C neighbours B-D
            edge = FindEdge(edges, 500, 500, 1000, 1000); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500)), "Expected: edge B-D neighbours A-B"); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 0, 1000)), "Expected: edge B-D neighbours B-C"); // B-D neighbours B-C
            edge = FindEdge(edges, 500, 300, 0, 300); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300)), "Expected: edge A-E neighbours A-F"); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0)), "Expected: edge A-E neighbours A-G"); // A-E neighbours A-G
            edge = FindEdge(edges, 500, 300, 1000, 300); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500)), "Expected: edge A-F neighbours A-B"); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300)), "Expected: edge A-F neighbours A-E"); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0)), "Expected: edge A-F neighbours A-G"); // A-F neighbours A-G
            edge = FindEdge(edges, 500, 300, 500, 0); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 500)), "Expected: edge A-G neighbours A-B"); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300)), "Expected: edge A-G neighbours A-E"); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300)), "Expected: edge A-G neighbours A-F"); // A-G neighbours A-F
        }

        /// <summary>
        /// This test basically repeats <see cref="FivePointsInAForkedStubbyCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FivePointsInAForkedStubbyCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 500), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(100, 700), // #3
                new VoronoiSite(100, 300), // #4
                new VoronoiSite(500, 300), // #5
            };

            // 1000 ↑              E                                 ,C
            //      |              |                               ,'  
            //  900 |              |                            ,·'    
            //      |              |                          ,'       
            //  800 |              |                       ,·'         
            //      |              |                     ,'            
            //  700 |    3         |         2        ,·'              
            //      |              |                ,'                 
            //  600 |              |             ,·'                   
            //      |              |           ,'                      
            //  500 G--------------A---------B#        1               
            //      |              |           ',                      
            //  400 |              |             '·,                   
            //      |              |                ',                 
            //  300 |    4         |         5        '·,              
            //      |              |                     ',            
            //  200 |              |                       '·,         
            //      |              |                          ',       
            //  100 |              |                            '·,    
            //      |              |                               ',  
            //    0 └--------------F---------------------------------'D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 500, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 300, 500, 300, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 300, 500, 300, 0), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-G"); // A-G

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 500, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(5, edge.Neighbours.Count(), "Expected: edge neighbour count 5");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge A-B neighbours B-D"); // A-B neighbours B-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0)), "Expected: edge A-B neighbours A-F"); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500)), "Expected: edge A-B neighbours A-G"); // A-B neighbours A-G
            edge = FindEdge(edges, 500, 500, 1000, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 0)), "Expected: edge B-C neighbours B-D"); // B-C neighbours B-D
            edge = FindEdge(edges, 500, 500, 1000, 0); // B-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500)), "Expected: edge B-D neighbours A-B"); // B-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 500, 1000, 1000)), "Expected: edge B-D neighbours B-C"); // B-D neighbours B-C
            edge = FindEdge(edges, 300, 500, 300, 1000); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0)), "Expected: edge A-E neighbours A-F"); // A-E neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500)), "Expected: edge A-E neighbours A-G"); // A-E neighbours A-G
            edge = FindEdge(edges, 300, 500, 300, 0); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500)), "Expected: edge A-F neighbours A-B"); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000)), "Expected: edge A-F neighbours A-E"); // A-F neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500)), "Expected: edge A-F neighbours A-G"); // A-F neighbours A-G
            edge = FindEdge(edges, 300, 500, 0, 500); // A-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 500, 500)), "Expected: edge A-G neighbours A-B"); // A-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000)), "Expected: edge A-G neighbours A-E"); // A-G neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0)), "Expected: edge A-G neighbours A-F"); // A-G neighbours A-F
        }

        [Test]
        public void SixPointsInADoubleCross()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 900), // #1
                new VoronoiSite(700, 900), // #2
                new VoronoiSite(300, 500), // #3
                new VoronoiSite(700, 500), // #4
                new VoronoiSite(300, 100), // #5
                new VoronoiSite(700, 100), // #6
            };

            // 1000 ↑                        H                         
            //      |                        |                         
            //  900 |              1         |         2               
            //      |                        |                         
            //  800 |                        |                         
            //      |                        |                         
            //  700 C------------------------B------------------------G
            //      |                        |                         
            //  600 |                        |                         
            //      |                        |                         
            //  500 |              3         |         4               
            //      |                        |                         
            //  400 |                        |                         
            //      |                        |                         
            //  300 D------------------------A------------------------F
            //      |                        |                         
            //  200 |                        |                         
            //      |                        |                         
            //  100 |              5         |         6               
            //      |                        |                         
            //    0 └------------------------E------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 500, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 0, 700), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 700, 1000, 700), "Expected: has edge B-G"); // B-G
            Assume.That(() => HasEdge(edges, 500, 300, 0, 300), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 300), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 500, 700, 500, 1000), "Expected: has edge B-H"); // B-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 300, 500, 700); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(6, edge.Neighbours.Count(), "Expected: edge neighbour count 6");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700)), "Expected: edge A-B neighbours B-G"); // A-B neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300)), "Expected: edge A-B neighbours A-F"); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000)), "Expected: edge A-B neighbours B-H"); // A-B neighbours B-H
            edge = FindEdge(edges, 500, 700, 0, 700); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700)), "Expected: edge B-C neighbours B-G"); // B-C neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000)), "Expected: edge B-C neighbours B-H"); // B-C neighbours B-H
            edge = FindEdge(edges, 500, 700, 1000, 700); // B-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700)), "Expected: edge B-G neighbours A-B"); // B-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700)), "Expected: edge B-G neighbours B-C"); // B-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 500, 1000)), "Expected: edge B-G neighbours B-H"); // B-G neighbours B-H
            edge = FindEdge(edges, 500, 300, 0, 300); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300)), "Expected: edge A-D neighbours A-F"); // A-D neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 500, 300, 1000, 300); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700)), "Expected: edge A-F neighbours A-B"); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300)), "Expected: edge A-F neighbours A-D"); // A-F neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 0)), "Expected: edge A-F neighbours A-E"); // A-F neighbours A-E
            edge = FindEdge(edges, 500, 300, 500, 0); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 0, 300)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 1000, 300)), "Expected: edge A-E neighbours A-F"); // A-E neighbours A-F
            edge = FindEdge(edges, 500, 700, 500, 1000); // B-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 300, 500, 700)), "Expected: edge B-H neighbours A-B"); // B-H neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 0, 700)), "Expected: edge B-H neighbours B-C"); // B-H neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 700, 1000, 700)), "Expected: edge B-H neighbours B-G"); // B-H neighbours B-G
        }

        /// <summary>
        /// This test basically repeats <see cref="SixPointsInADoubleCross"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void SixPointsInADoubleCross_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 700), // #1
                new VoronoiSite(900, 300), // #2
                new VoronoiSite(500, 700), // #3
                new VoronoiSite(500, 300), // #4
                new VoronoiSite(100, 700), // #5
                new VoronoiSite(100, 300), // #6
            };

            // 1000 ↑              D                   C               
            //      |              |                   |               
            //  900 |              |                   |               
            //      |              |                   |               
            //  800 |              |                   |               
            //      |              |                   |               
            //  700 |    5         |         3         |         1     
            //      |              |                   |               
            //  600 |              |                   |               
            //      |              |                   |               
            //  500 E--------------A-------------------B--------------H
            //      |              |                   |               
            //  400 |              |                   |               
            //      |              |                   |               
            //  300 |    6         |         4         |         2     
            //      |              |                   |               
            //  200 |              |                   |               
            //      |              |                   |               
            //  100 |              |                   |               
            //      |              |                   |               
            //    0 └--------------F-------------------G--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 700, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 700, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 700, 500, 700, 0), "Expected: has edge B-G"); // B-G
            Assume.That(() => HasEdge(edges, 300, 500, 300, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 300, 500, 300, 0), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 500), "Expected: has edge B-H"); // B-H

            // Assert

            VoronoiEdge edge = FindEdge(edges, 300, 500, 700, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(6, edge.Neighbours.Count(), "Expected: edge neighbour count 6");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0)), "Expected: edge A-B neighbours B-G"); // A-B neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000)), "Expected: edge A-B neighbours A-D"); // A-B neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0)), "Expected: edge A-B neighbours A-F"); // A-B neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500)), "Expected: edge A-B neighbours A-E"); // A-B neighbours A-E
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500)), "Expected: edge A-B neighbours B-H"); // A-B neighbours B-H
            edge = FindEdge(edges, 700, 500, 700, 1000); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0)), "Expected: edge B-C neighbours B-G"); // B-C neighbours B-G
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500)), "Expected: edge B-C neighbours B-H"); // B-C neighbours B-H
            edge = FindEdge(edges, 700, 500, 700, 0); // B-G
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500)), "Expected: edge B-G neighbours A-B"); // B-G neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000)), "Expected: edge B-G neighbours B-C"); // B-G neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 1000, 500)), "Expected: edge B-G neighbours B-H"); // B-G neighbours B-H
            edge = FindEdge(edges, 300, 500, 300, 1000); // A-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500)), "Expected: edge A-D neighbours A-B"); // A-D neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0)), "Expected: edge A-D neighbours A-F"); // A-D neighbours A-F
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500)), "Expected: edge A-D neighbours A-E"); // A-D neighbours A-E
            edge = FindEdge(edges, 300, 500, 300, 0); // A-F
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500)), "Expected: edge A-F neighbours A-B"); // A-F neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000)), "Expected: edge A-F neighbours A-D"); // A-F neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 0, 500)), "Expected: edge A-F neighbours A-E"); // A-F neighbours A-E
            edge = FindEdge(edges, 300, 500, 0, 500); // A-E
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500)), "Expected: edge A-E neighbours A-B"); // A-E neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 1000)), "Expected: edge A-E neighbours A-D"); // A-E neighbours A-D
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 300, 0)), "Expected: edge A-E neighbours A-F"); // A-E neighbours A-F
            edge = FindEdge(edges, 700, 500, 1000, 500); // B-H
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(3, edge.Neighbours.Count(), "Expected: edge neighbour count 3");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 300, 500, 700, 500)), "Expected: edge B-H neighbours A-B"); // B-H neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 1000)), "Expected: edge B-H neighbours B-C"); // B-H neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 700, 500, 700, 0)), "Expected: edge B-H neighbours B-G"); // B-H neighbours B-G
        }

        [Test]
        public void FivePointsInABorderTouchingKite()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 1000), // #1
                new VoronoiSite(0, 0), // #2
                new VoronoiSite(1000, 0), // #3
                new VoronoiSite(1000, 1000), // #4
                new VoronoiSite(500, 500), // #5
            };

            // 1000 1                       ,A,                       4
            //      |                     ,'   ',                      
            //  900 |                  ,·'       '·,                   
            //      |                ,'             ',                 
            //  800 |             ,·'                 '·,              
            //      |           ,'                       ',            
            //  700 |        ,·'                           '·,         
            //      |      ,'                                 ',       
            //  600 |   ,·'                                     '·,    
            //      | ,'                                           ',  
            //  500 B#                       5                       #D
            //      | ',                                           ,'  
            //  400 |   '·,                                     ,·'    
            //      |      ',                                 ,'       
            //  300 |        '·,                           ,·'         
            //      |           ',                       ,'            
            //  200 |             '·,                 ,·'              
            //      |                ',             ,'                 
            //  100 |                  '·,       ,·'                   
            //      |                     ',   ,'                      
            //    0 2-----------------------'C'-----------------------3
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 500, 500, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 500), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 1000, 500, 500, 1000), "Expected: has edge D-A"); // D-A

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 1000, 0, 500); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 500, 0)), "Expected: edge A-B neighbours B-C"); // A-B neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 500, 1000)), "Expected: edge A-B neighbours D-A"); // A-B neighbours D-A
            edge = FindEdge(edges, 0, 500, 500, 0); // B-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 500)), "Expected: edge B-C neighbours A-B"); // B-C neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 500)), "Expected: edge B-C neighbours C-D"); // B-C neighbours C-D
            edge = FindEdge(edges, 500, 0, 1000, 500); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 500, 0)), "Expected: edge C-D neighbours B-C"); // C-D neighbours B-C
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 500, 1000)), "Expected: edge C-D neighbours D-A"); // C-D neighbours D-A
            edge = FindEdge(edges, 1000, 500, 500, 1000); // D-A
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(2, edge.Neighbours.Count(), "Expected: edge neighbour count 2");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 500)), "Expected: edge D-A neighbours A-B"); // D-A neighbours A-B
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 500)), "Expected: edge D-A neighbours C-D"); // D-A neighbours C-D
        }

        [Test]
        public void ThreePointsMeetingAtBorder()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 900), // #1
                new VoronoiSite(300, 100), // #2
                new VoronoiSite(500, 500), // #3
            };

            // 1000 ↑                                               ,,B
            //      |                                          ,,·''   
            //  900 |              1                      ,,·''        
            //      |                                ,,·''             
            //  800 |                           ,,·''                  
            //      |                      ,,·''                       
            //  700 |                 ,,·''                            
            //      |            ,,·''                                 
            //  600 |       ,,·''                                      
            //      |  ,,·''                                           
            //  500 A##                      3                         
            //      |  ''·,,                                           
            //  400 |       ''·,,                                      
            //      |            ''·,,                                 
            //  300 |                 ''·,,                            
            //      |                      ''·,,                       
            //  200 |                           ''·,,                  
            //      |                                ''·,,             
            //  100 |              2                      ''·,,        
            //      |                                          ''·,,   
            //    0 └-----------------------------------------------''C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 0), "Expected: has edge A-C"); // A-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 500, 1000, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            edge = FindEdge(edges, 0, 500, 1000, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 500, 1000, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorder"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorder_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 700), // #1
                new VoronoiSite(100, 700), // #2
                new VoronoiSite(500, 500), // #3
            };

            // 1000 ↑                        A                         
            //      |                       ' '                        
            //  900 |                     ,'   ',                      
            //      |                    ,       ,                     
            //  800 |                   ·         ·                    
            //      |                  '           '                   
            //  700 |    2           ,'             ',           1     
            //      |               ,                 ,                
            //  600 |              ·                   ·               
            //      |             '                     '              
            //  500 |           ,'           3           ',            
            //      |          ,                           ,           
            //  400 |         ·                             ·          
            //      |        '                               '         
            //  300 |      ,'                                 ',       
            //      |     ,                                     ,      
            //  200 |    ·                                       ·     
            //      |   '                                         '    
            //  100 | ,'                                           ',  
            //      |,                                               , 
            //    0 C-------------------------------------------------B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 1000, 1000, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 0), "Expected: has edge A-C"); // A-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 1000, 1000, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 0, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            edge = FindEdge(edges, 500, 1000, 0, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 1000, 1000, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorder"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorder_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 100), // #1
                new VoronoiSite(700, 900), // #2
                new VoronoiSite(500, 500), // #3
            };

            // 1000 C,,                                                
            //      |  ''·,,                                           
            //  900 |       ''·,,                      2               
            //      |            ''·,,                                 
            //  800 |                 ''·,,                            
            //      |                      ''·,,                       
            //  700 |                           ''·,,                  
            //      |                                ''·,,             
            //  600 |                                     ''·,,        
            //      |                                          ''·,,   
            //  500 |                        3                      ##A
            //      |                                          ,,·''   
            //  400 |                                     ,,·''        
            //      |                                ,,·''             
            //  300 |                           ,,·''                  
            //      |                      ,,·''                       
            //  200 |                 ,,·''                            
            //      |            ,,·''                                 
            //  100 |       ,,·''                      1               
            //      |  ,,·''                                           
            //    0 B''-----------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 500, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 500, 0, 1000), "Expected: has edge A-C"); // A-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 500, 0, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 0, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            edge = FindEdge(edges, 1000, 500, 0, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1000, 500, 0, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorder"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorder_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 300), // #1
                new VoronoiSite(900, 300), // #2
                new VoronoiSite(500, 500), // #3
            };

            // 1000 B                                                 C
            //      |'                                               ' 
            //  900 | ',                                           ,'  
            //      |   ,                                         ,    
            //  800 |    ·                                       ·     
            //      |     '                                     '      
            //  700 |      ',                                 ,'       
            //      |        ,                               ,         
            //  600 |         ·                             ·          
            //      |          '                           '           
            //  500 |           ',           3           ,'            
            //      |             ,                     ,              
            //  400 |              ·                   ·               
            //      |               '                 '                
            //  300 |    1           ',             ,'           2     
            //      |                  ,           ,                   
            //  200 |                   ·         ·                    
            //      |                    '       '                     
            //  100 |                     ',   ,'                      
            //      |                       , ,                        
            //    0 └------------------------A------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 0, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 1000), "Expected: has edge A-C"); // A-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 0, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 1000, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
            edge = FindEdge(edges, 500, 0, 1000, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 500, 0, 0, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
        }

        [Test]
        public void ThreePointsMeetingPastBorder()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 900), // #1
                new VoronoiSite(100, 100), // #2
                new VoronoiSite(300, 500), // #3
            };

            // 1000 ↑                                     ,,B          
            //      |                                ,,·''             
            //  900 |    1                      ,,·''                  
            //      |                      ,,·''                       
            //  800 |                 ,,·''                            
            //      |            ,,·''                                 
            //  700 |       ,,·''                                      
            //      |  ,,·''                                           
            //  600 A''                                                
            //      |                                                  
            //  500 |              3                                   
            //      |                                                  
            //  400 D,,                                                
            //      |  ''·,,                                           
            //  300 |       ''·,,                                      
            //      |            ''·,,                                 
            //  200 |                 ''·,,                            
            //      |                      ''·,,                       
            //  100 |    2                      ''·,,                  
            //      |                                ''·,,             
            //    0 └-------------------------------------''C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 600, 800, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 400, 800, 0), "Expected: has edge D-C"); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 600, 800, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 400, 800, 0); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorder"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorder_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 900), // #1
                new VoronoiSite(100, 900), // #2
                new VoronoiSite(500, 700), // #3
            };

            // 1000 ↑                   D         A                    
            //      |                  '           '                   
            //  900 |    2           ,'             ',           1     
            //      |               ,                 ,                
            //  800 |              ·                   ·               
            //      |             '                     '              
            //  700 |           ,'           3           ',            
            //      |          ,                           ,           
            //  600 |         ·                             ·          
            //      |        '                               '         
            //  500 |      ,'                                 ',       
            //      |     ,                                     ,      
            //  400 |    ·                                       ·     
            //      |   '                                         '    
            //  300 | ,'                                           ',  
            //      |,                                               , 
            //  200 C                                                 B
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 1000, 1000, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 200), "Expected: has edge D-C"); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 1000, 1000, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 400, 1000, 0, 200); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorder"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorder_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 100), // #1
                new VoronoiSite(900, 900), // #2
                new VoronoiSite(700, 500), // #3
            };

            // 1000 ↑         C,,                                      
            //      |            ''·,,                                 
            //  900 |                 ''·,,                      2     
            //      |                      ''·,,                       
            //  800 |                           ''·,,                  
            //      |                                ''·,,             
            //  700 |                                     ''·,,        
            //      |                                          ''·,,   
            //  600 |                                               ''D
            //      |                                                  
            //  500 |                                  3               
            //      |                                                  
            //  400 |                                               ,,A
            //      |                                          ,,·''   
            //  300 |                                     ,,·''        
            //      |                                ,,·''             
            //  200 |                           ,,·''                  
            //      |                      ,,·''                       
            //  100 |                 ,,·''                      1     
            //      |            ,,·''                                 
            //    0 └---------B''-------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 400, 200, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 600, 200, 1000), "Expected: has edge D-C"); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1000, 400, 200, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 1000, 600, 200, 1000); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorder"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorder_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 100), // #1
                new VoronoiSite(900, 100), // #2
                new VoronoiSite(500, 300), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 B                                                 C
            //      |'                                               ' 
            //  700 | ',                                           ,'  
            //      |   ,                                         ,    
            //  600 |    ·                                       ·     
            //      |     '                                     '      
            //  500 |      ',                                 ,'       
            //      |        ,                               ,         
            //  400 |         ·                             ·          
            //      |          '                           '           
            //  300 |           ',           3           ,'            
            //      |             ,                     ,              
            //  200 |              ·                   ·               
            //      |               '                 '                
            //  100 |    1           ',             ,'           2     
            //      |                  ,           ,                   
            //    0 └-------------------A---------D-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 0, 0, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 800), "Expected: has edge D-C"); // D-C

            // Assert

            VoronoiEdge edge = FindEdge(edges, 400, 0, 0, 800); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 600, 0, 1000, 800); // D-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        [Test]
        public void ThreePointsMeetingAtBorderSharply()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 600), // #1
                new VoronoiSite(400, 900), // #2
                new VoronoiSite(400, 300), // #3
            };

            // 1200 ↑                                                            
            //      |                                                            
            // 1100 |                                                            
            //      |                                                            
            // 1000 |                                                        ,,,C
            //      |                                                ,,,··'''    
            //  900 |                   2                     ,,,·'''            
            //      |                                 ,,,··'''                   
            //  800 |                          ,,,·'''                           
            //      |                  ,,,··'''                                  
            //  700 |           ,,,·'''                                          
            //      |   ,,,··'''                                                 
            //  600 A###                     1                                   
            //      |   '''··,,,                                                 
            //  500 |           '''·,,,                                          
            //      |                  '''··,,,                                  
            //  400 |                          '''·,,,                           
            //      |                                 '''··,,,                   
            //  300 |                   3                     '''·,,,            
            //      |                                                '''··,,,    
            //  200 |                                                        '''B
            //      |                                                            
            //  100 |                                                            
            //      |                                                            
            //    0 └-----------------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 600, 1200, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 600, 1200, 200), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 600, 1200, 1000); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 1200, 200)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            edge = FindEdge(edges, 0, 600, 1200, 200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 0, 600, 1200, 1000)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderSharply"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderSharply_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 700), // #1
                new VoronoiSite(900, 800), // #2
                new VoronoiSite(300, 800), // #3
            };

            // 1200 ↑                             A                              
            //      |                            · ·                             
            // 1100 |                           ·   ·                            
            //      |                          ·     ·                           
            // 1000 |                          ·     ·                           
            //      |                         ·       ·                          
            //  900 |                        ·         ·                         
            //      |                       ·           ·                        
            //  800 |              3       ·             ·       2               
            //      |                     ·               ·                      
            //  700 |                     ·       1       ·                      
            //      |                    ·                 ·                     
            //  600 |                   ·                   ·                    
            //      |                  ·                     ·                   
            //  500 |                 ·                       ·                  
            //      |                ·                         ·                 
            //  400 |                ·                         ·                 
            //      |               ·                           ·                
            //  300 |              ·                             ·               
            //      |             ·                               ·              
            //  200 |            ·                                 ·             
            //      |           ·                                   ·            
            //  100 |           ·                                   ·            
            //      |          ·                                     ·           
            //    0 └---------B---------------------------------------C---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 1200, 1000, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 1200, 200, 0), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 1200, 1000, 0); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1200, 200, 0)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            edge = FindEdge(edges, 600, 1200, 200, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 1200, 1000, 0)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderSharply"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderSharply_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 600), // #1
                new VoronoiSite(800, 300), // #2
                new VoronoiSite(800, 900), // #3
            };

            // 1200 ↑                                                            
            //      |                                                            
            // 1100 |                                                            
            //      |                                                            
            // 1000 B,,,                                                         
            //      |   '''··,,,                                                 
            //  900 |           '''·,,,                     3                    
            //      |                  '''··,,,                                  
            //  800 |                          '''·,,,                           
            //      |                                 '''··,,,                   
            //  700 |                                         '''·,,,            
            //      |                                                '''··,,,    
            //  600 |                                  1                     ###A
            //      |                                                ,,,··'''    
            //  500 |                                         ,,,·'''            
            //      |                                 ,,,··'''                   
            //  400 |                          ,,,·'''                           
            //      |                  ,,,··'''                                  
            //  300 |           ,,,·'''                     2                    
            //      |   ,,,··'''                                                 
            //  200 C'''                                                         
            //      |                                                            
            //  100 |                                                            
            //      |                                                            
            //    0 └-----------------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1200, 600, 0, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 1200, 600, 0, 1000), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1200, 600, 0, 200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1200, 600, 0, 1000)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            edge = FindEdge(edges, 1200, 600, 0, 1000); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 1200, 600, 0, 200)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderSharply"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderSharply_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 500), // #1
                new VoronoiSite(300, 400), // #2
                new VoronoiSite(900, 400), // #3
            };

            // 1200 ↑         C                                       B          
            //      |          ·                                     ·           
            // 1100 |           ·                                   ·            
            //      |           ·                                   ·            
            // 1000 |            ·                                 ·             
            //      |             ·                               ·              
            //  900 |              ·                             ·               
            //      |               ·                           ·                
            //  800 |                ·                         ·                 
            //      |                ·                         ·                 
            //  700 |                 ·                       ·                  
            //      |                  ·                     ·                   
            //  600 |                   ·                   ·                    
            //      |                    ·                 ·                     
            //  500 |                     ·       1       ·                      
            //      |                     ·               ·                      
            //  400 |              2       ·             ·       3               
            //      |                       ·           ·                        
            //  300 |                        ·         ·                         
            //      |                         ·       ·                          
            //  200 |                          ·     ·                           
            //      |                          ·     ·                           
            //  100 |                           ·   ·                            
            //      |                            · ·                             
            //    0 └-----------------------------A-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 0, 200, 1200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 1200), "Expected: has edge A-B"); // A-B

            // Assert

            VoronoiEdge edge = FindEdge(edges, 600, 0, 200, 1200); // A-C
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 1000, 1200)), "Expected: edge A-C neighbours A-B"); // A-C neighbours A-B
            edge = FindEdge(edges, 600, 0, 1000, 1200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(1, edge.Neighbours.Count(), "Expected: edge neighbour count 1");
            Assert.IsTrue(edge.Neighbours.Contains(FindEdge(edges, 600, 0, 200, 1200)), "Expected: edge A-B neighbours A-C"); // A-B neighbours A-C
        }

        [Test]
        public void ThreePointsMeetingPastBorderSharply()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 600), // #1
                new VoronoiSite(100, 900), // #2
                new VoronoiSite(100, 300), // #3
            };

            // 1200 ↑                                                            
            //      |                                                            
            // 1100 |                                                        ,,,B
            //      |                                                ,,,··'''    
            // 1000 |                                         ,,,·'''            
            //      |                                 ,,,··'''                   
            //  900 |    2                     ,,,·'''                           
            //      |                  ,,,··'''                                  
            //  800 |           ,,,·'''                                          
            //      |   ,,,··'''                                                 
            //  700 A'''                                                         
            //      |                                                            
            //  600 |         1                                                  
            //      |                                                            
            //  500 D,,,                                                         
            //      |   '''··,,,                                                 
            //  400 |           '''·,,,                                          
            //      |                  '''··,,,                                  
            //  300 |    3                     '''·,,,                           
            //      |                                 '''··,,,                   
            //  200 |                                         '''·,,,            
            //      |                                                '''··,,,    
            //  100 |                                                        '''C
            //      |                                                            
            //    0 └-----------------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1200, 1100), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1200, 100, 0, 500), "Expected: has edge C-D"); // C-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 0, 700, 1200, 1100); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 1200, 100, 0, 500); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderSharply"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderSharply_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 1000), // #1
                new VoronoiSite(900, 1100), // #2
                new VoronoiSite(300, 1100), // #3
            };

            // 1200 ↑                        D         A                         
            //      |                       ·           ·                        
            // 1100 |              3       ·             ·       2               
            //      |                      ·              ·                      
            // 1000 |                     ·       1       ·                      
            //      |                    ·                 ·                     
            //  900 |                   ·                   ·                    
            //      |                  ·                     ·                   
            //  800 |                 ·                       ·                  
            //      |                 ·                        ·                 
            //  700 |                ·                         ·                 
            //      |               ·                           ·                
            //  600 |              ·                             ·               
            //      |             ·                               ·              
            //  500 |            ·                                 ·             
            //      |            ·                                  ·            
            //  400 |           ·                                   ·            
            //      |          ·                                     ·           
            //  300 |         ·                                       ·          
            //      |        ·                                         ·         
            //  200 |       ·                                           ·        
            //      |       ·                                            ·       
            //  100 |      ·                                             ·       
            //      |     ·                                               ·      
            //    0 └----C-------------------------------------------------B----→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1200, 1100, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 100, 0, 500, 1200), "Expected: has edge C-D"); // C-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 700, 1200, 1100, 0); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 100, 0, 500, 1200); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderSharply"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderSharply_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1000, 600), // #1
                new VoronoiSite(1100, 300), // #2
                new VoronoiSite(1100, 900), // #3
            };

            // 1200 ↑                                                            
            //      |                                                            
            // 1100 C,,,                                                         
            //      |   '''··,,,                                                 
            // 1000 |           '''·,,,                                          
            //      |                  '''··,,,                                  
            //  900 |                          '''·,,,                     3     
            //      |                                 '''··,,,                   
            //  800 |                                         '''·,,,            
            //      |                                                '''··,,,    
            //  700 |                                                        '''D
            //      |                                                            
            //  600 |                                                 1          
            //      |                                                            
            //  500 |                                                        ,,,A
            //      |                                                ,,,··'''    
            //  400 |                                         ,,,·'''            
            //      |                                 ,,,··'''                   
            //  300 |                          ,,,·'''                     2     
            //      |                  ,,,··'''                                  
            //  200 |           ,,,·'''                                          
            //      |   ,,,··'''                                                 
            //  100 B'''                                                         
            //      |                                                            
            //    0 └-----------------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1200, 500, 0, 100), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1100, 1200, 700), "Expected: has edge C-D"); // C-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 1200, 500, 0, 100); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 0, 1100, 1200, 700); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderSharply"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderSharply_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(600, 200), // #1
                new VoronoiSite(300, 100), // #2
                new VoronoiSite(900, 100), // #3
            };

            // 1200 ↑    B                                                 C     
            //      |     ·                                               ·      
            // 1100 |      ·                                             ·       
            //      |      ·                                            ·        
            // 1000 |       ·                                           ·        
            //      |        ·                                         ·         
            //  900 |         ·                                       ·          
            //      |          ·                                     ·           
            //  800 |           ·                                   ·            
            //      |           ·                                  ·             
            //  700 |            ·                                 ·             
            //      |             ·                               ·              
            //  600 |              ·                             ·               
            //      |               ·                           ·                
            //  500 |                ·                         ·                 
            //      |                ·                        ·                  
            //  400 |                 ·                       ·                  
            //      |                  ·                     ·                   
            //  300 |                   ·                   ·                    
            //      |                    ·                 ·                     
            //  200 |                     ·       1       ·                      
            //      |                     ·              ·                       
            //  100 |              2       ·             ·       3               
            //      |                       ·           ·                        
            //    0 └------------------------A---------D------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 2 == edges.Count, "Expected: edge count 2");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 0, 100, 1200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1100, 1200, 700, 0), "Expected: has edge C-D"); // C-D

            // Assert

            VoronoiEdge edge = FindEdge(edges, 500, 0, 100, 1200); // A-B
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
            edge = FindEdge(edges, 1100, 1200, 700, 0); // C-D
            Assert.NotNull(edge.Neighbours);
            Assert.AreEqual(0, edge.Neighbours.Count(), "Expected: edge neighbour count 0");
        }

    }
}
