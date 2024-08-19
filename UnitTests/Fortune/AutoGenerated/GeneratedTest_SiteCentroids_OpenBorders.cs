using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

#pragma warning disable
// ReSharper disable All

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiSite"/>`s have expected the expected centroid point.
    /// Specifically, that the <see cref="VoronoiSite.Centroid"/> matches the centroid of its closed polygon <see cref="VoronoiSite.Cell"/>.
    /// These tests are run without generating the border edges, i.e. <see cref="BorderEdgeGeneration.DoNotMakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_SiteCentroids_OpenBorders
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume


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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(200, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(500, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(800, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(500, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(200, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(700, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(800, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(300, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(0, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(500, 1000) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(1000, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(500, 0) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(0, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(700, 1000) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(1000, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(300, 0) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(1000, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(700, 0) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(0, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(300, 1000) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(0, 0) (using generic closed polygon formula)
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(0, 1000) (using generic closed polygon formula)
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(1000, 1000) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 0 == sites[0].Points.Count(), "Expected: site #1 point count 0"); // #1

            // Assert

            // Centroid of #1 in  is at ~(1000, 0) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(500, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(500, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(700, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(300, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(500, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(900, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B is at ~(500, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C-D is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C is at ~(500, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B is at ~(900, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D-B is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-D is at ~(100, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B is at ~(500, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C-D is at ~(500, 600) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C-E-F is at ~(500, 400) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in F-E is at ~(500, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B is at ~(800, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D-B is at ~(600, 500) (using rectangle formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-E-F-D is at ~(400, 500) (using rectangle formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-F is at ~(200, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(300, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(700, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(700, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(300, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(200, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(600, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(800, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(400, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(800, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(400, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(200, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(600, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(200, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(600, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(400, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(800, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(800, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(400, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(600, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(200, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(700, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(900, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(300, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(100, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(300, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(900, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in B-A is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(700, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 2 == sites[1].Points.Count(), "Expected: site #2 point count 2"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B

            // Assert

            // Centroid of #1 in A-B is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(100, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-A is at ~(200, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A-B is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B is at ~(800, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-D is at ~(800, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C-D is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-C is at ~(200, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-A is at ~(200, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A-B is at ~(408, 592) (using quadrilateral formula)
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B is at ~(600, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-D is at ~(800, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C-D is at ~(592, 592) (using quadrilateral formula)
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-C is at ~(400, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-D is at ~(800, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C-D is at ~(592, 408) (using quadrilateral formula)
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-C is at ~(400, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-A is at ~(200, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A-B is at ~(408, 408) (using quadrilateral formula)
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B is at ~(600, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in F-A is at ~(200, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in E-F-A-B is at ~(408, 592) (using quadrilateral formula)
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-E-B-C is at ~(592, 408) (using quadrilateral formula)
            ClassicAssert.AreEqual(591.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(408.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in D-C is at ~(800, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-F is at ~(800, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-E-F is at ~(592, 592) (using quadrilateral formula)
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-C-D-E is at ~(408, 408) (using quadrilateral formula)
            ClassicAssert.AreEqual(408.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(408.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in C-D is at ~(200, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-B-A is at ~(467, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C is at ~(267, 267) (using generic closed polygon formula)
            ClassicAssert.AreEqual(266.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-A-C is at ~(600, 467) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A-D is at ~(600, 533) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(533.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-A is at ~(267, 733) (using generic closed polygon formula)
            ClassicAssert.AreEqual(266.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C-D is at ~(467, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(466.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A-D is at ~(533, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(533.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B is at ~(733, 733) (using generic closed polygon formula)
            ClassicAssert.AreEqual(733.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-D-A is at ~(400, 533) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(533.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-D-B is at ~(400, 467) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B is at ~(733, 267) (using generic closed polygon formula)
            ClassicAssert.AreEqual(733.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-A-C is at ~(533, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(533.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-B-A is at ~(333, 733) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C is at ~(200, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-A-C is at ~(433, 533) (using generic closed polygon formula)
            ClassicAssert.AreEqual(433.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(533.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A-D is at ~(733, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-A is at ~(400, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C-D is at ~(533, 567) (using generic closed polygon formula)
            ClassicAssert.AreEqual(533.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(566.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A-D is at ~(667, 267) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B is at ~(800, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-D-A is at ~(567, 467) (using generic closed polygon formula)
            ClassicAssert.AreEqual(566.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-D-B is at ~(267, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B is at ~(600, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-A-C is at ~(467, 433) (using generic closed polygon formula)
            ClassicAssert.AreEqual(466.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(433.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-A-B is at ~(667, 733) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C is at ~(800, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-C is at ~(567, 533) (using generic closed polygon formula)
            ClassicAssert.AreEqual(566.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(533.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-A-B is at ~(733, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-B is at ~(400, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C-A is at ~(533, 433) (using generic closed polygon formula)
            ClassicAssert.AreEqual(533.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(433.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-D is at ~(333, 267) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-B-A is at ~(200, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A-D is at ~(433, 467) (using generic closed polygon formula)
            ClassicAssert.AreEqual(433.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-D-A is at ~(267, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C is at ~(600, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A-D is at ~(467, 567) (using generic closed polygon formula)
            ClassicAssert.AreEqual(466.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(566.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(500, 167) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C is at ~(667, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(333, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(167, 500) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C is at ~(500, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D is at ~(500, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-A is at ~(500, 833) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D is at ~(333, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D is at ~(667, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-A-B is at ~(833, 500) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A is at ~(500, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(500, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(500, 100) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C is at ~(600, 433) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(433.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(400, 433) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(433.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(100, 500) (using triangle formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C is at ~(433, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(433.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D is at ~(433, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(433.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-A is at ~(500, 900) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D is at ~(400, 567) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(566.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D is at ~(600, 567) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(566.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-A-B is at ~(900, 500) (using triangle formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A is at ~(567, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(566.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(567, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(566.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(500, 367) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(366.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C is at ~(667, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(333, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(367, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(366.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C is at ~(633, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D is at ~(633, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-A is at ~(500, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D is at ~(333, 367) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(366.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D is at ~(667, 367) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(366.67, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-A-B is at ~(633, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A is at ~(367, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(366.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(367, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(366.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-A-B-C is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-E-F-B is at ~(156, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(155.56, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B-F-G is at ~(500, 156) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(155.56, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in H-D-C-G is at ~(844, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(844.44, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in H-E-A-D is at ~(500, 844) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(844.44, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-A-B-C is at ~(500, 300) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-E-F-B is at ~(219, 371) (using generic closed polygon formula)
            ClassicAssert.AreEqual(219.05, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(371.43, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B-F-G is at ~(500, 83) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(83.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in H-D-C-G is at ~(781, 371) (using generic closed polygon formula)
            ClassicAssert.AreEqual(780.95, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(371.43, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in H-E-A-D is at ~(500, 644) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(644.44, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C-D is at ~(300, 500) (using rectangle formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in E-F-B-A is at ~(371, 781) (using generic closed polygon formula)
            ClassicAssert.AreEqual(371.43, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(780.95, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-F-G-C is at ~(83, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(83.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in D-C-G-H is at ~(371, 219) (using generic closed polygon formula)
            ClassicAssert.AreEqual(371.43, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(219.05, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in E-A-D-H is at ~(644, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(644.44, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-D-A is at ~(500, 700) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in F-B-A-E is at ~(781, 629) (using generic closed polygon formula)
            ClassicAssert.AreEqual(780.95, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(628.57, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in F-G-C-B is at ~(500, 917) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(916.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in C-G-H-D is at ~(219, 629) (using generic closed polygon formula)
            ClassicAssert.AreEqual(219.05, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(628.57, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in A-D-H-E is at ~(500, 356) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(355.56, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-D-A-B is at ~(700, 500) (using rectangle formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-E-F is at ~(629, 219) (using generic closed polygon formula)
            ClassicAssert.AreEqual(628.57, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(219.05, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in G-C-B-F is at ~(917, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(916.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in G-H-D-C is at ~(629, 781) (using generic closed polygon formula)
            ClassicAssert.AreEqual(628.57, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(780.95, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in D-H-E-A is at ~(356, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(355.56, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-A is at ~(333, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D is at ~(333, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-A-D is at ~(667, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-A-E is at ~(667, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-A is at ~(333, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D is at ~(333, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-A-D is at ~(667, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-A-E is at ~(667, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-A-B is at ~(667, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A is at ~(333, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-E is at ~(333, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-A-E is at ~(667, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in E-B-A is at ~(500, 833) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in E-A-D is at ~(833, 500) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C-D is at ~(500, 167) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-B-C is at ~(167, 500) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-A is at ~(167, 533) (using generic closed polygon formula)
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(533.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D is at ~(333, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-A-D is at ~(667, 367) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(366.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-B-A is at ~(500, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-A is at ~(533, 833) (using generic closed polygon formula)
            ClassicAssert.AreEqual(533.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A is at ~(200, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-E is at ~(367, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(366.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-A-E is at ~(700, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-A-B is at ~(833, 467) (using generic closed polygon formula)
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C is at ~(667, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-E-A is at ~(333, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-E-B is at ~(500, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(467, 167) (using generic closed polygon formula)
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C is at ~(800, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-A-D is at ~(633, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-B-A is at ~(300, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A-C is at ~(833, 533) (using generic closed polygon formula)
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(533.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-D is at ~(667, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-E-D is at ~(333, 367) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(366.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-E-A is at ~(500, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A-C is at ~(533, 167) (using generic closed polygon formula)
            ClassicAssert.AreEqual(533.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-D-C is at ~(200, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-D-A is at ~(367, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(366.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-A-B is at ~(700, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-C-B is at ~(167, 467) (using generic closed polygon formula)
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-C-A is at ~(333, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-A-E is at ~(667, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-A-B is at ~(500, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-B-A is at ~(467, 833) (using generic closed polygon formula)
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-D is at ~(800, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-A-E is at ~(633, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-B-E is at ~(300, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-C-B is at ~(500, 900) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-E-A is at ~(272, 623) (using generic closed polygon formula)
            ClassicAssert.AreEqual(271.79, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(623.08, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-E-G is at ~(333, 267) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in F-A-G is at ~(667, 267) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in D-B-A-F is at ~(728, 623) (using generic closed polygon formula)
            ClassicAssert.AreEqual(728.21, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(623.08, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-B-D is at ~(900, 500) (using triangle formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-E-A-B is at ~(623, 728) (using generic closed polygon formula)
            ClassicAssert.AreEqual(623.08, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(728.21, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-G-A is at ~(267, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(266.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-G-F is at ~(267, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(266.67, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in B-A-F-D is at ~(623, 272) (using generic closed polygon formula)
            ClassicAssert.AreEqual(623.08, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(271.79, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-D-C is at ~(500, 100) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in E-A-B-C is at ~(728, 377) (using generic closed polygon formula)
            ClassicAssert.AreEqual(728.21, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(376.92, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in G-A-E is at ~(667, 733) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in G-F-A is at ~(333, 733) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in B-A-F-D is at ~(272, 377) (using generic closed polygon formula)
            ClassicAssert.AreEqual(271.79, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(376.92, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-D-C is at ~(100, 500) (using triangle formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C-E is at ~(377, 272) (using generic closed polygon formula)
            ClassicAssert.AreEqual(376.92, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(271.79, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in G-A-E is at ~(733, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in F-A-G is at ~(733, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(733.33, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in F-D-B-A is at ~(377, 728) (using generic closed polygon formula)
            ClassicAssert.AreEqual(376.92, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(728.21, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-C-B is at ~(500, 833) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-E-A is at ~(204, 548) (using quadrilateral formula)
            ClassicAssert.AreEqual(203.70, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(548.15, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-E-G is at ~(333, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in F-A-G is at ~(667, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in D-B-A-F is at ~(796, 548) (using quadrilateral formula)
            ClassicAssert.AreEqual(796.30, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(548.15, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-B-D is at ~(833, 500) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-E-A-B is at ~(548, 796) (using quadrilateral formula)
            ClassicAssert.AreEqual(548.15, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(796.30, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-G-A is at ~(200, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-G-F is at ~(200, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in B-A-F-D is at ~(548, 204) (using quadrilateral formula)
            ClassicAssert.AreEqual(548.15, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(203.70, sites[4].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in H-C-B is at ~(333, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in H-B-G is at ~(667, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-C-D-A is at ~(250, 500) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in G-B-A-F is at ~(750, 500) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in A-D-E is at ~(333, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[4].Centroid.Y, 0.01);
            // Centroid of #6 in F-A-E is at ~(667, 200) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[5].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[5].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-B-H is at ~(800, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in H-B-G is at ~(800, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-D-A-B is at ~(500, 750) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-A-F-G is at ~(500, 250) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in D-E-A is at ~(200, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[4].Centroid.Y, 0.01);
            // Centroid of #6 in A-E-F is at ~(200, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(200.00, sites[5].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[5].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A is at ~(0, 1000) (using generic closed polygon formula)
            ClassicAssert.AreEqual(0.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-B is at ~(0, 0) (using generic closed polygon formula)
            ClassicAssert.AreEqual(0.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(0.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C is at ~(1000, 0) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1000.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(0.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-D is at ~(1000, 1000) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1000.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in D-A-B-C is at ~(500, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.Y, 0.01);
        }

        [Test]
        public void ThreePointsMeetingAtBorderPerpendicularly()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A is at ~(300, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C is at ~(300, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-C is at ~(667, 500) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderPerpendicularly_Rotated90()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B is at ~(900, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C is at ~(100, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C-B is at ~(500, 333) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderPerpendicularly_Rotated180()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B is at ~(700, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A is at ~(700, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C-B is at ~(333, 500) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderPerpendicularly_Rotated270()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A is at ~(100, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A is at ~(900, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B-A is at ~(500, 667) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
        }

        [Test]
        public void ThreePointsMeetingPastBorderPerpendicularly()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A is at ~(100, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-C is at ~(100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D-C is at ~(489, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(488.89, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderPerpendicularly_Rotated90()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B is at ~(900, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-C is at ~(100, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-C-B is at ~(500, 511) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(511.11, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderPerpendicularly_Rotated180()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B is at ~(900, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D is at ~(900, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C-B-A is at ~(511, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(511.11, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastBorderPerpendicularly_Rotated270()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A is at ~(100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D is at ~(900, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B-A-D is at ~(500, 489) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(488.89, sites[2].Centroid.Y, 0.01);
        }

        [Test]
        public void ThreePointsMeetingSharplyAtBorderPerpendicularly()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-A-B is at ~(800, 600) (using triangle formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A is at ~(400, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-B is at ~(400, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyAtBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyAtBorderPerpendicularly_Rotated90()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(600, 400) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C is at ~(900, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-B is at ~(300, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyAtBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyAtBorderPerpendicularly_Rotated180()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-B-C is at ~(400, 600) (using triangle formula)
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C is at ~(800, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A is at ~(800, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyAtBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyAtBorderPerpendicularly_Rotated270()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-C-A is at ~(600, 800) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A is at ~(300, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A is at ~(900, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
        }

        [Test]
        public void ThreePointsMeetingSharplyPastBorderPerpendicularly()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in B-A-D-C is at ~(733, 600) (using quadrilateral formula)
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(100, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C is at ~(100, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyPastBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyPastBorderPerpendicularly_Rotated90()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-D-C-B is at ~(600, 467) (using quadrilateral formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(900, 1100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1100.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C is at ~(300, 1100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1100.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyPastBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyPastBorderPerpendicularly_Rotated180()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in D-C-B-A is at ~(467, 600) (using quadrilateral formula)
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B is at ~(1100, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1100.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-D is at ~(1100, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyPastBorderPerpendicularly"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyPastBorderPerpendicularly_Rotated270()
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-B-A-D is at ~(600, 733) (using quadrilateral formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A is at ~(300, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-D is at ~(900, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
        }

        [Test]
        public void ThreePointsMeetingSharplyTowardsCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 900), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(900, 300), // #3
            };

            // 1000 ↑                             B                    
            //      |                            '                     
            //  900 |              1           ,'                      
            //      |                         ,                        
            //  800 |                        ·                         
            //      |                       '                          
            //  700 |                     ,'           2               
            //      |                    ,                             
            //  600 |                   ·                           ,,C
            //      |                  '                       ,,·''   
            //  500 |                ,'                   ,,·''        
            //      |               ,                ,,·''             
            //  400 |              ·            ,,·''                  
            //      |             '        ,,·''                       
            //  300 |           ,'    ,,·''                      3     
            //      |          , ,,·''                                 
            //  200 |        ,A''                                      
            //      |      ,'                                          
            //  100 |   ,·'                                            
            //      | ,'                                               
            //    0 D'------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            // Centroid of #1 in B-D-A is at ~(267, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C is at ~(600, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A-D is at ~(400, 267) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyTowardsCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyTowardsCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 700), // #1
                new VoronoiSite(700, 300), // #2
                new VoronoiSite(300, 100), // #3
            };

            // 1000 D,                                                 
            //      | ',                                               
            //  900 |   '·,                                            
            //      |      ',                                          
            //  800 |        'A,,                                      
            //      |          ' ''·,,                                 
            //  700 |           ',    ''·,,                      1     
            //      |             ,        ''·,,                       
            //  600 |              ·            ''·,,                  
            //      |               '                ''·,,             
            //  500 |                ',                   ''·,,        
            //      |                  ,                       ''·,,   
            //  400 |                   ·                           ''B
            //      |                    '                             
            //  300 |                     ',           2               
            //      |                       ,                          
            //  200 |                        ·                         
            //      |                         '                        
            //  100 |              3           ',                      
            //      |                            ,                     
            //    0 └-----------------------------C-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 800), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            // Centroid of #1 in D-A-B is at ~(400, 733) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C is at ~(600, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-C is at ~(267, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(266.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyTowardsCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyTowardsCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 100), // #1
                new VoronoiSite(300, 300), // #2
                new VoronoiSite(100, 700), // #3
            };

            // 1000 ↑                                                ,D
            //      |                                              ,'  
            //  900 |                                           ,·'    
            //      |                                         ,'       
            //  800 |                                     ,,A'         
            //      |                                ,,·'' '           
            //  700 |    3                      ,,·''    ,'            
            //      |                      ,,·''        ,              
            //  600 |                 ,,·''            ·               
            //      |            ,,·''                '                
            //  500 |       ,,·''                   ,'                 
            //      |  ,,·''                       ,                   
            //  400 C''                           ·                    
            //      |                            '                     
            //  300 |              2           ,'                      
            //      |                         ,                        
            //  200 |                        ·                         
            //      |                       '                          
            //  100 |                     ,'           1               
            //      |                    ,                             
            //    0 └-------------------B-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 800), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has D"); // #3 has D

            // Assert

            // Centroid of #1 in D-A-B is at ~(733, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-B is at ~(400, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-C is at ~(600, 733) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingSharplyTowardsCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingSharplyTowardsCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 300), // #1
                new VoronoiSite(300, 700), // #2
                new VoronoiSite(700, 900), // #3
            };

            // 1000 ↑                   C                              
            //      |                    '                             
            //  900 |                     ',           3               
            //      |                       ,                          
            //  800 |                        ·                         
            //      |                         '                        
            //  700 |              2           ',                      
            //      |                            ,                     
            //  600 B,,                           ·                    
            //      |  ''·,,                       '                   
            //  500 |       ''·,,                   ',                 
            //      |            ''·,,                ,                
            //  400 |                 ''·,,            ·               
            //      |                      ''·,,        '              
            //  300 |    1                      ''·,,    ',            
            //      |                                ''·,, ,           
            //  200 |                                     ''A,         
            //      |                                         ',       
            //  100 |                                           '·,    
            //      |                                              ',  
            //    0 └------------------------------------------------'D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            // Centroid of #1 in B-D-A is at ~(600, 267) (using generic closed polygon formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-B-A is at ~(400, 600) (using generic closed polygon formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A-D is at ~(733, 400) (using generic closed polygon formula)
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
        }

        [Test]
        public void ThreePointsMeetingAtCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 700), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(700, 100), // #3
            };

            // 1000 ↑                        B                         
            //      |                       '                          
            //  900 |                     ,'                           
            //      |                    ,                             
            //  800 |                   ·                              
            //      |                  '                               
            //  700 |    1           ,'                                
            //      |               ,                                  
            //  600 |              ·                                   
            //      |             '                                    
            //  500 |           ,'           2                      ,,C
            //      |          ,                               ,,·''   
            //  400 |         ·                           ,,·''        
            //      |        '                       ,,·''             
            //  300 |      ,'                   ,,·''                  
            //      |     ,                ,,·''                       
            //  200 |    ·            ,,·''                            
            //      |   '        ,,·''                                 
            //  100 | ,'    ,,·''                      3               
            //      |, ,,·''                                           
            //    0 A''-----------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in B-A is at ~(100, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-B-A is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A is at ~(700, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 900), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(100, 300), // #3
            };

            // 1000 A,,                                                
            //      |' ''·,,                                           
            //  900 | ',    ''·,,                      1               
            //      |   ,        ''·,,                                 
            //  800 |    ·            ''·,,                            
            //      |     '                ''·,,                       
            //  700 |      ',                   ''·,,                  
            //      |        ,                       ''·,,             
            //  600 |         ·                           ''·,,        
            //      |          '                               ''·,,   
            //  500 |           ',           2                      ''B
            //      |             ,                                    
            //  400 |              ·                                   
            //      |               '                                  
            //  300 |    3           ',                                
            //      |                  ,                               
            //  200 |                   ·                              
            //      |                    '                             
            //  100 |                     ',                           
            //      |                       ,                          
            //    0 └------------------------C------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in A-B is at ~(700, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C is at ~(100, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(900, 300), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(300, 900), // #3
            };

            // 1000 ↑                                               ,,A
            //      |                                          ,,·'' ' 
            //  900 |              3                      ,,·''    ,'  
            //      |                                ,,·''        ,    
            //  800 |                           ,,·''            ·     
            //      |                      ,,·''                '      
            //  700 |                 ,,·''                   ,'       
            //      |            ,,·''                       ,         
            //  600 |       ,,·''                           ·          
            //      |  ,,·''                               '           
            //  500 C''                      2           ,'            
            //      |                                   ,              
            //  400 |                                  ·               
            //      |                                 '                
            //  300 |                               ,'           1     
            //      |                              ,                   
            //  200 |                             ·                    
            //      |                            '                     
            //  100 |                          ,'                      
            //      |                         ,                        
            //    0 └------------------------B------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in A-B is at ~(900, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-B is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C is at ~(300, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 100), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(900, 700), // #3
            };

            // 1000 ↑                        C                         
            //      |                         '                        
            //  900 |                          ',                      
            //      |                            ,                     
            //  800 |                             ·                    
            //      |                              '                   
            //  700 |                               ',           3     
            //      |                                 ,                
            //  600 |                                  ·               
            //      |                                   '              
            //  500 B,,                      2           ',            
            //      |  ''·,,                               ,           
            //  400 |       ''·,,                           ·          
            //      |            ''·,,                       '         
            //  300 |                 ''·,,                   ',       
            //      |                      ''·,,                ,      
            //  200 |                           ''·,,            ·     
            //      |                                ''·,,        '    
            //  100 |              1                      ''·,,    ',  
            //      |                                          ''·,, , 
            //    0 └-----------------------------------------------''A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in B-A is at ~(300, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-B-A is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A is at ~(900, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[2].Centroid.Y, 0.01);
        }

        [Test]
        public void ThreePointsMeetingAtBorderAngled()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(900, 100), // #3
            };

            // 1000 ↑                                  B               
            //      |                                 '                
            //  900 |                               ,'                 
            //      |                              ,                   
            //  800 |                             ·                    
            //      |                            '                     
            //  700 |              1           ,'                      
            //      |                         ,                        
            //  600 |                        ·                         
            //      |                       '                          
            //  500 |                     ,'           2               
            //      |                    ,                             
            //  400 |                   ·                           ,,C
            //      |                  '                       ,,·''   
            //  300 |                ,'                   ,,·''        
            //      |               ,                ,,·''             
            //  200 |              ·            ,,·''                  
            //      |             '        ,,·''                       
            //  100 |           ,'    ,,·''                      3     
            //      |          , ,,·''                                 
            //    0 └---------A''-------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 400), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in B-A is at ~(300, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C is at ~(633, 467) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A is at ~(900, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderAngled"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderAngled_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 700), // #1
                new VoronoiSite(500, 300), // #2
                new VoronoiSite(100, 100), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 A,,                                                
            //      |' ''·,,                                           
            //  700 | ',    ''·,,                      1               
            //      |   ,        ''·,,                                 
            //  600 |    ·            ''·,,                            
            //      |     '                ''·,,                       
            //  500 |      ',                   ''·,,                  
            //      |        ,                       ''·,,             
            //  400 |         ·                           ''·,,        
            //      |          '                               ''·,,   
            //  300 |           ',           2                      ''B
            //      |             ,                                    
            //  200 |              ·                                   
            //      |               '                                  
            //  100 |    3           ',                                
            //      |                  ,                               
            //    0 └-------------------C-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 300), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 300), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 800), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in A-B is at ~(700, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C is at ~(467, 367) (using generic closed polygon formula)
            ClassicAssert.AreEqual(466.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(366.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C is at ~(100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderAngled"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderAngled_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 300), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(100, 900), // #3
            };

            // 1000 ↑                                     ,,A          
            //      |                                ,,·'' '           
            //  900 |    3                      ,,·''    ,'            
            //      |                      ,,·''        ,              
            //  800 |                 ,,·''            ·               
            //      |            ,,·''                '                
            //  700 |       ,,·''                   ,'                 
            //      |  ,,·''                       ,                   
            //  600 C''                           ·                    
            //      |                            '                     
            //  500 |              2           ,'                      
            //      |                         ,                        
            //  400 |                        ·                         
            //      |                       '                          
            //  300 |                     ,'           1               
            //      |                    ,                             
            //  200 |                   ·                              
            //      |                  '                               
            //  100 |                ,'                                
            //      |               ,                                  
            //    0 └--------------B----------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 300, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in A-B is at ~(700, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-B is at ~(367, 533) (using generic closed polygon formula)
            ClassicAssert.AreEqual(366.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(533.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C is at ~(100, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderAngled"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderAngled_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 300), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(900, 900), // #3
            };

            // 1000 ↑                             C                    
            //      |                              '                   
            //  900 |                               ',           3     
            //      |                                 ,                
            //  800 |                                  ·               
            //      |                                   '              
            //  700 B,,                      2           ',            
            //      |  ''·,,                               ,           
            //  600 |       ''·,,                           ·          
            //      |            ''·,,                       '         
            //  500 |                 ''·,,                   ',       
            //      |                      ''·,,                ,      
            //  400 |                           ''·,,            ·     
            //      |                                ''·,,        '    
            //  300 |              1                      ''·,,    ',  
            //      |                                          ''·,, , 
            //  200 |                                               ''A
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in B-A is at ~(300, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-B-A is at ~(533, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(533.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A is at ~(900, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderAngled"/> above,
        /// but all coordinates are mirrored horizontally.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderAngled_Mirrored()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 700), // #1
                new VoronoiSite(300, 500), // #2
                new VoronoiSite(100, 100), // #3
            };

            // 1000 ↑              B                                   
            //      |               '                                  
            //  900 |                ',                                
            //      |                  ,                               
            //  800 |                   ·                              
            //      |                    '                             
            //  700 |                     ',           1               
            //      |                       ,                          
            //  600 |                        ·                         
            //      |                         '                        
            //  500 |              2           ',                      
            //      |                            ,                     
            //  400 C,,                           ·                    
            //      |  ''·,,                       '                   
            //  300 |       ''·,,                   ',                 
            //      |            ''·,,                ,                
            //  200 |                 ''·,,            ·               
            //      |                      ''·,,        '              
            //  100 |    3                      ''·,,    ',            
            //      |                                ''·,, ,           
            //    0 └-------------------------------------''A---------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 300, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in B-A is at ~(700, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-A is at ~(367, 467) (using generic closed polygon formula)
            ClassicAssert.AreEqual(366.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A is at ~(100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderAngled"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderAngled_MirroredAndRotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(700, 300), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(100, 900), // #3
            };

            // 1000 ↑                   C                              
            //      |                  '                               
            //  900 |    3           ,'                                
            //      |               ,                                  
            //  800 |              ·                                   
            //      |             '                                    
            //  700 |           ,'           2                      ,,B
            //      |          ,                               ,,·''   
            //  600 |         ·                           ,,·''        
            //      |        '                       ,,·''             
            //  500 |      ,'                   ,,·''                  
            //      |     ,                ,,·''                       
            //  400 |    ·            ,,·''                            
            //      |   '        ,,·''                                 
            //  300 | ,'    ,,·''                      1               
            //      |, ,,·''                                           
            //  200 A''                                                
            //      |                                                  
            //  100 |                                                  
            //      |                                                  
            //    0 └-------------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in B-A is at ~(700, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-A is at ~(467, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(466.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A is at ~(100, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderAngled"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderAngled_MirroredAndRotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 300), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(900, 900), // #3
            };

            // 1000 ↑         A,,                                      
            //      |          ' ''·,,                                 
            //  900 |           ',    ''·,,                      3     
            //      |             ,        ''·,,                       
            //  800 |              ·            ''·,,                  
            //      |               '                ''·,,             
            //  700 |                ',                   ''·,,        
            //      |                  ,                       ''·,,   
            //  600 |                   ·                           ''C
            //      |                    '                             
            //  500 |                     ',           2               
            //      |                       ,                          
            //  400 |                        ·                         
            //      |                         '                        
            //  300 |              1           ',                      
            //      |                            ,                     
            //  200 |                             ·                    
            //      |                              '                   
            //  100 |                               ',                 
            //      |                                 ,                
            //    0 └----------------------------------B--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in A-B is at ~(300, 300) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B is at ~(633, 533) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(533.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C is at ~(900, 900) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingAtBorderAngled"/> above,
        /// but all coordinates are mirrored horizontally and then rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingAtBorderAngled_MirroredAndRotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(500, 300), // #2
                new VoronoiSite(900, 100), // #3
            };

            // 1000 ↑                                                  
            //      |                                                  
            //  900 |                                                  
            //      |                                                  
            //  800 |                                               ,,A
            //      |                                          ,,·'' ' 
            //  700 |              1                      ,,·''    ,'  
            //      |                                ,,·''        ,    
            //  600 |                           ,,·''            ·     
            //      |                      ,,·''                '      
            //  500 |                 ,,·''                   ,'       
            //      |            ,,·''                       ,         
            //  400 |       ,,·''                           ·          
            //      |  ,,·''                               '           
            //  300 B''                      2           ,'            
            //      |                                   ,              
            //  200 |                                  ·               
            //      |                                 '                
            //  100 |                               ,'           3     
            //      |                              ,                   
            //    0 └-----------------------------C-------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 800), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in A-B is at ~(300, 700) (using generic closed polygon formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C is at ~(533, 367) (using generic closed polygon formula)
            ClassicAssert.AreEqual(533.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(366.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C is at ~(900, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
        }

        [Test]
        public void ThreePointsMeetingPastCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 1100), // #1
                new VoronoiSite(700, 700), // #2
                new VoronoiSite(1100, 100), // #3
            };

            // 1200 ↑                             C                              
            //      |                           ,'                               
            // 1100 |    1                    ,'                                 
            //      |                        ·                                   
            // 1000 |                      ,'                                    
            //      |                    ,'                                      
            //  900 |                   ·                                        
            //      |                 ,'                                         
            //  800 |               ,'                                           
            //      |              ·                                             
            //  700 |            ,'                    2                         
            //      |          ,'                                                
            //  600 |         ·                                                ,D
            //      |       ,'                                             ,·''  
            //  500 |     ,'                                           ,,''      
            //      |    ·                                         ,,·'          
            //  400 |  ,'                                       ,·'              
            //      |,'                                     ,·''                 
            //  300 A                                   ,,''                     
            //      |                               ,,·'                         
            //  200 |                            ,·'                             
            //      |                        ,·''                                
            //  100 |                    ,,''                              3     
            //      |                ,,·'                                        
            //    0 └--------------B'-------------------------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 1200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1200, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1200, 600), "Expected: site #3 has D"); // #3 has D

            // Assert

            // Centroid of #1 in C-A is at ~(100, 1100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B-D is at ~(567, 567) (using generic closed polygon formula)
            ClassicAssert.AreEqual(566.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(566.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-B is at ~(1100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastCorner"/> above,
        /// but all coordinates are rotated 90° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastCorner_Rotated90()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1100, 1100), // #1
                new VoronoiSite(700, 500), // #2
                new VoronoiSite(100, 100), // #3
            };

            // 1200 ↑              A,                                            
            //      |                ''·,                                        
            // 1100 |                    '',,                              1     
            //      |                        '·,,                                
            // 1000 |                            '·,                             
            //      |                               ''·,                         
            //  900 B                                   '',,                     
            //      |',                                     '·,,                 
            //  800 |  ',                                       '·,              
            //      |    ·                                         ''·,          
            //  700 |     ',                                           '',,      
            //      |       ',                                             '·,,  
            //  600 |         ·                                                'C
            //      |          ',                                                
            //  500 |            ',                    2                         
            //      |              ·                                             
            //  400 |               ',                                           
            //      |                 ',                                         
            //  300 |                   ·                                        
            //      |                    ',                                      
            //  200 |                      ',                                    
            //      |                        ·                                   
            //  100 |    3                    ',                                 
            //      |                           ',                               
            //    0 └-----------------------------D-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 1200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1200, 600), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 1200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 900), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1200, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 900), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has D"); // #3 has D

            // Assert

            // Centroid of #1 in A-C is at ~(1100, 1100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B-D is at ~(567, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(566.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-D is at ~(100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastCorner"/> above,
        /// but all coordinates are rotated 180° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastCorner_Rotated180()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(1100, 100), // #1
                new VoronoiSite(500, 500), // #2
                new VoronoiSite(100, 1100), // #3
            };

            // 1200 ↑                                           ,B               
            //      |                                       ,·''                 
            // 1100 |    3                              ,,''                     
            //      |                               ,,·'                         
            // 1000 |                            ,·'                             
            //      |                        ,·''                                
            //  900 |                    ,,''                                   A
            //      |                ,,·'                                     ,' 
            //  800 |             ,·'                                       ,'   
            //      |         ,·''                                         ·     
            //  700 |     ,,''                                           ,'      
            //      | ,,·'                                             ,'        
            //  600 D'                                                ·          
            //      |                                               ,'           
            //  500 |                        2                    ,'             
            //      |                                            ·               
            //  400 |                                          ,'                
            //      |                                        ,'                  
            //  300 |                                       ·                    
            //      |                                     ,'                     
            //  200 |                                   ,'                       
            //      |                                  ·                         
            //  100 |                                ,'                    1     
            //      |                              ,'                            
            //    0 └-----------------------------C-----------------------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1200, 900), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1200, 900), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 900, 1200), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 900, 1200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has D"); // #3 has D

            // Assert

            // Centroid of #1 in A-C is at ~(1100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-D-C is at ~(633, 633) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-D is at ~(100, 1100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1100.00, sites[2].Centroid.Y, 0.01);
        }

        /// <summary>
        /// This test basically repeats <see cref="ThreePointsMeetingPastCorner"/> above,
        /// but all coordinates are rotated 270° around the center of the boundary.
        /// </summary>
        [Test]
        public void ThreePointsMeetingPastCorner_Rotated270()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 100), // #1
                new VoronoiSite(500, 700), // #2
                new VoronoiSite(1100, 1100), // #3
            };

            // 1200 ↑                             D                              
            //      |                              ',                            
            // 1100 |                                ',                    3     
            //      |                                  ·                         
            // 1000 |                                   ',                       
            //      |                                     ',                     
            //  900 |                                       ·                    
            //      |                                        ',                  
            //  800 |                                          ',                
            //      |                                            ·               
            //  700 |                        2                    ',             
            //      |                                               ',           
            //  600 C,                                                ·          
            //      | ''·,                                             ',        
            //  500 |     '',,                                           ',      
            //      |         '·,,                                         ·     
            //  400 |             '·,                                       ',   
            //      |                ''·,                                     ', 
            //  300 |                    '',,                                   B
            //      |                        '·,,                                
            //  200 |                            '·,                             
            //      |                               ''·,                         
            //  100 |    1                              '',,                     
            //      |                                       '·,,                 
            //    0 └-------------------------------------------'A--------------→
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 2 == sites[0].Points.Count(), "Expected: site #1 point count 2"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 900, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 900, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1200, 300), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 1200), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 2 == sites[2].Points.Count(), "Expected: site #3 point count 2"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1200, 300), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 600, 1200), "Expected: site #3 has D"); // #3 has D

            // Assert

            // Centroid of #1 in C-A is at ~(100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-C-A-B is at ~(633, 567) (using generic closed polygon formula)
            ClassicAssert.AreEqual(633.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(566.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-B is at ~(1100, 1100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(1100.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1100.00, sites[2].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-A is at ~(100, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-A is at ~(400, 600) (using triangle formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D is at ~(600, 400) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in D-A is at ~(800, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-C is at ~(800, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B is at ~(600, 500) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(400, 300) (using triangle formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-D is at ~(100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in A-C is at ~(800, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C is at ~(500, 300) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(300, 500) (using triangle formula)
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-D is at ~(100, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[3].Centroid.Y, 0.01);
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900, BorderEdgeGeneration.DoNotMakeBorderEdges);

            // Assume

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

            // Centroid of #1 in C-A is at ~(100, 100) (using generic closed polygon formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-A is at ~(300, 400) (using triangle formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-B-A is at ~(500, 600) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in D-A is at ~(800, 800) (using generic closed polygon formula)
            ClassicAssert.AreEqual(800.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[3].Centroid.Y, 0.01);
        }

    }
}
