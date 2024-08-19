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
    /// These tests assert that <see cref="VoronoiEdge"/>`s have expected <see cref="VoronoiSite"/>`s.
    /// Specifically, that the <see cref="VoronoiEdge.Left"/> and <see cref="VoronoiEdge.Right"/> are the expected sites.
    /// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
    /// </summary>
    /// <remarks>
    /// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
    /// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
    /// It contains a bunch of known Voronoi site layouts, including many edge cases.
    /// </remarks>
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class GeneratedTest_EdgeSites_ClosedBorders
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 500)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 500)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 200, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 200, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 200, 500)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 200, 500)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 800)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 800)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 800)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 800)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 800, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 800, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 800, 500)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 800, 500)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 200)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 200)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 200)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 200)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 200, 700)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 200, 700)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 200, 700)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 200, 700)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 800)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 700, 800)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 700, 800)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 800)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 800, 300)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 800, 300)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 800, 300)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 800, 300)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 200)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 300, 200)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 300, 200)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 200)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 0, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 0, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 0, 500)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 0, 500)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 1000)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 1000)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 1000)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 1000)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 1000, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 1000, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 1000, 500)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 1000, 500)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 0)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 0)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 0)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 0)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 0, 700)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 0, 700)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 0, 700)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 0, 700)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 1000)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 700, 1000)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 700, 1000)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 1000)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 1000, 300)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 1000, 300)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 1000, 300)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 1000, 300)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 0)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 300, 0)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 300, 0)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 0)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 1000, 700)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 1000, 700)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 1000, 700)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 1000, 700)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 700, 0)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 700, 0)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 700, 0)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 700, 0)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 0, 300)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 0, 300)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 0, 300)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 0, 300)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 300, 1000)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 300, 1000)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 300, 1000)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 300, 1000)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 0, 0)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 0, 0)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 0, 0)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 0, 0)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 0, 1000)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 0, 1000)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 0, 1000)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 0, 1000)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 1000, 1000)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 1000, 1000)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 1000, 1000)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 1000, 1000)); // Z-X has #1
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

            Assume.That(() => 4 == edges.Count, "Expected: edge count 4");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 1000, 0)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 1000, 0)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 1000, 0)); // W-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 1000, 0)); // Z-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-B"); // W-B
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 500), 500, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 500), 500, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 500, 700)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 500, 300)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 300)); // Y-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 500, 300)); // W-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 500, 700)); // B-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 700)); // Z-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 1000, 500, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge W-B"); // W-B
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 500, 0), 700, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 500, 0), 300, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 700, 500)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 300, 500)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 500)); // Y-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 500)); // W-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 700, 500)); // B-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 500)); // Z-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 700), "Expected: has edge W-B"); // W-B
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 700), 500, 900)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 0), 500, 500)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 500)); // Y-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 700), 500, 500)); // W-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 1000), 500, 900)); // B-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 900)); // Z-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 700, 0), "Expected: has edge W-B"); // W-B
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 900, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 500, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 700, 1000), 900, 500)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 0, 1000), 500, 500)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 500)); // Y-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 700, 0), 500, 500)); // W-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 1000, 0), 900, 500)); // B-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 900, 500)); // Z-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 300, 1000, 300), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 700, 0, 300), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 700), "Expected: has edge D-B"); // D-B
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 1000, 300), 500, 500)); // C-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 1000, 300), 500, 100)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 700), 500, 900)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 300), 500, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 0), 500, 100)); // C-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 100)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 300), 500, 100)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 700), 500, 500)); // D-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 1000), 500, 900)); // B-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 900)); // Z-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 1000, 300, 0), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 700, 1000, 300, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 300, 0, 700, 0), "Expected: has edge D-B"); // D-B
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 900, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 500, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 300, 0), 500, 500)); // C-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 300, 0), 100, 500)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 700, 1000), 900, 500)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 300, 1000), 500, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 0, 1000), 100, 500)); // C-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 100, 500)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 100, 500)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 700, 0), 500, 500)); // D-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 1000, 0), 900, 500)); // B-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 900, 500)); // Z-X has #1
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

            Assume.That(() => 13 == edges.Count, "Expected: edge count 13");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1000, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 500), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 0, 300, 1000, 300), "Expected: has edge E-F"); // E-F
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 700, 0, 500), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 500, 0, 300), "Expected: has edge C-E"); // C-E
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0), "Expected: has edge E-Y"); // E-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge W-F"); // W-F
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 500), "Expected: has edge F-D"); // F-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 700), "Expected: has edge D-B"); // D-B
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 800)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1000, 700), 500, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 500), 500, 600)); // C-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 500), 500, 400)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 1000, 300), 500, 400)); // E-F has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 1000, 300), 500, 200)); // E-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 700), 500, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 500), 500, 600)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 300), 500, 400)); // C-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 0), 500, 200)); // E-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 200)); // Y-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 300), 500, 200)); // W-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 500), 500, 400)); // F-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 700), 500, 600)); // D-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 1000), 500, 800)); // B-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 800)); // Z-X has #1
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

            Assume.That(() => 13 == edges.Count, "Expected: edge count 13");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 1000, 500, 0), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 300, 1000, 300, 0), "Expected: has edge E-F"); // E-F
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 700, 1000, 500, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 1000, 300, 1000), "Expected: has edge C-E"); // C-E
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge E-Y"); // E-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge W-F"); // W-F
            Assume.That(() => HasEdge(edges, 300, 0, 500, 0), "Expected: has edge F-D"); // F-D
            Assume.That(() => HasEdge(edges, 500, 0, 700, 0), "Expected: has edge D-B"); // D-B
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 800, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 700, 0), 600, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 500, 0), 600, 500)); // C-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 500, 0), 400, 500)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 300, 0), 400, 500)); // E-F has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 300, 0), 200, 500)); // E-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 700, 1000), 800, 500)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 500, 1000), 600, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 300, 1000), 400, 500)); // C-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 0, 1000), 200, 500)); // E-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 200, 500)); // Y-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 200, 500)); // W-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 500, 0), 400, 500)); // F-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 700, 0), 600, 500)); // D-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 1000, 0), 800, 500)); // B-Z has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 800, 500)); // Z-X has #1
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

            Assume.That(() => 5 == edges.Count, "Expected: edge count 5");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 300, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 700, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 700)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 700, 300)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 300)); // Y-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 300, 700)); // B-X has #1
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

            Assume.That(() => 5 == edges.Count, "Expected: edge count 5");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 700, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 300, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 700)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 300)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 300)); // Y-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 700)); // B-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 200, 800, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 800, 1000), 200, 800)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 800, 1000), 600, 400)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 200), 200, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 600, 400)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 600, 400)); // Y-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 600, 400)); // W-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 800, 1000), 600, 400)); // Z-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 0, 1000), 200, 800)); // B-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 200, 1000, 1000, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 1000, 200), 800, 800)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 1000, 200), 400, 400)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 200, 1000), 800, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 0, 1000), 400, 400)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 400, 400)); // Y-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 400, 400)); // W-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 200), 400, 400)); // Z-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 1000), 800, 800)); // B-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 800, 200, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 200, 0), 800, 200)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 200, 0), 400, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 800), 800, 200)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 1000), 400, 600)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 400, 600)); // Y-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 400, 600)); // W-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 400, 600)); // Z-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 1000, 0), 800, 200)); // B-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 800, 0, 0, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 0, 800, 0, 0), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 0, 800), 200, 200)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 0, 800), 600, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 800, 0), 200, 200)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 1000, 0), 600, 600)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 600, 600)); // Y-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 600, 600)); // W-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 800), 600, 600)); // Z-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 0), 200, 200)); // B-X has #1
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

            Assume.That(() => 5 == edges.Count, "Expected: edge count 5");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-A"); // Y-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 200, 400)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 600, 800)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 200, 400)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 200, 400)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 600, 800)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 600, 800)); // Y-A has #2
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

            Assume.That(() => 5 == edges.Count, "Expected: edge count 5");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-A"); // Y-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 0), 400, 800)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 0), 800, 400)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 400, 800)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 400, 800)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 800, 400)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 800, 400)); // Y-A has #2
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

            Assume.That(() => 5 == edges.Count, "Expected: edge count 5");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-A"); // Y-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 1000), 800, 600)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 1000), 400, 200)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 800, 600)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 800, 600)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 400, 200)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 400, 200)); // Y-A has #2
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

            Assume.That(() => 5 == edges.Count, "Expected: edge count 5");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-A"); // Y-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 600, 200)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 200, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 600, 200)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 600, 200)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 200, 600)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 200, 600)); // Y-A has #2
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

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-A"); // Z-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 500), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 500), 700, 900)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 500)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 500, 500)); // Y-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 700, 900)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 900)); // Z-A has #2
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

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-A"); // Z-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 0), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 0), 900, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 500)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 500, 500)); // Y-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 900, 300)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 900, 300)); // Z-A has #2
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

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-A"); // Z-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 500), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 500), 300, 100)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 500)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 500, 500)); // Y-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 300, 100)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 100)); // Z-A has #2
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

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 500, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-A"); // Z-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 1000), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 1000), 100, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 500)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 500, 500)); // Y-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 100, 700)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 100, 700)); // Z-A has #2
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

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 500), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 0, 500, 0, 1000), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge Z-A"); // Z-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 500), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 500), 300, 900)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 500, 500)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 500), 500, 500)); // Y-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 1000), 300, 900)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 300, 900)); // Z-A has #2
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

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 500, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 500, 1000), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 500, 1000, 1000, 1000), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge Z-A"); // Z-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 500, 1000), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 500, 1000), 900, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 500, 500)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 500, 1000), 500, 500)); // Y-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 1000, 1000), 900, 700)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 900, 700)); // Z-A has #2
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

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 500), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge Z-A"); // Z-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 500), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 500), 700, 100)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 500, 500)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 500), 500, 500)); // Y-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 0), 700, 100)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 700, 100)); // Z-A has #2
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

            Assume.That(() => 6 == edges.Count, "Expected: edge count 6");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 500, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge A-X"); // A-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 500, 0), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 500, 0, 0, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge Z-A"); // Z-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 500, 0), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 500, 0), 100, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 500, 500)); // A-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 500, 500)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 500, 0), 500, 500)); // Y-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 0, 0), 100, 300)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 100, 300)); // Z-A has #2
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 300, 700, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 700), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 300), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge B-W"); // B-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 700), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 700, 1000), 200, 800)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 700, 1000), 500, 500)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 700), 500, 500)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 700), 800, 200)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 300), 200, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 0), 500, 500)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 500, 500)); // Y-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 0), 800, 200)); // B-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 700), 800, 200)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 1000), 500, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 700, 1000), 500, 500)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 0, 1000), 200, 800)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 1000, 1000, 300), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 700, 700, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 300, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0), "Expected: has edge B-W"); // B-W
            Assume.That(() => HasEdge(edges, 0, 0, 700, 0), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 1000, 300), 800, 800)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 1000, 300), 500, 500)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 700, 0), 500, 500)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 700, 0), 200, 200)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 300, 1000), 800, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 0, 1000), 500, 500)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 700), 500, 500)); // Y-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 0), 200, 200)); // B-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 700, 0), 200, 200)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 1000, 0), 500, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 300), 500, 500)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 1000), 800, 800)); // D-X has #1
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 400, 600, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 600, 1000), 200, 800)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 600, 1000), 400, 600)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 400, 600)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 600, 400)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 400), 200, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 0), 400, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 600, 400)); // B-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 600, 400)); // Y-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 600, 1000), 400, 600)); // C-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 0, 1000), 200, 800)); // D-X has #1
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 400), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 400), 800, 800)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 400), 600, 600)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 600, 600)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 400, 400)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 400, 1000), 800, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 1000), 600, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 400, 400)); // B-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 400, 400)); // Y-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 400), 600, 600)); // C-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 1000), 800, 800)); // D-X has #1
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 600, 400, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 400, 0), 800, 200)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 400, 0), 600, 400)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 0), 600, 400)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 0), 400, 600)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 600), 800, 200)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 1000), 600, 400)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 400, 600)); // B-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 400, 600)); // Y-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 400, 0), 600, 400)); // C-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 0), 800, 200)); // D-X has #1
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 0, 0, 600), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 0, 600), 200, 200)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 0, 600), 400, 400)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 1000), 400, 400)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 1000), 600, 600)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 200, 200)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 0), 400, 400)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 600, 600)); // B-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 600, 600)); // Y-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 600), 400, 400)); // C-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 200, 200)); // D-X has #1
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

            Assume.That(() => 11 == edges.Count, "Expected: edge count 11");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 400, 600, 1000), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 1000), "Expected: has edge B-E"); // B-E
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 600), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge D-E"); // D-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge E-F"); // E-F
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge F-X"); // F-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 600, 1000), 200, 800)); // A-F has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 600, 1000), 400, 600)); // A-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 400, 600)); // B-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 1000), 600, 400)); // B-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 600), 600, 400)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 600), 800, 200)); // C-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 400), 200, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 0), 400, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 400, 0), 600, 400)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 0), 800, 200)); // C-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 600), 800, 200)); // Y-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 1000), 600, 400)); // D-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 600, 1000), 400, 600)); // E-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 0, 1000), 200, 800)); // F-X has #1
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

            Assume.That(() => 11 == edges.Count, "Expected: edge count 11");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 400), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 0), "Expected: has edge B-E"); // B-E
            Assume.That(() => HasEdge(edges, 0, 600, 600, 0), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge D-E"); // D-E
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge E-F"); // E-F
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge F-X"); // F-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 400), 800, 800)); // A-F has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 400), 600, 600)); // A-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 600, 600)); // B-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 0), 400, 400)); // B-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 600, 0), 400, 400)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 600, 0), 200, 200)); // C-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 400, 1000), 800, 800)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 1000), 600, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 600), 400, 400)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 200, 200)); // C-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 200, 200)); // Y-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 0), 400, 400)); // D-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 400), 600, 600)); // E-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 1000), 800, 800)); // F-X has #1
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 0, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 400, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 400), 300, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 400), 300, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 0), 300, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 0), 500, 300)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 1000, 1000), 300, 500)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 1000, 1000), 500, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 400), 300, 500)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 0), 300, 300)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 400, 0), 300, 300)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 0), 500, 300)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 300)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 300, 500)); // D-X has #1
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 400, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 0, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 400, 1000), 500, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 400, 1000), 300, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 600), 300, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 600), 300, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 1000, 0), 500, 700)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 1000, 0), 300, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 400, 1000), 500, 700)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 1000), 300, 700)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 600), 300, 700)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 300, 500)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 500)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 700)); // D-X has #1
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 600, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 0, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 600), 700, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 600), 700, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 1000), 700, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 1000), 500, 700)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 0, 0), 700, 500)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 0, 0), 500, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 600), 700, 500)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 1000), 700, 700)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 600, 1000), 700, 700)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 0, 1000), 500, 700)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 700)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 700, 500)); // D-X has #1
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 600, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 400), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 0, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 600, 0), 500, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 600, 0), 700, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 400), 700, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 400), 700, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 0, 1000), 500, 300)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 0, 1000), 700, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 500, 300)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 0), 700, 300)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 400), 700, 300)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 1000), 700, 500)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 500)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 300)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 600, 0, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 600, 300, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 600, 700, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 600, 0, 600), 100, 800)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 600, 0, 600), 100, 400)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 600, 300, 0), 100, 400)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 600, 300, 0), 500, 400)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 600, 700, 1000), 100, 800)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 600, 700, 1000), 500, 400)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 600), 100, 800)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 100, 400)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 100, 400)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 0), 500, 400)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 400)); // W-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 700, 1000), 500, 400)); // Z-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 0, 1000), 100, 800)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 700, 600, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 700, 0, 700), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 700, 1000, 300), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 700, 600, 1000), 800, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 700, 600, 1000), 400, 900)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 700, 0, 700), 400, 900)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 700, 0, 700), 400, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 700, 1000, 300), 800, 900)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 700, 1000, 300), 400, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 600, 1000), 800, 900)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 0, 1000), 400, 900)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 700), 400, 900)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 0), 400, 500)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 400, 500)); // W-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 300), 400, 500)); // Z-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 1000), 800, 900)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 400, 1000, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 400, 700, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 400, 300, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 400, 1000, 400), 900, 200)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 400, 1000, 400), 900, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 400, 700, 1000), 900, 600)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 400, 700, 1000), 500, 600)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 400, 300, 0), 900, 200)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 400, 300, 0), 500, 600)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 400), 900, 200)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 1000), 900, 600)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 700, 1000), 900, 600)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 0, 1000), 500, 600)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 600)); // W-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 500, 600)); // Z-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 0), 900, 200)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 300, 400, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 300, 1000, 300), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 300, 0, 700), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 300, 400, 0), 200, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 300, 400, 0), 600, 100)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 300, 1000, 300), 600, 100)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 300, 1000, 300), 600, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 300, 0, 700), 200, 100)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 300, 0, 700), 600, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 400, 0), 200, 100)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 0), 600, 100)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 300), 600, 100)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 1000), 600, 500)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 600, 500)); // W-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 700), 600, 500)); // Z-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 0), 200, 100)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 600, 1000, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 600, 700, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 600, 300, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 600), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 700, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 700, 0, 0, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 300, 1000), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 300, 1000, 1000, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 600, 1000, 600), 900, 800)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 600, 1000, 600), 900, 400)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 600, 700, 0), 900, 400)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 600, 700, 0), 500, 400)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 600, 300, 1000), 900, 800)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 600, 300, 1000), 500, 400)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 600), 900, 800)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 0), 900, 400)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 700, 0), 900, 400)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 0, 0), 500, 400)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 500, 400)); // W-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 300, 1000), 500, 400)); // Z-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 1000, 1000), 900, 800)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 300, 600, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 300, 0, 300), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 300, 1000, 700), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 600, 0), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 600, 0, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 300), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 0, 300, 0, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 700), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 300, 600, 0), 800, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 300, 600, 0), 400, 100)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 300, 0, 300), 400, 100)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 300, 0, 300), 400, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 300, 1000, 700), 800, 100)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 300, 1000, 700), 400, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 600, 0), 800, 100)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 0, 0), 400, 100)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 300), 400, 100)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 1000), 400, 500)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 400, 500)); // W-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 700), 400, 500)); // Z-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 0), 800, 100)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 400, 0, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 400, 300, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 400, 700, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 0, 400), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 400, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 300, 1000), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 300, 1000, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 700, 0), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 700, 0, 0, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 400, 0, 400), 100, 200)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 400, 0, 400), 100, 600)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 400, 300, 1000), 100, 600)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 400, 300, 1000), 500, 600)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 400, 700, 0), 100, 200)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 400, 700, 0), 500, 600)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 400), 100, 200)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 1000), 100, 600)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 300, 1000), 100, 600)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 1000, 1000), 500, 600)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 500, 600)); // W-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 700, 0), 500, 600)); // Z-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 0, 0), 100, 200)); // D-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 700, 400, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 700, 1000, 700), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 700, 0, 300), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 400, 1000), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 700), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 300), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 0, 300, 0, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 700, 400, 1000), 200, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 700, 400, 1000), 600, 900)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 700, 1000, 700), 600, 900)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 700, 1000, 700), 600, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 700, 0, 300), 200, 900)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 700, 0, 300), 600, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 400, 1000), 200, 900)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 1000), 600, 900)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 700), 600, 900)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 0), 600, 500)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 600, 500)); // W-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 300), 600, 500)); // Z-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 1000), 200, 900)); // D-X has #1
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 500, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 300, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 500, 300)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 700, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 700, 500)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 300, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 500)); // X-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 300)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 500)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 700, 500)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 300, 500)); // D-X has #3
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 300, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 500, 700)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 300, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 500, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 500, 300)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 500, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 700)); // X-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 300)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 500, 300)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 500, 700)); // D-X has #3
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 500, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 700, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 500, 700)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 300, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 300, 500)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 700, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 500)); // X-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 700)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 500)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 500)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 700, 500)); // D-X has #3
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 700, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 500, 300)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 700, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 500, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 500, 700)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 500, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 300)); // X-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 700)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 500, 700)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 500, 300)); // D-X has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 200, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 800, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 300, 500, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 200, 0, 800, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 200, 0), 500, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 200, 0), 300, 300)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 800, 0), 500, 100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 800, 0), 700, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 1000), 700, 300)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 1000), 300, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 300)); // X-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 300, 300)); // Y-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 800, 0), 500, 100)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 1000, 0), 700, 300)); // C-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 300)); // W-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 700, 300)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 300, 300)); // D-X has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 0, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 0, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 500, 1000, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 0, 800, 0, 200), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 800), 100, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 800), 300, 700)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 200), 100, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 200), 300, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 1000, 500), 300, 300)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 1000, 500), 300, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 300, 700)); // X-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 800), 300, 700)); // Y-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 200), 100, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 300, 300)); // C-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 300)); // W-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 300, 300)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 300, 700)); // D-X has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 700, 800, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 200, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 700, 500, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 800, 1000, 200, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 800, 1000), 500, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 800, 1000), 700, 700)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 200, 1000), 500, 900)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 200, 1000), 300, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 500, 0), 300, 700)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 500, 0), 700, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 700)); // X-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 800, 1000), 700, 700)); // Y-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 200, 1000), 500, 900)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 0, 1000), 300, 700)); // C-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 700)); // W-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 700)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 700, 700)); // D-X has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 800), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 800), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge W-Z"); // W-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 200), 900, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 200), 700, 300)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 800), 900, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 800), 700, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 0, 500), 700, 700)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 0, 500), 700, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 700, 300)); // X-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 200), 700, 300)); // Y-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 800), 900, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 1000), 700, 700)); // C-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 700)); // W-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 700, 700)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 700, 300)); // D-X has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 700, 0, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 1000, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 700, 500, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 0, 200), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 0, 200), 300, 700)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 1000, 200), 500, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 1000, 200), 700, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 500, 1000), 700, 700)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 500, 1000), 300, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 200), 300, 700)); // X-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 500, 500)); // B-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 200), 500, 500)); // W-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 1000), 700, 700)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 700, 700)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 300, 700)); // D-X has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 500, 200, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 200, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 200, 1000), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 200, 1000), 700, 700)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 200, 0), 500, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 200, 0), 700, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 500), 700, 300)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 500), 700, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 200, 1000), 700, 700)); // X-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 0, 1000), 500, 500)); // B-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 500, 500)); // W-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 1000, 0), 700, 300)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 700, 300)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 700, 700)); // D-X has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 0, 800), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 0, 800, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 1000, 800), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 1000, 800), 700, 300)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 0, 800), 500, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 0, 800), 300, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 0), 300, 300)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 0), 700, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 800), 700, 300)); // X-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 1000), 500, 500)); // B-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 800), 500, 500)); // W-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 0), 300, 300)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 300)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 700, 300)); // D-X has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 800, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 800, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-X"); // D-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 800, 0), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 800, 0), 300, 300)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 800, 1000), 500, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 800, 1000), 300, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 500), 300, 700)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 500), 300, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 800, 0), 300, 300)); // X-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 1000, 0), 500, 500)); // B-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 500)); // Y-W has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 800, 1000), 500, 500)); // W-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 0, 1000), 300, 700)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 300, 700)); // Z-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 300, 300)); // D-X has #3
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 400, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 600, 400), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 600, 400, 600, 600), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 600, 600, 400, 600), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 400, 600, 0, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 400, 400, 0, 0), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 0), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 1000), "Expected: has edge D-H"); // D-H
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge E-F"); // E-F
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge F-G"); // F-G
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge G-H"); // G-H
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge H-E"); // H-E

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 400, 400), 500, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 400, 400), 300, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 600, 400), 500, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 600, 400), 500, 300)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 600, 600), 500, 500)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 600, 600), 700, 500)); // C-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 400, 600), 500, 500)); // D-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 400, 600), 500, 700)); // D-A has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 1000), 300, 500)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 1000), 500, 700)); // A-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 0), 300, 500)); // B-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 0), 500, 300)); // B-F has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 0), 500, 300)); // C-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 0), 700, 500)); // C-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 1000), 700, 500)); // D-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 1000), 500, 700)); // D-H has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 500)); // E-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 300)); // F-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 500)); // G-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 700)); // H-E has #5
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

            Assume.That(() => 16 == edges.Count, "Expected: edge count 16");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 400, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 200, 600, 200), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 600, 200, 600, 400), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 600, 400, 400, 400), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 400, 400, 0, 800), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 400, 200, 200, 0), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 600, 200, 800, 0), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 800), "Expected: has edge D-H"); // D-H
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge X-E"); // X-E
            Assume.That(() => HasEdge(edges, 0, 800, 0, 0), "Expected: has edge E-Y"); // E-Y
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 200, 0, 800, 0), "Expected: has edge F-G"); // F-G
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge G-W"); // G-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge W-H"); // W-H
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge H-Z"); // H-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 200), 500, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 200), 300, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 200, 600, 200), 500, 300)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 200, 600, 200), 500, 100)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 200, 600, 400), 500, 300)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 200, 600, 400), 700, 300)); // C-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 400, 400), 500, 300)); // D-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 400, 400), 500, 500)); // D-A has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 800), 300, 300)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 800), 500, 500)); // A-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 200, 200, 0), 300, 300)); // B-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 200, 200, 0), 500, 100)); // B-F has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 200, 800, 0), 500, 100)); // C-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 200, 800, 0), 700, 300)); // C-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 800), 700, 300)); // D-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 800), 500, 500)); // D-H has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 800), 500, 500)); // X-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 0), 300, 300)); // E-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 300, 300)); // Y-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 800, 0), 500, 100)); // F-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 1000, 0), 700, 300)); // G-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 800), 700, 300)); // W-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 1000), 500, 500)); // H-Z has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 500)); // Z-X has #5
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

            Assume.That(() => 16 == edges.Count, "Expected: edge count 16");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 200, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 200, 600, 200, 400), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 200, 400, 400, 400), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 400, 400, 400, 600), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 400, 600, 800, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 200, 600, 0, 800), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 200, 400, 0, 200), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 400, 400, 800, 0), "Expected: has edge D-H"); // D-H
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge X-E"); // X-E
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge E-Y"); // E-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 0, 800, 0, 200), "Expected: has edge F-G"); // F-G
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge G-W"); // G-W
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0), "Expected: has edge W-H"); // W-H
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge H-Z"); // H-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 200, 600), 300, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 200, 600), 300, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 600, 200, 400), 300, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 600, 200, 400), 100, 500)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 400, 400, 400), 300, 500)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 400, 400, 400), 300, 300)); // C-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 600), 300, 500)); // D-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 400, 600), 500, 500)); // D-A has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 800, 1000), 300, 700)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 800, 1000), 500, 500)); // A-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 600, 0, 800), 300, 700)); // B-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 600, 0, 800), 100, 500)); // B-F has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 400, 0, 200), 100, 500)); // C-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 400, 0, 200), 300, 300)); // C-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 800, 0), 300, 300)); // D-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 800, 0), 500, 500)); // D-H has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 800, 1000), 500, 500)); // X-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 0, 1000), 300, 700)); // E-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 800), 300, 700)); // Y-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 200), 100, 500)); // F-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 300, 300)); // G-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 800, 0), 300, 300)); // W-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 1000, 0), 500, 500)); // H-Z has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 500)); // Z-X has #5
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

            Assume.That(() => 16 == edges.Count, "Expected: edge count 16");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 600, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 800, 400, 800), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 400, 800, 400, 600), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 400, 600, 600, 600), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 200), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 600, 800, 800, 1000), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 400, 800, 200, 1000), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 400, 600, 0, 200), "Expected: has edge D-H"); // D-H
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge X-E"); // X-E
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge E-Y"); // E-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 800, 1000, 200, 1000), "Expected: has edge F-G"); // F-G
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge G-W"); // G-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge W-H"); // W-H
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge H-Z"); // H-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 800), 500, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 800), 700, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 800, 400, 800), 500, 700)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 800, 400, 800), 500, 900)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 800, 400, 600), 500, 700)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 800, 400, 600), 300, 700)); // C-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 600, 600), 500, 700)); // D-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 600, 600), 500, 500)); // D-A has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 200), 700, 700)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 200), 500, 500)); // A-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 800, 800, 1000), 700, 700)); // B-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 800, 800, 1000), 500, 900)); // B-F has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 800, 200, 1000), 500, 900)); // C-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 800, 200, 1000), 300, 700)); // C-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 200), 300, 700)); // D-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 200), 500, 500)); // D-H has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 200), 500, 500)); // X-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 1000), 700, 700)); // E-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 800, 1000), 700, 700)); // Y-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 200, 1000), 500, 900)); // F-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 0, 1000), 300, 700)); // G-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 200), 300, 700)); // W-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 500, 500)); // H-Z has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 500)); // Z-X has #5
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

            Assume.That(() => 16 == edges.Count, "Expected: edge count 16");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 800, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 800, 400, 800, 600), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 800, 600, 600, 600), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 600, 600, 600, 400), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 600, 400, 200, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 800, 400, 1000, 200), "Expected: has edge B-F"); // B-F
            Assume.That(() => HasEdge(edges, 800, 600, 1000, 800), "Expected: has edge C-G"); // C-G
            Assume.That(() => HasEdge(edges, 600, 600, 200, 1000), "Expected: has edge D-H"); // D-H
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge X-E"); // X-E
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge E-Y"); // E-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 800), "Expected: has edge F-G"); // F-G
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge G-W"); // G-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge W-H"); // W-H
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge H-Z"); // H-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 800, 400), 700, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 800, 400), 700, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 400, 800, 600), 700, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 400, 800, 600), 900, 500)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 600, 600, 600), 700, 500)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 600, 600, 600), 700, 700)); // C-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 400), 700, 500)); // D-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 600, 400), 500, 500)); // D-A has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 200, 0), 700, 300)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 200, 0), 500, 500)); // A-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 400, 1000, 200), 700, 300)); // B-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 400, 1000, 200), 900, 500)); // B-F has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 600, 1000, 800), 900, 500)); // C-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 600, 1000, 800), 700, 700)); // C-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 200, 1000), 700, 700)); // D-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 200, 1000), 500, 500)); // D-H has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 500, 500)); // X-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 1000, 0), 700, 300)); // E-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 200), 700, 300)); // Y-F has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 800), 900, 500)); // F-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 1000), 700, 700)); // G-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 200, 1000), 700, 700)); // W-H has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 0, 1000), 500, 500)); // H-Z has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 500)); // Z-X has #5
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 300, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 700, 700)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 300, 700)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 300, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 300, 300)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 700, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 700, 300)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 700, 700)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 300, 700)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 300, 300)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 300)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 700, 300)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 700, 300)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 700, 700)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 700, 700)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 300, 700)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 400, 800)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 600, 800)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 400, 800)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 400, 200)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 400, 200)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 600, 200)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 600, 200)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 600, 800)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 400, 800)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 400, 200)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 400, 200)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 600, 200)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 600, 200)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 600, 800)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 600, 800)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 400, 800)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 500, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 0, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 500, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 800, 600)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 500), 800, 400)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 800, 600)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 1000), 200, 600)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 200, 600)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 500), 200, 400)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 200, 400)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 500, 0), 800, 400)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 800, 600)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 200, 600)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 200, 600)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 200, 400)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 200, 400)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 800, 400)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 800, 400)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 800, 600)); // B-X has #1
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge D-E"); // D-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge E-B"); // E-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 500, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 300, 500)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 500, 300)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 0), 300, 500)); // A-C has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 700, 500)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 500, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 500, 700)); // A-E has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 700, 500)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 500)); // B-C has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 300)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 500)); // D-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 700)); // E-B has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 100, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 0, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 600, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 700), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 700), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 100, 1000), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 100, 1000, 0, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 100, 1000), 100, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 100, 1000), 500, 700)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 200), 100, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 200), 300, 100)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 600, 0), 300, 100)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 600, 0), 700, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 1000, 700), 700, 300)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 1000, 700), 500, 700)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 200), 100, 500)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 300, 100)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 300, 100)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 0), 700, 300)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 700), 700, 300)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 1000), 500, 700)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 100, 1000), 500, 700)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 100, 1000, 0, 1000), 100, 500)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 900), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 200, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 0, 400), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 600, 700, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 0, 0, 700, 0), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 900), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 1000, 900, 1000, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 1000, 900), 500, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 1000, 900), 700, 500)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 200, 1000), 500, 900)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 200, 1000), 100, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 400), 100, 700)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 400), 300, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 700, 0), 300, 300)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 700, 0), 700, 500)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 200, 1000), 500, 900)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 0, 1000), 100, 700)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 400), 100, 700)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 0), 300, 300)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 700, 0), 300, 300)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 1000, 0), 700, 500)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 900), 700, 500)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 900, 1000, 1000), 500, 900)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 900, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 800), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 400, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 600, 0, 300), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 300), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 0, 0, 900, 0), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 900, 0, 1000, 0), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 900, 0), 900, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 900, 0), 500, 300)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 800), 900, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 800), 700, 900)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 400, 1000), 700, 900)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 400, 1000), 300, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 0, 300), 300, 700)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 0, 300), 500, 300)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 800), 900, 500)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 1000), 700, 900)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 400, 1000), 700, 900)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 1000), 300, 700)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 300), 300, 700)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 0), 500, 300)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 900, 0), 500, 300)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 1000, 0), 900, 500)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 0, 100), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 800, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 600), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 400, 300, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 300, 1000), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 100), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 0, 100, 0, 0), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 0, 100), 500, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 0, 100), 300, 500)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 800, 0), 500, 100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 800, 0), 900, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 600), 900, 300)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 600), 700, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 300, 1000), 700, 700)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 300, 1000), 300, 500)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 800, 0), 500, 100)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 1000, 0), 900, 300)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 600), 900, 300)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 1000), 700, 700)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 300, 1000), 700, 700)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 0, 1000), 300, 500)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 100), 300, 500)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 100, 0, 0), 500, 100)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 400, 900, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 400, 1000, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 400, 400, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 400, 0, 700), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 200), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 400, 0), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 400, 0, 0, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 0, 0, 0, 700), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 0, 700, 0, 1000), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 900, 1000), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 900, 1000, 1000, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 900, 1000), 900, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 900, 1000), 500, 700)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 200), 900, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 1000, 200), 700, 100)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 400, 0), 700, 100)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 400, 0), 300, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 0, 700), 300, 300)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 400, 0, 700), 500, 700)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 200), 900, 500)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 0), 700, 100)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 400, 0), 700, 100)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 0, 0), 300, 300)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 700), 300, 300)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 1000), 500, 700)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 900, 1000), 500, 700)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 1000, 1000, 1000), 900, 500)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 400, 1000, 100), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 400, 200, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 400, 0, 600), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 400, 700, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 1000, 0, 200, 0), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 200, 0, 0, 0), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 600), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 0, 600, 0, 1000), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 0, 1000, 700, 1000), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 700, 1000, 1000, 1000), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 100), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 1000, 100, 1000, 0), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 1000, 100), 500, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 1000, 100), 700, 500)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 200, 0), 500, 100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 200, 0), 100, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 600), 100, 300)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 0, 600), 300, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 700, 1000), 300, 700)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 400, 700, 1000), 700, 500)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 200, 0), 500, 100)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 0, 0), 100, 300)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 600), 100, 300)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 1000), 300, 700)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 700, 1000), 300, 700)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 1000, 1000), 700, 500)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 100), 700, 500)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 100, 1000, 0), 500, 100)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 600, 100, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 600, 0, 800), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 400, 600, 600, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 600, 1000, 300), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 0, 0, 0, 800), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 0, 800, 0, 1000), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 600, 1000), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 600, 1000, 1000, 1000), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 300), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 0), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 100, 0), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 100, 0, 0, 0), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 100, 0), 100, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 100, 0), 500, 300)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 800), 100, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 0, 800), 300, 900)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 600, 1000), 300, 900)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 600, 1000), 700, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 1000, 300), 700, 700)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 600, 1000, 300), 500, 300)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 800), 100, 500)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 1000), 300, 900)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 600, 1000), 300, 900)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 1000, 1000), 700, 700)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 300), 700, 700)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 0), 500, 300)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 100, 0), 500, 300)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 100, 0, 0, 0), 100, 500)); // B-X has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 600, 0, 900), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 600, 800, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 600, 1000, 400), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 600, 300, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 0, 1000, 800, 1000), "Expected: has edge X-C"); // X-C
            Assume.That(() => HasEdge(edges, 800, 1000, 1000, 1000), "Expected: has edge C-Y"); // C-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 400), "Expected: has edge Y-D"); // Y-D
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 300, 0), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 300, 0, 0, 0), "Expected: has edge E-Z"); // E-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 900), "Expected: has edge Z-B"); // Z-B
            Assume.That(() => HasEdge(edges, 0, 900, 0, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 0, 900), 500, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 0, 900), 300, 500)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 800, 1000), 500, 900)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 800, 1000), 900, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 400), 900, 700)); // A-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 1000, 400), 700, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 300, 0), 700, 300)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 600, 300, 0), 300, 500)); // A-E has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 800, 1000), 500, 900)); // X-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 1000, 1000), 900, 700)); // C-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 400), 900, 700)); // Y-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 0), 700, 300)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 300, 0), 700, 300)); // W-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 0, 0), 300, 500)); // E-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 900), 300, 500)); // Z-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 0, 1000), 500, 900)); // B-X has #1
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

            Assume.That(() => 15 == edges.Count, "Expected: edge count 15");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 400, 500, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 200, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 700, 800, 1000), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 500, 400, 0, 400), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 500, 400, 1000, 400), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 500, 400, 500, 0), "Expected: has edge A-G"); // A-G
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0), "Expected: has edge E-X"); // E-X
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-G"); // X-G
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge G-Y"); // G-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge F-Z"); // F-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 800, 1000, 200, 1000), "Expected: has edge D-C"); // D-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 400, 500, 700), 300, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 400, 500, 700), 700, 700)); // A-B has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 200, 1000), 500, 900)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 200, 1000), 300, 700)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 800, 1000), 500, 900)); // B-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 800, 1000), 700, 700)); // B-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 400, 0, 400), 300, 700)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 400, 0, 400), 300, 100)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 400, 1000, 400), 700, 100)); // A-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 400, 1000, 400), 700, 700)); // A-F has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 400, 500, 0), 300, 100)); // A-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 400, 500, 0), 700, 100)); // A-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 0, 1000), 300, 700)); // C-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 400), 300, 700)); // W-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 0), 300, 100)); // E-X has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 100)); // X-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 700, 100)); // G-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 400), 700, 100)); // Y-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 1000), 700, 700)); // F-Z has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 800, 1000), 700, 700)); // Z-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 200, 1000), 500, 900)); // D-C has #1
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

            Assume.That(() => 15 == edges.Count, "Expected: edge count 15");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 500, 700, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 800), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 200), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 400, 500, 400, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 400, 500, 400, 0), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 400, 500, 0, 500), "Expected: has edge A-G"); // A-G
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge E-X"); // E-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-G"); // X-G
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge G-Y"); // G-Y
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge F-Z"); // F-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 800), "Expected: has edge D-C"); // D-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 500, 700, 500), 700, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 500, 700, 500), 700, 300)); // A-B has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 800), 900, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 800), 700, 700)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 200), 900, 500)); // B-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 200), 700, 300)); // B-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 500, 400, 1000), 700, 700)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 500, 400, 1000), 100, 700)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 500, 400, 0), 100, 300)); // A-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 500, 400, 0), 700, 300)); // A-F has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 500, 0, 500), 100, 700)); // A-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 500, 0, 500), 100, 300)); // A-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 1000), 700, 700)); // C-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 400, 1000), 700, 700)); // W-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 1000), 100, 700)); // E-X has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 100, 700)); // X-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 100, 300)); // G-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 400, 0), 100, 300)); // Y-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 0), 700, 300)); // F-Z has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 200), 700, 300)); // Z-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 800), 900, 500)); // D-C has #1
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

            Assume.That(() => 15 == edges.Count, "Expected: edge count 15");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 600, 500, 300), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 300, 800, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 300, 200, 0), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 500, 600, 1000, 600), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 500, 600, 0, 600), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 500, 600, 500, 1000), "Expected: has edge A-G"); // A-G
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge E-X"); // E-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge X-G"); // X-G
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge G-Y"); // G-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge F-Z"); // F-Z
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 200, 0, 800, 0), "Expected: has edge D-C"); // D-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 600, 500, 300), 700, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 600, 500, 300), 300, 300)); // A-B has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 800, 0), 500, 100)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 800, 0), 700, 300)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 200, 0), 500, 100)); // B-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 200, 0), 300, 300)); // B-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 600, 1000, 600), 700, 300)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 600, 1000, 600), 700, 900)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 600, 0, 600), 300, 900)); // A-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 600, 0, 600), 300, 300)); // A-F has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 600, 500, 1000), 700, 900)); // A-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 600, 500, 1000), 300, 900)); // A-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 1000, 0), 700, 300)); // C-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 600), 700, 300)); // W-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 1000), 700, 900)); // E-X has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 700, 900)); // X-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 300, 900)); // G-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 600), 300, 900)); // Y-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 300, 300)); // F-Z has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 300, 300)); // Z-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 800, 0), 500, 100)); // D-C has #1
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

            Assume.That(() => 15 == edges.Count, "Expected: edge count 15");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 500, 300, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 300, 500, 0, 200), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 300, 500, 0, 800), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 600, 500, 600, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 600, 500, 600, 1000), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 600, 500, 1000, 500), "Expected: has edge A-G"); // A-G
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge W-E"); // W-E
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge E-X"); // E-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge X-G"); // X-G
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge G-Y"); // G-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge F-Z"); // F-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Z-D"); // Z-D
            Assume.That(() => HasEdge(edges, 0, 800, 0, 200), "Expected: has edge D-C"); // D-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 500, 300, 500), 300, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 500, 300, 500), 300, 700)); // A-B has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 200), 100, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 200), 300, 300)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 800), 100, 500)); // B-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 800), 300, 700)); // B-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 500, 600, 0), 300, 300)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 500, 600, 0), 900, 300)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 500, 600, 1000), 900, 700)); // A-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 500, 600, 1000), 300, 700)); // A-F has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 500, 1000, 500), 900, 300)); // A-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 500, 1000, 500), 900, 700)); // A-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 300, 300)); // C-W has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 300, 300)); // W-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 0), 900, 300)); // E-X has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 900, 300)); // X-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 900, 700)); // G-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 600, 1000), 900, 700)); // Y-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 0, 1000), 300, 700)); // F-Z has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 800), 300, 700)); // Z-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 200), 100, 500)); // D-C has #1
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

            Assume.That(() => 13 == edges.Count, "Expected: edge count 13");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 500, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 0, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 500, 300, 0, 300), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 300), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-G"); // A-G
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 300), "Expected: has edge C-E"); // C-E
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0), "Expected: has edge E-X"); // E-X
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-G"); // X-G
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge G-Y"); // G-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge F-D"); // F-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge D-C"); // D-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 500), 300, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 500), 700, 500)); // A-B has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 500, 700)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 0, 1000), 300, 500)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 500, 700)); // B-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 700, 500)); // B-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 0, 300), 300, 500)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 0, 300), 300, 100)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 1000, 300), 700, 100)); // A-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 1000, 300), 700, 500)); // A-F has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 0), 300, 100)); // A-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 0), 700, 100)); // A-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 300), 300, 500)); // C-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 0), 300, 100)); // E-X has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 100)); // X-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 700, 100)); // G-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 300), 700, 100)); // Y-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 1000), 700, 500)); // F-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 700)); // D-C has #1
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

            Assume.That(() => 13 == edges.Count, "Expected: edge count 13");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 500, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 500, 1000, 0), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 300, 500, 300, 1000), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 300, 500, 300, 0), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-G"); // A-G
            Assume.That(() => HasEdge(edges, 1000, 1000, 300, 1000), "Expected: has edge C-E"); // C-E
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge E-X"); // E-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-G"); // X-G
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge G-Y"); // G-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge F-D"); // F-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge D-C"); // D-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 500, 500), 500, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 500, 500), 500, 300)); // A-B has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 700, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 1000), 500, 700)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 700, 500)); // B-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 500, 1000, 0), 500, 300)); // B-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 300, 1000), 500, 700)); // A-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 300, 1000), 100, 700)); // A-E has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 300, 0), 100, 300)); // A-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 300, 0), 500, 300)); // A-F has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 500), 100, 700)); // A-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 500), 100, 300)); // A-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 300, 1000), 500, 700)); // C-E has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 0, 1000), 100, 700)); // E-X has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 100, 700)); // X-G has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 100, 300)); // G-Y has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 100, 300)); // Y-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 0), 500, 300)); // F-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 500)); // D-C has #1
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

            Assume.That(() => 17 == edges.Count, "Expected: edge count 17");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 300, 500, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 700, 0, 700), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 700, 1000, 700), "Expected: has edge B-G"); // B-G
            Assume.That(() => HasEdge(edges, 500, 300, 0, 300), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 300, 1000, 300), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 500, 300, 500, 0), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 500, 700, 500, 1000), "Expected: has edge B-H"); // B-H
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 0, 700, 0, 300), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0), "Expected: has edge D-X"); // D-X
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-E"); // X-E
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge E-Y"); // E-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 700), "Expected: has edge F-G"); // F-G
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 1000), "Expected: has edge G-Z"); // G-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-H"); // Z-H
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge H-W"); // H-W

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 700), 300, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 700), 700, 500)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 0, 700), 300, 900)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 0, 700), 300, 500)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 1000, 700), 700, 900)); // B-G has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 1000, 700), 700, 500)); // B-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 0, 300), 300, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 0, 300), 300, 100)); // A-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 1000, 300), 700, 500)); // A-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 1000, 300), 700, 100)); // A-F has #6
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 0), 300, 100)); // A-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 300, 500, 0), 700, 100)); // A-E has #6
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 500, 1000), 300, 900)); // B-H has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 700, 500, 1000), 700, 900)); // B-H has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 700), 300, 900)); // W-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 300), 300, 500)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 0), 300, 100)); // D-X has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 100)); // X-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 700, 100)); // E-Y has #6
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 300), 700, 100)); // Y-F has #6
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 700), 700, 500)); // F-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 1000), 700, 900)); // G-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 700, 900)); // Z-H has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 300, 900)); // H-W has #1
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

            Assume.That(() => 17 == edges.Count, "Expected: edge count 17");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 500, 700, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 700, 500, 700, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 700, 500, 700, 0), "Expected: has edge B-G"); // B-G
            Assume.That(() => HasEdge(edges, 300, 500, 300, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 300, 500, 300, 0), "Expected: has edge A-F"); // A-F
            Assume.That(() => HasEdge(edges, 300, 500, 0, 500), "Expected: has edge A-E"); // A-E
            Assume.That(() => HasEdge(edges, 700, 500, 1000, 500), "Expected: has edge B-H"); // B-H
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 700, 1000, 300, 1000), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 300, 1000, 0, 1000), "Expected: has edge D-X"); // D-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-E"); // X-E
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge E-Y"); // E-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-F"); // Y-F
            Assume.That(() => HasEdge(edges, 300, 0, 700, 0), "Expected: has edge F-G"); // F-G
            Assume.That(() => HasEdge(edges, 700, 0, 1000, 0), "Expected: has edge G-Z"); // G-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-H"); // Z-H
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge H-W"); // H-W

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 700, 500), 500, 700)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 700, 500), 500, 300)); // A-B has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 700, 1000), 900, 700)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 700, 1000), 500, 700)); // B-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 700, 0), 900, 300)); // B-G has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 700, 0), 500, 300)); // B-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 300, 1000), 500, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 300, 1000), 100, 700)); // A-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 300, 0), 500, 300)); // A-F has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 300, 0), 100, 300)); // A-F has #6
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 500), 100, 700)); // A-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 500, 0, 500), 100, 300)); // A-E has #6
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 500), 900, 700)); // B-H has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 500, 1000, 500), 900, 300)); // B-H has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 700, 1000), 900, 700)); // W-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 300, 1000), 500, 700)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 0, 1000), 100, 700)); // D-X has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 100, 700)); // X-E has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 100, 300)); // E-Y has #6
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 100, 300)); // Y-F has #6
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 700, 0), 500, 300)); // F-G has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 1000, 0), 900, 300)); // G-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 900, 300)); // Z-H has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 900, 700)); // H-W has #1
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

            Assume.That(() => 12 == edges.Count, "Expected: edge count 12");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 500, 500, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 500), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 1000, 500, 500, 1000), "Expected: has edge D-A"); // D-A
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-B"); // X-B
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge B-Y"); // B-Y
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge C-W"); // C-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge D-Z"); // D-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-A"); // Z-A
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge A-X"); // A-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 500), 0, 1000)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 500), 500, 500)); // A-B has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 500, 0), 0, 0)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 500, 0), 500, 500)); // B-C has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 500), 1000, 0)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 500), 500, 500)); // C-D has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 500, 1000), 1000, 1000)); // D-A has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 500, 1000), 500, 500)); // D-A has #5
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 0, 1000)); // X-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 0, 0)); // B-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 0, 0)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 1000, 0)); // C-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 1000, 0)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 1000, 1000)); // D-Z has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 1000, 1000)); // Z-A has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 0, 1000)); // A-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 500, 1000, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge C-B"); // C-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 1000), 300, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 1000), 500, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 0), 300, 100)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 1000, 0), 500, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 300, 900)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 300, 100)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 100)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 500, 500)); // C-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 300, 900)); // B-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 1000, 1000, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge C-B"); // C-B
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 1000, 0), 900, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 1000, 0), 500, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 0), 100, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 0), 500, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 900, 700)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 100, 700)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 100, 700)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 500)); // C-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 900, 700)); // B-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 500, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 500, 0, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge C-B"); // C-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 0, 0), 700, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 0, 0), 500, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 0, 1000), 700, 900)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 0, 1000), 500, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 700, 100)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 700, 900)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 900)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 500, 500)); // C-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 700, 100)); // B-X has #1
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

            Assume.That(() => 7 == edges.Count, "Expected: edge count 7");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 0, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge C-B"); // C-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge B-X"); // B-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 0, 1000), 100, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 0, 1000), 500, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 1000), 900, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 1000), 500, 500)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 100, 300)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 900, 300)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 900, 300)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 500)); // C-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 100, 300)); // B-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 600, 800, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 400, 800, 0), "Expected: has edge D-C"); // D-C
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 600, 0, 400), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0), "Expected: has edge D-Y"); // D-Y
            Assume.That(() => HasEdge(edges, 0, 0, 800, 0), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 800, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge Z-W"); // Z-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge W-B"); // W-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 800, 1000), 100, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 800, 1000), 300, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 800, 0), 100, 100)); // D-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 800, 0), 300, 500)); // D-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 0, 1000), 100, 900)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 600), 100, 900)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 400), 300, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 0), 100, 100)); // D-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 800, 0), 100, 100)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 1000, 0), 300, 500)); // C-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 300, 500)); // Z-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 800, 1000), 300, 500)); // W-B has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 1000, 1000, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 200), "Expected: has edge D-C"); // D-C
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 600, 1000, 400, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge D-Y"); // D-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge Z-W"); // Z-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge W-B"); // W-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 1000, 200), 900, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 1000, 200), 500, 700)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 200), 100, 900)); // D-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 200), 500, 700)); // D-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 1000), 900, 900)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 600, 1000), 900, 900)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 400, 1000), 500, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 1000), 100, 900)); // D-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 200), 100, 900)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 500, 700)); // C-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 500, 700)); // Z-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 200), 500, 700)); // W-B has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 400, 200, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 600, 200, 1000), "Expected: has edge D-C"); // D-C
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 600), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge D-Y"); // D-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 200, 1000), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 200, 1000, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge Z-W"); // Z-W
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge W-B"); // W-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 200, 0), 900, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 200, 0), 700, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 200, 1000), 900, 900)); // D-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 200, 1000), 700, 500)); // D-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 1000, 0), 900, 100)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 400), 900, 100)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 600), 700, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 1000), 900, 900)); // D-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 200, 1000), 900, 900)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 0, 1000), 700, 500)); // C-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 700, 500)); // Z-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 700, 500)); // W-B has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 400, 0, 0, 800), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 800), "Expected: has edge D-C"); // D-C
            Assume.That(() => HasEdge(edges, 0, 800, 0, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 400, 0, 600, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge D-Y"); // D-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 800), "Expected: has edge Y-C"); // Y-C
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge Z-W"); // Z-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge W-B"); // W-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 0, 800), 100, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 0, 800), 500, 300)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 800), 900, 100)); // D-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 800), 500, 300)); // D-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 0), 100, 100)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 400, 0), 100, 100)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 600, 0), 500, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 0), 900, 100)); // D-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 800), 900, 100)); // Y-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 1000), 500, 300)); // C-Z has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 500, 300)); // Z-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 800), 500, 300)); // W-B has #3
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 600, 1200, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 600, 1200, 200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 600), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1200, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 200), "Expected: has edge W-B"); // W-B
            Assume.That(() => HasEdge(edges, 1200, 200, 1200, 1000), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 1200, 1000, 1200, 1200), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1200, 1200, 0, 1200), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 1200, 1000), 500, 600)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 1200, 1000), 400, 900)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 1200, 200), 500, 600)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 1200, 200), 400, 300)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 600), 400, 900)); // X-A has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 400, 300)); // A-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1200, 0), 400, 300)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 200), 400, 300)); // W-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 200, 1200, 1000), 500, 600)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1000, 1200, 1200), 400, 900)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 0, 1200), 400, 900)); // Z-X has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 1200, 1000, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 1200, 200, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1200, 1200, 600, 1200), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 600, 1200, 0, 1200), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge W-B"); // W-B
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 1000, 0, 1200, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 1200), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1200, 1000, 0), 600, 700)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1200, 1000, 0), 900, 800)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1200, 200, 0), 600, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1200, 200, 0), 300, 800)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 600, 1200), 900, 800)); // X-A has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1200, 0, 1200), 300, 800)); // A-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 0), 300, 800)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 300, 800)); // W-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 1000, 0), 600, 700)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1200, 0), 900, 800)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 1200), 900, 800)); // Z-X has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1200, 600, 0, 200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 1200, 600, 0, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 600), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1200, 600, 1200, 1200), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1200, 1200, 0, 1200), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 1000), "Expected: has edge W-B"); // W-B
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 200), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 200, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1200, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 600, 0, 200), 700, 600)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 600, 0, 200), 800, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 600, 0, 1000), 700, 600)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 600, 0, 1000), 800, 900)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 600), 800, 300)); // X-A has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 600, 1200, 1200), 800, 900)); // A-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 0, 1200), 800, 900)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 1000), 800, 900)); // W-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 200), 700, 600)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 0), 800, 300)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1200, 0), 800, 300)); // Z-X has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 600, 0, 200, 1200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 1200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 600, 0, 1200, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 1200), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1200, 1200, 1000, 1200), "Expected: has edge W-B"); // W-B
            Assume.That(() => HasEdge(edges, 1000, 1200, 200, 1200), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 200, 1200, 0, 1200), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 0), "Expected: has edge Z-X"); // Z-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 200, 1200), 600, 500)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 200, 1200), 300, 400)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 1200), 600, 500)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 1200), 900, 400)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 300, 400)); // X-A has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1200, 0), 900, 400)); // A-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 1200), 900, 400)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 1000, 1200), 900, 400)); // W-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1200, 200, 1200), 600, 500)); // B-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1200, 0, 1200), 300, 400)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 0), 300, 400)); // Z-X has #2
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 700, 1200, 1100), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1200, 100, 0, 500), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 1200, 100, 1200, 1100), "Expected: has edge C-B"); // C-B
            Assume.That(() => HasEdge(edges, 1200, 1100, 1200, 1200), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1200, 1200, 0, 1200), "Expected: has edge Z-X"); // Z-X
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 700), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 700, 0, 500), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge D-Y"); // D-Y
            Assume.That(() => HasEdge(edges, 0, 0, 1200, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 100), "Expected: has edge W-C"); // W-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1200, 1100), 200, 600)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 1200, 1100), 100, 900)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 100, 0, 500), 200, 600)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 100, 0, 500), 100, 300)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 100, 1200, 1100), 200, 600)); // C-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1100, 1200, 1200), 100, 900)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 0, 1200), 100, 900)); // Z-X has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 700), 100, 900)); // X-A has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 500), 200, 600)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 100, 300)); // D-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1200, 0), 100, 300)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 100), 100, 300)); // W-C has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 700, 1200, 1100, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 100, 0, 500, 1200), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 100, 0, 1100, 0), "Expected: has edge C-B"); // C-B
            Assume.That(() => HasEdge(edges, 1100, 0, 1200, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 1200), "Expected: has edge Z-X"); // Z-X
            Assume.That(() => HasEdge(edges, 1200, 1200, 700, 1200), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 700, 1200, 500, 1200), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 500, 1200, 0, 1200), "Expected: has edge D-Y"); // D-Y
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 0), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 0, 100, 0), "Expected: has edge W-C"); // W-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1200, 1100, 0), 600, 1000)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1200, 1100, 0), 900, 1100)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 100, 0, 500, 1200), 600, 1000)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 100, 0, 500, 1200), 300, 1100)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 100, 0, 1100, 0), 600, 1000)); // C-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1100, 0, 1200, 0), 900, 1100)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 1200), 900, 1100)); // Z-X has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 700, 1200), 900, 1100)); // X-A has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1200, 500, 1200), 600, 1000)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1200, 0, 1200), 300, 1100)); // D-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 0), 300, 1100)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 100, 0), 300, 1100)); // W-C has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1200, 500, 0, 100), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1100, 1200, 700), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 0, 1100, 0, 100), "Expected: has edge C-B"); // C-B
            Assume.That(() => HasEdge(edges, 0, 100, 0, 0), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 0, 0, 1200, 0), "Expected: has edge Z-X"); // Z-X
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 500), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1200, 500, 1200, 700), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1200, 700, 1200, 1200), "Expected: has edge D-Y"); // D-Y
            Assume.That(() => HasEdge(edges, 1200, 1200, 0, 1200), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 1100), "Expected: has edge W-C"); // W-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 500, 0, 100), 1000, 600)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 500, 0, 100), 1100, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1100, 1200, 700), 1000, 600)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1100, 1200, 700), 1100, 900)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1100, 0, 100), 1000, 600)); // C-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 100, 0, 0), 1100, 300)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1200, 0), 1100, 300)); // Z-X has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 500), 1100, 300)); // X-A has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 500, 1200, 700), 1000, 600)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 700, 1200, 1200), 1100, 900)); // D-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 0, 1200), 1100, 900)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 1100), 1100, 900)); // W-C has #3
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 500, 0, 100, 1200), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1100, 1200, 700, 0), "Expected: has edge C-D"); // C-D
            Assume.That(() => HasEdge(edges, 1100, 1200, 100, 1200), "Expected: has edge C-B"); // C-B
            Assume.That(() => HasEdge(edges, 100, 1200, 0, 1200), "Expected: has edge B-Z"); // B-Z
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 0), "Expected: has edge Z-X"); // Z-X
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 500, 0, 700, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 700, 0, 1200, 0), "Expected: has edge D-Y"); // D-Y
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 1200), "Expected: has edge Y-W"); // Y-W
            Assume.That(() => HasEdge(edges, 1200, 1200, 1100, 1200), "Expected: has edge W-C"); // W-C

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 100, 1200), 600, 200)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 100, 1200), 300, 100)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1100, 1200, 700, 0), 600, 200)); // C-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1100, 1200, 700, 0), 900, 100)); // C-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1100, 1200, 100, 1200), 600, 200)); // C-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 100, 1200, 0, 1200), 300, 100)); // B-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 0), 300, 100)); // Z-X has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 300, 100)); // X-A has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 700, 0), 600, 200)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 1200, 0), 900, 100)); // D-Y has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 1200), 900, 100)); // Y-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 1100, 1200), 900, 100)); // W-C has #3
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 200, 200, 600, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 200, 200, 1000, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 200, 200, 0, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-D"); // X-D
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 600), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 200, 600, 1000), 300, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 200, 600, 1000), 700, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 200, 1000, 600), 700, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 200, 1000, 600), 900, 300)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 200, 0, 0), 300, 900)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 200, 0, 0), 900, 300)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 0, 1000), 300, 900)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 900)); // X-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 900, 300)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 600), 900, 300)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 1000), 700, 700)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 600, 1000), 700, 700)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 200, 800, 1000, 400), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 200, 800, 600, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 200, 800, 0, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-D"); // X-D
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 600, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 800, 1000, 400), 900, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 800, 1000, 400), 700, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 800, 600, 0), 700, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 800, 600, 0), 300, 100)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 800, 0, 1000), 900, 700)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 800, 0, 1000), 300, 100)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 1000), 900, 700)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 900, 700)); // X-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 100)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 300, 100)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1000, 0), 700, 300)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 400), 700, 300)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 800, 800, 400, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 800, 800, 0, 400), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 800, 800, 1000, 1000), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-D"); // X-D
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 400), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 0, 400, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 800, 400, 0), 700, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 800, 400, 0), 300, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 800, 0, 400), 300, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 800, 0, 400), 100, 700)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 800, 1000, 1000), 700, 100)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 800, 1000, 1000), 100, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 0), 700, 100)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 100)); // X-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 100, 700)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 400), 100, 700)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 0), 300, 300)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 400, 0), 300, 300)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 800, 200, 0, 600), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 800, 200, 400, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 800, 200, 1000, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-D"); // X-D
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge D-W"); // D-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 400, 1000), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 400, 1000, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 200, 0, 600), 100, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 200, 0, 600), 300, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 200, 400, 1000), 300, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 200, 400, 1000), 700, 900)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 200, 1000, 0), 100, 300)); // A-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 200, 1000, 0), 700, 900)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 100, 300)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 100, 300)); // X-D has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 900)); // D-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 400, 1000), 700, 900)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 0, 1000), 300, 700)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 600), 300, 700)); // Z-B has #2
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 500, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 500), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 1000), 100, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 1000), 500, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 500), 500, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 500), 700, 100)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 100, 700)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 100, 700)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 700, 100)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 700, 100)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 500, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 500, 500)); // Z-B has #2
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 1000, 500, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 1000, 500, 1000, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 500), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 500), 700, 900)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 500), 500, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 500, 0), 500, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 500, 0), 100, 300)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 500, 1000, 1000), 700, 900)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 900)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 100, 300)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 100, 300)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 500, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 500), 500, 500)); // Z-B has #2
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 500), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 500, 0, 1000, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 0, 500, 0), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 0), 900, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 0), 500, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 500), 500, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 500), 300, 900)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 0, 1000, 0), 900, 300)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 900, 300)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 300, 900)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 300, 900)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 500, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 500, 0), 500, 500)); // Z-B has #2
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

            Assume.That(() => 8 == edges.Count, "Expected: edge count 8");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 500), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 0, 500, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 500, 0, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 500, 1000), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 500, 1000, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 500), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 500), 300, 100)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 500), 500, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 500, 1000), 500, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 500, 1000), 900, 700)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 500, 0, 0), 300, 100)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 100)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 900, 700)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 500, 1000), 900, 700)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 500, 1000, 0, 1000), 500, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 500), 500, 500)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 200, 0, 700, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 400), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 1000, 0, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 200, 0), "Expected: has edge Y-A"); // Y-A
            Assume.That(() => HasEdge(edges, 200, 0, 1000, 0), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 400), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 1000, 400, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 700, 1000), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 700, 1000), 300, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 700, 1000), 700, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 1000, 400), 700, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 1000, 400), 900, 100)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 1000, 0, 1000), 300, 700)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 0), 300, 700)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 200, 0), 300, 700)); // Y-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 0, 1000, 0), 900, 100)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 400), 900, 100)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 400, 1000, 1000), 700, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 700, 1000), 700, 500)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 800, 1000, 300), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 800, 400, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 1000, 300, 1000, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 800), "Expected: has edge Y-A"); // Y-A
            Assume.That(() => HasEdge(edges, 0, 800, 0, 0), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 0, 0, 400, 0), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 400, 0, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 300), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 1000, 300), 700, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 1000, 300), 500, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 400, 0), 500, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 400, 0), 100, 100)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 300, 1000, 1000), 700, 700)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 0, 1000), 700, 700)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 800), 700, 700)); // Y-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 800, 0, 0), 100, 100)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 400, 0), 100, 100)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 0, 1000, 0), 500, 300)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 300), 500, 300)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 800, 1000, 300, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 0, 1000, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 800, 1000), "Expected: has edge Y-A"); // Y-A
            Assume.That(() => HasEdge(edges, 800, 1000, 0, 1000), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 600), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 300, 0), 700, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 300, 0), 300, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 0, 600), 300, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 0, 600), 100, 900)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1000, 0), 700, 300)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 1000), 700, 300)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 800, 1000), 700, 300)); // Y-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 1000, 0, 1000), 100, 900)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 600), 100, 900)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 300, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 300, 500)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 200, 0, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 200, 600, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 700, 0, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 0, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 1000, 200), "Expected: has edge Y-A"); // Y-A
            Assume.That(() => HasEdge(edges, 1000, 200, 1000, 1000), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 600, 1000), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 600, 1000, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 0, 700), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 0, 700), 300, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 0, 700), 500, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 600, 1000), 500, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 600, 1000), 900, 900)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 700, 0, 0), 300, 300)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 1000, 0), 300, 300)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 1000, 200), 300, 300)); // Y-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 200, 1000, 1000), 900, 900)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 600, 1000), 900, 900)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1000, 0, 1000), 500, 700)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 0, 700), 500, 700)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 800, 0, 300, 1000), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 800, 0, 0, 400), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 1000, 1000, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 0, 800, 0), "Expected: has edge Y-A"); // Y-A
            Assume.That(() => HasEdge(edges, 800, 0, 0, 0), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 0, 0, 0, 400), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 0, 400, 0, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 1000, 300, 1000), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 300, 1000), 700, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 300, 1000), 300, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 0, 400), 300, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 0, 400), 100, 100)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1000, 1000, 1000), 700, 700)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 0), 700, 700)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 800, 0), 700, 700)); // Y-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 800, 0, 0, 0), 100, 100)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 400), 100, 100)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 400, 0, 1000), 300, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 300, 1000), 300, 500)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 200, 1000, 700), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 200, 400, 1000), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 1000, 700, 1000, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 1000, 0, 0, 0), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 0, 0, 200), "Expected: has edge Y-A"); // Y-A
            Assume.That(() => HasEdge(edges, 0, 200, 0, 1000), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 0, 1000, 400, 1000), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 400, 1000, 1000, 1000), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 700), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 1000, 700), 700, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 1000, 700), 500, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 400, 1000), 500, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 400, 1000), 100, 900)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 700, 1000, 0), 700, 300)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 0, 0), 700, 300)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 200), 700, 300)); // Y-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 200, 0, 1000), 100, 900)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 400, 1000), 100, 900)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 400, 1000, 1000, 1000), 500, 700)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 700), 500, 700)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 200, 1000, 700, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 200, 1000, 1000, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 700, 0, 0, 0), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 0, 0, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 0, 1000, 200, 1000), "Expected: has edge Y-A"); // Y-A
            Assume.That(() => HasEdge(edges, 200, 1000, 1000, 1000), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 600), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 1000, 600, 1000, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 1000, 0, 700, 0), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 700, 0), 300, 300)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 700, 0), 700, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 1000, 600), 700, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 1000, 600), 900, 900)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 700, 0, 0, 0), 300, 300)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 1000), 300, 300)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 200, 1000), 300, 300)); // Y-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 200, 1000, 1000, 1000), 900, 900)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 600), 900, 900)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 600, 1000, 0), 700, 500)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 700, 0), 700, 500)); // Z-B has #2
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1000, 800, 0, 300), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 1000, 800, 600, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 300, 0, 1000), "Expected: has edge B-X"); // B-X
            Assume.That(() => HasEdge(edges, 0, 1000, 1000, 1000), "Expected: has edge X-Y"); // X-Y
            Assume.That(() => HasEdge(edges, 1000, 1000, 1000, 800), "Expected: has edge Y-A"); // Y-A
            Assume.That(() => HasEdge(edges, 1000, 800, 1000, 0), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 1000, 0, 600, 0), "Expected: has edge W-C"); // W-C
            Assume.That(() => HasEdge(edges, 600, 0, 0, 0), "Expected: has edge C-Z"); // C-Z
            Assume.That(() => HasEdge(edges, 0, 0, 0, 300), "Expected: has edge Z-B"); // Z-B

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 0, 300), 300, 700)); // A-B has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 0, 300), 500, 300)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 600, 0), 500, 300)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 600, 0), 900, 100)); // A-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 1000), 300, 700)); // B-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1000, 1000, 1000), 300, 700)); // X-Y has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 1000, 1000, 800), 300, 700)); // Y-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 800, 1000, 0), 900, 100)); // A-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1000, 0, 600, 0), 900, 100)); // W-C has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 0, 0), 500, 300)); // C-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 0, 300), 500, 300)); // Z-B has #2
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 300, 600, 1200), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 300, 0, 1200, 600), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 300), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 300, 0, 1200, 0), "Expected: has edge B-W"); // B-W
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 600), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 1200, 600, 1200, 1200), "Expected: has edge D-Z"); // D-Z
            Assume.That(() => HasEdge(edges, 1200, 1200, 600, 1200), "Expected: has edge Z-C"); // Z-C
            Assume.That(() => HasEdge(edges, 600, 1200, 0, 1200), "Expected: has edge C-X"); // C-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 600, 1200), 100, 1100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 600, 1200), 700, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1200, 600), 700, 700)); // B-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1200, 600), 1100, 100)); // B-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 300), 100, 1100)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 0), 700, 700)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 700, 700)); // Y-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 1200, 0), 1100, 100)); // B-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 600), 1100, 100)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 600, 1200, 1200), 700, 700)); // D-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 600, 1200), 700, 700)); // Z-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1200, 0, 1200), 100, 1100)); // C-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 300, 1200, 1200, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 900, 600, 0), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 1200, 1200, 300, 1200), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 300, 1200, 0, 1200), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 900), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 0, 900, 0, 0), "Expected: has edge B-W"); // B-W
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 600, 0, 1200, 0), "Expected: has edge D-Z"); // D-Z
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 600), "Expected: has edge Z-C"); // Z-C
            Assume.That(() => HasEdge(edges, 1200, 600, 1200, 1200), "Expected: has edge C-X"); // C-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1200, 1200, 600), 1100, 1100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1200, 1200, 600), 700, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 600, 0), 700, 500)); // B-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 600, 0), 100, 100)); // B-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 300, 1200), 1100, 1100)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 1200, 0, 1200), 700, 500)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 900), 700, 500)); // Y-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 0, 0), 100, 100)); // B-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 100, 100)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1200, 0), 700, 500)); // D-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 600), 700, 500)); // Z-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 600, 1200, 1200), 1100, 1100)); // C-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 1200, 900, 600, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 900, 1200, 0, 600), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 900), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 1200, 900, 1200, 1200), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1200, 1200, 900, 1200), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 900, 1200, 0, 1200), "Expected: has edge B-W"); // B-W
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 600), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge D-Z"); // D-Z
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge Z-C"); // Z-C
            Assume.That(() => HasEdge(edges, 600, 0, 1200, 0), "Expected: has edge C-X"); // C-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 900, 600, 0), 1100, 100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 900, 600, 0), 500, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 1200, 0, 600), 500, 500)); // B-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 1200, 0, 600), 100, 1100)); // B-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 900), 1100, 100)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 900, 1200, 1200), 500, 500)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 900, 1200), 500, 500)); // Y-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 1200, 0, 1200), 100, 1100)); // B-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 600), 100, 1100)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 500, 500)); // D-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 500, 500)); // Z-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 1200, 0), 1100, 100)); // C-X has #1
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

            Assume.That(() => 10 == edges.Count, "Expected: edge count 10");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 900, 0, 0, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 1200, 300, 600, 1200), "Expected: has edge B-D"); // B-D
            Assume.That(() => HasEdge(edges, 0, 0, 900, 0), "Expected: has edge X-A"); // X-A
            Assume.That(() => HasEdge(edges, 900, 0, 1200, 0), "Expected: has edge A-Y"); // A-Y
            Assume.That(() => HasEdge(edges, 1200, 0, 1200, 300), "Expected: has edge Y-B"); // Y-B
            Assume.That(() => HasEdge(edges, 1200, 300, 1200, 1200), "Expected: has edge B-W"); // B-W
            Assume.That(() => HasEdge(edges, 1200, 1200, 600, 1200), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 600, 1200, 0, 1200), "Expected: has edge D-Z"); // D-Z
            Assume.That(() => HasEdge(edges, 0, 1200, 0, 600), "Expected: has edge Z-C"); // Z-C
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge C-X"); // C-X

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 0, 600), 100, 100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 0, 600), 500, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 300, 600, 1200), 500, 700)); // B-D has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 300, 600, 1200), 1100, 1100)); // B-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 900, 0), 100, 100)); // X-A has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 1200, 0), 500, 700)); // A-Y has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 0, 1200, 300), 500, 700)); // Y-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 300, 1200, 1200), 1100, 1100)); // B-W has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 1200, 1200, 600, 1200), 1100, 1100)); // W-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 1200, 0, 1200), 500, 700)); // D-Z has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 1200, 0, 600), 500, 700)); // Z-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 100, 100)); // C-X has #1
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 0, 900, 900), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 0, 300, 900), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 0, 900, 300), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 0, 900, 0), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 900, 0, 900, 300), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 900, 300, 900, 900), "Expected: has edge D-B"); // D-B
            Assume.That(() => HasEdge(edges, 900, 900, 300, 900), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 300, 900, 0, 900), "Expected: has edge C-X"); // C-X
            Assume.That(() => HasEdge(edges, 0, 900, 0, 0), "Expected: has edge X-A"); // X-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 900, 900), 400, 700)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 900, 900), 700, 400)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 900), 100, 800)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 900), 400, 700)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 900, 300), 700, 400)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 900, 300), 800, 100)); // A-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 900, 0), 800, 100)); // A-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 900, 300), 800, 100)); // W-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 300, 900, 900), 700, 400)); // D-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 300, 900), 400, 700)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 900, 0, 900), 100, 800)); // C-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 0, 0), 100, 800)); // X-A has #1
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 0, 900, 900, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 0, 900, 900, 600), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 0, 900, 300, 0), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 0, 900, 0, 0), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 0, 0, 300, 0), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 300, 0, 900, 0), "Expected: has edge D-B"); // D-B
            Assume.That(() => HasEdge(edges, 900, 0, 900, 600), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 900, 600, 900, 900), "Expected: has edge C-X"); // C-X
            Assume.That(() => HasEdge(edges, 900, 900, 0, 900), "Expected: has edge X-A"); // X-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 900, 0), 700, 500)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 900, 0), 400, 200)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 900, 600), 800, 800)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 900, 600), 700, 500)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 300, 0), 400, 200)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 300, 0), 100, 100)); // A-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 0, 0), 100, 100)); // A-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 300, 0), 100, 100)); // W-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 300, 0, 900, 0), 400, 200)); // D-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 900, 600), 700, 500)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 600, 900, 900), 800, 800)); // C-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 0, 900), 800, 800)); // X-A has #1
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 900, 900, 0, 0), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 900, 900, 600, 0), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 900, 900, 0, 600), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 900, 900, 0, 900), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 0, 900, 0, 600), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 0, 600, 0, 0), "Expected: has edge D-B"); // D-B
            Assume.That(() => HasEdge(edges, 0, 0, 600, 0), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 600, 0, 900, 0), "Expected: has edge C-X"); // C-X
            Assume.That(() => HasEdge(edges, 900, 0, 900, 900), "Expected: has edge X-A"); // X-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 0, 0), 500, 200)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 0, 0), 200, 500)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 600, 0), 800, 100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 600, 0), 500, 200)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 0, 600), 200, 500)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 0, 600), 100, 800)); // A-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 0, 900), 100, 800)); // A-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 0, 600), 100, 800)); // W-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 600, 0, 0), 200, 500)); // D-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 600, 0), 500, 200)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 0, 900, 0), 800, 100)); // C-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 900, 900), 800, 100)); // X-A has #1
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

            Assume.That(() => 9 == edges.Count, "Expected: edge count 9");
            Assume.That(() => null != edges);
            Assume.That(() => HasEdge(edges, 900, 0, 0, 900), "Expected: has edge A-B"); // A-B
            Assume.That(() => HasEdge(edges, 900, 0, 0, 300), "Expected: has edge A-C"); // A-C
            Assume.That(() => HasEdge(edges, 900, 0, 600, 900), "Expected: has edge A-D"); // A-D
            Assume.That(() => HasEdge(edges, 900, 0, 900, 900), "Expected: has edge A-W"); // A-W
            Assume.That(() => HasEdge(edges, 900, 900, 600, 900), "Expected: has edge W-D"); // W-D
            Assume.That(() => HasEdge(edges, 600, 900, 0, 900), "Expected: has edge D-B"); // D-B
            Assume.That(() => HasEdge(edges, 0, 900, 0, 300), "Expected: has edge B-C"); // B-C
            Assume.That(() => HasEdge(edges, 0, 300, 0, 0), "Expected: has edge C-X"); // C-X
            Assume.That(() => HasEdge(edges, 0, 0, 900, 0), "Expected: has edge X-A"); // X-A

            // Assert

            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 0, 900), 200, 400)); // A-B has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 0, 900), 500, 700)); // A-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 0, 300), 100, 100)); // A-C has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 0, 300), 200, 400)); // A-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 600, 900), 500, 700)); // A-D has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 600, 900), 800, 800)); // A-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 0, 900, 900), 800, 800)); // A-W has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 900, 900, 600, 900), 800, 800)); // W-D has #4
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 600, 900, 0, 900), 500, 700)); // D-B has #3
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 900, 0, 300), 200, 400)); // B-C has #2
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 300, 0, 0), 100, 100)); // C-X has #1
            ClassicAssert.IsTrue(EdgeHasSite(FindEdge(edges, 0, 0, 900, 0), 100, 100)); // X-A has #1
        }

    }
}
