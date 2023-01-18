using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

#pragma warning disable
// ReSharper disable All

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiSite"/>`s have expected clockwise-sorted <see cref="VoronoiEdge"/>`s.
    /// Specifically, that the <see cref="VoronoiSite.ClockwiseCell"/> contains the expected edges in clockwise order.
    /// These tests are run without generating the border edges, i.e. <see cref="BorderEdgeGeneration.DoNotMakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_SiteEdgesClockwise_OpenBorders
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

            // There are no sites, so nothing to check
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(0, sites[0].ClockwiseCell.Count()); // #1
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 500, 1000, 500)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 500, 1000, 500)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 500, 1000, 500)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 500, 1000, 500)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 1000, 500, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 1000, 500, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 1000, 500, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 1000, 500, 0)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 700, 1000, 700)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 700, 1000, 700)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 700, 1000, 700)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 700, 1000, 700)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 1000, 700, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 1000, 700, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 1000, 700, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 1000, 700, 0)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 300), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 700, 1000, 700)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 700, 1000, 700)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 700, 1000, 700)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 300, 1000, 300)); // #2 has C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 700, 1000, 700)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 300, 1000, 300)); // #2 C-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 300, 1000, 300)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 300, 1000, 300)); // #3 C-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 1000, 700, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 1000, 700, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 1000, 700, 0)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 1000, 300, 0)); // #2 has C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 300, 1000, 300, 0)); // #2 C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 1000, 700, 0)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 1000, 300, 0)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 1000, 300, 0)); // #3 C-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 0, 300), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 300), "Expected: site #4 has F"); // #4 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 700, 1000, 700)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 700, 1000, 700)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 700, 1000, 700)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 500, 1000, 500)); // #2 has C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 700, 1000, 700)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 500, 1000, 500)); // #2 C-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 500, 1000, 500)); // #3 has C-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 300, 1000, 300)); // #3 has E-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 500, 1000, 500)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 300, 1000, 300)); // #3 E-F
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 0, 300, 1000, 300)); // #4 has E-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 0, 300, 1000, 300)); // #4 E-F
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 300, 1000), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has F"); // #4 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 1000, 700, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 1000, 700, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 1000, 700, 0)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 1000, 500, 0)); // #2 has C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 1000, 500, 0)); // #2 C-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 1000, 700, 0)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 1000, 500, 0)); // #3 has C-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 1000, 300, 0)); // #3 has E-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 1000, 300, 0)); // #3 E-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 1000, 500, 0)); // #3 C-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 300, 1000, 300, 0)); // #4 has E-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 300, 1000, 300, 0)); // #4 E-F
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 0, 1000, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 0, 1000, 1000)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 1000, 1000, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 1000, 1000, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 0)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 200, 800, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 200, 800, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 200, 800, 1000)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 200, 800, 1000)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 200, 1000, 1000, 200)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 200, 1000, 1000, 200)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 200, 1000, 1000, 200)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 200, 1000, 1000, 200)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 800, 200, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 800, 200, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 800, 200, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 800, 200, 0)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 800, 0, 0, 800)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 800, 0, 0, 800)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 800, 0, 0, 800)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 800, 0, 0, 800)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 1000, 1000, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 1000, 1000, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 0)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 1000, 0, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 1000, 0, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 0)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 0, 0, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 0, 0, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 0, 0, 1000)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 0, 0, 1000)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 0, 1000, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 0, 1000, 1000)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 1000, 1000, 500)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 500)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 1000, 1000, 500)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 500)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 1000, 500, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 500, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 1000, 500, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 1000, 500, 0)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 0, 0, 500)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 0, 0, 500)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 0, 0, 500)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 0, 0, 500)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 0, 500, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 0, 500, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 0, 500, 1000)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 0, 500, 1000)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 1000, 0, 500)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 500)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 1000, 0, 500)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 500)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 0, 500, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 0, 500, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 0, 500, 1000)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 0, 500, 1000)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 0, 1000, 500)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 0, 1000, 500)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 0, 1000, 500)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 0, 1000, 500)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 1000, 500, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1000, 500, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 1000, 500, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 500, 0)); // #2 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 700), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 300, 700, 1000)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 300, 700, 1000)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 300, 700, 1000)); // #2 has A-D
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 0, 1000, 700)); // #2 has B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 300, 700, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 0, 1000, 700)); // #2 B-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 0, 1000, 700)); // #3 has B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 0, 1000, 700)); // #3 B-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 300), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 300), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 1000, 1000, 300)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 1000, 1000, 300)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 1000, 1000, 300)); // #2 has A-D
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 700, 700, 0)); // #2 has B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 700, 700, 0)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 1000, 1000, 300)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 700, 700, 0)); // #3 has B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 700, 700, 0)); // #3 B-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 400, 600, 1000)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 400, 600, 1000)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 400, 600, 1000)); // #2 has A-D
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 0, 1000, 1000)); // #2 has B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 400, 600, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 0, 1000, 1000)); // #2 B-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 0, 1000, 1000)); // #3 has B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #3 B-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 1000, 1000, 400)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 1000, 1000, 400)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 1000, 1000, 400)); // #2 has A-D
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 1000, 1000, 0)); // #2 has B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 0)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 1000, 1000, 400)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 1000, 1000, 0)); // #3 has B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 0)); // #3 B-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 600, 400, 0)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 600, 400, 0)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 600, 400, 0)); // #2 has A-D
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 1000, 0, 0)); // #2 has B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 0)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 600, 400, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1000, 1000, 0, 0)); // #3 has B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 1000, 0, 0)); // #3 B-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 0, 0, 600)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 0, 0, 600)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 0, 0, 600)); // #2 has A-D
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 0, 0, 1000)); // #2 has B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 0, 0, 600)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 1000, 0, 0, 1000)); // #2 B-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1000, 0, 0, 1000)); // #3 has B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 0, 0, 1000)); // #3 B-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has F"); // #1 has F
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 0), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 1000, 600), "Expected: site #4 has D"); // #4 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 400, 600, 1000)); // #1 has A-F
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 400, 600, 1000)); // #1 A-F
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 400, 600, 1000)); // #2 has A-F
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 0, 1000, 1000)); // #2 has B-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 400, 600, 1000)); // #2 A-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 0, 1000, 1000)); // #2 B-E
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 0, 1000, 1000)); // #3 has B-E
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 0, 1000, 600)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 0, 1000, 1000)); // #3 B-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 0, 1000, 600)); // #3 C-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 0, 1000, 600)); // #4 has C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 0, 1000, 600)); // #4 C-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has F"); // #1 has F
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 0, 600), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 600, 0), "Expected: site #4 has D"); // #4 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 1000, 1000, 400)); // #1 has A-F
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 1000, 1000, 400)); // #1 A-F
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 1000, 1000, 400)); // #2 has A-F
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 1000, 1000, 0)); // #2 has B-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 1000, 1000, 0)); // #2 B-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 1000, 1000, 400)); // #2 A-F
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 1000, 1000, 0)); // #3 has B-E
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 600, 600, 0)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 600, 600, 0)); // #3 C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 1000, 1000, 0)); // #3 B-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 0, 600, 600, 0)); // #4 has C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 0, 600, 600, 0)); // #4 C-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 0, 400)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 1000, 1000)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 400, 0, 400)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 400, 1000, 1000)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 0, 400)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 400, 0)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 400, 0, 400)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 400, 400, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 400, 400, 0)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 400, 1000, 1000)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 400, 1000, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 400, 400, 0)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 400, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 1000, 0)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 600, 400, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 600, 1000, 0)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 400, 1000)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 0, 600)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 600, 0, 600)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 600, 400, 1000)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 600, 0, 600)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 600, 1000, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 600, 0, 600)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 600, 1000, 0)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 1000, 600)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 0, 0)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 600, 1000, 600)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 600, 0, 0)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 600, 1000, 600)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 600, 600, 1000)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 600, 600, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 600, 1000, 600)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 600, 600, 1000)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 600, 0, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 600, 0, 0)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 600, 600, 1000)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 600, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 0, 1000)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 400, 0, 1000)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 400, 600, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 400, 600, 0)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 400, 1000, 400)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 400, 1000, 400)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 400, 600, 0)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 400, 1000, 400)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 400, 0, 1000)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 400, 0, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 400, 1000, 400)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 700, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 600, 0, 600)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 600, 700, 1000)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 600, 0, 600)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 300, 600, 700, 1000)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 600, 0, 600)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 600, 300, 0)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 300, 600, 0, 600)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 600, 300, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 600, 300, 0)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 600, 700, 1000)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 600, 700, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 600, 300, 0)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 300), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 700), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 700, 600, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 700, 1000, 300)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 700, 600, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 700, 1000, 300)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 700, 600, 1000)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 700, 0, 700)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 700, 0, 700)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 700, 600, 1000)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 700, 0, 700)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 700, 1000, 300)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 700, 0, 700)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 700, 1000, 300)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 300, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 700, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 700, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 400, 1000, 400)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 400, 300, 0)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 400, 1000, 400)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 700, 400, 300, 0)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 400, 1000, 400)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 400, 700, 1000)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 400, 700, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 400, 1000, 400)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 400, 700, 1000)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 400, 300, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 700, 400, 300, 0)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 700, 400, 700, 1000)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 300), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 300, 400, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 300, 0, 700)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 300, 0, 700)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 300, 400, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 300, 400, 0)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 300, 1000, 300)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 300, 1000, 300)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 300, 400, 0)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 300, 1000, 300)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 300, 0, 700)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 300, 0, 700)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 300, 1000, 300)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 300, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 700, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 600, 1000, 600)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 600, 300, 1000)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 600, 300, 1000)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 700, 600, 1000, 600)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 600, 1000, 600)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 600, 700, 0)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 600, 1000, 600)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 600, 700, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 600, 700, 0)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 600, 300, 1000)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 700, 600, 300, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 700, 600, 700, 0)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 700), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 300, 600, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 300, 1000, 700)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 300, 1000, 700)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 300, 600, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 300, 600, 0)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 300, 0, 300)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 300, 0, 300)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 300, 600, 0)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 300, 0, 300)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 300, 1000, 700)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 300, 0, 300)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 300, 1000, 700)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 400, 0, 400)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 400, 700, 0)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 400, 0, 400)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 300, 400, 700, 0)); // #1 A-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 400, 0, 400)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 400, 300, 1000)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 300, 400, 0, 400)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 400, 300, 1000)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 400, 300, 1000)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 400, 700, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 400, 300, 1000)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 400, 700, 0)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 700), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 700), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 700, 400, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 700, 0, 300)); // #1 has A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 700, 0, 300)); // #1 A-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 700, 400, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 700, 400, 1000)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 700, 1000, 700)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 700, 400, 1000)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 700, 1000, 700)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 700, 1000, 700)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 700, 0, 300)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 700, 1000, 700)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 700, 0, 300)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 0, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 0)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 0)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 1000, 0)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 500, 1000)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 500, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 0, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 500, 1000)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 500, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 0, 0)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 0, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 0, 0)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 0, 0)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 0, 0)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 1000, 500)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 1000, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 0, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 0, 1000)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 1000, 500)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 1000, 500)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 0, 1000)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 0, 1000)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 500, 0)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 1000, 1000)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 500, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 1000, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 1000)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 1000, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 1000, 1000)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 0, 500)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 1000, 1000)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 1000, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 0, 500)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 300, 200, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 300, 800, 0)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 300, 200, 0)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 300, 800, 0)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 300, 800, 0)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 300, 500, 1000)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 300, 500, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 300, 800, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 300, 200, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 300, 500, 1000)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 300, 500, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 300, 200, 0)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 800), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 500, 0, 800)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 500, 0, 200)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 500, 0, 800)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 300, 500, 0, 200)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 500, 0, 200)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 500, 1000, 500)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 300, 500, 1000, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 500, 0, 200)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 500, 0, 800)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 500, 1000, 500)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 500, 0, 800)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 500, 1000, 500)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 700), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 800, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 700, 800, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 700, 200, 1000)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 700, 200, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 700, 800, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 700, 200, 1000)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 700, 500, 0)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 700, 200, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 700, 500, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 700, 800, 1000)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 700, 500, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 700, 800, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 700, 500, 0)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 700, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 500, 1000, 200)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 500, 1000, 800)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 500, 1000, 800)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 700, 500, 1000, 200)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 500, 1000, 800)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 500, 0, 500)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 500, 0, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 500, 1000, 800)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 500, 1000, 200)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 500, 0, 500)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 700, 500, 0, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 700, 500, 1000, 200)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 700), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 700, 0, 200)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 700, 1000, 200)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 700, 0, 200)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 700, 1000, 200)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 700, 1000, 200)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 700, 500, 1000)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 700, 500, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 700, 1000, 200)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 700, 0, 200)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 700, 500, 1000)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 700, 500, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 700, 0, 200)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 700, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 200, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 500, 200, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 500, 200, 0)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 500, 200, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 700, 500, 200, 0)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 500, 200, 0)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 500, 1000, 500)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 500, 1000, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 500, 200, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 500, 200, 1000)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 500, 1000, 500)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 700, 500, 200, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 700, 500, 1000, 500)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 800), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 300, 1000, 800)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 300, 0, 800)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 300, 0, 800)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 300, 1000, 800)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 300, 0, 800)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 300, 500, 0)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 300, 0, 800)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 300, 500, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 300, 1000, 800)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 300, 500, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 300, 1000, 800)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 300, 500, 0)); // #3 A-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 800, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 500, 800, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 500, 800, 1000)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 500, 800, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 300, 500, 800, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 500, 800, 1000)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 500, 0, 500)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 300, 500, 0, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 500, 800, 1000)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 500, 800, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 500, 0, 500)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 500, 0, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 500, 800, 0)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 400), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 600, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 400), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 600, 600), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 1000, 1000), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 400, 600), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 600, 600), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 0, 1000), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 1000, 1000), "Expected: site #5 has H"); // #5 has H

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 400, 400)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 600, 400)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 600, 600)); // #1 has C-D
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 400, 600)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 600, 400, 600)); // #1 D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 600, 400, 400)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 400, 400, 600, 400)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 600, 400, 600, 600)); // #1 C-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 400, 400)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 0, 1000)); // #2 has A-E
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 0, 0)); // #2 has B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 600, 0, 1000)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 400, 0, 0)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 400, 600, 400, 400)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 400, 600, 400)); // #3 has B-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 400, 0, 0)); // #3 has B-F
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 400, 1000, 0)); // #3 has C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 400, 600, 400)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 400, 0, 0)); // #3 B-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 600, 400, 1000, 0)); // #3 C-G
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 400, 600, 600)); // #4 has C-D
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 400, 1000, 0)); // #4 has C-G
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 600, 1000, 1000)); // #4 has D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 600, 1000, 1000)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 400, 600, 600)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 600, 400, 1000, 0)); // #4 C-G
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 600, 400, 600)); // #5 has D-A
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 600, 0, 1000)); // #5 has A-E
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 600, 1000, 1000)); // #5 has D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 600, 0, 1000)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 600, 600, 400, 600)); // #5 D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 600, 600, 1000, 1000)); // #5 D-H
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 600, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 200), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 600, 200), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 800, 0), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 200), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 600, 400), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 800, 0), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 1000, 800), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 400, 400), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 600, 400), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 0, 800), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 1000, 800), "Expected: site #5 has H"); // #5 has H

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 400, 200)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 200, 600, 200)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 200, 600, 400)); // #1 has C-D
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 400, 400)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 400, 400, 400)); // #1 D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 400, 400, 200)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 400, 200, 600, 200)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 600, 200, 600, 400)); // #1 C-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 400, 200)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 0, 800)); // #2 has A-E
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 200, 200, 0)); // #2 has B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 400, 0, 800)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 200, 200, 0)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 400, 400, 400, 200)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 200, 600, 200)); // #3 has B-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 200, 200, 0)); // #3 has B-F
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 200, 800, 0)); // #3 has C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 200, 600, 200)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 200, 200, 0)); // #3 B-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 600, 200, 800, 0)); // #3 C-G
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 200, 600, 400)); // #4 has C-D
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 200, 800, 0)); // #4 has C-G
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 400, 1000, 800)); // #4 has D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 400, 1000, 800)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 200, 600, 400)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 600, 200, 800, 0)); // #4 C-G
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 400, 400, 400)); // #5 has D-A
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 400, 0, 800)); // #5 has A-E
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 400, 1000, 800)); // #5 has D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 400, 0, 800)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 600, 400, 400, 400)); // #5 D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 600, 400, 1000, 800)); // #5 D-H
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 400), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 600), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 200, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 800), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 0, 200), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 200, 400), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 400, 400), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 0, 200), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 800, 0), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 400, 600), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 400, 400), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 800, 1000), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 800, 0), "Expected: site #5 has H"); // #5 has H

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 200, 600)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 200, 600, 200, 400)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 200, 400, 400, 400)); // #1 has C-D
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 400, 600)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 600, 200, 600)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 200, 600, 200, 400)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 200, 400, 400, 400)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 400, 400, 400, 600)); // #1 D-A
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 200, 600)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 800, 1000)); // #2 has A-E
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 200, 600, 0, 800)); // #2 has B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 200, 600, 0, 800)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 600, 200, 600)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 400, 600, 800, 1000)); // #2 A-E
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 200, 600, 200, 400)); // #3 has B-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 200, 600, 0, 800)); // #3 has B-F
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 200, 400, 0, 200)); // #3 has C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 200, 600, 0, 800)); // #3 B-F
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 200, 400, 0, 200)); // #3 C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 200, 600, 200, 400)); // #3 B-C
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 200, 400, 400, 400)); // #4 has C-D
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 200, 400, 0, 200)); // #4 has C-G
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 400, 800, 0)); // #4 has D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 200, 400, 400, 400)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 200, 400, 0, 200)); // #4 C-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 400, 400, 800, 0)); // #4 D-H
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 400, 400, 600)); // #5 has D-A
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 600, 800, 1000)); // #5 has A-E
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 400, 800, 0)); // #5 has D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 600, 800, 1000)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 400, 400, 400, 600)); // #5 D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 400, 400, 800, 0)); // #5 D-H
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 400, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 800), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 800), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 400, 800), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 800, 1000), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 200, 1000), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 800), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 400, 600), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 200, 1000), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 0, 200), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 600, 600), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 400, 600), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 1000, 200), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 0, 200), "Expected: site #5 has H"); // #5 has H

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 600, 800)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 800, 400, 800)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 800, 400, 600)); // #1 has C-D
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 600, 600)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 800, 400, 800)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 800, 400, 600)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 400, 600, 600, 600)); // #1 D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 600, 600, 600, 800)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 600, 600, 800)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 600, 1000, 200)); // #2 has A-E
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 800, 800, 1000)); // #2 has B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 800, 800, 1000)); // #2 B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 600, 600, 800)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 600, 600, 1000, 200)); // #2 A-E
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 800, 400, 800)); // #3 has B-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 800, 800, 1000)); // #3 has B-F
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 800, 200, 1000)); // #3 has C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 800, 200, 1000)); // #3 C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 800, 400, 800)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 600, 800, 800, 1000)); // #3 B-F
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 800, 400, 600)); // #4 has C-D
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 800, 200, 1000)); // #4 has C-G
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 600, 0, 200)); // #4 has D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 800, 200, 1000)); // #4 C-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 400, 600, 0, 200)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 400, 800, 400, 600)); // #4 C-D
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 600, 600, 600)); // #5 has D-A
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 600, 1000, 200)); // #5 has A-E
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 600, 0, 200)); // #5 has D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 600, 600, 600)); // #5 D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 400, 600, 0, 200)); // #5 D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 600, 600, 1000, 200)); // #5 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 600), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 400), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 800, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 200), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 1000, 800), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 800, 600), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 600, 600), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 1000, 800), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 200, 1000), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 600, 400), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 600, 600), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 200, 0), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 200, 1000), "Expected: site #5 has H"); // #5 has H

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(4, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 800, 400)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 800, 400, 800, 600)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 800, 600, 600, 600)); // #1 has C-D
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 600, 400)); // #1 has D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 800, 600, 600, 600)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 600, 600, 400)); // #1 D-A
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(2), 600, 400, 800, 400)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(3), 800, 400, 800, 600)); // #1 B-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 400, 800, 400)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 400, 200, 0)); // #2 has A-E
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 800, 400, 1000, 200)); // #2 has B-F
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 400, 800, 400)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 400, 200, 0)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 800, 400, 1000, 200)); // #2 B-F
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 800, 400, 800, 600)); // #3 has B-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 800, 400, 1000, 200)); // #3 has B-F
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 800, 600, 1000, 800)); // #3 has C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 800, 600, 1000, 800)); // #3 C-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 800, 400, 800, 600)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 800, 400, 1000, 200)); // #3 B-F
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 800, 600, 600, 600)); // #4 has C-D
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 800, 600, 1000, 800)); // #4 has C-G
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 600, 200, 1000)); // #4 has D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 600, 200, 1000)); // #4 D-H
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 800, 600, 600, 600)); // #4 C-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 800, 600, 1000, 800)); // #4 C-G
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 600, 600, 400)); // #5 has D-A
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 400, 200, 0)); // #5 has A-E
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 600, 200, 1000)); // #5 has D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 600, 600, 200, 1000)); // #5 D-H
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 600, 400, 200, 0)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 600, 600, 600, 400)); // #5 D-A
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 500, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 500, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 0, 500)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 500, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 0, 500)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 500, 0)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 500, 0)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 1000, 500)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 1000, 500)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 500, 500, 1000)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 500, 1000, 500)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 500, 500, 1000)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 500, 1000, 500)); // #4 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 500, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 500, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 0, 500)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 500, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 0, 500)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 500, 0)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 500, 0)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 1000, 500)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 1000, 500)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 500, 500, 1000)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 500, 1000, 500)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 500, 500, 1000)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 500, 1000, 500)); // #4 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 500, 0), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 500)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 500, 1000)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 500, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 500)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 500, 1000)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 0, 500)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 500, 1000)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 0, 500)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 500, 0)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 0, 500)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 500, 1000, 500)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 500, 500, 0)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 500, 1000, 500)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 500, 500, 0)); // #4 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has E"); // #1 has E
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has C"); // #4 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 0, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 1000)); // #1 has A-E
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 1000)); // #1 A-E
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 1000, 0)); // #2 has A-D
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 1000, 1000)); // #2 has A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 1000, 1000)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 0, 0)); // #3 has A-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 500, 1000, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 500, 0, 0)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 500, 0, 1000)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 500, 0, 0)); // #4 has A-C
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 500, 0, 0)); // #4 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 100, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 700), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 100, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 700), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 100, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 0, 200)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 400, 0, 200)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 400, 100, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 0, 200)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 600, 0)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 400, 0, 200)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 400, 600, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 400, 600, 0)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 400, 1000, 700)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 400, 1000, 700)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 400, 600, 0)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 400, 100, 1000)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 400, 1000, 700)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 400, 100, 1000)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 400, 400, 1000, 700)); // #4 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 900), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 900), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 700, 0), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 1000, 900)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 200, 1000)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 600, 200, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 600, 1000, 900)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 200, 1000)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 0, 400)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 600, 0, 400)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 600, 200, 1000)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 600, 0, 400)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 600, 700, 0)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 600, 0, 400)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 600, 700, 0)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 600, 1000, 900)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 600, 700, 0)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 600, 1000, 900)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 400, 600, 700, 0)); // #4 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 900, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 900, 0), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 0, 300), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 900, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 1000, 800)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 600, 1000, 800)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 600, 900, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 600, 1000, 800)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 600, 400, 1000)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 600, 400, 1000)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 600, 1000, 800)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 600, 400, 1000)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 600, 0, 300)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 600, 0, 300)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 600, 400, 1000)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 600, 900, 0)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 600, 0, 300)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 600, 0, 300)); // #4 A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 600, 900, 0)); // #4 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 100), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 100), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 300, 1000), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 0, 100)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 800, 0)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 400, 0, 100)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 400, 800, 0)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 400, 800, 0)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 400, 1000, 600)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 400, 1000, 600)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 400, 800, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 400, 1000, 600)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 400, 300, 1000)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 400, 300, 1000)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 400, 1000, 600)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 400, 0, 100)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 400, 300, 1000)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 400, 0, 100)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 400, 300, 1000)); // #4 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 900, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 900, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 0, 700), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 900, 1000)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 400, 1000, 200)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 400, 900, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 400, 1000, 200)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 400, 1000, 200)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 400, 400, 0)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 400, 1000, 200)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 400, 400, 0)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 400, 400, 0)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 400, 0, 700)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 400, 0, 700)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 400, 400, 0)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 400, 900, 1000)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 400, 0, 700)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 400, 0, 700)); // #4 A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 400, 900, 1000)); // #4 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 100), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 700, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 100), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 700, 1000), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 1000, 100)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 400, 200, 0)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 400, 1000, 100)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 400, 200, 0)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 200, 0)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 400, 0, 600)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 400, 0, 600)); // #2 A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 400, 200, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 400, 0, 600)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 400, 700, 1000)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 400, 0, 600)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 400, 700, 1000)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 400, 1000, 100)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 400, 700, 1000)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 400, 700, 1000)); // #4 A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 400, 400, 1000, 100)); // #4 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 100, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 100, 0), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 300), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 100, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 600, 0, 800)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 600, 0, 800)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 400, 600, 100, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 0, 800)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 600, 600, 1000)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 600, 0, 800)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 600, 600, 1000)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 600, 600, 1000)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 600, 1000, 300)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 600, 600, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 600, 1000, 300)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 600, 100, 0)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 600, 1000, 300)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 600, 1000, 300)); // #4 A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 400, 600, 100, 0)); // #4 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 900), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 400), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 900), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has E"); // #4 has E

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 0, 900)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 600, 800, 1000)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 600, 0, 900)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 600, 800, 1000)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 600, 800, 1000)); // #2 has A-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 600, 1000, 400)); // #2 has A-D
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 600, 800, 1000)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 600, 600, 1000, 400)); // #2 A-D
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 600, 1000, 400)); // #3 has A-D
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 600, 300, 0)); // #3 has A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 600, 1000, 400)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 600, 300, 0)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 600, 0, 900)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 600, 300, 0)); // #4 has A-E
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 600, 0, 900)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 600, 300, 0)); // #4 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 400), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 500, 0), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 400), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 500, 700), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 800, 1000), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 1000, 400), "Expected: site #5 has F"); // #5 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 700, 200, 1000)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 700, 800, 1000)); // #1 has B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 700, 200, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 700, 800, 1000)); // #1 B-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 400, 500, 700)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 700, 200, 1000)); // #2 has B-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 400, 0, 400)); // #2 has A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 700, 200, 1000)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 400, 0, 400)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 400, 500, 700)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 400, 0, 400)); // #3 has A-E
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 400, 500, 0)); // #3 has A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 400, 0, 400)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 400, 500, 0)); // #3 A-G
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 400, 1000, 400)); // #4 has A-F
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 400, 500, 0)); // #4 has A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 400, 1000, 400)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 400, 500, 0)); // #4 A-G
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 400, 500, 700)); // #5 has A-B
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 700, 800, 1000)); // #5 has B-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 400, 1000, 400)); // #5 has A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 500, 700, 800, 1000)); // #5 B-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 400, 500, 700)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 500, 400, 1000, 400)); // #5 A-F
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 400, 0), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 0, 500), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 400, 500), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 700, 500), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 1000, 200), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 400, 0), "Expected: site #5 has F"); // #5 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 500, 1000, 800)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 500, 1000, 200)); // #1 has B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 500, 1000, 800)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 700, 500, 1000, 200)); // #1 B-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 500, 700, 500)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 500, 1000, 800)); // #2 has B-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 500, 400, 1000)); // #2 has A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 500, 400, 1000)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 400, 500, 700, 500)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 700, 500, 1000, 800)); // #2 B-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 500, 400, 1000)); // #3 has A-E
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 500, 0, 500)); // #3 has A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 500, 0, 500)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 400, 500, 400, 1000)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 500, 400, 0)); // #4 has A-F
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 400, 500, 0, 500)); // #4 has A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 400, 500, 0, 500)); // #4 A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 400, 500, 400, 0)); // #4 A-F
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 500, 700, 500)); // #5 has A-B
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 700, 500, 1000, 200)); // #5 has B-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 400, 500, 400, 0)); // #5 has A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 400, 500, 700, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 400, 500, 400, 0)); // #5 A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 700, 500, 1000, 200)); // #5 B-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 300), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 300), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 600), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 500, 1000), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 600), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 500, 300), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 200, 0), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 0, 600), "Expected: site #5 has F"); // #5 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 300, 800, 0)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 300, 200, 0)); // #1 has B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 300, 200, 0)); // #1 B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 300, 800, 0)); // #1 B-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 600, 500, 300)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 300, 800, 0)); // #2 has B-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 600, 1000, 600)); // #2 has A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 600, 1000, 600)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 600, 500, 300)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 300, 800, 0)); // #2 B-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 600, 1000, 600)); // #3 has A-E
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 600, 500, 1000)); // #3 has A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 600, 500, 1000)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 600, 1000, 600)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 600, 0, 600)); // #4 has A-F
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 600, 500, 1000)); // #4 has A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 600, 0, 600)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 600, 500, 1000)); // #4 A-G
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 600, 500, 300)); // #5 has A-B
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 300, 200, 0)); // #5 has B-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 600, 0, 600)); // #5 has A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 500, 600, 500, 300)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 600, 0, 600)); // #5 A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 500, 300, 200, 0)); // #5 B-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 600, 1000), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 600, 500), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 300, 500), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 0, 800), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 600, 1000), "Expected: site #5 has F"); // #5 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 500, 0, 200)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 300, 500, 0, 800)); // #1 has B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 300, 500, 0, 800)); // #1 B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 300, 500, 0, 200)); // #1 B-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 500, 300, 500)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 500, 0, 200)); // #2 has B-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 500, 600, 0)); // #2 has A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 500, 300, 500)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 500, 0, 200)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 600, 500, 600, 0)); // #2 A-E
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 500, 600, 0)); // #3 has A-E
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 500, 1000, 500)); // #3 has A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 500, 1000, 500)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 500, 600, 0)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 500, 600, 1000)); // #4 has A-F
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 600, 500, 1000, 500)); // #4 has A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 600, 500, 600, 1000)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 600, 500, 1000, 500)); // #4 A-G
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 500, 300, 500)); // #5 has A-B
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 300, 500, 0, 800)); // #5 has B-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 600, 500, 600, 1000)); // #5 has A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 300, 500, 0, 800)); // #5 B-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 600, 500, 300, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 600, 500, 600, 1000)); // #5 A-F
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 300), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 300), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 500, 0), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 300), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 500, 500), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 1000, 1000), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 1000, 300), "Expected: site #5 has F"); // #5 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 0, 1000)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 1000)); // #1 has B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 1000)); // #1 B-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 300, 500, 500)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 0, 1000)); // #2 has B-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 300, 0, 300)); // #2 has A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 500, 0, 1000)); // #2 B-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 300, 0, 300)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 300, 500, 500)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 300, 0, 300)); // #3 has A-E
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 300, 500, 0)); // #3 has A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 300, 0, 300)); // #3 A-E
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 300, 500, 0)); // #3 A-G
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 300, 1000, 300)); // #4 has A-F
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 300, 500, 0)); // #4 has A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 300, 1000, 300)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 300, 500, 0)); // #4 A-G
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 300, 500, 500)); // #5 has A-B
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 500, 1000, 1000)); // #5 has B-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 300, 1000, 300)); // #5 has A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 500, 500, 1000, 1000)); // #5 B-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 300, 500, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 500, 300, 1000, 300)); // #5 A-F
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 300, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 0, 500), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 300, 500), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 500, 500), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 1000, 0), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 300, 0), "Expected: site #5 has F"); // #5 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 1000)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 500, 1000, 0)); // #1 has B-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 500, 1000, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 500, 1000, 0)); // #1 B-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(3, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 500, 500, 500)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 500, 1000, 1000)); // #2 has B-C
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 300, 500, 300, 1000)); // #2 has A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 300, 500, 300, 1000)); // #2 A-E
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 300, 500, 500, 500)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(2), 500, 500, 1000, 1000)); // #2 B-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 500, 300, 1000)); // #3 has A-E
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 500, 0, 500)); // #3 has A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 500, 0, 500)); // #3 A-G
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 500, 300, 1000)); // #3 A-E
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(2, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 300, 500, 300, 0)); // #4 has A-F
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 300, 500, 0, 500)); // #4 has A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 300, 500, 0, 500)); // #4 A-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 300, 500, 300, 0)); // #4 A-F
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(3, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 300, 500, 500, 500)); // #5 has A-B
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 500, 1000, 0)); // #5 has B-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 300, 500, 300, 0)); // #5 has A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 300, 500, 500, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 300, 500, 300, 0)); // #5 A-F
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 500, 500, 1000, 0)); // #5 B-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has H"); // #1 has H
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has G"); // #2 has G
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has H"); // #2 has H
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 700), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 300), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 500, 700), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 300), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 1000, 700), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 3 == sites[4].Points.Count(), "Expected: site #5 point count 3"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 300), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 0, 300), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 500, 0), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => null != sites[5].Points);
            Assume.That(() => 3 == sites[5].Points.Count(), "Expected: site #6 point count 3"); // #6
            Assume.That(() => HasPoint(sites[5].Points, 500, 300), "Expected: site #6 has A"); // #6 has A
            Assume.That(() => HasPoint(sites[5].Points, 500, 0), "Expected: site #6 has E"); // #6 has E
            Assume.That(() => HasPoint(sites[5].Points, 1000, 300), "Expected: site #6 has F"); // #6 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 700, 0, 700)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 700, 500, 1000)); // #1 has B-H
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 700, 0, 700)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 500, 700, 500, 1000)); // #1 B-H
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 700, 1000, 700)); // #2 has B-G
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 700, 500, 1000)); // #2 has B-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 700, 500, 1000)); // #2 B-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 500, 700, 1000, 700)); // #2 B-G
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 300, 500, 700)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 700, 0, 700)); // #3 has B-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 300, 0, 300)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 700, 0, 700)); // #3 B-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 300, 0, 300)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 500, 300, 500, 700)); // #3 A-B
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 300, 500, 700)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 700, 1000, 700)); // #4 has B-G
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 500, 300, 1000, 300)); // #4 has A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 500, 700, 1000, 700)); // #4 B-G
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 500, 300, 500, 700)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 500, 300, 1000, 300)); // #4 A-F
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(2, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 300, 0, 300)); // #5 has A-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 300, 500, 0)); // #5 has A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 500, 300, 0, 300)); // #5 A-D
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 300, 500, 0)); // #5 A-E
            Assert.NotNull(sites[5].ClockwiseCell);
            Assert.AreEqual(2, sites[5].ClockwiseCell.Count()); // #6
            Assert.IsTrue(HasEdge(sites[5].ClockwiseCell, 500, 300, 1000, 300)); // #6 has A-F
            Assert.IsTrue(HasEdge(sites[5].ClockwiseCell, 500, 300, 500, 0)); // #6 has A-E
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(0), 500, 300, 1000, 300)); // #6 A-F
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(1), 500, 300, 500, 0)); // #6 A-E
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has H"); // #1 has H
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has G"); // #2 has G
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has H"); // #2 has H
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 700, 500), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 700, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 300, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 700, 500), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 700, 0), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 3 == sites[4].Points.Count(), "Expected: site #5 point count 3"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 300, 500), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 300, 1000), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 0, 500), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => null != sites[5].Points);
            Assume.That(() => 3 == sites[5].Points.Count(), "Expected: site #6 point count 3"); // #6
            Assume.That(() => HasPoint(sites[5].Points, 300, 500), "Expected: site #6 has A"); // #6 has A
            Assume.That(() => HasPoint(sites[5].Points, 0, 500), "Expected: site #6 has E"); // #6 has E
            Assume.That(() => HasPoint(sites[5].Points, 300, 0), "Expected: site #6 has F"); // #6 has F

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 500, 700, 1000)); // #1 has B-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 500, 1000, 500)); // #1 has B-H
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 700, 500, 700, 1000)); // #1 B-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 700, 500, 1000, 500)); // #1 B-H
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 500, 700, 0)); // #2 has B-G
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 500, 1000, 500)); // #2 has B-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 500, 1000, 500)); // #2 B-H
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 700, 500, 700, 0)); // #2 B-G
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(3, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 500, 700, 500)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 700, 500, 700, 1000)); // #3 has B-C
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 300, 500, 300, 1000)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 300, 500, 300, 1000)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 300, 500, 700, 500)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(2), 700, 500, 700, 1000)); // #3 B-C
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(3, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 300, 500, 700, 500)); // #4 has A-B
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 700, 500, 700, 0)); // #4 has B-G
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 300, 500, 300, 0)); // #4 has A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 300, 500, 700, 500)); // #4 A-B
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(1), 300, 500, 300, 0)); // #4 A-F
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(2), 700, 500, 700, 0)); // #4 B-G
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(2, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 300, 500, 300, 1000)); // #5 has A-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 300, 500, 0, 500)); // #5 has A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 300, 500, 0, 500)); // #5 A-E
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 300, 500, 300, 1000)); // #5 A-D
            Assert.NotNull(sites[5].ClockwiseCell);
            Assert.AreEqual(2, sites[5].ClockwiseCell.Count()); // #6
            Assert.IsTrue(HasEdge(sites[5].ClockwiseCell, 300, 500, 300, 0)); // #6 has A-F
            Assert.IsTrue(HasEdge(sites[5].ClockwiseCell, 300, 500, 0, 500)); // #6 has A-E
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(0), 300, 500, 0, 500)); // #6 A-E
            Assert.IsTrue(EdgeIs(sites[5].ClockwiseCell.ElementAt(1), 300, 500, 300, 0)); // #6 A-F
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 1000), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 1000), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 0, 500), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 500, 0), "Expected: site #5 has C"); // #5 has C
            Assume.That(() => HasPoint(sites[4].Points, 1000, 500), "Expected: site #5 has D"); // #5 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 1000, 0, 500)); // #1 has A-B
            // Exact starting edge is undefined, so we only check that edges are sequential
            Assert.IsTrue(EdgesAreSequential(sites[0].ClockwiseCell, 500, 1000, 0, 500, 500, 1000, 0, 500)); // #1 A-B > A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 500, 500, 0)); // #2 has B-C
            // Exact starting edge is undefined, so we only check that edges are sequential
            Assert.IsTrue(EdgesAreSequential(sites[1].ClockwiseCell, 0, 500, 500, 0, 0, 500, 500, 0)); // #2 B-C > B-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 0, 1000, 500)); // #3 has C-D
            // Exact starting edge is undefined, so we only check that edges are sequential
            Assert.IsTrue(EdgesAreSequential(sites[2].ClockwiseCell, 500, 0, 1000, 500, 500, 0, 1000, 500)); // #3 C-D > C-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 1000, 500, 500, 1000)); // #4 has D-A
            // Exact starting edge is undefined, so we only check that edges are sequential
            Assert.IsTrue(EdgesAreSequential(sites[3].ClockwiseCell, 1000, 500, 500, 1000, 1000, 500, 500, 1000)); // #4 D-A > D-A
            Assert.NotNull(sites[4].ClockwiseCell);
            Assert.AreEqual(4, sites[4].ClockwiseCell.Count()); // #5
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 1000, 0, 500)); // #5 has A-B
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 0, 500, 500, 0)); // #5 has B-C
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 500, 0, 1000, 500)); // #5 has C-D
            Assert.IsTrue(HasEdge(sites[4].ClockwiseCell, 1000, 500, 500, 1000)); // #5 has D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(0), 1000, 500, 500, 1000)); // #5 D-A
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(1), 500, 1000, 0, 500)); // #5 A-B
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(2), 0, 500, 500, 0)); // #5 B-C
            Assert.IsTrue(EdgeIs(sites[4].ClockwiseCell.ElementAt(3), 500, 0, 1000, 500)); // #5 C-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 500, 1000, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 500, 1000, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 500, 1000, 0)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 500, 1000, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 500, 1000, 1000)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 500, 1000, 0)); // #3 has A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 500, 1000, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 500, 1000, 0)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 1000, 1000, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 1000, 1000, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 1000, 0, 0)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 1000, 0, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 1000, 1000, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 1000, 0, 0)); // #3 has A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 1000, 0, 0)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 1000, 1000, 0)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 500, 0, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 500, 0, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 500, 0, 1000)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 500, 0, 1000)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1000, 500, 0, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1000, 500, 0, 1000)); // #3 has A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 500, 0, 1000)); // #3 A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 500, 0, 0)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 0, 0, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 0, 0, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 0, 1000, 1000)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 0, 1000, 1000)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 0, 0, 1000)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 500, 0, 1000, 1000)); // #3 has A-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 500, 0, 0, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 500, 0, 1000, 1000)); // #3 A-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 800, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 800, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 600, 800, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 600, 800, 1000)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 400, 800, 0)); // #2 has D-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 400, 800, 0)); // #2 D-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 600, 800, 1000)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 400, 800, 0)); // #3 has D-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 600, 800, 1000)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 400, 800, 0)); // #3 D-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 200), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 1000, 1000, 200)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 1000, 1000, 200)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 400, 1000, 0, 200)); // #2 has D-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 400, 1000, 0, 200)); // #2 D-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 1000, 1000, 200)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 1000, 0, 200)); // #3 has D-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 1000, 0, 200)); // #3 D-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 1000, 1000, 200)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 200, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1000, 400, 200, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1000, 400, 200, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1000, 600, 200, 1000)); // #2 has D-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1000, 600, 200, 1000)); // #2 D-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1000, 400, 200, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1000, 600, 200, 1000)); // #3 has D-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1000, 600, 200, 1000)); // #3 D-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 1000, 400, 200, 0)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 800), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 800), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 400, 0, 0, 800)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 400, 0, 0, 800)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 0, 1000, 800)); // #2 has D-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 0, 1000, 800)); // #2 D-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 400, 0, 0, 800)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 0, 1000, 800)); // #3 has D-C
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 400, 0, 0, 800)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 600, 0, 1000, 800)); // #3 D-C
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1200, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1200, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1200, 200), "Expected: site #3 has B"); // #3 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 600, 1200, 1000)); // #1 has A-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 600, 1200, 200)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 600, 1200, 1000)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 0, 600, 1200, 200)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 600, 1200, 1000)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 600, 1200, 1000)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 600, 1200, 200)); // #3 has A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 600, 1200, 200)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 1200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 1200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 1200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has B"); // #3 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 1200, 1000, 0)); // #1 has A-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 1200, 200, 0)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 1200, 200, 0)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 1200, 1000, 0)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 1200, 1000, 0)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 1200, 1000, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 1200, 200, 0)); // #3 has A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 1200, 200, 0)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1200, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1200, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1200, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1200, 600, 0, 200)); // #1 has A-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1200, 600, 0, 1000)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 1200, 600, 0, 1000)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1200, 600, 0, 200)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1200, 600, 0, 200)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1200, 600, 0, 200)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1200, 600, 0, 1000)); // #3 has A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1200, 600, 0, 1000)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 1200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 1200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1200), "Expected: site #3 has B"); // #3 has B

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 0, 200, 1200)); // #1 has A-C
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 600, 0, 1000, 1200)); // #1 has A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 600, 0, 200, 1200)); // #1 A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 600, 0, 1000, 1200)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 600, 0, 200, 1200)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 600, 0, 200, 1200)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 600, 0, 1000, 1200)); // #3 has A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 600, 0, 1000, 1200)); // #3 A-B
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1200, 1100), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1200, 100), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1100), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1200, 100), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 700, 1200, 1100)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1200, 100, 0, 500)); // #1 has C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 700, 1200, 1100)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1200, 100, 0, 500)); // #1 C-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 700, 1200, 1100)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 700, 1200, 1100)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1200, 100, 0, 500)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1200, 100, 0, 500)); // #3 C-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1100, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 100, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 500, 1200), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 1200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1100, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 100, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 500, 1200), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 700, 1200, 1100, 0)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 100, 0, 500, 1200)); // #1 has C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 100, 0, 500, 1200)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 700, 1200, 1100, 0)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 700, 1200, 1100, 0)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 700, 1200, 1100, 0)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 100, 0, 500, 1200)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 100, 0, 500, 1200)); // #3 C-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1200, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 100), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1100), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1200, 700), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1200, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 100), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 1100), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1200, 700), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1200, 500, 0, 100)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 1100, 1200, 700)); // #1 has C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 1100, 1200, 700)); // #1 C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1200, 500, 0, 100)); // #1 A-B
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 1200, 500, 0, 100)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 1200, 500, 0, 100)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 1100, 1200, 700)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 1100, 1200, 700)); // #3 C-D
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

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 100, 1200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1100, 1200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 100, 1200), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1100, 1200), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(2, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 500, 0, 100, 1200)); // #1 has A-B
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 1100, 1200, 700, 0)); // #1 has C-D
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 500, 0, 100, 1200)); // #1 A-B
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(1), 1100, 1200, 700, 0)); // #1 C-D
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(1, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 500, 0, 100, 1200)); // #2 has A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 500, 0, 100, 1200)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(1, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 1100, 1200, 700, 0)); // #3 has C-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 1100, 1200, 700, 0)); // #3 C-D
        }

        [Test]
        public void FourPointsMeetingAtCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 800), // #1
                new VoronoiSite(400, 700), // #2
                new VoronoiSite(700, 400), // #3
                new VoronoiSite(800, 100), // #4
            };

            //  900 ↑              C                            ,B
            //      |             ·                           ,'  
            //  800 |    1       ·                         ,·'    
            //      |            ·                       ,'       
            //  700 |           ·       2             ,·'         
            //      |          ·                    ,'            
            //  600 |         ·                  ,·'              
            //      |        ·                 ,'                 
            //  500 |       ·               ,·'                   
            //      |       ·             ,'                      
            //  400 |      ·           ,·'             3          
            //      |     ·          ,'                           
            //  300 |    ·        ,·'                         ,,,D
            //      |   ·       ,'                    ,,,··'''    
            //  200 |  ·     ,·'               ,,,·'''            
            //      |  ·   ,'          ,,,··'''                   
            //  100 | · ,·'     ,,,·'''                     4     
            //      |·,',,,··'''                                  
            //    0 A#''-----------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 900, 900), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 300, 900), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 0, 900, 300), "Expected: has edge A-D"); // A-D

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 300, 900), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 900, 900), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 300, 900), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 900, 900), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 900, 300), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 900, 300), "Expected: site #4 has D"); // #4 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 0, 300, 900)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 0, 300, 900)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 0, 900, 900)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 0, 300, 900)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 0, 300, 900)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 0, 900, 900)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 0, 900, 900)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 0, 900, 300)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 0, 900, 900)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 0, 900, 300)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 0, 0, 900, 300)); // #4 has A-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 0, 0, 900, 300)); // #4 A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsMeetingAtCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 800), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(400, 200), // #3
                new VoronoiSite(100, 100), // #4
            };

            //  900 A#,,                                          
            //      |·','''··,,,                                  
            //  800 | · '·,     '''·,,,                     1     
            //      |  ·   ',          '''··,,,                   
            //  700 |  ·     '·,               '''·,,,            
            //      |   ·       ',                    '''··,,,    
            //  600 |    ·        '·,                         '''C
            //      |     ·          ',                           
            //  500 |      ·           '·,             2          
            //      |       ·             ',                      
            //  400 |       ·               '·,                   
            //      |        ·                 ',                 
            //  300 |         ·                  '·,              
            //      |          ·                    ',            
            //  200 |           ·       3             '·,         
            //      |            ·                       ',       
            //  100 |    4       ·                         '·,    
            //      |             ·                           ',  
            //    0 └--------------D----------------------------'B
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 900, 900, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 900, 900, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 900, 300, 0), "Expected: has edge A-D"); // A-D

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 900), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 900, 600), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 900), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 900, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 900, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 900), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 900, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 0, 900), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has D"); // #4 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 0, 900, 900, 600)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 0, 900, 900, 600)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 900, 900, 0)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 0, 900, 900, 600)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 0, 900, 900, 600)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 0, 900, 900, 0)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 900, 900, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 0, 900, 300, 0)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 0, 900, 300, 0)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 0, 900, 900, 0)); // #3 A-B
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 0, 900, 300, 0)); // #4 has A-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 0, 900, 300, 0)); // #4 A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsMeetingAtCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(800, 100), // #1
                new VoronoiSite(500, 200), // #2
                new VoronoiSite(200, 500), // #3
                new VoronoiSite(100, 800), // #4
            };

            //  900 ↑                                         ,,#A
            //      |                                 ,,,··''','· 
            //  800 |    4                     ,,,·'''     ,·' ·  
            //      |                  ,,,··'''          ,'   ·   
            //  700 |           ,,,·'''               ,·'     ·   
            //      |   ,,,··'''                    ,'       ·    
            //  600 D'''                         ,·'        ·     
            //      |                          ,'          ·      
            //  500 |         3             ,·'           ·       
            //      |                     ,'             ·        
            //  400 |                  ,·'               ·        
            //      |                ,'                 ·         
            //  300 |             ,·'                  ·          
            //      |           ,'                    ·           
            //  200 |        ,·'             2       ·            
            //      |      ,'                       ·             
            //  100 |   ,·'                         ·       1     
            //      | ,'                           ·              
            //    0 B'----------------------------C--------------→
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 900, 900, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 900, 900, 600, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 900, 900, 0, 600), "Expected: has edge A-D"); // A-D

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 900, 900), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 900, 900), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 900, 900), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 900, 900), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 600), "Expected: site #4 has D"); // #4 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 900, 900, 600, 0)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 900, 900, 600, 0)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 900, 900, 0, 0)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 900, 900, 600, 0)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 900, 900, 0, 0)); // #2 A-B
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 900, 900, 600, 0)); // #2 A-C
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 900, 900, 0, 0)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 900, 900, 0, 600)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 900, 900, 0, 600)); // #3 A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 900, 900, 0, 0)); // #3 A-B
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 900, 900, 0, 600)); // #4 has A-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 900, 900, 0, 600)); // #4 A-D
        }

        /// <summary>
        /// This test basically repeats <see cref="FourPointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void FourPointsMeetingAtCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 100), // #1
                new VoronoiSite(200, 400), // #2
                new VoronoiSite(500, 700), // #3
                new VoronoiSite(800, 800), // #4
            };

            //  900 B,                            D               
            //      | ',                           ·              
            //  800 |   '·,                         ·       4     
            //      |      ',                       ·             
            //  700 |        '·,             3       ·            
            //      |           ',                    ·           
            //  600 |             '·,                  ·          
            //      |                ',                 ·         
            //  500 |                  '·,               ·        
            //      |                     ',             ·        
            //  400 |         2             '·,           ·       
            //      |                          ',          ·      
            //  300 C,,,                         '·,        ·     
            //      |   '''··,,,                    ',       ·    
            //  200 |           '''·,,,               '·,     ·   
            //      |                  '''··,,,          ',   ·   
            //  100 |    1                     '''·,,,     '·, ·  
            //      |                                 '''··,,,',· 
            //    0 └-----------------------------------------''#A
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900, BorderEdgeGeneration.DoNotMakeBorderEdges).ToList();

            // Assume

            Assume.That(() => 3 == edges.Count, "Expected: edge count 3");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 900, 0, 0, 900), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 900, 0, 0, 300), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 900, 0, 600, 900), "Expected: has edge A-D"); // A-D

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 900, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 900, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 900), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 900, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 900), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 600, 900), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 2 == sites[3].Points.Count(), "Expected: site #4 point count 2"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 900, 0), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 600, 900), "Expected: site #4 has D"); // #4 has D

            // Assert

            Assert.NotNull(sites[0].ClockwiseCell);
            Assert.AreEqual(1, sites[0].ClockwiseCell.Count()); // #1
            Assert.IsTrue(HasEdge(sites[0].ClockwiseCell, 900, 0, 0, 300)); // #1 has A-C
            Assert.IsTrue(EdgeIs(sites[0].ClockwiseCell.ElementAt(0), 900, 0, 0, 300)); // #1 A-C
            Assert.NotNull(sites[1].ClockwiseCell);
            Assert.AreEqual(2, sites[1].ClockwiseCell.Count()); // #2
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 900, 0, 0, 900)); // #2 has A-B
            Assert.IsTrue(HasEdge(sites[1].ClockwiseCell, 900, 0, 0, 300)); // #2 has A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(0), 900, 0, 0, 300)); // #2 A-C
            Assert.IsTrue(EdgeIs(sites[1].ClockwiseCell.ElementAt(1), 900, 0, 0, 900)); // #2 A-B
            Assert.NotNull(sites[2].ClockwiseCell);
            Assert.AreEqual(2, sites[2].ClockwiseCell.Count()); // #3
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 900, 0, 0, 900)); // #3 has A-B
            Assert.IsTrue(HasEdge(sites[2].ClockwiseCell, 900, 0, 600, 900)); // #3 has A-D
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(0), 900, 0, 0, 900)); // #3 A-B
            Assert.IsTrue(EdgeIs(sites[2].ClockwiseCell.ElementAt(1), 900, 0, 600, 900)); // #3 A-D
            Assert.NotNull(sites[3].ClockwiseCell);
            Assert.AreEqual(1, sites[3].ClockwiseCell.Count()); // #4
            Assert.IsTrue(HasEdge(sites[3].ClockwiseCell, 900, 0, 600, 900)); // #4 has A-D
            Assert.IsTrue(EdgeIs(sites[3].ClockwiseCell.ElementAt(0), 900, 0, 600, 900)); // #4 A-D
        }

    }
}
