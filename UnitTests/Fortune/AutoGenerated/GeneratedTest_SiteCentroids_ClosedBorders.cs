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
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_SiteCentroids_ClosedBorders
    {
        [Test]
        public void NoPoints()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        1                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Z-X-Y-W is at ~(500, 500) (using rectangle formula)
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |         1                                       |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Z-X-Y-W is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
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

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                        1                        |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in X-Y-W-Z is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                       1         |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                        1                        |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in W-Z-X-Y is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
        }

        [Test]
        public void OnePointArbitrary()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(200, 700), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |         1                                       |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Z-X-Y-W is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                  1              |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in X-Y-W-Z is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                       1         |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |              1                                  |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in W-Z-X-Y is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
        }

        [Test]
        public void OnePointOnBorderCentered()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 500), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 1                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
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

            // 1000 Y------------------------1------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 1
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X------------------------1------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
        }

        [Test]
        public void OnePointOnBorderOffset()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 700), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 1                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 Y----------------------------------1--------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 1
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X--------------1----------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 Z-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 1
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in X-Z-W-Y is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y----------------------------------1--------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in X-Z-W-Y is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 Y-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 1                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in X-Z-W-Y is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 X--------------1----------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in X-Z-W-Y is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
        }

        [Test]
        public void OnePointInCorner()
        {
            // Arrange

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                new VoronoiSite(0, 0), // #1
            };

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 1-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 1-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------1
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                                                 |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------1
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Z"); // #1 has Z

            // Assert

            // Centroid of #1 in Y-W-Z-X is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                        1                        |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 A-------------------------------------------------B
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                        2                        |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in Z-X-A-B is at ~(500, 750) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-Y-W is at ~(500, 250) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[1].Centroid.Y, 0.01);
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

            // 1000 Y------------------------A------------------------X
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              2         |         1              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 W------------------------B------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in X-A-B-Z is at ~(750, 500) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-W-B is at ~(250, 500) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[1].Centroid.X, 0.01);
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                        1                        |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        2                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in Z-X-A-B is at ~(500, 850) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-Y-W is at ~(500, 350) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(350.00, sites[1].Centroid.Y, 0.01);
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

            // 1000 Y----------------------------------A--------------X
            //      |                                  |              |
            //  900 |                                  |              |
            //      |                                  |              |
            //  800 |                                  |              |
            //      |                                  |              |
            //  700 |                                  |              |
            //      |                                  |              |
            //  600 |                                  |              |
            //      |                                  |              |
            //  500 |                        2         |         1    |
            //      |                                  |              |
            //  400 |                                  |              |
            //      |                                  |              |
            //  300 |                                  |              |
            //      |                                  |              |
            //  200 |                                  |              |
            //      |                                  |              |
            //  100 |                                  |              |
            //      |                                  |              |
            //    0 W----------------------------------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in X-A-B-Z is at ~(850, 500) (using rectangle formula)
            ClassicAssert.AreEqual(850.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-W-B is at ~(350, 500) (using rectangle formula)
            ClassicAssert.AreEqual(350.00, sites[1].Centroid.X, 0.01);
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                        1                        |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        2                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 C-------------------------------------------------D
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                        3                        |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 300), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in Z-X-A-B is at ~(500, 850) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C-D is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C-Y-W is at ~(500, 150) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y--------------C-------------------A--------------X
            //      |              |                   |              |
            //  900 |              |                   |              |
            //      |              |                   |              |
            //  800 |              |                   |              |
            //      |              |                   |              |
            //  700 |              |                   |              |
            //      |              |                   |              |
            //  600 |              |                   |              |
            //      |              |                   |              |
            //  500 |    3         |         2         |         1    |
            //      |              |                   |              |
            //  400 |              |                   |              |
            //      |              |                   |              |
            //  300 |              |                   |              |
            //      |              |                   |              |
            //  200 |              |                   |              |
            //      |              |                   |              |
            //  100 |              |                   |              |
            //      |              |                   |              |
            //    0 W--------------D-------------------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in X-A-B-Z is at ~(850, 500) (using rectangle formula)
            ClassicAssert.AreEqual(850.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D-B is at ~(500, 500) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-Y-W-D is at ~(150, 500) (using rectangle formula)
            ClassicAssert.AreEqual(150.00, sites[2].Centroid.X, 0.01);
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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                        1                        |
            //      |                                                 |
            //  700 A-------------------------------------------------B
            //      |                                                 |
            //  600 |                        2                        |
            //      |                                                 |
            //  500 C-------------------------------------------------D
            //      |                                                 |
            //  400 |                        3                        |
            //      |                                                 |
            //  300 E-------------------------------------------------F
            //      |                                                 |
            //  200 |                        4                        |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Z"); // #1 has Z
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
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 0, 300), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 300), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has W"); // #4 has W
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has Y"); // #4 has Y

            // Assert

            // Centroid of #1 in Z-X-A-B is at ~(500, 850) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C-D is at ~(500, 600) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C-E-F is at ~(500, 400) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in F-E-Y-W is at ~(500, 150) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 Y--------------E---------C---------A--------------X
            //      |              |         |         |              |
            //  900 |              |         |         |              |
            //      |              |         |         |              |
            //  800 |              |         |         |              |
            //      |              |         |         |              |
            //  700 |              |         |         |              |
            //      |              |         |         |              |
            //  600 |              |         |         |              |
            //      |              |         |         |              |
            //  500 |         4    |    3    |    2    |    1         |
            //      |              |         |         |              |
            //  400 |              |         |         |              |
            //      |              |         |         |              |
            //  300 |              |         |         |              |
            //      |              |         |         |              |
            //  200 |              |         |         |              |
            //      |              |         |         |              |
            //  100 |              |         |         |              |
            //      |              |         |         |              |
            //    0 W--------------F---------D---------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Z"); // #1 has Z
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
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 300, 1000), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has W"); // #4 has W
            Assume.That(() => HasPoint(sites[3].Points, 0, 1000), "Expected: site #4 has Y"); // #4 has Y

            // Assert

            // Centroid of #1 in X-A-B-Z is at ~(850, 500) (using rectangle formula)
            ClassicAssert.AreEqual(850.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-D-B is at ~(600, 500) (using rectangle formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-E-F-D is at ~(400, 500) (using rectangle formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-Y-W-F is at ~(150, 500) (using rectangle formula)
            ClassicAssert.AreEqual(150.00, sites[3].Centroid.X, 0.01);
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

            // 1000 X------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |              1                  ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                  2              |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 A#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in B-X-A is at ~(333, 667) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-Y is at ~(667, 333) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 A#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                  1              |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |              2                  '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in X-A-B is at ~(667, 667) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-B is at ~(333, 333) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 X--------------------------------------#B---------Z
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 |         1                  ,·'                  |
            //      |                          ,'                     |
            //  700 |                       ,·'                       |
            //      |                     ,'                          |
            //  600 |                  ,·'                            |
            //      |                ,'                               |
            //  500 |             ,·'                                 |
            //      |           ,'                                    |
            //  400 |        ,·'                  2                   |
            //      |      ,'                                         |
            //  300 |   ,·'                                           |
            //      | ,'                                              |
            //  200 A'                                                |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in B-X-A is at ~(267, 733) (using triangle formula)
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-B-A-Y-W is at ~(610, 390) (using generic closed polygon formula)
            ClassicAssert.AreEqual(609.80, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(390.20, sites[1].Centroid.Y, 0.01);
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

            // 1000 Y---------A#--------------------------------------X
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                  1         |
            //      |                     ',                          |
            //  700 |                       '·,                       |
            //      |                          ',                     |
            //  600 |                            '·,                  |
            //      |                               ',                |
            //  500 |                                 '·,             |
            //      |                                    ',           |
            //  400 |                   2                  '·,        |
            //      |                                         ',      |
            //  300 |                                           '·,   |
            //      |                                              ', |
            //  200 |                                                'B
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in X-A-B is at ~(733, 733) (using triangle formula)
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-W-Z-B is at ~(390, 390) (using generic closed polygon formula)
            ClassicAssert.AreEqual(390.20, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(390.20, sites[1].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                ,A
            //      |                                              ,' |
            //  700 |                                           ,·'   |
            //      |                                         ,'      |
            //  600 |                   2                  ,·'        |
            //      |                                    ,'           |
            //  500 |                                 ,·'             |
            //      |                               ,'                |
            //  400 |                            ,·'                  |
            //      |                          ,'                     |
            //  300 |                       ,·'                       |
            //      |                     ,'                          |
            //  200 |                  ,·'                  1         |
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 Z---------B#--------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in A-B-X is at ~(733, 267) (using triangle formula)
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-W-Z-B is at ~(390, 610) (using generic closed polygon formula)
            ClassicAssert.AreEqual(390.20, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(609.80, sites[1].Centroid.Y, 0.01);
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 B,                                                |
            //      | ',                                              |
            //  700 |   '·,                                           |
            //      |      ',                                         |
            //  600 |        '·,                  2                   |
            //      |           ',                                    |
            //  500 |             '·,                                 |
            //      |                ',                               |
            //  400 |                  '·,                            |
            //      |                     ',                          |
            //  300 |                       '·,                       |
            //      |                          ',                     |
            //  200 |         1                  '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 X--------------------------------------#A---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in B-X-A is at ~(267, 267) (using triangle formula)
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in W-Z-B-A-Y is at ~(610, 610) (using generic closed polygon formula)
            ClassicAssert.AreEqual(609.80, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(609.80, sites[1].Centroid.Y, 0.01);
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

            // 1000 A#------------------------------------------------Y
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                  2                   |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |         1                  '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 X------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in A-X-B is at ~(333, 333) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-A-B is at ~(667, 667) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
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

            // 1000 X------------------------------------------------#A
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                   1                  ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                  2         |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 B#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in A-X-B is at ~(333, 667) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-Y is at ~(667, 333) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 B#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                  1         |
            //      |                     ',                          |
            //  500 |                       '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                   2                  '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in X-B-A is at ~(667, 667) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Y-A is at ~(333, 333) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 Y------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |         2                  ,·'                  |
            //      |                          ,'                     |
            //  500 |                       ,·'                       |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                  1                   |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 A#------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y

            // Assert

            // Centroid of #1 in B-A-X is at ~(667, 333) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Y-A is at ~(333, 667) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
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

            // 1000 A##-----------------------------------------------Z
            //      |  ''·,,                                          |
            //  900 |       ''·,,                      2              |
            //      |            ''·,,                                |
            //  800 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  700 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  600 |                                     ''·,,       |
            //      |                                          ''·,,  |
            //  500 |                        1                      ''B
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in B-A-X-Y is at ~(444, 389) (using quadrilateral formula)
            ClassicAssert.AreEqual(444.44, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(388.89, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-A-B is at ~(667, 833) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 X-------------------------------------------------A
            //      |                                                '|
            //  900 |                                              ,' |
            //      |                                             ,   |
            //  800 |                                            ·    |
            //      |                                           '     |
            //  700 |                                         ,'      |
            //      |                                        ,        |
            //  600 |                                       ·         |
            //      |                                      '          |
            //  500 |                        1           ,'           |
            //      |                                   ,             |
            //  400 |                                  ·              |
            //      |                                 '               |
            //  300 |                               ,'           2    |
            //      |                              ,                  |
            //  200 |                             ·                   |
            //      |                            '                    |
            //  100 |                          ,'                     |
            //      |                         ,                       |
            //    0 Y------------------------B------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in A-X-Y-B is at ~(389, 556) (using quadrilateral formula)
            ClassicAssert.AreEqual(388.89, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(555.56, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-Z is at ~(833, 333) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 B,,                      1                        |
            //      |  ''·,,                                          |
            //  400 |       ''·,,                                     |
            //      |            ''·,,                                |
            //  300 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  200 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  100 |              2                      ''·,,       |
            //      |                                          ''·,,  |
            //    0 Z-----------------------------------------------##A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in X-Y-B-A is at ~(556, 611) (using quadrilateral formula)
            ClassicAssert.AreEqual(555.56, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(611.11, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Z-A is at ~(333, 167) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[1].Centroid.Y, 0.01);
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

            // 1000 Z------------------------B------------------------Y
            //      |                       '                         |
            //  900 |                     ,'                          |
            //      |                    ,                            |
            //  800 |                   ·                             |
            //      |                  '                              |
            //  700 |    2           ,'                               |
            //      |               ,                                 |
            //  600 |              ·                                  |
            //      |             '                                   |
            //  500 |           ,'           1                        |
            //      |          ,                                      |
            //  400 |         ·                                       |
            //      |        '                                        |
            //  300 |      ,'                                         |
            //      |     ,                                           |
            //  200 |    ·                                            |
            //      |   '                                             |
            //  100 | ,'                                              |
            //      |,                                                |
            //    0 A-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in Y-B-A-X is at ~(611, 444) (using quadrilateral formula)
            ClassicAssert.AreEqual(611.11, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(444.44, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Z-A is at ~(167, 667) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
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

            // 1000 Z-----------------------------------------------##A
            //      |                                          ,,·''  |
            //  900 |              2                      ,,·''       |
            //      |                                ,,·''            |
            //  800 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  700 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  600 |       ,,·''                                     |
            //      |  ,,·''                                          |
            //  500 B''                      1                        |
            //      |                                                 |
            //  400 |                                                 |
            //      |                                                 |
            //  300 |                                                 |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in A-B-Y-X is at ~(556, 389) (using quadrilateral formula)
            ClassicAssert.AreEqual(555.56, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(388.89, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Z-B is at ~(333, 833) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 Y------------------------B------------------------Z
            //      |                         '                       |
            //  900 |                          ',                     |
            //      |                            ,                    |
            //  800 |                             ·                   |
            //      |                              '                  |
            //  700 |                               ',           2    |
            //      |                                 ,               |
            //  600 |                                  ·              |
            //      |                                   '             |
            //  500 |                        1           ',           |
            //      |                                      ,          |
            //  400 |                                       ·         |
            //      |                                        '        |
            //  300 |                                         ',      |
            //      |                                           ,     |
            //  200 |                                            ·    |
            //      |                                             '   |
            //  100 |                                              ', |
            //      |                                                ,|
            //    0 X-------------------------------------------------A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in B-Y-X-A is at ~(389, 444) (using quadrilateral formula)
            ClassicAssert.AreEqual(388.89, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(444.44, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-B-A is at ~(833, 667) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
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

            // 1000 X-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                 |
            //      |                                                 |
            //  600 |                                                 |
            //      |                                                 |
            //  500 |                        1                      ,,B
            //      |                                          ,,·''  |
            //  400 |                                     ,,·''       |
            //      |                                ,,·''            |
            //  300 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  200 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  100 |       ,,·''                      2              |
            //      |  ,,·''                                          |
            //    0 A##-----------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in B-Y-X-A is at ~(444, 611) (using quadrilateral formula)
            ClassicAssert.AreEqual(444.44, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(611.11, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-Z is at ~(667, 167) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[1].Centroid.Y, 0.01);
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

            // 1000 A-------------------------------------------------X
            //      |'                                                |
            //  900 | ',                                              |
            //      |   ,                                             |
            //  800 |    ·                                            |
            //      |     '                                           |
            //  700 |      ',                                         |
            //      |        ,                                        |
            //  600 |         ·                                       |
            //      |          '                                      |
            //  500 |           ',           1                        |
            //      |             ,                                   |
            //  400 |              ·                                  |
            //      |               '                                 |
            //  300 |    2           ',                               |
            //      |                  ,                              |
            //  200 |                   ·                             |
            //      |                    '                            |
            //  100 |                     ',                          |
            //      |                       ,                         |
            //    0 Z------------------------B------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z

            // Assert

            // Centroid of #1 in X-A-B-Y is at ~(611, 556) (using quadrilateral formula)
            ClassicAssert.AreEqual(611.11, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(555.56, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Z-B is at ~(167, 333) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 X---------------------------------#D--------------Z
            //      |                               ,'                |
            //  900 |                            ,·'                  |
            //      |                          ,'                     |
            //  800 |         1             ,·'                       |
            //      |                     ,'                          |
            //  700 |                  ,·'                           ,C
            //      |                ,'                            ,' |
            //  600 |             ,·'                           ,·'   |
            //      |           ,'                            ,'      |
            //  500 |        ,·'             2             ,·'        |
            //      |      ,'                            ,'           |
            //  400 |   ,·'                           ,·'             |
            //      | ,'                            ,'                |
            //  300 A'                           ,·'                  |
            //      |                          ,'                     |
            //  200 |                       ,·'             3         |
            //      |                     ,'                          |
            //  100 |                  ,·'                            |
            //      |                ,'                               |
            //    0 Y--------------B#---------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 6 == sites[1].Points.Count(), "Expected: site #2 point count 6"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 700), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in D-X-A is at ~(233, 767) (using triangle formula)
            ClassicAssert.AreEqual(233.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(766.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Z-D-A-Y-B is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B-W is at ~(767, 233) (using triangle formula)
            ClassicAssert.AreEqual(766.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(233.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y--------------A#---------------------------------X
            //      |                ',                               |
            //  900 |                  '·,                            |
            //      |                     ',                          |
            //  800 |                       '·,             1         |
            //      |                          ',                     |
            //  700 B,                           '·,                  |
            //      | ',                            ',                |
            //  600 |   '·,                           '·,             |
            //      |      ',                            ',           |
            //  500 |        '·,             2             '·,        |
            //      |           ',                            ',      |
            //  400 |             '·,                           '·,   |
            //      |                ',                            ', |
            //  300 |                  '·,                           'D
            //      |                     ',                          |
            //  200 |         3             '·,                       |
            //      |                          ',                     |
            //  100 |                            '·,                  |
            //      |                               ',                |
            //    0 W---------------------------------#C--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 300), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 6 == sites[1].Points.Count(), "Expected: site #2 point count 6"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 300), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in X-A-D is at ~(767, 767) (using triangle formula)
            ClassicAssert.AreEqual(766.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(766.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-B-C-Z-D is at ~(500, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-W-C is at ~(233, 233) (using triangle formula)
            ClassicAssert.AreEqual(233.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(233.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 X----------------------------#D------------------#C
            //      |                          ,'                  ,' |
            //  900 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  800 |         1        ,·'                 ,·'        |
            //      |                ,'                  ,'           |
            //  700 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  600 |        ,·'        2        ,·'                  |
            //      |      ,'                  ,'                     |
            //  500 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //  400 A'                 ,·'        3                   |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 B#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in D-X-A is at ~(200, 800) (using triangle formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A-B is at ~(408, 592) (using quadrilateral formula)
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B-Y is at ~(667, 333) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 B#------------------A#----------------------------X
            //      | ',                  ',                          |
            //  900 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  800 |        '·,                 '·,        1         |
            //      |           ',                  ',                |
            //  700 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  600 |                  '·,        2        '·,        |
            //      |                     ',                  ',      |
            //  500 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //  400 |                   3        '·,                 'D
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 Y------------------------------------------------#C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in X-A-D is at ~(800, 800) (using triangle formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C-D is at ~(592, 592) (using quadrilateral formula)
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-Y-C is at ~(333, 333) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y------------------------------------------------#B
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                   3        ,·'                 ,A
            //      |                          ,'                  ,' |
            //  500 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  400 |                  ,·'        2        ,·'        |
            //      |                ,'                  ,'           |
            //  300 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  200 |        ,·'                 ,·'        1         |
            //      |      ,'                  ,'                     |
            //  100 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //    0 C#------------------D#----------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in A-D-X is at ~(800, 200) (using triangle formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C-D is at ~(592, 408) (using quadrilateral formula)
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-Y-C is at ~(333, 667) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
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

            // 1000 C#------------------------------------------------Y
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 D,                 '·,        3                   |
            //      | ',                  ',                          |
            //  500 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  400 |        '·,        2        '·,                  |
            //      |           ',                  ',                |
            //  300 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  200 |         1        '·,                 '·,        |
            //      |                     ',                  ',      |
            //  100 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //    0 X----------------------------#A------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in D-X-A is at ~(200, 200) (using triangle formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-A-B is at ~(408, 408) (using quadrilateral formula)
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in Y-C-B is at ~(667, 667) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
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

            // 1000 X----------------------------#F------------------#E
            //      |                          ,'                  ,' |
            //  900 |                       ,·'                 ,·'   |
            //      |                     ,'                  ,'      |
            //  800 |         1        ,·'                 ,·'        |
            //      |                ,'                  ,'           |
            //  700 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  600 |        ,·'        2        ,·'                 ,D
            //      |      ,'                  ,'                  ,' |
            //  500 |   ,·'                 ,·'                 ,·'   |
            //      | ,'                  ,'                  ,'      |
            //  400 A'                 ,·'        3        ,·'        |
            //      |                ,'                  ,'           |
            //  300 |             ,·'                 ,·'             |
            //      |           ,'                  ,'                |
            //  200 |        ,·'                 ,·'        4         |
            //      |      ,'                  ,'                     |
            //  100 |   ,·'                 ,·'                       |
            //      | ,'                  ,'                          |
            //    0 B#------------------C#----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has F"); // #1 has F
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
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
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 0), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 1000, 600), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has Y"); // #4 has Y

            // Assert

            // Centroid of #1 in F-X-A is at ~(200, 800) (using triangle formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in E-F-A-B is at ~(408, 592) (using quadrilateral formula)
            ClassicAssert.AreEqual(408.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-E-B-C is at ~(592, 408) (using quadrilateral formula)
            ClassicAssert.AreEqual(591.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(408.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in D-C-Y is at ~(800, 200) (using triangle formula)
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

            // 1000 B#------------------A#----------------------------X
            //      | ',                  ',                          |
            //  900 |   '·,                 '·,                       |
            //      |      ',                  ',                     |
            //  800 |        '·,                 '·,        1         |
            //      |           ',                  ',                |
            //  700 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  600 C,                 '·,        2        '·,        |
            //      | ',                  ',                  ',      |
            //  500 |   '·,                 '·,                 '·,   |
            //      |      ',                  ',                  ', |
            //  400 |        '·,        3        '·,                 'F
            //      |           ',                  ',                |
            //  300 |             '·,                 '·,             |
            //      |                ',                  ',           |
            //  200 |         4        '·,                 '·,        |
            //      |                     ',                  ',      |
            //  100 |                       '·,                 '·,   |
            //      |                          ',                  ', |
            //    0 Y----------------------------#D------------------#E
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has F"); // #1 has F
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
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
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 0, 600), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 600, 0), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has Y"); // #4 has Y

            // Assert

            // Centroid of #1 in X-A-F is at ~(800, 800) (using triangle formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-E-F is at ~(592, 592) (using quadrilateral formula)
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(591.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-C-D-E is at ~(408, 408) (using quadrilateral formula)
            ClassicAssert.AreEqual(408.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(408.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in C-Y-D is at ~(200, 200) (using triangle formula)
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

            // 1000 X------------------------------------------------#D
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                                 ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 |              1        ,·'                       |
            //      |                     ,'                          |
            //  400 B-------------------A'                            |
            //      |                   |                             |
            //  300 |              2    |    3                        |
            //      |                   |                             |
            //  200 |                   |                             |
            //      |                   |                             |
            //  100 |                   |                             |
            //      |                   |                             |
            //    0 Y-------------------C-----------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in D-X-B-A is at ~(371, 743) (using quadrilateral formula)
            ClassicAssert.AreEqual(371.43, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(742.86, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-Y-C is at ~(200, 200) (using rectangle formula)
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-A-C-W is at ~(743, 371) (using quadrilateral formula)
            ClassicAssert.AreEqual(742.86, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(371.43, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y-------------------B-----------------------------X
            //      |                   |                             |
            //  900 |                   |                             |
            //      |                   |                             |
            //  800 |                   |                             |
            //      |                   |                             |
            //  700 |              2    |    1                        |
            //      |                   |                             |
            //  600 C-------------------A,                            |
            //      |                     ',                          |
            //  500 |              3        '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 W------------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in X-B-A-D is at ~(743, 629) (using quadrilateral formula)
            ClassicAssert.AreEqual(742.86, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(628.57, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Y-C-A is at ~(200, 800) (using rectangle formula)
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C-W-D is at ~(371, 257) (using quadrilateral formula)
            ClassicAssert.AreEqual(371.43, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(257.14, sites[2].Centroid.Y, 0.01);
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

            // 1000 W-----------------------------C-------------------Y
            //      |                             |                   |
            //  900 |                             |                   |
            //      |                             |                   |
            //  800 |                             |                   |
            //      |                             |                   |
            //  700 |                        3    |    2              |
            //      |                             |                   |
            //  600 |                            ,A-------------------B
            //      |                          ,'                     |
            //  500 |                       ,·'        1              |
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'                                 |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 D#------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in B-A-D-X is at ~(629, 257) (using quadrilateral formula)
            ClassicAssert.AreEqual(628.57, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(257.14, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-C-A-B is at ~(800, 800) (using rectangle formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-W-D-A is at ~(257, 629) (using quadrilateral formula)
            ClassicAssert.AreEqual(257.14, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(628.57, sites[2].Centroid.Y, 0.01);
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

            // 1000 D#------------------------------------------------W
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,                                 |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |                       '·,        3              |
            //      |                          ',                     |
            //  400 |                            'A-------------------C
            //      |                             |                   |
            //  300 |                        1    |    2              |
            //      |                             |                   |
            //  200 |                             |                   |
            //      |                             |                   |
            //  100 |                             |                   |
            //      |                             |                   |
            //    0 X-----------------------------B-------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in A-D-X-B is at ~(257, 371) (using quadrilateral formula)
            ClassicAssert.AreEqual(257.14, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(371.43, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B-Y is at ~(800, 200) (using rectangle formula)
            ClassicAssert.AreEqual(800.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-D-A-C is at ~(629, 743) (using quadrilateral formula)
            ClassicAssert.AreEqual(628.57, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(742.86, sites[2].Centroid.Y, 0.01);
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

            // 1000 X---------------------------------#D--------------Z
            //      |                               ,'                |
            //  900 |                            ,·'                  |
            //      |                          ,'                     |
            //  800 |    1                  ,·'                       |
            //      |                     ,'                          |
            //  700 |                  ,·'                            |
            //      |                ,'                               |
            //  600 B--------------A'                                 |
            //      |              |                                  |
            //  500 |              |                                  |
            //      |              |                                  |
            //  400 |    2         |         3                        |
            //      |              |                                  |
            //  300 |              |                                  |
            //      |              |                                  |
            //  200 |              |                                  |
            //      |              |                                  |
            //  100 |              |                                  |
            //      |              |                                  |
            //    0 Y--------------C----------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 700, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in D-X-B-A is at ~(263, 827) (using quadrilateral formula)
            ClassicAssert.AreEqual(263.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(826.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-Y-C is at ~(150, 300) (using rectangle formula)
            ClassicAssert.AreEqual(150.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in Z-D-A-C-W is at ~(678, 453) (using generic closed polygon formula)
            ClassicAssert.AreEqual(677.96, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(452.69, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y-----------------------------B-------------------X
            //      |                             |                   |
            //  900 |                   2         |         1         |
            //      |                             |                   |
            //  800 |                             |                   |
            //      |                             |                   |
            //  700 C-----------------------------A,                  |
            //      |                               ',                |
            //  600 |                                 '·,             |
            //      |                                    ',           |
            //  500 |                   3                  '·,        |
            //      |                                         ',      |
            //  400 |                                           '·,   |
            //      |                                              ', |
            //  300 |                                                'D
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 300), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 700), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in X-B-A-D is at ~(827, 737) (using quadrilateral formula)
            ClassicAssert.AreEqual(826.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(736.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Y-C-A is at ~(300, 850) (using rectangle formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C-W-Z-D is at ~(453, 322) (using generic closed polygon formula)
            ClassicAssert.AreEqual(452.69, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(322.04, sites[2].Centroid.Y, 0.01);
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

            // 1000 W----------------------------------C--------------Y
            //      |                                  |              |
            //  900 |                                  |              |
            //      |                                  |              |
            //  800 |                                  |              |
            //      |                                  |              |
            //  700 |                                  |              |
            //      |                                  |              |
            //  600 |                        3         |         2    |
            //      |                                  |              |
            //  500 |                                  |              |
            //      |                                  |              |
            //  400 |                                 ,A--------------B
            //      |                               ,'                |
            //  300 |                            ,·'                  |
            //      |                          ,'                     |
            //  200 |                       ,·'                  1    |
            //      |                     ,'                          |
            //  100 |                  ,·'                            |
            //      |                ,'                               |
            //    0 Z--------------D#---------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 300, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 700, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 700, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in B-A-D-X is at ~(737, 173) (using quadrilateral formula)
            ClassicAssert.AreEqual(736.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(173.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-C-A-B is at ~(850, 700) (using rectangle formula)
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-W-Z-D-A is at ~(322, 547) (using generic closed polygon formula)
            ClassicAssert.AreEqual(322.04, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(547.31, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 D,                                                |
            //      | ',                                              |
            //  600 |   '·,                                           |
            //      |      ',                                         |
            //  500 |        '·,                  3                   |
            //      |           ',                                    |
            //  400 |             '·,                                 |
            //      |                ',                               |
            //  300 |                  'A-----------------------------C
            //      |                   |                             |
            //  200 |                   |                             |
            //      |                   |                             |
            //  100 |         1         |         2                   |
            //      |                   |                             |
            //    0 X-------------------B-----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 300), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in A-D-X-B is at ~(173, 263) (using quadrilateral formula)
            ClassicAssert.AreEqual(173.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(263.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B-Y is at ~(700, 150) (using rectangle formula)
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-Z-D-A-C is at ~(547, 678) (using generic closed polygon formula)
            ClassicAssert.AreEqual(547.31, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(677.96, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z--------------D#---------------------------------X
            //      |                ',                               |
            //  900 |                  '·,                            |
            //      |                     ',                          |
            //  800 |                       '·,                  1    |
            //      |                          ',                     |
            //  700 |                            '·,                  |
            //      |                               ',                |
            //  600 |                                 'A--------------B
            //      |                                  |              |
            //  500 |                                  |              |
            //      |                                  |              |
            //  400 |                        3         |         2    |
            //      |                                  |              |
            //  300 |                                  |              |
            //      |                                  |              |
            //  200 |                                  |              |
            //      |                                  |              |
            //  100 |                                  |              |
            //      |                                  |              |
            //    0 W----------------------------------C--------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 300, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 700, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in X-D-A-B is at ~(737, 827) (using quadrilateral formula)
            ClassicAssert.AreEqual(736.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(826.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C-Y is at ~(850, 300) (using rectangle formula)
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-Z-W-C is at ~(322, 453) (using generic closed polygon formula)
            ClassicAssert.AreEqual(322.04, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(452.69, sites[2].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                 |
            //      |                                                 |
            //  700 |                                                ,D
            //      |                                              ,' |
            //  600 |                                           ,·'   |
            //      |                                         ,'      |
            //  500 |                   3                  ,·'        |
            //      |                                    ,'           |
            //  400 |                                 ,·'             |
            //      |                               ,'                |
            //  300 C-----------------------------A'                  |
            //      |                             |                   |
            //  200 |                             |                   |
            //      |                             |                   |
            //  100 |                   2         |         1         |
            //      |                             |                   |
            //    0 Y-----------------------------B-------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 700), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in D-A-B-X is at ~(827, 263) (using quadrilateral formula)
            ClassicAssert.AreEqual(826.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(263.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Y-B is at ~(300, 150) (using rectangle formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-Z-W-C-A is at ~(453, 678) (using generic closed polygon formula)
            ClassicAssert.AreEqual(452.69, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(677.96, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y--------------C----------------------------------W
            //      |              |                                  |
            //  900 |              |                                  |
            //      |              |                                  |
            //  800 |              |                                  |
            //      |              |                                  |
            //  700 |              |                                  |
            //      |              |                                  |
            //  600 |    2         |         3                        |
            //      |              |                                  |
            //  500 |              |                                  |
            //      |              |                                  |
            //  400 B--------------A,                                 |
            //      |                ',                               |
            //  300 |                  '·,                            |
            //      |                     ',                          |
            //  200 |    1                  '·,                       |
            //      |                          ',                     |
            //  100 |                            '·,                  |
            //      |                               ',                |
            //    0 X---------------------------------#D--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in A-B-X-D is at ~(263, 173) (using quadrilateral formula)
            ClassicAssert.AreEqual(263.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(173.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Y-B-A is at ~(150, 700) (using rectangle formula)
            ClassicAssert.AreEqual(150.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-C-A-D-Z is at ~(678, 547) (using generic closed polygon formula)
            ClassicAssert.AreEqual(677.96, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(547.31, sites[2].Centroid.Y, 0.01);
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

            // 1000 X-------------------B-----------------------------Y
            //      |                   |                             |
            //  900 |         1         |         2                   |
            //      |                   |                             |
            //  800 |                   |                             |
            //      |                   |                             |
            //  700 |                  ,A-----------------------------C
            //      |                ,'                               |
            //  600 |             ,·'                                 |
            //      |           ,'                                    |
            //  500 |        ,·'                  3                   |
            //      |      ,'                                         |
            //  400 |   ,·'                                           |
            //      | ,'                                              |
            //  300 D'                                                |
            //      |                                                 |
            //  200 |                                                 |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 700), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 700), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in B-X-D-A is at ~(173, 737) (using quadrilateral formula)
            ClassicAssert.AreEqual(173.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(736.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-B-A-C is at ~(700, 850) (using rectangle formula)
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A-D-Z-W is at ~(547, 322) (using generic closed polygon formula)
            ClassicAssert.AreEqual(547.31, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(322.04, sites[2].Centroid.Y, 0.01);
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

            // 1000 X------------------------D------------------------Y
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  400 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 B#-----------------------------------------------#C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has X"); // #3 has X

            // Assert

            // Centroid of #1 in A-B-C is at ~(500, 167) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-D-A-C is at ~(778, 611) (using quadrilateral formula)
            ClassicAssert.AreEqual(777.78, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(611.11, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-X-B is at ~(222, 611) (using quadrilateral formula)
            ClassicAssert.AreEqual(222.22, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(611.11, sites[2].Centroid.Y, 0.01);
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

            // 1000 B#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        '·,                                      |
            //      |           ',                                    |
            //  700 |             '·,        3                        |
            //      |                ',                               |
            //  600 |                  '·,                            |
            //      |                     ',                          |
            //  500 |              1        #A------------------------D
            //      |                     ,'                          |
            //  400 |                  ,·'                            |
            //      |                ,'                               |
            //  300 |             ,·'        2                        |
            //      |           ,'                                    |
            //  200 |        ,·'                                      |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 C#------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has X"); // #3 has X

            // Assert

            // Centroid of #1 in A-B-C is at ~(167, 500) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C-Y is at ~(611, 222) (using quadrilateral formula)
            ClassicAssert.AreEqual(611.11, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(222.22, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in X-B-A-D is at ~(611, 778) (using quadrilateral formula)
            ClassicAssert.AreEqual(611.11, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(777.78, sites[2].Centroid.Y, 0.01);
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

            // 1000 C#-----------------------------------------------#B
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              2        'A'        3              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has X"); // #3 has X

            // Assert

            // Centroid of #1 in B-C-A is at ~(500, 833) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Y-D is at ~(222, 389) (using quadrilateral formula)
            ClassicAssert.AreEqual(222.22, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(388.89, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D-X is at ~(778, 389) (using quadrilateral formula)
            ClassicAssert.AreEqual(777.78, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(388.89, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y------------------------------------------------#C
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                      ,·'        |
            //      |                                    ,'           |
            //  700 |                        2        ,·'             |
            //      |                               ,'                |
            //  600 |                            ,·'                  |
            //      |                          ,'                     |
            //  500 D------------------------A#        1              |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                        3        '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 X------------------------------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has X"); // #3 has X

            // Assert

            // Centroid of #1 in C-A-B is at ~(833, 500) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Y-D-A is at ~(389, 778) (using quadrilateral formula)
            ClassicAssert.AreEqual(388.89, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(777.78, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-X-B is at ~(389, 222) (using quadrilateral formula)
            ClassicAssert.AreEqual(388.89, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(222.22, sites[2].Centroid.Y, 0.01);
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

            // 1000 X------------------------D------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  200 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //    0 Y---------B#---------------------------#C---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in A-B-C is at ~(500, 100) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-D-A-C-W is at ~(765, 540) (using generic closed polygon formula)
            ClassicAssert.AreEqual(764.84, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(539.56, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-X-Y-B is at ~(235, 540) (using generic closed polygon formula)
            ClassicAssert.AreEqual(235.16, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(539.56, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 B,                                                |
            //      | ',                                              |
            //  700 |   '·,        3                                  |
            //      |      ',                                         |
            //  600 |        '·,                                      |
            //      |           ',                                    |
            //  500 |    1        #A----------------------------------D
            //      |           ,'                                    |
            //  400 |        ,·'                                      |
            //      |      ,'                                         |
            //  300 |   ,·'        2                                  |
            //      | ,'                                              |
            //  200 C'                                                |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 W-------------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 800), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in A-B-C is at ~(100, 500) (using triangle formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C-W-Z is at ~(540, 235) (using generic closed polygon formula)
            ClassicAssert.AreEqual(539.56, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(235.16, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in X-Y-B-A-D is at ~(540, 765) (using generic closed polygon formula)
            ClassicAssert.AreEqual(539.56, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(764.84, sites[2].Centroid.Y, 0.01);
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

            // 1000 W---------C#---------------------------#B---------Y
            //      |           ',                       ,'           |
            //  900 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  700 |              2        'A'        3              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Z------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 700), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 800, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in B-C-A is at ~(500, 900) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-W-Z-D is at ~(235, 460) (using generic closed polygon formula)
            ClassicAssert.AreEqual(235.16, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(460.44, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in Y-B-A-D-X is at ~(765, 460) (using generic closed polygon formula)
            ClassicAssert.AreEqual(764.84, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(460.44, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z-------------------------------------------------W
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                                ,C
            //      |                                              ,' |
            //  700 |                                  2        ,·'   |
            //      |                                         ,'      |
            //  600 |                                      ,·'        |
            //      |                                    ,'           |
            //  500 D----------------------------------A#        1    |
            //      |                                    ',           |
            //  400 |                                      '·,        |
            //      |                                         ',      |
            //  300 |                                  3        '·,   |
            //      |                                              ', |
            //  200 |                                                'B
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 5 == sites[2].Points.Count(), "Expected: site #3 point count 5"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 700, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in C-A-B is at ~(900, 500) (using triangle formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-W-Z-D-A is at ~(460, 765) (using generic closed polygon formula)
            ClassicAssert.AreEqual(460.44, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(764.84, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-X-Y-B is at ~(460, 235) (using generic closed polygon formula)
            ClassicAssert.AreEqual(460.44, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(235.16, sites[2].Centroid.Y, 0.01);
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

            // 1000 X------------------------D------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |              3        ,A,        2              |
            //      |                     ,'   ',                     |
            //  600 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  500 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //  400 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  300 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //  200 B'                                               'C
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 5 == sites[0].Points.Count(), "Expected: site #1 point count 5"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 700), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has X"); // #3 has X

            // Assert

            // Centroid of #1 in A-B-Y-W-C is at ~(500, 248) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(248.15, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-D-A-C is at ~(788, 706) (using quadrilateral formula)
            ClassicAssert.AreEqual(787.88, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(706.06, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-X-B is at ~(212, 706) (using quadrilateral formula)
            ClassicAssert.AreEqual(212.12, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(706.06, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y---------B#--------------------------------------X
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                            |
            //      |                     ',                          |
            //  700 |                       '·,        3              |
            //      |                          ',                     |
            //  600 |                            '·,                  |
            //      |                               ',                |
            //  500 |                        1        #A--------------D
            //      |                               ,'                |
            //  400 |                            ,·'                  |
            //      |                          ,'                     |
            //  300 |                       ,·'        2              |
            //      |                     ,'                          |
            //  200 |                  ,·'                            |
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 W---------C#--------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 5 == sites[0].Points.Count(), "Expected: site #1 point count 5"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 700, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 200, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has X"); // #3 has X

            // Assert

            // Centroid of #1 in A-B-Y-W-C is at ~(248, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(248.15, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C-Z is at ~(706, 212) (using quadrilateral formula)
            ClassicAssert.AreEqual(706.06, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(212.12, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in X-B-A-D is at ~(706, 788) (using quadrilateral formula)
            ClassicAssert.AreEqual(706.06, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(787.88, sites[2].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 C,                                               ,B
            //      | ',                                           ,' |
            //  700 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  600 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  500 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  400 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  300 |              2        'A'        3              |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Z------------------------D------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 5 == sites[0].Points.Count(), "Expected: site #1 point count 5"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 800), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has X"); // #3 has X

            // Assert

            // Centroid of #1 in B-Y-W-C-A is at ~(500, 752) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(751.85, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Z-D is at ~(212, 294) (using quadrilateral formula)
            ClassicAssert.AreEqual(212.12, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(293.94, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D-X is at ~(788, 294) (using quadrilateral formula)
            ClassicAssert.AreEqual(787.88, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(293.94, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z--------------------------------------#C---------W
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 |                            ,·'                  |
            //      |                          ,'                     |
            //  700 |              2        ,·'                       |
            //      |                     ,'                          |
            //  600 |                  ,·'                            |
            //      |                ,'                               |
            //  500 D--------------A#        1                        |
            //      |                ',                               |
            //  400 |                  '·,                            |
            //      |                     ',                          |
            //  300 |              3        '·,                       |
            //      |                          ',                     |
            //  200 |                            '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 X--------------------------------------#B---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 5 == sites[0].Points.Count(), "Expected: site #1 point count 5"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 800, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has X"); // #3 has X

            // Assert

            // Centroid of #1 in W-C-A-B-Y is at ~(752, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(751.85, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Z-D-A is at ~(294, 788) (using quadrilateral formula)
            ClassicAssert.AreEqual(293.94, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(787.88, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-X-B is at ~(294, 212) (using quadrilateral formula)
            ClassicAssert.AreEqual(293.94, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(212.12, sites[2].Centroid.Y, 0.01);
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

            // 1000 E#-----------------------------------------------#H
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        5        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  'A---------D'                  |
            //      |                   |         |                   |
            //  500 |              2    |    1    |    4              |
            //      |                   |         |                   |
            //  400 |                  ,B---------C,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 F#-----------------------------------------------#G
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

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

            // 1000 X-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 E,                                               ,H
            //      | ',                                           ,' |
            //  700 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  600 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  500 |             '·,        5        ,·'             |
            //      |                ',             ,'                |
            //  400 |                  'A---------D'                  |
            //      |                   |         |                   |
            //  300 |              2    |    1    |    4              |
            //      |                   |         |                   |
            //  200 |                  ,B---------C,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //    0 Y---------F#---------------------------#G---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 600, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 200), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 600, 200), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 800, 0), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 5 == sites[3].Points.Count(), "Expected: site #4 point count 5"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 200), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 600, 400), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 800, 0), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 1000, 800), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has W"); // #4 has W
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 6 == sites[4].Points.Count(), "Expected: site #5 point count 6"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 400, 400), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 600, 400), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 0, 800), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 1000, 800), "Expected: site #5 has H"); // #5 has H
            Assume.That(() => HasPoint(sites[4].Points, 0, 1000), "Expected: site #5 has X"); // #5 has X
            Assume.That(() => HasPoint(sites[4].Points, 1000, 1000), "Expected: site #5 has Z"); // #5 has Z

            // Assert

            // Centroid of #1 in D-A-B-C is at ~(500, 300) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-E-Y-F-B is at ~(164, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(163.64, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-B-F-G is at ~(500, 83) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(83.33, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in H-D-C-G-W is at ~(836, 333) (using generic closed polygon formula)
            ClassicAssert.AreEqual(836.36, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in H-Z-X-E-A-D is at ~(500, 761) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(760.61, sites[4].Centroid.Y, 0.01);
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

            // 1000 Y--------------------------------------#E---------X
            //      |                                    ,'           |
            //  900 |                                 ,·'             |
            //      |                               ,'                |
            //  800 F,                           ,·'                  |
            //      | ',                       ,'                     |
            //  700 |   '·,        2        ,·'                       |
            //      |      ',             ,'                          |
            //  600 |        'B---------A'                            |
            //      |         |         |                             |
            //  500 |    3    |    1    |    5                        |
            //      |         |         |                             |
            //  400 |        ,C---------D,                            |
            //      |      ,'             ',                          |
            //  300 |   ,·'        4        '·,                       |
            //      | ,'                       ',                     |
            //  200 G'                           '·,                  |
            //      |                               ',                |
            //  100 |                                 '·,             |
            //      |                                    ',           |
            //    0 W--------------------------------------#H---------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 400), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 600), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 200, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 800), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 0, 200), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 5 == sites[3].Points.Count(), "Expected: site #4 point count 5"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 200, 400), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 400, 400), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 0, 200), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 800, 0), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has W"); // #4 has W
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 6 == sites[4].Points.Count(), "Expected: site #5 point count 6"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 400, 600), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 400, 400), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 800, 1000), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 800, 0), "Expected: site #5 has H"); // #5 has H
            Assume.That(() => HasPoint(sites[4].Points, 1000, 1000), "Expected: site #5 has X"); // #5 has X
            Assume.That(() => HasPoint(sites[4].Points, 1000, 0), "Expected: site #5 has Z"); // #5 has Z

            // Assert

            // Centroid of #1 in A-B-C-D is at ~(300, 500) (using rectangle formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in E-Y-F-B-A is at ~(333, 836) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(836.36, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-F-G-C is at ~(83, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(83.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in D-C-G-W-H is at ~(333, 164) (using generic closed polygon formula)
            ClassicAssert.AreEqual(333.33, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(163.64, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in X-E-A-D-H-Z is at ~(761, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(760.61, sites[4].Centroid.X, 0.01);
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

            // 1000 W---------G#---------------------------#F---------Y
            //      |           ',                       ,'           |
            //  900 |             '·,        3        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  'C---------B'                  |
            //      |                   |         |                   |
            //  700 |              4    |    1    |    2              |
            //      |                   |         |                   |
            //  600 |                  ,D---------A,                  |
            //      |                ,'             ',                |
            //  500 |             ,·'        5        '·,             |
            //      |           ,'                       ',           |
            //  400 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  300 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //  200 H'                                               'E
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 400, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 800), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 800), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 400, 800), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 800, 1000), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 200, 1000), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 5 == sites[3].Points.Count(), "Expected: site #4 point count 5"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 800), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 400, 600), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 200, 1000), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 0, 200), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => HasPoint(sites[3].Points, 0, 1000), "Expected: site #4 has W"); // #4 has W
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 6 == sites[4].Points.Count(), "Expected: site #5 point count 6"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 600, 600), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 400, 600), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 1000, 200), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 0, 200), "Expected: site #5 has H"); // #5 has H
            Assume.That(() => HasPoint(sites[4].Points, 1000, 0), "Expected: site #5 has X"); // #5 has X
            Assume.That(() => HasPoint(sites[4].Points, 0, 0), "Expected: site #5 has Z"); // #5 has Z

            // Assert

            // Centroid of #1 in B-C-D-A is at ~(500, 700) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-F-B-A-E is at ~(836, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(836.36, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in F-G-C-B is at ~(500, 917) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(916.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in C-G-W-H-D is at ~(164, 667) (using generic closed polygon formula)
            ClassicAssert.AreEqual(163.64, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in A-D-H-Z-X-E is at ~(500, 239) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(239.39, sites[4].Centroid.Y, 0.01);
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

            // 1000 Z---------H#--------------------------------------W
            //      |           ',                                    |
            //  900 |             '·,                                 |
            //      |                ',                               |
            //  800 |                  '·,                           ,G
            //      |                     ',                       ,' |
            //  700 |                       '·,        4        ,·'   |
            //      |                          ',             ,'      |
            //  600 |                            'D---------C'        |
            //      |                             |         |         |
            //  500 |                        5    |    1    |    3    |
            //      |                             |         |         |
            //  400 |                            ,A---------B,        |
            //      |                          ,'             ',      |
            //  300 |                       ,·'        2        '·,   |
            //      |                     ,'                       ', |
            //  200 |                  ,·'                           'F
            //      |                ,'                               |
            //  100 |             ,·'                                 |
            //      |           ,'                                    |
            //    0 X---------E#--------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 600), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has F"); // #2 has F
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 400), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 800, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 200), "Expected: site #3 has F"); // #3 has F
            Assume.That(() => HasPoint(sites[2].Points, 1000, 800), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 5 == sites[3].Points.Count(), "Expected: site #4 point count 5"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 800, 600), "Expected: site #4 has C"); // #4 has C
            Assume.That(() => HasPoint(sites[3].Points, 600, 600), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 1000, 800), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 200, 1000), "Expected: site #4 has H"); // #4 has H
            Assume.That(() => HasPoint(sites[3].Points, 1000, 1000), "Expected: site #4 has W"); // #4 has W
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 6 == sites[4].Points.Count(), "Expected: site #5 point count 6"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 600, 400), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 600, 600), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 200, 0), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 200, 1000), "Expected: site #5 has H"); // #5 has H
            Assume.That(() => HasPoint(sites[4].Points, 0, 0), "Expected: site #5 has X"); // #5 has X
            Assume.That(() => HasPoint(sites[4].Points, 0, 1000), "Expected: site #5 has Z"); // #5 has Z

            // Assert

            // Centroid of #1 in C-D-A-B is at ~(700, 500) (using rectangle formula)
            ClassicAssert.AreEqual(700.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-E-Y-F is at ~(667, 164) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(163.64, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in G-C-B-F is at ~(917, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(916.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in G-W-H-D-C is at ~(667, 836) (using generic closed polygon formula)
            ClassicAssert.AreEqual(666.67, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(836.36, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in D-H-Z-X-E-A is at ~(239, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(239.39, sites[4].Centroid.X, 0.01);
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

            // 1000 X------------------------B------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |              1         |         4              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 C------------------------A------------------------E
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              2         |         3              |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 500, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 1000), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in B-X-C-A is at ~(250, 750) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Y-D is at ~(250, 250) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-A-D-W is at ~(750, 250) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in Z-B-A-E is at ~(750, 750) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 X------------------------B------------------------Z
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                   1    |    4                   |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 C------------------------A------------------------E
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                   2    |    3                   |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 Y------------------------D------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 500, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 1000), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in B-X-C-A is at ~(250, 750) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Y-D is at ~(250, 250) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-A-D-W is at ~(750, 250) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in Z-B-A-E is at ~(750, 750) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 Y------------------------C------------------------X
            //      |                        |                        |
            //  900 |                        |                        |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 |         2              |              1         |
            //      |                        |                        |
            //  500 D------------------------A------------------------B
            //      |                        |                        |
            //  400 |         3              |              4         |
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |                        |                        |
            //      |                        |                        |
            //    0 W------------------------E------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 500, 0), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in X-C-A-B is at ~(750, 750) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Y-D-A is at ~(250, 750) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-W-E is at ~(250, 250) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-A-E-Z is at ~(750, 250) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 B#-----------------------------------------------#E
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              4        #A#        2              |
            //      |                     ,'   ',                     |
            //  400 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  300 |             ,·'        3        '·,             |
            //      |           ,'                       ',           |
            //  200 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  100 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //    0 C#-----------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

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

            // 1000 X----B--------------------------------------------Z
            //      |     '                                           |
            //  900 |      ',                                         |
            //      |        ,                                        |
            //  800 |         ·                                       |
            //      |          '                                      |
            //  700 |           ',           4                      ,,E
            //      |             ,                            ,,·''  |
            //  600 |              ·                      ,,·''       |
            //      |               '                ,,·''            |
            //  500 |    1           ',         ,,·''                 |
            //      |                  ,   ,,·''                      |
            //  400 |                 ,,A''                           |
            //      |            ,,·''   '                            |
            //  300 |       ,,·''         ',           3              |
            //      |  ,,·''                ,                         |
            //  200 C''                      ·                        |
            //      |                         '                       |
            //  100 |              2           ',                     |
            //      |                            ,                    |
            //    0 Y-----------------------------D-------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 100, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 700), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 100, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 700), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 1000), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in B-X-C-A is at ~(139, 575) (using quadrilateral formula)
            ClassicAssert.AreEqual(138.60, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(575.44, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Y-D is at ~(283, 150) (using quadrilateral formula)
            ClassicAssert.AreEqual(283.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-A-D-W is at ~(763, 302) (using quadrilateral formula)
            ClassicAssert.AreEqual(763.22, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(302.30, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-Z-B-A is at ~(575, 775) (using quadrilateral formula)
            ClassicAssert.AreEqual(575.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(775.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 Y---------C---------------------------------------X
            //      |          '                                      |
            //  900 |           ',           1                      ,,B
            //      |             ,                            ,,·''  |
            //  800 |              ·                      ,,·''       |
            //      |               '                ,,·''            |
            //  700 |    2           ',         ,,·''                 |
            //      |                  ,   ,,·''                      |
            //  600 |                 ,,A''                           |
            //      |            ,,·''   '                            |
            //  500 |       ,,·''         ',           4              |
            //      |  ,,·''                ,                         |
            //  400 D''                      ·                        |
            //      |                         '                       |
            //  300 |              3           ',                     |
            //      |                            ,                    |
            //  200 |                             ·                   |
            //      |                              '                  |
            //  100 |                               ',                |
            //      |                                 ,               |
            //    0 W----------------------------------E--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 900), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 900), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 700, 0), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in B-X-C-A is at ~(575, 861) (using quadrilateral formula)
            ClassicAssert.AreEqual(575.44, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(861.40, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Y-D-A is at ~(150, 717) (using quadrilateral formula)
            ClassicAssert.AreEqual(150.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(716.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-W-E is at ~(302, 237) (using quadrilateral formula)
            ClassicAssert.AreEqual(302.30, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(236.78, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-A-E-Z is at ~(775, 425) (using quadrilateral formula)
            ClassicAssert.AreEqual(775.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(425.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 W-------------------D-----------------------------Y
            //      |                    '                            |
            //  900 |                     ',           2              |
            //      |                       ,                         |
            //  800 |                        ·                      ,,C
            //      |                         '                ,,·''  |
            //  700 |              3           ',         ,,·''       |
            //      |                            ,   ,,·''            |
            //  600 |                           ,,A''                 |
            //      |                      ,,·''   '                  |
            //  500 |                 ,,·''         ',           1    |
            //      |            ,,·''                ,               |
            //  400 |       ,,·''                      ·              |
            //      |  ,,·''                            '             |
            //  300 E''                      4           ',           |
            //      |                                      ,          |
            //  200 |                                       ·         |
            //      |                                        '        |
            //  100 |                                         ',      |
            //      |                                           ,     |
            //    0 Z--------------------------------------------B----X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 900, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 900, 0), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 0, 300), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in C-A-B-X is at ~(861, 425) (using quadrilateral formula)
            ClassicAssert.AreEqual(861.40, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(424.56, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-D-A-C is at ~(717, 850) (using quadrilateral formula)
            ClassicAssert.AreEqual(716.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-W-E-A is at ~(237, 698) (using quadrilateral formula)
            ClassicAssert.AreEqual(236.78, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(697.70, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-E-Z-B is at ~(425, 225) (using quadrilateral formula)
            ClassicAssert.AreEqual(425.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(225.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 Z--------------E----------------------------------W
            //      |               '                                 |
            //  900 |                ',                               |
            //      |                  ,                              |
            //  800 |                   ·                             |
            //      |                    '                            |
            //  700 |                     ',           3              |
            //      |                       ,                         |
            //  600 |                        ·                      ,,D
            //      |                         '                ,,·''  |
            //  500 |              4           ',         ,,·''       |
            //      |                            ,   ,,·''            |
            //  400 |                           ,,A''                 |
            //      |                      ,,·''   '                  |
            //  300 |                 ,,·''         ',           2    |
            //      |            ,,·''                ,               |
            //  200 |       ,,·''                      ·              |
            //      |  ,,·''                            '             |
            //  100 B''                      1           ',           |
            //      |                                      ,          |
            //    0 X---------------------------------------C---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 100), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 100), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 300, 1000), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 0, 1000), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in A-B-X-C is at ~(425, 139) (using quadrilateral formula)
            ClassicAssert.AreEqual(424.56, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(138.60, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-A-C-Y is at ~(850, 283) (using quadrilateral formula)
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(283.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-E-A-D is at ~(698, 763) (using quadrilateral formula)
            ClassicAssert.AreEqual(697.70, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(763.22, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-Z-B-A is at ~(225, 575) (using quadrilateral formula)
            ClassicAssert.AreEqual(225.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(575.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 Z--------------------------------------------B----X
            //      |                                           '     |
            //  900 |                                         ,'      |
            //      |                                        ,        |
            //  800 |                                       ·         |
            //      |                                      '          |
            //  700 E,,                      4           ,'           |
            //      |  ''·,,                            ,             |
            //  600 |       ''·,,                      ·              |
            //      |            ''·,,                '               |
            //  500 |                 ''·,,         ,'           1    |
            //      |                      ''·,,   ,                  |
            //  400 |                           ''A,,                 |
            //      |                            '   ''·,,            |
            //  300 |              3           ,'         ''·,,       |
            //      |                         ,                ''·,,  |
            //  200 |                        ·                      ''C
            //      |                       '                         |
            //  100 |                     ,'           2              |
            //      |                    ,                            |
            //    0 W-------------------D-----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 900, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 700), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 900, 1000), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 0, 700), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 0, 1000), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in X-B-A-C is at ~(861, 575) (using quadrilateral formula)
            ClassicAssert.AreEqual(861.40, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(575.44, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-D-Y is at ~(717, 150) (using quadrilateral formula)
            ClassicAssert.AreEqual(716.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-E-W-D is at ~(237, 302) (using quadrilateral formula)
            ClassicAssert.AreEqual(236.78, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(302.30, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-Z-E-A is at ~(425, 775) (using quadrilateral formula)
            ClassicAssert.AreEqual(425.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(775.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 W----------------------------------E--------------Z
            //      |                                 '               |
            //  900 |                               ,'                |
            //      |                              ,                  |
            //  800 |                             ·                   |
            //      |                            '                    |
            //  700 |              3           ,'                     |
            //      |                         ,                       |
            //  600 D,,                      ·                        |
            //      |  ''·,,                '                         |
            //  500 |       ''·,,         ,'           4              |
            //      |            ''·,,   ,                            |
            //  400 |                 ''A,,                           |
            //      |                  '   ''·,,                      |
            //  300 |    2           ,'         ''·,,                 |
            //      |               ,                ''·,,            |
            //  200 |              ·                      ''·,,       |
            //      |             '                            ''·,,  |
            //  100 |           ,'           1                      ''B
            //      |          ,                                      |
            //    0 Y---------C---------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 100), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 700, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 100), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 700, 1000), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 1000), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in B-A-C-X is at ~(575, 139) (using quadrilateral formula)
            ClassicAssert.AreEqual(575.44, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(138.60, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-D-Y-C is at ~(150, 283) (using quadrilateral formula)
            ClassicAssert.AreEqual(150.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(283.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-W-D-A is at ~(302, 763) (using quadrilateral formula)
            ClassicAssert.AreEqual(302.30, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(763.22, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in Z-E-A-B is at ~(775, 575) (using quadrilateral formula)
            ClassicAssert.AreEqual(775.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(575.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 Y-----------------------------D-------------------W
            //      |                            '                    |
            //  900 |              2           ,'                     |
            //      |                         ,                       |
            //  800 C,,                      ·                        |
            //      |  ''·,,                '                         |
            //  700 |       ''·,,         ,'           3              |
            //      |            ''·,,   ,                            |
            //  600 |                 ''A,,                           |
            //      |                  '   ''·,,                      |
            //  500 |    1           ,'         ''·,,                 |
            //      |               ,                ''·,,            |
            //  400 |              ·                      ''·,,       |
            //      |             '                            ''·,,  |
            //  300 |           ,'           4                      ''E
            //      |          ,                                      |
            //  200 |         ·                                       |
            //      |        '                                        |
            //  100 |      ,'                                         |
            //      |     ,                                           |
            //    0 X----B--------------------------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 100, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 300), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 100, 0), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 1000, 300), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in A-C-X-B is at ~(139, 425) (using quadrilateral formula)
            ClassicAssert.AreEqual(138.60, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(424.56, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-Y-C-A is at ~(283, 850) (using quadrilateral formula)
            ClassicAssert.AreEqual(283.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-D-A-E is at ~(763, 698) (using quadrilateral formula)
            ClassicAssert.AreEqual(763.22, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(697.70, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in E-A-B-Z is at ~(575, 225) (using quadrilateral formula)
            ClassicAssert.AreEqual(575.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(225.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 X---------------------------------------C---------Y
            //      |                                      '          |
            //  900 B,,                      1           ,'           |
            //      |  ''·,,                            ,             |
            //  800 |       ''·,,                      ·              |
            //      |            ''·,,                '               |
            //  700 |                 ''·,,         ,'           2    |
            //      |                      ''·,,   ,                  |
            //  600 |                           ''A,,                 |
            //      |                            '   ''·,,            |
            //  500 |              4           ,'         ''·,,       |
            //      |                         ,                ''·,,  |
            //  400 |                        ·                      ''D
            //      |                       '                         |
            //  300 |                     ,'           3              |
            //      |                    ,                            |
            //  200 |                   ·                             |
            //      |                  '                              |
            //  100 |                ,'                               |
            //      |               ,                                 |
            //    0 Z--------------E----------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 900), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 400), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 900), "Expected: site #4 has B"); // #4 has B
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has E"); // #4 has E
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has Z"); // #4 has Z

            // Assert

            // Centroid of #1 in C-X-B-A is at ~(425, 861) (using quadrilateral formula)
            ClassicAssert.AreEqual(424.56, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(861.40, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-C-A-D is at ~(850, 717) (using quadrilateral formula)
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(716.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-A-E-W is at ~(698, 237) (using quadrilateral formula)
            ClassicAssert.AreEqual(697.70, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(236.78, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-B-Z-E is at ~(225, 425) (using quadrilateral formula)
            ClassicAssert.AreEqual(225.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(425.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 W---------C#---------------------------#D---------Z
            //      |           ',                       ,'           |
            //  900 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  800 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  700 |              2        'B'        5              |
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 E------------------------A------------------------F
            //      |                        |                        |
            //  300 |                        |                        |
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              3         |         4              |
            //      |                        |                        |
            //    0 X------------------------G------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 400), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 400), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 400), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 500, 0), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has Y"); // #4 has Y
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 5 == sites[4].Points.Count(), "Expected: site #5 point count 5"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 400), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 500, 700), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 800, 1000), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 1000, 400), "Expected: site #5 has F"); // #5 has F
            Assume.That(() => HasPoint(sites[4].Points, 1000, 1000), "Expected: site #5 has Z"); // #5 has Z

            // Assert

            // Centroid of #1 in D-C-B is at ~(500, 900) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-W-E-A is at ~(224, 665) (using generic closed polygon formula)
            ClassicAssert.AreEqual(223.53, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(664.71, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-E-X-G is at ~(250, 200) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in F-A-G-Y is at ~(750, 200) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in Z-D-B-A-F is at ~(776, 665) (using generic closed polygon formula)
            ClassicAssert.AreEqual(776.47, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(664.71, sites[4].Centroid.Y, 0.01);
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

            // 1000 X-------------------E-----------------------------W
            //      |                   |                             |
            //  900 |                   |                             |
            //      |                   |                             |
            //  800 |                   |                            ,C
            //      |                   |                          ,' |
            //  700 |    3              |              2        ,·'   |
            //      |                   |                     ,'      |
            //  600 |                   |                  ,·'        |
            //      |                   |                ,'           |
            //  500 G-------------------A--------------B#        1    |
            //      |                   |                ',           |
            //  400 |                   |                  '·,        |
            //      |                   |                     ',      |
            //  300 |    4              |              5        '·,   |
            //      |                   |                          ', |
            //  200 |                   |                            'D
            //      |                   |                             |
            //  100 |                   |                             |
            //      |                   |                             |
            //    0 Y-------------------F-----------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 400, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 400, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 400, 0), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 0, 500), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has Y"); // #4 has Y
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 5 == sites[4].Points.Count(), "Expected: site #5 point count 5"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 400, 500), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 700, 500), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 1000, 200), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 400, 0), "Expected: site #5 has F"); // #5 has F
            Assume.That(() => HasPoint(sites[4].Points, 1000, 0), "Expected: site #5 has Z"); // #5 has Z

            // Assert

            // Centroid of #1 in C-B-D is at ~(900, 500) (using triangle formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-W-E-A-B is at ~(665, 776) (using generic closed polygon formula)
            ClassicAssert.AreEqual(664.71, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(776.47, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in E-X-G-A is at ~(200, 750) (using rectangle formula)
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-G-Y-F is at ~(200, 250) (using rectangle formula)
            ClassicAssert.AreEqual(200.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in B-A-F-Z-D is at ~(665, 224) (using generic closed polygon formula)
            ClassicAssert.AreEqual(664.71, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(223.53, sites[4].Centroid.Y, 0.01);
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

            // 1000 Y------------------------G------------------------X
            //      |                        |                        |
            //  900 |              4         |         3              |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 |                        |                        |
            //      |                        |                        |
            //  600 F------------------------A------------------------E
            //      |                        |                        |
            //  500 |                        |                        |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 |              5        ,B,        2              |
            //      |                     ,'   ',                     |
            //  200 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  100 |             ,·'        1        '·,             |
            //      |           ,'                       ',           |
            //    0 Z---------D#---------------------------#C---------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 300), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 300), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 600), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 600), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 500, 1000), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 0, 1000), "Expected: site #4 has Y"); // #4 has Y
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 5 == sites[4].Points.Count(), "Expected: site #5 point count 5"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 600), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 500, 300), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 200, 0), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 0, 600), "Expected: site #5 has F"); // #5 has F
            Assume.That(() => HasPoint(sites[4].Points, 0, 0), "Expected: site #5 has Z"); // #5 has Z

            // Assert

            // Centroid of #1 in B-D-C is at ~(500, 100) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in E-A-B-C-W is at ~(776, 335) (using generic closed polygon formula)
            ClassicAssert.AreEqual(776.47, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(335.29, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in X-G-A-E is at ~(750, 800) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in G-Y-F-A is at ~(250, 800) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in B-A-F-Z-D is at ~(224, 335) (using generic closed polygon formula)
            ClassicAssert.AreEqual(223.53, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(335.29, sites[4].Centroid.Y, 0.01);
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

            // 1000 Z-----------------------------F-------------------Y
            //      |                             |                   |
            //  900 |                             |                   |
            //      |                             |                   |
            //  800 D,                            |                   |
            //      | ',                          |                   |
            //  700 |   '·,        5              |              4    |
            //      |      ',                     |                   |
            //  600 |        '·,                  |                   |
            //      |           ',                |                   |
            //  500 |    1        #B--------------A-------------------G
            //      |           ,'                |                   |
            //  400 |        ,·'                  |                   |
            //      |      ,'                     |                   |
            //  300 |   ,·'        2              |              3    |
            //      | ,'                          |                   |
            //  200 C'                            |                   |
            //      |                             |                   |
            //  100 |                             |                   |
            //      |                             |                   |
            //    0 W-----------------------------E-------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 5 == sites[1].Points.Count(), "Expected: site #2 point count 5"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has E"); // #2 has E
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has W"); // #2 has W
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 600, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 600, 1000), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 1000, 1000), "Expected: site #4 has Y"); // #4 has Y
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 5 == sites[4].Points.Count(), "Expected: site #5 point count 5"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 600, 500), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 300, 500), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 0, 800), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 600, 1000), "Expected: site #5 has F"); // #5 has F
            Assume.That(() => HasPoint(sites[4].Points, 0, 1000), "Expected: site #5 has Z"); // #5 has Z

            // Assert

            // Centroid of #1 in B-D-C is at ~(100, 500) (using triangle formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C-W-E is at ~(335, 224) (using generic closed polygon formula)
            ClassicAssert.AreEqual(335.29, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(223.53, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in G-A-E-X is at ~(800, 250) (using rectangle formula)
            ClassicAssert.AreEqual(800.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in Y-F-A-G is at ~(800, 750) (using rectangle formula)
            ClassicAssert.AreEqual(800.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in F-Z-D-B-A is at ~(335, 776) (using generic closed polygon formula)
            ClassicAssert.AreEqual(335.29, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(776.47, sites[4].Centroid.Y, 0.01);
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

            // 1000 C#-----------------------------------------------#D
            //      | ',                                           ,' |
            //  900 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  800 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  700 |             '·,        1        ,·'             |
            //      |                ',             ,'                |
            //  600 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //  500 |              2        'B'        5              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 E------------------------A------------------------F
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              3         |         4              |
            //      |                        |                        |
            //    0 X------------------------G------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

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
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 300), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 300), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 300), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 300), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 500, 0), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 1000, 0), "Expected: site #4 has Y"); // #4 has Y
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
            // Centroid of #3 in A-E-X-G is at ~(250, 150) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in F-A-G-Y is at ~(750, 150) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 X--------------E---------------------------------#C
            //      |              |                               ,' |
            //  900 |              |                            ,·'   |
            //      |              |                          ,'      |
            //  800 |              |                       ,·'        |
            //      |              |                     ,'           |
            //  700 |    3         |         2        ,·'             |
            //      |              |                ,'                |
            //  600 |              |             ,·'                  |
            //      |              |           ,'                     |
            //  500 G--------------A---------B#        1              |
            //      |              |           ',                     |
            //  400 |              |             '·,                  |
            //      |              |                ',                |
            //  300 |    4         |         5        '·,             |
            //      |              |                     ',           |
            //  200 |              |                       '·,        |
            //      |              |                          ',      |
            //  100 |              |                            '·,   |
            //      |              |                               ', |
            //    0 Y--------------F---------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

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
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 300, 1000), "Expected: site #3 has E"); // #3 has E
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has G"); // #3 has G
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has X"); // #3 has X
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 4 == sites[3].Points.Count(), "Expected: site #4 point count 4"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 300, 500), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has F"); // #4 has F
            Assume.That(() => HasPoint(sites[3].Points, 0, 500), "Expected: site #4 has G"); // #4 has G
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has Y"); // #4 has Y
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
            // Centroid of #3 in E-X-G-A is at ~(150, 750) (using rectangle formula)
            ClassicAssert.AreEqual(150.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-G-Y-F is at ~(150, 250) (using rectangle formula)
            ClassicAssert.AreEqual(150.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[3].Centroid.Y, 0.01);
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

            // 1000 W------------------------H------------------------Z
            //      |                        |                        |
            //  900 |              1         |         2              |
            //      |                        |                        |
            //  800 |                        |                        |
            //      |                        |                        |
            //  700 C------------------------B------------------------G
            //      |                        |                        |
            //  600 |                        |                        |
            //      |                        |                        |
            //  500 |              3         |         4              |
            //      |                        |                        |
            //  400 |                        |                        |
            //      |                        |                        |
            //  300 D------------------------A------------------------F
            //      |                        |                        |
            //  200 |                        |                        |
            //      |                        |                        |
            //  100 |              5         |         6              |
            //      |                        |                        |
            //    0 X------------------------E------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has H"); // #1 has H
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has G"); // #2 has G
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has H"); // #2 has H
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z
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
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 300), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 0, 300), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 500, 0), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 0, 0), "Expected: site #5 has X"); // #5 has X
            Assume.That(() => null != sites[5].Points);
            Assume.That(() => 4 == sites[5].Points.Count(), "Expected: site #6 point count 4"); // #6
            Assume.That(() => HasPoint(sites[5].Points, 500, 300), "Expected: site #6 has A"); // #6 has A
            Assume.That(() => HasPoint(sites[5].Points, 500, 0), "Expected: site #6 has E"); // #6 has E
            Assume.That(() => HasPoint(sites[5].Points, 1000, 300), "Expected: site #6 has F"); // #6 has F
            Assume.That(() => HasPoint(sites[5].Points, 1000, 0), "Expected: site #6 has Y"); // #6 has Y

            // Assert

            // Centroid of #1 in H-W-C-B is at ~(250, 850) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-H-B-G is at ~(750, 850) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-C-D-A is at ~(250, 500) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in G-B-A-F is at ~(750, 500) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in A-D-X-E is at ~(250, 150) (using rectangle formula)
            ClassicAssert.AreEqual(250.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[4].Centroid.Y, 0.01);
            // Centroid of #6 in F-A-E-Y is at ~(750, 150) (using rectangle formula)
            ClassicAssert.AreEqual(750.00, sites[5].Centroid.X, 0.01);
            ClassicAssert.AreEqual(150.00, sites[5].Centroid.Y, 0.01);
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

            // 1000 X--------------D-------------------C--------------W
            //      |              |                   |              |
            //  900 |              |                   |              |
            //      |              |                   |              |
            //  800 |              |                   |              |
            //      |              |                   |              |
            //  700 |    5         |         3         |         1    |
            //      |              |                   |              |
            //  600 |              |                   |              |
            //      |              |                   |              |
            //  500 E--------------A-------------------B--------------H
            //      |              |                   |              |
            //  400 |              |                   |              |
            //      |              |                   |              |
            //  300 |    6         |         4         |         2    |
            //      |              |                   |              |
            //  200 |              |                   |              |
            //      |              |                   |              |
            //  100 |              |                   |              |
            //      |              |                   |              |
            //    0 Y--------------F-------------------G--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has H"); // #1 has H
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has W"); // #1 has W
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has G"); // #2 has G
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has H"); // #2 has H
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z
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
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 300, 500), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 300, 1000), "Expected: site #5 has D"); // #5 has D
            Assume.That(() => HasPoint(sites[4].Points, 0, 500), "Expected: site #5 has E"); // #5 has E
            Assume.That(() => HasPoint(sites[4].Points, 0, 1000), "Expected: site #5 has X"); // #5 has X
            Assume.That(() => null != sites[5].Points);
            Assume.That(() => 4 == sites[5].Points.Count(), "Expected: site #6 point count 4"); // #6
            Assume.That(() => HasPoint(sites[5].Points, 300, 500), "Expected: site #6 has A"); // #6 has A
            Assume.That(() => HasPoint(sites[5].Points, 0, 500), "Expected: site #6 has E"); // #6 has E
            Assume.That(() => HasPoint(sites[5].Points, 300, 0), "Expected: site #6 has F"); // #6 has F
            Assume.That(() => HasPoint(sites[5].Points, 0, 0), "Expected: site #6 has Y"); // #6 has Y

            // Assert

            // Centroid of #1 in W-C-B-H is at ~(850, 750) (using rectangle formula)
            ClassicAssert.AreEqual(850.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in H-B-G-Z is at ~(850, 250) (using rectangle formula)
            ClassicAssert.AreEqual(850.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-D-A-B is at ~(500, 750) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in B-A-F-G is at ~(500, 250) (using rectangle formula)
            ClassicAssert.AreEqual(500.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[3].Centroid.Y, 0.01);
            // Centroid of #5 in D-X-E-A is at ~(150, 750) (using rectangle formula)
            ClassicAssert.AreEqual(150.00, sites[4].Centroid.X, 0.01);
            ClassicAssert.AreEqual(750.00, sites[4].Centroid.Y, 0.01);
            // Centroid of #6 in A-E-Y-F is at ~(150, 250) (using rectangle formula)
            ClassicAssert.AreEqual(150.00, sites[5].Centroid.X, 0.01);
            ClassicAssert.AreEqual(250.00, sites[5].Centroid.Y, 0.01);
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

            // 1000 1-----------------------#A#-----------------------4
            //      |                     ,'   ',                     |
            //  900 |                  ,·'       '·,                  |
            //      |                ,'             ',                |
            //  800 |             ,·'                 '·,             |
            //      |           ,'                       ',           |
            //  700 |        ,·'                           '·,        |
            //      |      ,'                                 ',      |
            //  600 |   ,·'                                     '·,   |
            //      | ,'                                           ', |
            //  500 B#                       5                       #D
            //      | ',                                           ,' |
            //  400 |   '·,                                     ,·'   |
            //      |      ',                                 ,'      |
            //  300 |        '·,                           ,·'        |
            //      |           ',                       ,'           |
            //  200 |             '·,                 ,·'             |
            //      |                ',             ,'                |
            //  100 |                  '·,       ,·'                  |
            //      |                     ',   ,'                     |
            //    0 2-----------------------#C#-----------------------3
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => null != sites[3].Points);
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 500, 1000), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 1000, 500), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 1000, 1000), "Expected: site #4 has Z"); // #4 has Z
            Assume.That(() => null != sites[4].Points);
            Assume.That(() => 4 == sites[4].Points.Count(), "Expected: site #5 point count 4"); // #5
            Assume.That(() => HasPoint(sites[4].Points, 500, 1000), "Expected: site #5 has A"); // #5 has A
            Assume.That(() => HasPoint(sites[4].Points, 0, 500), "Expected: site #5 has B"); // #5 has B
            Assume.That(() => HasPoint(sites[4].Points, 500, 0), "Expected: site #5 has C"); // #5 has C
            Assume.That(() => HasPoint(sites[4].Points, 1000, 500), "Expected: site #5 has D"); // #5 has D

            // Assert

            // Centroid of #1 in X-B-A is at ~(167, 833) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-C-B is at ~(167, 167) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-D-C is at ~(833, 167) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in Z-A-D is at ~(833, 833) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[3].Centroid.Y, 0.01);
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

            // 1000 X-----------------------------------------------##B
            //      |                                          ,,·''  |
            //  900 |              1                      ,,·''       |
            //      |                                ,,·''            |
            //  800 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  700 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  600 |       ,,·''                                     |
            //      |  ,,·''                                          |
            //  500 A##                      3                        |
            //      |  ''·,,                                          |
            //  400 |       ''·,,                                     |
            //      |            ''·,,                                |
            //  300 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  200 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  100 |              2                      ''·,,       |
            //      |                                          ''·,,  |
            //    0 Y-----------------------------------------------##C
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in B-X-A is at ~(333, 833) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-C is at ~(333, 167) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[1].Centroid.Y, 0.01);
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

            // 1000 Y------------------------A------------------------X
            //      |                       ' '                       |
            //  900 |                     ,'   ',                     |
            //      |                    ,       ,                    |
            //  800 |                   ·         ·                   |
            //      |                  '           '                  |
            //  700 |    2           ,'             ',           1    |
            //      |               ,                 ,               |
            //  600 |              ·                   ·              |
            //      |             '                     '             |
            //  500 |           ,'           3           ',           |
            //      |          ,                           ,          |
            //  400 |         ·                             ·         |
            //      |        '                               '        |
            //  300 |      ,'                                 ',      |
            //      |     ,                                     ,     |
            //  200 |    ·                                       ·    |
            //      |   '                                         '   |
            //  100 | ,'                                           ', |
            //      |,                                               ,|
            //    0 C-------------------------------------------------B
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in X-A-B is at ~(833, 667) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-C is at ~(167, 667) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
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

            // 1000 C##-----------------------------------------------Y
            //      |  ''·,,                                          |
            //  900 |       ''·,,                      2              |
            //      |            ''·,,                                |
            //  800 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  700 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  600 |                                     ''·,,       |
            //      |                                          ''·,,  |
            //  500 |                        3                      ##A
            //      |                                          ,,·''  |
            //  400 |                                     ,,·''       |
            //      |                                ,,·''            |
            //  300 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  200 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  100 |       ,,·''                      1              |
            //      |  ,,·''                                          |
            //    0 B##-----------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in A-B-X is at ~(667, 167) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-C-A is at ~(667, 833) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 B-------------------------------------------------C
            //      |'                                               '|
            //  900 | ',                                           ,' |
            //      |   ,                                         ,   |
            //  800 |    ·                                       ·    |
            //      |     '                                     '     |
            //  700 |      ',                                 ,'      |
            //      |        ,                               ,        |
            //  600 |         ·                             ·         |
            //      |          '                           '          |
            //  500 |           ',           3           ,'           |
            //      |             ,                     ,             |
            //  400 |              ·                   ·              |
            //      |               '                 '               |
            //  300 |    1           ',             ,'           2    |
            //      |                  ,           ,                  |
            //  200 |                   ·         ·                   |
            //      |                    '       '                    |
            //  100 |                     ',   ,'                     |
            //      |                       , ,                       |
            //    0 X------------------------A------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has C"); // #3 has C

            // Assert

            // Centroid of #1 in B-X-A is at ~(167, 333) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-Y is at ~(833, 333) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
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

            // 1000 X-------------------------------------##B---------W
            //      |                                ,,·''            |
            //  900 |    1                      ,,·''                 |
            //      |                      ,,·''                      |
            //  800 |                 ,,·''                           |
            //      |            ,,·''                                |
            //  700 |       ,,·''                                     |
            //      |  ,,·''                                          |
            //  600 A''                                               |
            //      |                                                 |
            //  500 |              3                                  |
            //      |                                                 |
            //  400 D,,                                               |
            //      |  ''·,,                                          |
            //  300 |       ''·,,                                     |
            //      |            ''·,,                                |
            //  200 |                 ''·,,                           |
            //      |                      ''·,,                      |
            //  100 |    2                      ''·,,                 |
            //      |                                ''·,,            |
            //    0 Y-------------------------------------##C---------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 6 == sites[2].Points.Count(), "Expected: site #3 point count 6"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 800, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 800, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in B-X-A is at ~(267, 867) (using triangle formula)
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(866.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-Y-C is at ~(267, 133) (using triangle formula)
            ClassicAssert.AreEqual(266.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(133.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-B-A-D-C-Z is at ~(610, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(609.80, sites[2].Centroid.X, 0.01);
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

            // 1000 Y-------------------D---------A-------------------X
            //      |                  '           '                  |
            //  900 |    2           ,'             ',           1    |
            //      |               ,                 ,               |
            //  800 |              ·                   ·              |
            //      |             '                     '             |
            //  700 |           ,'           3           ',           |
            //      |          ,                           ,          |
            //  600 |         ·                             ·         |
            //      |        '                               '        |
            //  500 |      ,'                                 ',      |
            //      |     ,                                     ,     |
            //  400 |    ·                                       ·    |
            //      |   '                                         '   |
            //  300 | ,'                                           ', |
            //      |,                                               ,|
            //  200 C                                                 B
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Z-------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 6 == sites[2].Points.Count(), "Expected: site #3 point count 6"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 200), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in X-A-B is at ~(867, 733) (using triangle formula)
            ClassicAssert.AreEqual(866.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-Y-C is at ~(133, 733) (using triangle formula)
            ClassicAssert.AreEqual(133.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-C-Z-W-B is at ~(500, 390) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(390.20, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z---------C##-------------------------------------Y
            //      |            ''·,,                                |
            //  900 |                 ''·,,                      2    |
            //      |                      ''·,,                      |
            //  800 |                           ''·,,                 |
            //      |                                ''·,,            |
            //  700 |                                     ''·,,       |
            //      |                                          ''·,,  |
            //  600 |                                               ''D
            //      |                                                 |
            //  500 |                                  3              |
            //      |                                                 |
            //  400 |                                               ,,A
            //      |                                          ,,·''  |
            //  300 |                                     ,,·''       |
            //      |                                ,,·''            |
            //  200 |                           ,,·''                 |
            //      |                      ,,·''                      |
            //  100 |                 ,,·''                      1    |
            //      |            ,,·''                                |
            //    0 W---------B##-------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 6 == sites[2].Points.Count(), "Expected: site #3 point count 6"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 400), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 200, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in A-B-X is at ~(733, 133) (using triangle formula)
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(133.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Y-C-D is at ~(733, 867) (using triangle formula)
            ClassicAssert.AreEqual(733.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(866.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-C-Z-W-B-A is at ~(390, 500) (using generic closed polygon formula)
            ClassicAssert.AreEqual(390.20, sites[2].Centroid.X, 0.01);
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

            // 1000 W-------------------------------------------------Z
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 B                                                 C
            //      |'                                               '|
            //  700 | ',                                           ,' |
            //      |   ,                                         ,   |
            //  600 |    ·                                       ·    |
            //      |     '                                     '     |
            //  500 |      ',                                 ,'      |
            //      |        ,                               ,        |
            //  400 |         ·                             ·         |
            //      |          '                           '          |
            //  300 |           ',           3           ,'           |
            //      |             ,                     ,             |
            //  200 |              ·                   ·              |
            //      |               '                 '               |
            //  100 |    1           ',             ,'           2    |
            //      |                  ,           ,                  |
            //    0 X-------------------A---------D-------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 400, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 3 == sites[1].Points.Count(), "Expected: site #2 point count 3"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 6 == sites[2].Points.Count(), "Expected: site #3 point count 6"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 800), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1000, 800), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has Z"); // #3 has Z

            // Assert

            // Centroid of #1 in B-X-A is at ~(133, 267) (using triangle formula)
            ClassicAssert.AreEqual(133.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-D-Y is at ~(867, 267) (using triangle formula)
            ClassicAssert.AreEqual(866.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-Z-W-B-A-D is at ~(500, 610) (using generic closed polygon formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(609.80, sites[2].Centroid.Y, 0.01);
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

            // 1200 X-----------------------------------------------------------Z
            //      |                                                           |
            // 1100 |                                                           |
            //      |                                                           |
            // 1000 |                                                        ,,,C
            //      |                                                ,,,··'''   |
            //  900 |                   2                     ,,,·'''           |
            //      |                                 ,,,··'''                  |
            //  800 |                          ,,,·'''                          |
            //      |                  ,,,··'''                                 |
            //  700 |           ,,,·'''                                         |
            //      |   ,,,··'''                                                |
            //  600 A###                     1                                  |
            //      |   '''··,,,                                                |
            //  500 |           '''·,,,                                         |
            //      |                  '''··,,,                                 |
            //  400 |                          '''·,,,                          |
            //      |                                 '''··,,,                  |
            //  300 |                   3                     '''·,,,           |
            //      |                                                '''··,,,   |
            //  200 |                                                        '''B
            //      |                                                           |
            //  100 |                                                           |
            //      |                                                           |
            //    0 Y-----------------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1200, 200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1200, 1000), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1200), "Expected: site #2 has X"); // #2 has X
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1200), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1200, 200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1200, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in C-A-B is at ~(800, 600) (using triangle formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Z-X-A is at ~(500, 983) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(983.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-Y-W-B is at ~(500, 217) (using quadrilateral formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(216.67, sites[2].Centroid.Y, 0.01);
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

            // 1200 Y-----------------------------A-----------------------------X
            //      |                            · ·                            |
            // 1100 |                           ·   ·                           |
            //      |                          ·     ·                          |
            // 1000 |                          ·     ·                          |
            //      |                         ·       ·                         |
            //  900 |                        ·         ·                        |
            //      |                       ·           ·                       |
            //  800 |              3       ·             ·       2              |
            //      |                     ·               ·                     |
            //  700 |                     ·       1       ·                     |
            //      |                    ·                 ·                    |
            //  600 |                   ·                   ·                   |
            //      |                  ·                     ·                  |
            //  500 |                 ·                       ·                 |
            //      |                ·                         ·                |
            //  400 |                ·                         ·                |
            //      |               ·                           ·               |
            //  300 |              ·                             ·              |
            //      |             ·                               ·             |
            //  200 |            ·                                 ·            |
            //      |           ·                                   ·           |
            //  100 |           ·                                   ·           |
            //      |          ·                                     ·          |
            //    0 W---------B---------------------------------------C---------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 1200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 1200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1200), "Expected: site #2 has X"); // #2 has X
            Assume.That(() => HasPoint(sites[1].Points, 1200, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 1200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 1200), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in A-B-C is at ~(600, 400) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in X-A-C-Z is at ~(983, 700) (using quadrilateral formula)
            ClassicAssert.AreEqual(983.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-Y-W-B is at ~(217, 700) (using quadrilateral formula)
            ClassicAssert.AreEqual(216.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(700.00, sites[2].Centroid.Y, 0.01);
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

            // 1200 W-----------------------------------------------------------Y
            //      |                                                           |
            // 1100 |                                                           |
            //      |                                                           |
            // 1000 B,,,                                                        |
            //      |   '''··,,,                                                |
            //  900 |           '''·,,,                     3                   |
            //      |                  '''··,,,                                 |
            //  800 |                          '''·,,,                          |
            //      |                                 '''··,,,                  |
            //  700 |                                         '''·,,,           |
            //      |                                                '''··,,,   |
            //  600 |                                  1                     ###A
            //      |                                                ,,,··'''   |
            //  500 |                                         ,,,·'''           |
            //      |                                 ,,,··'''                  |
            //  400 |                          ,,,·'''                          |
            //      |                  ,,,··'''                                 |
            //  300 |           ,,,·'''                     2                   |
            //      |   ,,,··'''                                                |
            //  200 C'''                                                        |
            //      |                                                           |
            //  100 |                                                           |
            //      |                                                           |
            //    0 Z-----------------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1200, 600), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1200, 600), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1200, 0), "Expected: site #2 has X"); // #2 has X
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1200, 600), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 1200), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1200, 1200), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in A-B-C is at ~(400, 600) (using triangle formula)
            ClassicAssert.AreEqual(400.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Z-X is at ~(700, 217) (using quadrilateral formula)
            ClassicAssert.AreEqual(700.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(216.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in Y-W-B-A is at ~(700, 983) (using quadrilateral formula)
            ClassicAssert.AreEqual(700.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(983.33, sites[2].Centroid.Y, 0.01);
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

            // 1200 Z---------C---------------------------------------B---------W
            //      |          ·                                     ·          |
            // 1100 |           ·                                   ·           |
            //      |           ·                                   ·           |
            // 1000 |            ·                                 ·            |
            //      |             ·                               ·             |
            //  900 |              ·                             ·              |
            //      |               ·                           ·               |
            //  800 |                ·                         ·                |
            //      |                ·                         ·                |
            //  700 |                 ·                       ·                 |
            //      |                  ·                     ·                  |
            //  600 |                   ·                   ·                   |
            //      |                    ·                 ·                    |
            //  500 |                     ·       1       ·                     |
            //      |                     ·               ·                     |
            //  400 |              2       ·             ·       3              |
            //      |                       ·           ·                       |
            //  300 |                        ·         ·                        |
            //      |                         ·       ·                         |
            //  200 |                          ·     ·                          |
            //      |                          ·     ·                          |
            //  100 |                           ·   ·                           |
            //      |                            · ·                            |
            //    0 X-----------------------------A-----------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 200, 1200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 200, 1200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has X"); // #2 has X
            Assume.That(() => HasPoint(sites[1].Points, 0, 1200), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1200, 1200), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1200, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in B-C-A is at ~(600, 800) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Z-X-A is at ~(217, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(216.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-B-A-Y is at ~(983, 500) (using quadrilateral formula)
            ClassicAssert.AreEqual(983.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
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

            // 1200 X-----------------------------------------------------------Z
            //      |                                                           |
            // 1100 |                                                        ,,,B
            //      |                                                ,,,··'''   |
            // 1000 |                                         ,,,·'''           |
            //      |                                 ,,,··'''                  |
            //  900 |    2                     ,,,·'''                          |
            //      |                  ,,,··'''                                 |
            //  800 |           ,,,·'''                                         |
            //      |   ,,,··'''                                                |
            //  700 A'''                                                        |
            //      |                                                           |
            //  600 |         1                                                 |
            //      |                                                           |
            //  500 D,,,                                                        |
            //      |   '''··,,,                                                |
            //  400 |           '''·,,,                                         |
            //      |                  '''··,,,                                 |
            //  300 |    3                     '''·,,,                          |
            //      |                                 '''··,,,                  |
            //  200 |                                         '''·,,,           |
            //      |                                                '''··,,,   |
            //  100 |                                                        '''C
            //      |                                                           |
            //    0 Y-----------------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1200, 1100), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1200, 100), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1100), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 1200), "Expected: site #2 has X"); // #2 has X
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1200), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1200, 100), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1200, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in B-A-D-C is at ~(733, 600) (using quadrilateral formula)
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Z-X-A is at ~(467, 1028) (using quadrilateral formula)
            ClassicAssert.AreEqual(466.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1027.78, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-Y-W-C is at ~(467, 172) (using quadrilateral formula)
            ClassicAssert.AreEqual(466.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(172.22, sites[2].Centroid.Y, 0.01);
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

            // 1200 Y------------------------D---------A------------------------X
            //      |                       ·           ·                       |
            // 1100 |              3       ·             ·       2              |
            //      |                      ·              ·                     |
            // 1000 |                     ·       1       ·                     |
            //      |                    ·                 ·                    |
            //  900 |                   ·                   ·                   |
            //      |                  ·                     ·                  |
            //  800 |                 ·                       ·                 |
            //      |                 ·                        ·                |
            //  700 |                ·                         ·                |
            //      |               ·                           ·               |
            //  600 |              ·                             ·              |
            //      |             ·                               ·             |
            //  500 |            ·                                 ·            |
            //      |            ·                                  ·           |
            //  400 |           ·                                   ·           |
            //      |          ·                                     ·          |
            //  300 |         ·                                       ·         |
            //      |        ·                                         ·        |
            //  200 |       ·                                           ·       |
            //      |       ·                                            ·      |
            //  100 |      ·                                             ·      |
            //      |     ·                                               ·     |
            //    0 W----C-------------------------------------------------B----Z
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 700, 1200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1100, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 100, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 500, 1200), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 700, 1200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1100, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1200), "Expected: site #2 has X"); // #2 has X
            Assume.That(() => HasPoint(sites[1].Points, 1200, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 100, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 500, 1200), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 0, 1200), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in A-D-C-B is at ~(600, 467) (using quadrilateral formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in X-A-B-Z is at ~(1028, 733) (using quadrilateral formula)
            ClassicAssert.AreEqual(1027.78, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-Y-W-C is at ~(172, 733) (using quadrilateral formula)
            ClassicAssert.AreEqual(172.22, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.Y, 0.01);
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

            // 1200 W-----------------------------------------------------------Y
            //      |                                                           |
            // 1100 C,,,                                                        |
            //      |   '''··,,,                                                |
            // 1000 |           '''·,,,                                         |
            //      |                  '''··,,,                                 |
            //  900 |                          '''·,,,                     3    |
            //      |                                 '''··,,,                  |
            //  800 |                                         '''·,,,           |
            //      |                                                '''··,,,   |
            //  700 |                                                        '''D
            //      |                                                           |
            //  600 |                                                 1         |
            //      |                                                           |
            //  500 |                                                        ,,,A
            //      |                                                ,,,··'''   |
            //  400 |                                         ,,,·'''           |
            //      |                                 ,,,··'''                  |
            //  300 |                          ,,,·'''                     2    |
            //      |                  ,,,··'''                                 |
            //  200 |           ,,,·'''                                         |
            //      |   ,,,··'''                                                |
            //  100 B'''                                                        |
            //      |                                                           |
            //    0 Z-----------------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1200, 500), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 100), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1100), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1200, 700), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1200, 500), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 100), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1200, 0), "Expected: site #2 has X"); // #2 has X
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 1100), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1200, 700), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1200), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1200, 1200), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in D-C-B-A is at ~(467, 600) (using quadrilateral formula)
            ClassicAssert.AreEqual(466.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-Z-X is at ~(733, 172) (using quadrilateral formula)
            ClassicAssert.AreEqual(733.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(172.22, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in Y-W-C-D is at ~(733, 1028) (using quadrilateral formula)
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1027.78, sites[2].Centroid.Y, 0.01);
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

            // 1200 Z----B-------------------------------------------------C----W
            //      |     ·                                               ·     |
            // 1100 |      ·                                             ·      |
            //      |      ·                                            ·       |
            // 1000 |       ·                                           ·       |
            //      |        ·                                         ·        |
            //  900 |         ·                                       ·         |
            //      |          ·                                     ·          |
            //  800 |           ·                                   ·           |
            //      |           ·                                  ·            |
            //  700 |            ·                                 ·            |
            //      |             ·                               ·             |
            //  600 |              ·                             ·              |
            //      |               ·                           ·               |
            //  500 |                ·                         ·                |
            //      |                ·                        ·                 |
            //  400 |                 ·                       ·                 |
            //      |                  ·                     ·                  |
            //  300 |                   ·                   ·                   |
            //      |                    ·                 ·                    |
            //  200 |                     ·       1       ·                     |
            //      |                     ·              ·                      |
            //  100 |              2       ·             ·       3              |
            //      |                       ·           ·                       |
            //    0 X------------------------A---------D------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 100, 1200), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1100, 1200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 100, 1200), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has X"); // #2 has X
            Assume.That(() => HasPoint(sites[1].Points, 0, 1200), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1100, 1200), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 700, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1200, 1200), "Expected: site #3 has W"); // #3 has W
            Assume.That(() => HasPoint(sites[2].Points, 1200, 0), "Expected: site #3 has Y"); // #3 has Y

            // Assert

            // Centroid of #1 in C-B-A-D is at ~(600, 733) (using quadrilateral formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Z-X-A is at ~(172, 467) (using quadrilateral formula)
            ClassicAssert.AreEqual(172.22, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-C-D-Y is at ~(1028, 467) (using quadrilateral formula)
            ClassicAssert.AreEqual(1027.78, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(466.67, sites[2].Centroid.Y, 0.01);
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

            // 1000 X-----------------------------B-------------------Z
            //      |                            '                    |
            //  900 |              1           ,'                     |
            //      |                         ,                       |
            //  800 |                        ·                        |
            //      |                       '                         |
            //  700 |                     ,'           2              |
            //      |                    ,                            |
            //  600 |                   ·                           ,,C
            //      |                  '                       ,,·''  |
            //  500 |                ,'                   ,,·''       |
            //      |               ,                ,,·''            |
            //  400 |              ·            ,,·''                 |
            //      |             '        ,,·''                      |
            //  300 |           ,'    ,,·''                      3    |
            //      |          , ,,·''                                |
            //  200 |        ,A''                                     |
            //      |      ,'                                         |
            //  100 |   ,·'                                           |
            //      | ,'                                              |
            //    0 D#------------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in B-X-D-A is at ~(208, 635) (using quadrilateral formula)
            ClassicAssert.AreEqual(207.84, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(635.29, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-B-A-C is at ~(667, 667) (using quadrilateral formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A-D-W is at ~(635, 208) (using quadrilateral formula)
            ClassicAssert.AreEqual(635.29, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(207.84, sites[2].Centroid.Y, 0.01);
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

            // 1000 D#------------------------------------------------X
            //      | ',                                              |
            //  900 |   '·,                                           |
            //      |      ',                                         |
            //  800 |        'A,,                                     |
            //      |          ' ''·,,                                |
            //  700 |           ',    ''·,,                      1    |
            //      |             ,        ''·,,                      |
            //  600 |              ·            ''·,,                 |
            //      |               '                ''·,,            |
            //  500 |                ',                   ''·,,       |
            //      |                  ,                       ''·,,  |
            //  400 |                   ·                           ''B
            //      |                    '                            |
            //  300 |                     ',           2              |
            //      |                       ,                         |
            //  200 |                        ·                        |
            //      |                         '                       |
            //  100 |              3           ',                     |
            //      |                            ,                    |
            //    0 W-----------------------------C-------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 400), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 800), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in X-D-A-B is at ~(635, 792) (using quadrilateral formula)
            ClassicAssert.AreEqual(635.29, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(792.16, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C-Z is at ~(667, 333) (using quadrilateral formula)
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-W-C is at ~(208, 365) (using quadrilateral formula)
            ClassicAssert.AreEqual(207.84, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(364.71, sites[2].Centroid.Y, 0.01);
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

            // 1000 W------------------------------------------------#D
            //      |                                              ,' |
            //  900 |                                           ,·'   |
            //      |                                         ,'      |
            //  800 |                                     ,,A'        |
            //      |                                ,,·'' '          |
            //  700 |    3                      ,,·''    ,'           |
            //      |                      ,,·''        ,             |
            //  600 |                 ,,·''            ·              |
            //      |            ,,·''                '               |
            //  500 |       ,,·''                   ,'                |
            //      |  ,,·''                       ,                  |
            //  400 C''                           ·                   |
            //      |                            '                    |
            //  300 |              2           ,'                     |
            //      |                         ,                       |
            //  200 |                        ·                        |
            //      |                       '                         |
            //  100 |                     ,'           1              |
            //      |                    ,                            |
            //    0 Z-------------------B-----------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 400, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 800), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in D-A-B-X is at ~(792, 365) (using quadrilateral formula)
            ClassicAssert.AreEqual(792.16, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(364.71, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Z-B is at ~(333, 333) (using quadrilateral formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-W-C is at ~(365, 792) (using quadrilateral formula)
            ClassicAssert.AreEqual(364.71, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(792.16, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z-------------------C-----------------------------W
            //      |                    '                            |
            //  900 |                     ',           3              |
            //      |                       ,                         |
            //  800 |                        ·                        |
            //      |                         '                       |
            //  700 |              2           ',                     |
            //      |                            ,                    |
            //  600 B,,                           ·                   |
            //      |  ''·,,                       '                  |
            //  500 |       ''·,,                   ',                |
            //      |            ''·,,                ,               |
            //  400 |                 ''·,,            ·              |
            //      |                      ''·,,        '             |
            //  300 |    1                      ''·,,    ',           |
            //      |                                ''·,, ,          |
            //  200 |                                     ''A,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 X------------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has D"); // #1 has D
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 4 == sites[2].Points.Count(), "Expected: site #3 point count 4"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in B-X-D-A is at ~(365, 208) (using quadrilateral formula)
            ClassicAssert.AreEqual(364.71, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(207.84, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Z-B-A is at ~(333, 667) (using quadrilateral formula)
            ClassicAssert.AreEqual(333.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-C-A-D is at ~(792, 635) (using quadrilateral formula)
            ClassicAssert.AreEqual(792.16, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(635.29, sites[2].Centroid.Y, 0.01);
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

            // 1000 X------------------------B------------------------Z
            //      |                       '                         |
            //  900 |                     ,'                          |
            //      |                    ,                            |
            //  800 |                   ·                             |
            //      |                  '                              |
            //  700 |    1           ,'                               |
            //      |               ,                                 |
            //  600 |              ·                                  |
            //      |             '                                   |
            //  500 |           ,'           2                      ,,C
            //      |          ,                               ,,·''  |
            //  400 |         ·                           ,,·''       |
            //      |        '                       ,,·''            |
            //  300 |      ,'                   ,,·''                 |
            //      |     ,                ,,·''                      |
            //  200 |    ·            ,,·''                           |
            //      |   '        ,,·''                                |
            //  100 | ,'    ,,·''                      3              |
            //      |, ,,·''                                          |
            //    0 A##-----------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 500), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in B-X-A is at ~(167, 667) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Z-B-A is at ~(583, 583) (using quadrilateral formula)
            ClassicAssert.AreEqual(583.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(583.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A-W is at ~(667, 167) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[2].Centroid.Y, 0.01);
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

            // 1000 A##-----------------------------------------------X
            //      |' ''·,,                                          |
            //  900 | ',    ''·,,                      1              |
            //      |   ,        ''·,,                                |
            //  800 |    ·            ''·,,                           |
            //      |     '                ''·,,                      |
            //  700 |      ',                   ''·,,                 |
            //      |        ,                       ''·,,            |
            //  600 |         ·                           ''·,,       |
            //      |          '                               ''·,,  |
            //  500 |           ',           2                      ''B
            //      |             ,                                   |
            //  400 |              ·                                  |
            //      |               '                                 |
            //  300 |    3           ',                               |
            //      |                  ,                              |
            //  200 |                   ·                             |
            //      |                    '                            |
            //  100 |                     ',                          |
            //      |                       ,                         |
            //    0 W------------------------C------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in X-A-B is at ~(667, 833) (using triangle formula)
            ClassicAssert.AreEqual(666.67, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C-Z is at ~(583, 417) (using quadrilateral formula)
            ClassicAssert.AreEqual(583.33, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(416.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-W-C is at ~(167, 333) (using triangle formula)
            ClassicAssert.AreEqual(166.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 W-----------------------------------------------##A
            //      |                                          ,,·'' '|
            //  900 |              3                      ,,·''    ,' |
            //      |                                ,,·''        ,   |
            //  800 |                           ,,·''            ·    |
            //      |                      ,,·''                '     |
            //  700 |                 ,,·''                   ,'      |
            //      |            ,,·''                       ,        |
            //  600 |       ,,·''                           ·         |
            //      |  ,,·''                               '          |
            //  500 C''                      2           ,'           |
            //      |                                   ,             |
            //  400 |                                  ·              |
            //      |                                 '               |
            //  300 |                               ,'           1    |
            //      |                              ,                  |
            //  200 |                             ·                   |
            //      |                            '                    |
            //  100 |                          ,'                     |
            //      |                         ,                       |
            //    0 Z------------------------B------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 500, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 500, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 500), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in A-B-X is at ~(833, 333) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Z-B is at ~(417, 417) (using quadrilateral formula)
            ClassicAssert.AreEqual(416.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(416.67, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-W-C is at ~(333, 833) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(833.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z------------------------C------------------------W
            //      |                         '                       |
            //  900 |                          ',                     |
            //      |                            ,                    |
            //  800 |                             ·                   |
            //      |                              '                  |
            //  700 |                               ',           3    |
            //      |                                 ,               |
            //  600 |                                  ·              |
            //      |                                   '             |
            //  500 B,,                      2           ',           |
            //      |  ''·,,                               ,          |
            //  400 |       ''·,,                           ·         |
            //      |            ''·,,                       '        |
            //  300 |                 ''·,,                   ',      |
            //      |                      ''·,,                ,     |
            //  200 |                           ''·,,            ·    |
            //      |                                ''·,,        '   |
            //  100 |              1                      ''·,,    ', |
            //      |                                          ''·,, ,|
            //    0 X-----------------------------------------------##A
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 500), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 500), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 500, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 500, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in B-X-A is at ~(333, 167) (using triangle formula)
            ClassicAssert.AreEqual(333.33, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(166.67, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Z-B-A is at ~(417, 583) (using quadrilateral formula)
            ClassicAssert.AreEqual(416.67, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(583.33, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-C-A is at ~(833, 667) (using triangle formula)
            ClassicAssert.AreEqual(833.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(666.67, sites[2].Centroid.Y, 0.01);
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

            // 1000 X----------------------------------B--------------Z
            //      |                                 '               |
            //  900 |                               ,'                |
            //      |                              ,                  |
            //  800 |                             ·                   |
            //      |                            '                    |
            //  700 |              1           ,'                     |
            //      |                         ,                       |
            //  600 |                        ·                        |
            //      |                       '                         |
            //  500 |                     ,'           2              |
            //      |                    ,                            |
            //  400 |                   ·                           ,,C
            //      |                  '                       ,,·''  |
            //  300 |                ,'                   ,,·''       |
            //      |               ,                ,,·''            |
            //  200 |              ·            ,,·''                 |
            //      |             '        ,,·''                      |
            //  100 |           ,'    ,,·''                      3    |
            //      |          , ,,·''                                |
            //    0 Y---------A##-------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 400), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in B-X-Y-A is at ~(248, 593) (using quadrilateral formula)
            ClassicAssert.AreEqual(248.15, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(592.59, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-B-A-C is at ~(695, 544) (using quadrilateral formula)
            ClassicAssert.AreEqual(694.87, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(543.59, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-A-W is at ~(733, 133) (using triangle formula)
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(133.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y-------------------------------------------------X
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 A,,                                               |
            //      |' ''·,,                                          |
            //  700 | ',    ''·,,                      1              |
            //      |   ,        ''·,,                                |
            //  600 |    ·            ''·,,                           |
            //      |     '                ''·,,                      |
            //  500 |      ',                   ''·,,                 |
            //      |        ,                       ''·,,            |
            //  400 |         ·                           ''·,,       |
            //      |          '                               ''·,,  |
            //  300 |           ',           2                      ''B
            //      |             ,                                   |
            //  200 |              ·                                  |
            //      |               '                                 |
            //  100 |    3           ',                               |
            //      |                  ,                              |
            //    0 W-------------------C-----------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 300), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 300), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 400, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 800), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in X-Y-A-B is at ~(593, 752) (using quadrilateral formula)
            ClassicAssert.AreEqual(592.59, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(751.85, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-A-C-Z is at ~(544, 305) (using quadrilateral formula)
            ClassicAssert.AreEqual(543.59, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(305.13, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-W-C is at ~(133, 267) (using triangle formula)
            ClassicAssert.AreEqual(133.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[2].Centroid.Y, 0.01);
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

            // 1000 W-------------------------------------##A---------Y
            //      |                                ,,·'' '          |
            //  900 |    3                      ,,·''    ,'           |
            //      |                      ,,·''        ,             |
            //  800 |                 ,,·''            ·              |
            //      |            ,,·''                '               |
            //  700 |       ,,·''                   ,'                |
            //      |  ,,·''                       ,                  |
            //  600 C''                           ·                   |
            //      |                            '                    |
            //  500 |              2           ,'                     |
            //      |                         ,                       |
            //  400 |                        ·                        |
            //      |                       '                         |
            //  300 |                     ,'           1              |
            //      |                    ,                            |
            //  200 |                   ·                             |
            //      |                  '                              |
            //  100 |                ,'                               |
            //      |               ,                                 |
            //    0 Z--------------B----------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 300, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in Y-A-B-X is at ~(752, 407) (using quadrilateral formula)
            ClassicAssert.AreEqual(751.85, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(407.41, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-C-Z-B is at ~(305, 456) (using quadrilateral formula)
            ClassicAssert.AreEqual(305.13, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(456.41, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-W-C is at ~(267, 867) (using triangle formula)
            ClassicAssert.AreEqual(266.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(866.67, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z-----------------------------C-------------------W
            //      |                              '                  |
            //  900 |                               ',           3    |
            //      |                                 ,               |
            //  800 |                                  ·              |
            //      |                                   '             |
            //  700 B,,                      2           ',           |
            //      |  ''·,,                               ,          |
            //  600 |       ''·,,                           ·         |
            //      |            ''·,,                       '        |
            //  500 |                 ''·,,                   ',      |
            //      |                      ''·,,                ,     |
            //  400 |                           ''·,,            ·    |
            //      |                                ''·,,        '   |
            //  300 |              1                      ''·,,    ', |
            //      |                                          ''·,, ,|
            //  200 |                                               ''A
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 X-------------------------------------------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in B-X-Y-A is at ~(407, 248) (using quadrilateral formula)
            ClassicAssert.AreEqual(407.41, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(248.15, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-Z-B-A is at ~(456, 695) (using quadrilateral formula)
            ClassicAssert.AreEqual(456.41, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(694.87, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-C-A is at ~(867, 733) (using triangle formula)
            ClassicAssert.AreEqual(866.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 Z--------------B----------------------------------X
            //      |               '                                 |
            //  900 |                ',                               |
            //      |                  ,                              |
            //  800 |                   ·                             |
            //      |                    '                            |
            //  700 |                     ',           1              |
            //      |                       ,                         |
            //  600 |                        ·                        |
            //      |                         '                       |
            //  500 |              2           ',                     |
            //      |                            ,                    |
            //  400 C,,                           ·                   |
            //      |  ''·,,                       '                  |
            //  300 |       ''·,,                   ',                |
            //      |            ''·,,                ,               |
            //  200 |                 ''·,,            ·              |
            //      |                      ''·,,        '             |
            //  100 |    3                      ''·,,    ',           |
            //      |                                ''·,, ,          |
            //    0 W-------------------------------------##A---------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 800, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 300, 1000), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 800, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 1000), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 400), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 800, 0), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 0, 400), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in X-B-A-Y is at ~(752, 593) (using quadrilateral formula)
            ClassicAssert.AreEqual(751.85, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(592.59, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Z-C-A is at ~(305, 544) (using quadrilateral formula)
            ClassicAssert.AreEqual(305.13, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(543.59, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-W-A is at ~(267, 133) (using triangle formula)
            ClassicAssert.AreEqual(266.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(133.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 W-------------------C-----------------------------Z
            //      |                  '                              |
            //  900 |    3           ,'                               |
            //      |               ,                                 |
            //  800 |              ·                                  |
            //      |             '                                   |
            //  700 |           ,'           2                      ,,B
            //      |          ,                               ,,·''  |
            //  600 |         ·                           ,,·''       |
            //      |        '                       ,,·''            |
            //  500 |      ,'                   ,,·''                 |
            //      |     ,                ,,·''                      |
            //  400 |    ·            ,,·''                           |
            //      |   '        ,,·''                                |
            //  300 | ,'    ,,·''                      1              |
            //      |, ,,·''                                          |
            //  200 A''                                               |
            //      |                                                 |
            //  100 |                                                 |
            //      |                                                 |
            //    0 Y-------------------------------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1000, 700), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 1000, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1000, 700), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 400, 1000), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 1000), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 200), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 400, 1000), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 0, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in B-A-Y-X is at ~(593, 248) (using quadrilateral formula)
            ClassicAssert.AreEqual(592.59, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(248.15, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-Z-C-A is at ~(544, 695) (using quadrilateral formula)
            ClassicAssert.AreEqual(543.59, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(694.87, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in C-W-A is at ~(133, 733) (using triangle formula)
            ClassicAssert.AreEqual(133.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.Y, 0.01);
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

            // 1000 Y---------A##-------------------------------------W
            //      |          ' ''·,,                                |
            //  900 |           ',    ''·,,                      3    |
            //      |             ,        ''·,,                      |
            //  800 |              ·            ''·,,                 |
            //      |               '                ''·,,            |
            //  700 |                ',                   ''·,,       |
            //      |                  ,                       ''·,,  |
            //  600 |                   ·                           ''C
            //      |                    '                            |
            //  500 |                     ',           2              |
            //      |                       ,                         |
            //  400 |                        ·                        |
            //      |                         '                       |
            //  300 |              1           ',                     |
            //      |                            ,                    |
            //  200 |                             ·                   |
            //      |                              '                  |
            //  100 |                               ',                |
            //      |                                 ,               |
            //    0 X----------------------------------B--------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 200, 1000), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 700, 0), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 200, 1000), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 700, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1000, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1000, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 200, 1000), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 1000, 600), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 1000), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in A-Y-X-B is at ~(248, 407) (using quadrilateral formula)
            ClassicAssert.AreEqual(248.15, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(407.41, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B-Z is at ~(695, 456) (using quadrilateral formula)
            ClassicAssert.AreEqual(694.87, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(456.41, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-A-C is at ~(733, 867) (using triangle formula)
            ClassicAssert.AreEqual(733.33, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(866.67, sites[2].Centroid.Y, 0.01);
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

            // 1000 X-------------------------------------------------Y
            //      |                                                 |
            //  900 |                                                 |
            //      |                                                 |
            //  800 |                                               ,,A
            //      |                                          ,,·'' '|
            //  700 |              1                      ,,·''    ,' |
            //      |                                ,,·''        ,   |
            //  600 |                           ,,·''            ·    |
            //      |                      ,,·''                '     |
            //  500 |                 ,,·''                   ,'      |
            //      |            ,,·''                       ,        |
            //  400 |       ,,·''                           ·         |
            //      |  ,,·''                               '          |
            //  300 B''                      2           ,'           |
            //      |                                   ,             |
            //  200 |                                  ·              |
            //      |                                 '               |
            //  100 |                               ,'           3    |
            //      |                              ,                  |
            //    0 Z-----------------------------C-------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 4 == sites[0].Points.Count(), "Expected: site #1 point count 4"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1000, 800), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has B"); // #1 has B
            Assume.That(() => HasPoint(sites[0].Points, 0, 1000), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => HasPoint(sites[0].Points, 1000, 1000), "Expected: site #1 has Y"); // #1 has Y
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 4 == sites[1].Points.Count(), "Expected: site #2 point count 4"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1000, 800), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1000, 800), "Expected: site #3 has A"); // #3 has A
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has C"); // #3 has C
            Assume.That(() => HasPoint(sites[2].Points, 1000, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in A-Y-X-B is at ~(407, 752) (using quadrilateral formula)
            ClassicAssert.AreEqual(407.41, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(751.85, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-Z-C is at ~(456, 305) (using quadrilateral formula)
            ClassicAssert.AreEqual(456.41, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(305.13, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-C-W is at ~(867, 267) (using triangle formula)
            ClassicAssert.AreEqual(866.67, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(266.67, sites[2].Centroid.Y, 0.01);
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

            // 1200 X-----------------------------C-----------------------------Z
            //      |                           ,'                              |
            // 1100 |    1                    ,'                                |
            //      |                        ·                                  |
            // 1000 |                      ,'                                   |
            //      |                    ,'                                     |
            //  900 |                   ·                                       |
            //      |                 ,'                                        |
            //  800 |               ,'                                          |
            //      |              ·                                            |
            //  700 |            ,'                    2                        |
            //      |          ,'                                               |
            //  600 |         ·                                                ,D
            //      |       ,'                                             ,·'' |
            //  500 |     ,'                                           ,,''     |
            //      |    ·                                         ,,·'         |
            //  400 |  ,'                                       ,·'             |
            //      |,'                                     ,·''                |
            //  300 A                                   ,,''                    |
            //      |                               ,,·'                        |
            //  200 |                            ,·'                            |
            //      |                        ,·''                               |
            //  100 |                    ,,''                              3    |
            //      |                ,,·'                                       |
            //    0 Y--------------B#-------------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 1200), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 1200), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 6 == sites[1].Points.Count(), "Expected: site #2 point count 6"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 0, 300), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 300, 0), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 1200), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 1200, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1200), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 300, 0), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 1200, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1200, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in C-X-A is at ~(200, 900) (using triangle formula)
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in Z-C-A-Y-B-D is at ~(630, 630) (using generic closed polygon formula)
            ClassicAssert.AreEqual(630.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(630.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-B-W is at ~(900, 200) (using triangle formula)
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.Y, 0.01);
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

            // 1200 Y--------------A#-------------------------------------------X
            //      |                ''·,                                       |
            // 1100 |                    '',,                              1    |
            //      |                        '·,,                               |
            // 1000 |                            '·,                            |
            //      |                               ''·,                        |
            //  900 B                                   '',,                    |
            //      |',                                     '·,,                |
            //  800 |  ',                                       '·,             |
            //      |    ·                                         ''·,         |
            //  700 |     ',                                           '',,     |
            //      |       ',                                             '·,, |
            //  600 |         ·                                                'C
            //      |          ',                                               |
            //  500 |            ',                    2                        |
            //      |              ·                                            |
            //  400 |               ',                                          |
            //      |                 ',                                        |
            //  300 |                   ·                                       |
            //      |                    ',                                     |
            //  200 |                      ',                                   |
            //      |                        ·                                  |
            //  100 |    3                    ',                                |
            //      |                           ',                              |
            //    0 W-----------------------------D-----------------------------Z
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 300, 1200), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 1200, 600), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1200, 1200), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 6 == sites[1].Points.Count(), "Expected: site #2 point count 6"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 300, 1200), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 0, 900), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 1200, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 0, 1200), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 1200, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 0, 900), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 600, 0), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 0), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in X-A-C is at ~(900, 1000) (using triangle formula)
            ClassicAssert.AreEqual(900.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-Y-B-D-Z is at ~(630, 570) (using generic closed polygon formula)
            ClassicAssert.AreEqual(630.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(570.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-W-D is at ~(200, 300) (using triangle formula)
            ClassicAssert.AreEqual(200.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.Y, 0.01);
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

            // 1200 W-------------------------------------------#B--------------Y
            //      |                                       ,·''                |
            // 1100 |    3                              ,,''                    |
            //      |                               ,,·'                        |
            // 1000 |                            ,·'                            |
            //      |                        ,·''                               |
            //  900 |                    ,,''                                   A
            //      |                ,,·'                                     ,'|
            //  800 |             ,·'                                       ,'  |
            //      |         ,·''                                         ·    |
            //  700 |     ,,''                                           ,'     |
            //      | ,,·'                                             ,'       |
            //  600 D'                                                ·         |
            //      |                                               ,'          |
            //  500 |                        2                    ,'            |
            //      |                                            ·              |
            //  400 |                                          ,'               |
            //      |                                        ,'                 |
            //  300 |                                       ·                   |
            //      |                                     ,'                    |
            //  200 |                                   ,'                      |
            //      |                                  ·                        |
            //  100 |                                ,'                    1    |
            //      |                              ,'                           |
            //    0 Z-----------------------------C-----------------------------X
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 1200, 900), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 1200, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 6 == sites[1].Points.Count(), "Expected: site #2 point count 6"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 1200, 900), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 900, 1200), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 600, 0), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1200, 1200), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 0, 0), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 900, 1200), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 0, 600), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 0, 1200), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in A-C-X is at ~(1000, 300) (using triangle formula)
            ClassicAssert.AreEqual(1000.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-Y-B-D-Z-C is at ~(570, 570) (using generic closed polygon formula)
            ClassicAssert.AreEqual(570.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(570.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-W-D is at ~(300, 1000) (using triangle formula)
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(1000.00, sites[2].Centroid.Y, 0.01);
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

            // 1200 Z-----------------------------D-----------------------------W
            //      |                              ',                           |
            // 1100 |                                ',                    3    |
            //      |                                  ·                        |
            // 1000 |                                   ',                      |
            //      |                                     ',                    |
            //  900 |                                       ·                   |
            //      |                                        ',                 |
            //  800 |                                          ',               |
            //      |                                            ·              |
            //  700 |                        2                    ',            |
            //      |                                               ',          |
            //  600 C,                                                ·         |
            //      | ''·,                                             ',       |
            //  500 |     '',,                                           ',     |
            //      |         '·,,                                         ·    |
            //  400 |             '·,                                       ',  |
            //      |                ''·,                                     ',|
            //  300 |                    '',,                                   B
            //      |                        '·,,                               |
            //  200 |                            '·,                            |
            //      |                               ''·,                        |
            //  100 |    1                              '',,                    |
            //      |                                       '·,,                |
            //    0 X-------------------------------------------#A--------------Y
            //       0  100  200  300  400  500  600  700  800  900 1000 1100 1200 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1200, 1200);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 900, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 600), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
            Assume.That(() => null != sites[1].Points);
            Assume.That(() => 6 == sites[1].Points.Count(), "Expected: site #2 point count 6"); // #2
            Assume.That(() => HasPoint(sites[1].Points, 900, 0), "Expected: site #2 has A"); // #2 has A
            Assume.That(() => HasPoint(sites[1].Points, 1200, 300), "Expected: site #2 has B"); // #2 has B
            Assume.That(() => HasPoint(sites[1].Points, 0, 600), "Expected: site #2 has C"); // #2 has C
            Assume.That(() => HasPoint(sites[1].Points, 600, 1200), "Expected: site #2 has D"); // #2 has D
            Assume.That(() => HasPoint(sites[1].Points, 1200, 0), "Expected: site #2 has Y"); // #2 has Y
            Assume.That(() => HasPoint(sites[1].Points, 0, 1200), "Expected: site #2 has Z"); // #2 has Z
            Assume.That(() => null != sites[2].Points);
            Assume.That(() => 3 == sites[2].Points.Count(), "Expected: site #3 point count 3"); // #3
            Assume.That(() => HasPoint(sites[2].Points, 1200, 300), "Expected: site #3 has B"); // #3 has B
            Assume.That(() => HasPoint(sites[2].Points, 600, 1200), "Expected: site #3 has D"); // #3 has D
            Assume.That(() => HasPoint(sites[2].Points, 1200, 1200), "Expected: site #3 has W"); // #3 has W

            // Assert

            // Centroid of #1 in C-X-A is at ~(300, 200) (using triangle formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(200.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in D-Z-C-A-Y-B is at ~(570, 630) (using generic closed polygon formula)
            ClassicAssert.AreEqual(570.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(630.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in W-D-B is at ~(1000, 900) (using triangle formula)
            ClassicAssert.AreEqual(1000.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(900.00, sites[2].Centroid.Y, 0.01);
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

            //  900 X--------------C----------------------------#B
            //      |             ·                           ,' |
            //  800 |    1       ·                         ,·'   |
            //      |            ·                       ,'      |
            //  700 |           ·       2             ,·'        |
            //      |          ·                    ,'           |
            //  600 |         ·                  ,·'             |
            //      |        ·                 ,'                |
            //  500 |       ·               ,·'                  |
            //      |       ·             ,'                     |
            //  400 |      ·           ,·'             3         |
            //      |     ·          ,'                          |
            //  300 |    ·        ,·'                         ,,,D
            //      |   ·       ,'                    ,,,··'''   |
            //  200 |  ·     ,·'               ,,,·'''           |
            //      |  ·   ,'          ,,,··'''                  |
            //  100 | · ,·'     ,,,·'''                     4    |
            //      |·,',,,··'''                                 |
            //    0 A###-----------------------------------------W
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 300, 900), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 900), "Expected: site #1 has X"); // #1 has X
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
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 900, 300), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 900, 0), "Expected: site #4 has W"); // #4 has W

            // Assert

            // Centroid of #1 in C-X-A is at ~(100, 600) (using triangle formula)
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-A is at ~(400, 600) (using triangle formula)
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in B-A-D is at ~(600, 400) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in D-A-W is at ~(600, 100) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[3].Centroid.X, 0.01);
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

            //  900 A###-----------------------------------------X
            //      |·','''··,,,                                 |
            //  800 | · '·,     '''·,,,                     1    |
            //      |  ·   ',          '''··,,,                  |
            //  700 |  ·     '·,               '''·,,,           |
            //      |   ·       ',                    '''··,,,   |
            //  600 |    ·        '·,                         '''C
            //      |     ·          ',                          |
            //  500 |      ·           '·,             2         |
            //      |       ·             ',                     |
            //  400 |       ·               '·,                  |
            //      |        ·                 ',                |
            //  300 |         ·                  '·,             |
            //      |          ·                    ',           |
            //  200 |           ·       3             '·,        |
            //      |            ·                       ',      |
            //  100 |    4       ·                         '·,   |
            //      |             ·                           ', |
            //    0 W--------------D----------------------------#B
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 0, 900), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 900, 600), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 900, 900), "Expected: site #1 has X"); // #1 has X
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
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 0, 900), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 300, 0), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 0, 0), "Expected: site #4 has W"); // #4 has W

            // Assert

            // Centroid of #1 in X-A-C is at ~(600, 800) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in C-A-B is at ~(600, 500) (using triangle formula)
            ClassicAssert.AreEqual(600.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(400, 300) (using triangle formula)
            ClassicAssert.AreEqual(400.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-W-D is at ~(100, 300) (using triangle formula)
            ClassicAssert.AreEqual(100.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[3].Centroid.Y, 0.01);
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

            //  900 W-----------------------------------------###A
            //      |                                 ,,,··''','·|
            //  800 |    4                     ,,,·'''     ,·' · |
            //      |                  ,,,··'''          ,'   ·  |
            //  700 |           ,,,·'''               ,·'     ·  |
            //      |   ,,,··'''                    ,'       ·   |
            //  600 D'''                         ,·'        ·    |
            //      |                          ,'          ·     |
            //  500 |         3             ,·'           ·      |
            //      |                     ,'             ·       |
            //  400 |                  ,·'               ·       |
            //      |                ,'                 ·        |
            //  300 |             ,·'                  ·         |
            //      |           ,'                    ·          |
            //  200 |        ,·'             2       ·           |
            //      |      ,'                       ·            |
            //  100 |   ,·'                         ·       1    |
            //      | ,'                           ·             |
            //    0 B#----------------------------C--------------X
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 900, 900), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 600, 0), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 900, 0), "Expected: site #1 has X"); // #1 has X
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
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 900, 900), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 0, 600), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 0, 900), "Expected: site #4 has W"); // #4 has W

            // Assert

            // Centroid of #1 in A-C-X is at ~(800, 300) (using triangle formula)
            ClassicAssert.AreEqual(800.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in A-B-C is at ~(500, 300) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in A-D-B is at ~(300, 500) (using triangle formula)
            ClassicAssert.AreEqual(300.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in A-W-D is at ~(300, 800) (using triangle formula)
            ClassicAssert.AreEqual(300.00, sites[3].Centroid.X, 0.01);
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

            //  900 B#----------------------------D--------------W
            //      | ',                           ·             |
            //  800 |   '·,                         ·       4    |
            //      |      ',                       ·            |
            //  700 |        '·,             3       ·           |
            //      |           ',                    ·          |
            //  600 |             '·,                  ·         |
            //      |                ',                 ·        |
            //  500 |                  '·,               ·       |
            //      |                     ',             ·       |
            //  400 |         2             '·,           ·      |
            //      |                          ',          ·     |
            //  300 C,,,                         '·,        ·    |
            //      |   '''··,,,                    ',       ·   |
            //  200 |           '''·,,,               '·,     ·  |
            //      |                  '''··,,,          ',   ·  |
            //  100 |    1                     '''·,,,     '·, · |
            //      |                                 '''··,,,',·|
            //    0 X-----------------------------------------###A
            //       0  100  200  300  400  500  600  700  800  900 

            // Act

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 900, 900);

            // Assume

            Assume.That(() => null != sites[0].Points);
            Assume.That(() => 3 == sites[0].Points.Count(), "Expected: site #1 point count 3"); // #1
            Assume.That(() => HasPoint(sites[0].Points, 900, 0), "Expected: site #1 has A"); // #1 has A
            Assume.That(() => HasPoint(sites[0].Points, 0, 300), "Expected: site #1 has C"); // #1 has C
            Assume.That(() => HasPoint(sites[0].Points, 0, 0), "Expected: site #1 has X"); // #1 has X
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
            Assume.That(() => 3 == sites[3].Points.Count(), "Expected: site #4 point count 3"); // #4
            Assume.That(() => HasPoint(sites[3].Points, 900, 0), "Expected: site #4 has A"); // #4 has A
            Assume.That(() => HasPoint(sites[3].Points, 600, 900), "Expected: site #4 has D"); // #4 has D
            Assume.That(() => HasPoint(sites[3].Points, 900, 900), "Expected: site #4 has W"); // #4 has W

            // Assert

            // Centroid of #1 in C-X-A is at ~(300, 100) (using triangle formula)
            ClassicAssert.AreEqual(300.00, sites[0].Centroid.X, 0.01);
            ClassicAssert.AreEqual(100.00, sites[0].Centroid.Y, 0.01);
            // Centroid of #2 in B-C-A is at ~(300, 400) (using triangle formula)
            ClassicAssert.AreEqual(300.00, sites[1].Centroid.X, 0.01);
            ClassicAssert.AreEqual(400.00, sites[1].Centroid.Y, 0.01);
            // Centroid of #3 in D-B-A is at ~(500, 600) (using triangle formula)
            ClassicAssert.AreEqual(500.00, sites[2].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[2].Centroid.Y, 0.01);
            // Centroid of #4 in W-D-A is at ~(800, 600) (using triangle formula)
            ClassicAssert.AreEqual(800.00, sites[3].Centroid.X, 0.01);
            ClassicAssert.AreEqual(600.00, sites[3].Centroid.Y, 0.01);
        }

    }
}
