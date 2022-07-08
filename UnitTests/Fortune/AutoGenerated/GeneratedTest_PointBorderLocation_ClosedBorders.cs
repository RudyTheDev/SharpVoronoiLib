using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

namespace SharpVoronoiLib.UnitTests
{
    /// <summary>
    /// These tests assert that <see cref="VoronoiPoint"/>`s have the expected <see cref="PointBorderLocation"/>.
    /// Specifically, that the <see cref="VoronoiPoint.BorderLocation"/> has the expected value.
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_PointBorderLocation_ClosedBorders
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 700).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 700).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 700, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 700, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 700).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 700).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 300).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 300).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 700, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 700, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 300, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 300, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 700).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 700).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 300).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 300).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 700, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 700, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 300, 1000).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 300, 0).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 200).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 800, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 200, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 200).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 800).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 200, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 800, 0).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 800).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 300).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 300, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 700).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 700, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 300, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 700).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 700, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 300).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 400).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 600, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 400, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 400).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 600).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 400, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 600, 0).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 600).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 400).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 400, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 600).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 600, 1000).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 400, 1000).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 600).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 600, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 400).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 400).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 400).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 400, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 600).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 400, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 600).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 600).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 600).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 600, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 400).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 600, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 400).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 300).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 200, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 800, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 300, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 800).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 200).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 700).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 800, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 200, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 700, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 200).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 800).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 700).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 200).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 200).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 700, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 200, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 200, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 300).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 800).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 800).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 300, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 800, 0).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 800, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 600).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 400).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 400).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 600).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // H
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 400).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 200).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 200).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 400).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 800).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 200, 0).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 800, 0).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 800).BorderLocation); // H
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 600).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 200, 600).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 200, 400).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 400).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 800, 1000).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 800).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 200).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 800, 0).BorderLocation); // H
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 600).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 800).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 800).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 600).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 200).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 800, 1000).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 200, 1000).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 200).BorderLocation); // H
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 400).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 800, 400).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 800, 600).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 600).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 200, 0).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 200).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 800).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 200, 1000).BorderLocation); // H
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 400).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 700).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 200, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 800, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 400).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 400).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 400, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 700, 500).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 800).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 200).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 400, 1000).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 400, 0).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 600).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 300).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 800, 0).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 200, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 600).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 600).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 600, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 300, 500).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 200).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 800).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 600, 0).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 600, 1000).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 300).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 300).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 300).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 300, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 500).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 300, 1000).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 300, 0).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 300).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 500, 700).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 700).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 300).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 500, 0).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 300).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 700).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 500, 1000).BorderLocation); // H
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // Z
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

            List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000, BorderEdgeGeneration.MakeBorderEdges).ToList();

            // Assert

            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 300, 500).BorderLocation); // A
            Assert.AreEqual(PointBorderLocation.NotOnBorder, FindPoint(edges, 700, 500).BorderLocation); // B
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 700, 1000).BorderLocation); // C
            Assert.AreEqual(PointBorderLocation.Top, FindPoint(edges, 300, 1000).BorderLocation); // D
            Assert.AreEqual(PointBorderLocation.Left, FindPoint(edges, 0, 500).BorderLocation); // E
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 300, 0).BorderLocation); // F
            Assert.AreEqual(PointBorderLocation.Bottom, FindPoint(edges, 700, 0).BorderLocation); // G
            Assert.AreEqual(PointBorderLocation.Right, FindPoint(edges, 1000, 500).BorderLocation); // H
            Assert.AreEqual(PointBorderLocation.TopRight, FindPoint(edges, 1000, 1000).BorderLocation); // W
            Assert.AreEqual(PointBorderLocation.TopLeft, FindPoint(edges, 0, 1000).BorderLocation); // X
            Assert.AreEqual(PointBorderLocation.BottomLeft, FindPoint(edges, 0, 0).BorderLocation); // Y
            Assert.AreEqual(PointBorderLocation.BottomRight, FindPoint(edges, 1000, 0).BorderLocation); // Z
        }

    }
}
