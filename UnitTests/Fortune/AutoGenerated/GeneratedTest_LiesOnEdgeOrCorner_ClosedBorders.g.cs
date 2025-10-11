using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static SharpVoronoiLib.UnitTests.CommonTestUtilities;

#pragma warning disable
// ReSharper disable All

namespace SharpVoronoiLib.UnitTests;

/// <summary>
/// These tests assert that <see cref="VoronoiSite"/>`s have expected flags for being on an edge or corner.
/// Specifically, that the <see cref="VoronoiSite.LiesOnEdge"/> is set when the site is on exactly one of its <see cref="VoronoiSite.Cell"/> edges.
/// And that the <see cref="VoronoiSite.LiesOnCorner"/> is set when the site is on exactly two of its <see cref="VoronoiSite.Cell"/> edges, i.e. the point between them.
/// These tests are run with generating the border edges, i.e. <see cref="BorderEdgeGeneration.MakeBorderEdges"/>.
/// </summary>
/// <remarks>
/// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.
/// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.
/// It contains a bunch of known Voronoi site layouts, including many edge cases.
/// </remarks>
[Parallelizable(ParallelScope.All)]
[TestFixture]
public class GeneratedTest_LiesOnEdgeOrCorner_ClosedBorders
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X


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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 0, 1000, 0, 0))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 1000, 1000, 0, 1000))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 1000, 0, 1000, 1000))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 0, 0, 1000, 0))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 0, 1000, 0, 0))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 1000, 1000, 0, 1000))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 1000, 0, 1000, 1000))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 0, 0, 1000, 0))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 1000, 1000, 1000, 0))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 1000, 0, 0, 0))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 0, 0, 0, 1000))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Not.Null);// #1
        Assert.That(sites[0].LiesOnEdge, Is.EqualTo(FindEdge(edges, 0, 1000, 1000, 1000))); // #1 on X-Y
        Assert.That(sites[0].LiesOnCorner, Is.Null); // #1
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Not.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.EqualTo(FindPoint(edges, 0, 0))); // #1 on Y
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Not.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.EqualTo(FindPoint(edges, 0, 1000))); // #1 on Y
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Not.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.EqualTo(FindPoint(edges, 1000, 1000))); // #1 on Y
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

        Assume.That(edges.Count, Is.EqualTo(4), "Expected: edge count 4");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Not.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.EqualTo(FindPoint(edges, 1000, 0))); // #1 on Y
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 500, 1000, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge W-B"); // W-B
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 1000, 500, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge W-B"); // W-B
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 700, 1000, 700), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 700, 0, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 700), Is.True, "Expected: has edge W-B"); // W-B
        Assume.That(HasEdge(edges, 1000, 700, 1000, 1000), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 700), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 700), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 700), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 1000, 700, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 700, 1000, 0, 1000), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 700, 0), Is.True, "Expected: has edge W-B"); // W-B
        Assume.That(HasEdge(edges, 700, 0, 1000, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 700, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 700, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 700, 1000, 700), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 300, 1000, 300), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 700, 0, 300), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 300, 0, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 300), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 1000, 300, 1000, 700), Is.True, "Expected: has edge D-B"); // D-B
        Assume.That(HasEdge(edges, 1000, 700, 1000, 1000), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 700), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 700), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 700), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 300), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 300), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 300), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 300), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 1000, 700, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 300, 1000, 300, 0), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 700, 1000, 300, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 300, 1000, 0, 1000), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 300, 0, 700, 0), Is.True, "Expected: has edge D-B"); // D-B
        Assume.That(HasEdge(edges, 700, 0, 1000, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 700, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 700, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 300, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 300, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 300, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(13), "Expected: edge count 13");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 700, 1000, 700), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 500, 1000, 500), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 0, 300, 1000, 300), Is.True, "Expected: has edge E-F"); // E-F
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 700, 0, 500), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 500, 0, 300), Is.True, "Expected: has edge C-E"); // C-E
        Assume.That(HasEdge(edges, 0, 300, 0, 0), Is.True, "Expected: has edge E-Y"); // E-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 300), Is.True, "Expected: has edge W-F"); // W-F
        Assume.That(HasEdge(edges, 1000, 300, 1000, 500), Is.True, "Expected: has edge F-D"); // F-D
        Assume.That(HasEdge(edges, 1000, 500, 1000, 700), Is.True, "Expected: has edge D-B"); // D-B
        Assume.That(HasEdge(edges, 1000, 700, 1000, 1000), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 700), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 700), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Z"); // #1 has Z
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 700), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 300), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 300), Is.True, "Expected: site #3 has F"); // #3 has F
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 0, 300), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 1000, 300), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has W"); // #4 has W
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has Y"); // #4 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(13), "Expected: edge count 13");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 1000, 700, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 1000, 500, 0), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 300, 1000, 300, 0), Is.True, "Expected: has edge E-F"); // E-F
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 700, 1000, 500, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 1000, 300, 1000), Is.True, "Expected: has edge C-E"); // C-E
        Assume.That(HasEdge(edges, 300, 1000, 0, 1000), Is.True, "Expected: has edge E-Y"); // E-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge W-F"); // W-F
        Assume.That(HasEdge(edges, 300, 0, 500, 0), Is.True, "Expected: has edge F-D"); // F-D
        Assume.That(HasEdge(edges, 500, 0, 700, 0), Is.True, "Expected: has edge D-B"); // D-B
        Assume.That(HasEdge(edges, 700, 0, 1000, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 700, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Z"); // #1 has Z
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 700, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 300, 1000), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 300, 0), Is.True, "Expected: site #3 has F"); // #3 has F
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 300, 1000), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 300, 0), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has W"); // #4 has W
        Assume.That(HasPoint(sites[3].Points, 0, 1000), Is.True, "Expected: site #4 has Y"); // #4 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(5), "Expected: edge count 5");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 1000, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(5), "Expected: edge count 5");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 1000, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 200, 800, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 200), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 800, 1000), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 800, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 200), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 800, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 200), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 800, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 200, 1000, 1000, 200), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 200, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 200, 1000, 0, 1000), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 200), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 1000, 200, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 200, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 200), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 200, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 200), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 800, 200, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 0, 1000, 800), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1000, 800, 1000, 1000), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 200, 0, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 800), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 200, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 800), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 200, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 800, 0, 0, 800), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 800, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 800, 0, 1000, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 800), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 0, 800, 0, 0), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 800, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 800), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 800, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 800), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(5), "Expected: edge count 5");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 1000, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-A"); // Y-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(5), "Expected: edge count 5");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 0, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-A"); // Y-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(5), "Expected: edge count 5");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 0, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-A"); // Y-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(5), "Expected: edge count 5");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 1000, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-A"); // Y-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(6), "Expected: edge count 6");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 1000, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-A"); // Z-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(6), "Expected: edge count 6");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 500, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-A"); // Z-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(6), "Expected: edge count 6");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 0, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Z-A"); // Z-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(6), "Expected: edge count 6");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 500, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Z-A"); // Z-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(6), "Expected: edge count 6");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 0, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 0, 500), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 0, 500, 0, 1000), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge Z-A"); // Z-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(6), "Expected: edge count 6");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 500, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 500, 1000), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 500, 1000, 1000, 1000), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge Z-A"); // Z-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(6), "Expected: edge count 6");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 1000, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 500), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 1000, 500, 1000, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge Z-A"); // Z-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(6), "Expected: edge count 6");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 500, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge A-X"); // A-X
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 500, 0), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 500, 0, 0, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge Z-A"); // Z-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 300, 700, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 300, 0, 1000, 700), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 1000, 0, 300), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 300, 0, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 300, 0, 1000, 0), Is.True, "Expected: has edge B-W"); // B-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 700), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 1000, 700, 1000, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 700, 1000, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 300), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 700, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(6), "Expected: site #2 point count 6"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 300), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 300, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 700), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 700, 1000), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 700), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 300, 1000, 1000, 300), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 700, 700, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 1000, 1000, 300, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 300, 1000, 0, 1000), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 0, 700, 0, 0), Is.True, "Expected: has edge B-W"); // B-W
        Assume.That(HasEdge(edges, 0, 0, 700, 0), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 700, 0, 1000, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 300), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 1000, 300, 1000, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 300, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 300), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(6), "Expected: site #2 point count 6"); // #2
        Assume.That(HasPoint(sites[1].Points, 300, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 700), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 700, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 300), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 700), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 700, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 400, 600, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 0, 1000, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 1000, 0, 400), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 400, 0, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 1000, 1000, 600, 1000), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 600, 1000, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 600, 1000), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 1000, 1000, 400), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 1000, 1000, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 1000, 1000, 400, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 400, 1000, 0, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 1000, 0, 1000, 400), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 1000, 400, 1000, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 400), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 400), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 600, 400, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 1000, 0, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 1000, 0, 1000, 600), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1000, 600, 1000, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 0, 0, 400, 0), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 400, 0, 1000, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 400, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 400, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 0, 0, 600), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 0, 0, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 600, 0, 1000, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 0, 1000, 0, 600), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 600), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(11), "Expected: edge count 11");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 400, 600, 1000), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 0, 0, 1000, 1000), Is.True, "Expected: has edge B-E"); // B-E
        Assume.That(HasEdge(edges, 400, 0, 1000, 600), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 400), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 400, 0, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 400, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 400, 0, 1000, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 600), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 1000, 600, 1000, 1000), Is.True, "Expected: has edge D-E"); // D-E
        Assume.That(HasEdge(edges, 1000, 1000, 600, 1000), Is.True, "Expected: has edge E-F"); // E-F
        Assume.That(HasEdge(edges, 600, 1000, 0, 1000), Is.True, "Expected: has edge F-X"); // F-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 1000), Is.True, "Expected: site #1 has F"); // #1 has F
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 600, 1000), Is.True, "Expected: site #2 has F"); // #2 has F
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 400, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 600), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(3), "Expected: site #4 point count 3"); // #4
        Assume.That(HasPoint(sites[3].Points, 400, 0), Is.True, "Expected: site #4 has C"); // #4 has C
        Assume.That(HasPoint(sites[3].Points, 1000, 600), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has Y"); // #4 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(11), "Expected: edge count 11");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 1000, 1000, 400), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 0, 1000, 1000, 0), Is.True, "Expected: has edge B-E"); // B-E
        Assume.That(HasEdge(edges, 0, 600, 600, 0), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 1000, 1000, 400, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 400, 1000, 0, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 600), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 600, 0, 1000, 0), Is.True, "Expected: has edge D-E"); // D-E
        Assume.That(HasEdge(edges, 1000, 0, 1000, 400), Is.True, "Expected: has edge E-F"); // E-F
        Assume.That(HasEdge(edges, 1000, 400, 1000, 1000), Is.True, "Expected: has edge F-X"); // F-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 400), Is.True, "Expected: site #1 has F"); // #1 has F
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 1000, 400), Is.True, "Expected: site #2 has F"); // #2 has F
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 600), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 600, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(3), "Expected: site #4 point count 3"); // #4
        Assume.That(HasPoint(sites[3].Points, 0, 600), Is.True, "Expected: site #4 has C"); // #4 has C
        Assume.That(HasPoint(sites[3].Points, 600, 0), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has Y"); // #4 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 400, 0, 400), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 400, 400, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 400, 400, 1000, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 400), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 400, 0, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 0, 400, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 400, 0, 1000, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 400), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 400, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 400, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 600, 400, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 600, 0, 600), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 400, 600, 1000, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 1000, 400, 1000), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 400, 1000, 0, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 600), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 400, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 600), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 600, 1000, 600), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 600, 600, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 600, 0, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 600), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 1000, 600, 1000, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 1000, 600, 1000), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 600, 1000, 0, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 600), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 600), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 600, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 600, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 400, 600, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 400, 1000, 400), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 400, 0, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 600, 0, 1000, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 400), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 1000, 400, 1000, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 400), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 400), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 300, 600, 0, 600), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 300, 600, 300, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 300, 600, 700, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 600), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 300, 0, 1000, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 700, 1000, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 300, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 600), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 700, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 300, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 300, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 300, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 700, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 700, 600, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 700, 0, 700), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 700, 1000, 300), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 1000, 600, 1000), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 600, 1000, 0, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 0, 700, 0, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 300), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 1000, 300, 1000, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 700), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 300), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 600, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 700), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 700), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 700), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 300), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 400, 1000, 400), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 700, 400, 700, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 700, 400, 300, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 400), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 1000, 400, 1000, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 700, 1000, 0, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 300, 0, 1000, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 400), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 300, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 400), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 700, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 700, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 700, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 300, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 300, 400, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 300, 1000, 300), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 400, 300, 0, 700), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 0, 400, 0), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 400, 0, 1000, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 300), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 1000, 300, 1000, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 0, 700, 0, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 300), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 400, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 700), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 300), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 400, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 300), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 300), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 300), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 700), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 600, 1000, 600), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 700, 600, 700, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 700, 600, 300, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 600), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 1000, 600, 1000, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 0, 700, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 700, 0, 0, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 300, 1000), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 300, 1000, 1000, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 600), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 300, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 600), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 700, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 700, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 700, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 300, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 300, 600, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 300, 0, 300), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 300, 1000, 700), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 0, 600, 0), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 600, 0, 0, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 0, 0, 300), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 0, 300, 0, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 700), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 1000, 700, 1000, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 300), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 700), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 300), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 300), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 300), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 300), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 700), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 300, 400, 0, 400), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 300, 400, 300, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 300, 400, 700, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 0, 0, 400), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 400, 0, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 1000, 300, 1000), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 300, 1000, 1000, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 700, 0), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 700, 0, 0, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 300, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 400), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 700, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 300, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 300, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 300, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 700, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 700, 400, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 700, 1000, 700), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 400, 700, 0, 300), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 1000, 400, 1000), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 400, 1000, 1000, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 700), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 1000, 700, 1000, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 0, 300), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 0, 300, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 700), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 400, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 300), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 700), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 700), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 700), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 300), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 500, 0, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 1000, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 500, 500, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 500, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has X"); // #3 has X

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 500, 0, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 0, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 500, 1000, 500), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has X"); // #3 has X

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 500, 1000, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 0, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 500, 500, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has X"); // #3 has X

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 500, 1000, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 1000, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 500, 0, 500), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has X"); // #3 has X

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 300, 200, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 300, 800, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 300, 500, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 200, 0, 800, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 800, 0, 1000, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 300), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 200, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 800, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 300), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 800, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 300), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 200, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 500, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 300, 500, 0, 800), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 300, 500, 0, 200), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 300, 500, 1000, 500), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 800), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 0, 800, 0, 200), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 300, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 800), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 300, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 800), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 700, 800, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 700, 200, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 700, 500, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 800, 1000), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 800, 1000, 200, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 200, 1000, 0, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 700), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 800, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 200, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 200, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 700), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 800, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 500, 1000, 200), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 700, 500, 1000, 800), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 700, 500, 0, 500), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 200), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 1000, 200, 1000, 800), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 1000, 800, 1000, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge W-Z"); // W-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 200), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 800), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 800), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 700, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 200), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 700, 0, 200), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 700, 1000, 200), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 700, 500, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 200), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 200), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 1000, 200, 1000, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(5), "Expected: site #1 point count 5"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 700), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 200), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 700), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 200), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 500, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has X"); // #3 has X

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 500, 200, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 700, 500, 200, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 700, 500, 1000, 500), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 1000, 200, 1000), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 200, 1000, 0, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 200, 0, 1000, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(5), "Expected: site #1 point count 5"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 200, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 200, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 200, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 700, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 200, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has X"); // #3 has X

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 300, 1000, 800), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 300, 0, 800), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 300, 500, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 800), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 1000, 800, 1000, 1000), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 800), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 0, 800, 0, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(5), "Expected: site #1 point count 5"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 300), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 800), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 800), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 300), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 800), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 300), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 800), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has X"); // #3 has X

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 300, 500, 800, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 300, 500, 800, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 300, 500, 0, 500), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 0, 800, 0), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 800, 0, 1000, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1000, 1000, 800, 1000), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 800, 1000, 0, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge D-X"); // D-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(5), "Expected: site #1 point count 5"); // #1
        Assume.That(HasPoint(sites[0].Points, 300, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 800, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 800, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 300, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 800, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 800, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has X"); // #3 has X

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 600, 400, 400), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 400, 600, 400), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 600, 400, 600, 600), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 600, 600, 400, 600), Is.True, "Expected: has edge D-A"); // D-A
        Assume.That(HasEdge(edges, 400, 600, 0, 1000), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 400, 400, 0, 0), Is.True, "Expected: has edge B-F"); // B-F
        Assume.That(HasEdge(edges, 600, 400, 1000, 0), Is.True, "Expected: has edge C-G"); // C-G
        Assume.That(HasEdge(edges, 600, 600, 1000, 1000), Is.True, "Expected: has edge D-H"); // D-H
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge E-F"); // E-F
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge F-G"); // F-G
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge G-H"); // G-H
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge H-E"); // H-E

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 400, 400), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 600, 400), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 600, 600), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 400, 400), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has F"); // #2 has F
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 400), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 600, 400), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has F"); // #3 has F
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 600, 400), Is.True, "Expected: site #4 has C"); // #4 has C
        Assume.That(HasPoint(sites[3].Points, 600, 600), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has H"); // #4 has H
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 400, 600), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 600, 600), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 0, 1000), Is.True, "Expected: site #5 has E"); // #5 has E
        Assume.That(HasPoint(sites[4].Points, 1000, 1000), Is.True, "Expected: site #5 has H"); // #5 has H

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(16), "Expected: edge count 16");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 400, 400, 200), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 200, 600, 200), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 600, 200, 600, 400), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 600, 400, 400, 400), Is.True, "Expected: has edge D-A"); // D-A
        Assume.That(HasEdge(edges, 400, 400, 0, 800), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 400, 200, 200, 0), Is.True, "Expected: has edge B-F"); // B-F
        Assume.That(HasEdge(edges, 600, 200, 800, 0), Is.True, "Expected: has edge C-G"); // C-G
        Assume.That(HasEdge(edges, 600, 400, 1000, 800), Is.True, "Expected: has edge D-H"); // D-H
        Assume.That(HasEdge(edges, 0, 1000, 0, 800), Is.True, "Expected: has edge X-E"); // X-E
        Assume.That(HasEdge(edges, 0, 800, 0, 0), Is.True, "Expected: has edge E-Y"); // E-Y
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 200, 0, 800, 0), Is.True, "Expected: has edge F-G"); // F-G
        Assume.That(HasEdge(edges, 800, 0, 1000, 0), Is.True, "Expected: has edge G-W"); // G-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 800), Is.True, "Expected: has edge W-H"); // W-H
        Assume.That(HasEdge(edges, 1000, 800, 1000, 1000), Is.True, "Expected: has edge H-Z"); // H-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 400, 200), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 600, 200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 600, 400), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 400, 200), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 800), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 200, 0), Is.True, "Expected: site #2 has F"); // #2 has F
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 200), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 600, 200), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 200, 0), Is.True, "Expected: site #3 has F"); // #3 has F
        Assume.That(HasPoint(sites[2].Points, 800, 0), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(5), "Expected: site #4 point count 5"); // #4
        Assume.That(HasPoint(sites[3].Points, 600, 200), Is.True, "Expected: site #4 has C"); // #4 has C
        Assume.That(HasPoint(sites[3].Points, 600, 400), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 800, 0), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 1000, 800), Is.True, "Expected: site #4 has H"); // #4 has H
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has W"); // #4 has W
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(6), "Expected: site #5 point count 6"); // #5
        Assume.That(HasPoint(sites[4].Points, 400, 400), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 600, 400), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 0, 800), Is.True, "Expected: site #5 has E"); // #5 has E
        Assume.That(HasPoint(sites[4].Points, 1000, 800), Is.True, "Expected: site #5 has H"); // #5 has H
        Assume.That(HasPoint(sites[4].Points, 0, 1000), Is.True, "Expected: site #5 has X"); // #5 has X
        Assume.That(HasPoint(sites[4].Points, 1000, 1000), Is.True, "Expected: site #5 has Z"); // #5 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(16), "Expected: edge count 16");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 600, 200, 600), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 200, 600, 200, 400), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 200, 400, 400, 400), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 400, 400, 400, 600), Is.True, "Expected: has edge D-A"); // D-A
        Assume.That(HasEdge(edges, 400, 600, 800, 1000), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 200, 600, 0, 800), Is.True, "Expected: has edge B-F"); // B-F
        Assume.That(HasEdge(edges, 200, 400, 0, 200), Is.True, "Expected: has edge C-G"); // C-G
        Assume.That(HasEdge(edges, 400, 400, 800, 0), Is.True, "Expected: has edge D-H"); // D-H
        Assume.That(HasEdge(edges, 1000, 1000, 800, 1000), Is.True, "Expected: has edge X-E"); // X-E
        Assume.That(HasEdge(edges, 800, 1000, 0, 1000), Is.True, "Expected: has edge E-Y"); // E-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 800), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 0, 800, 0, 200), Is.True, "Expected: has edge F-G"); // F-G
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge G-W"); // G-W
        Assume.That(HasEdge(edges, 0, 0, 800, 0), Is.True, "Expected: has edge W-H"); // W-H
        Assume.That(HasEdge(edges, 800, 0, 1000, 0), Is.True, "Expected: has edge H-Z"); // H-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 200, 600), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 200, 400), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 400, 400), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 200, 600), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 800, 1000), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 0, 800), Is.True, "Expected: site #2 has F"); // #2 has F
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 200, 600), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 200, 400), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 800), Is.True, "Expected: site #3 has F"); // #3 has F
        Assume.That(HasPoint(sites[2].Points, 0, 200), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(5), "Expected: site #4 point count 5"); // #4
        Assume.That(HasPoint(sites[3].Points, 200, 400), Is.True, "Expected: site #4 has C"); // #4 has C
        Assume.That(HasPoint(sites[3].Points, 400, 400), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 0, 200), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 800, 0), Is.True, "Expected: site #4 has H"); // #4 has H
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has W"); // #4 has W
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(6), "Expected: site #5 point count 6"); // #5
        Assume.That(HasPoint(sites[4].Points, 400, 600), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 400, 400), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 800, 1000), Is.True, "Expected: site #5 has E"); // #5 has E
        Assume.That(HasPoint(sites[4].Points, 800, 0), Is.True, "Expected: site #5 has H"); // #5 has H
        Assume.That(HasPoint(sites[4].Points, 1000, 1000), Is.True, "Expected: site #5 has X"); // #5 has X
        Assume.That(HasPoint(sites[4].Points, 1000, 0), Is.True, "Expected: site #5 has Z"); // #5 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(16), "Expected: edge count 16");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 600, 600, 800), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 800, 400, 800), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 400, 800, 400, 600), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 400, 600, 600, 600), Is.True, "Expected: has edge D-A"); // D-A
        Assume.That(HasEdge(edges, 600, 600, 1000, 200), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 600, 800, 800, 1000), Is.True, "Expected: has edge B-F"); // B-F
        Assume.That(HasEdge(edges, 400, 800, 200, 1000), Is.True, "Expected: has edge C-G"); // C-G
        Assume.That(HasEdge(edges, 400, 600, 0, 200), Is.True, "Expected: has edge D-H"); // D-H
        Assume.That(HasEdge(edges, 1000, 0, 1000, 200), Is.True, "Expected: has edge X-E"); // X-E
        Assume.That(HasEdge(edges, 1000, 200, 1000, 1000), Is.True, "Expected: has edge E-Y"); // E-Y
        Assume.That(HasEdge(edges, 1000, 1000, 800, 1000), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 800, 1000, 200, 1000), Is.True, "Expected: has edge F-G"); // F-G
        Assume.That(HasEdge(edges, 200, 1000, 0, 1000), Is.True, "Expected: has edge G-W"); // G-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 200), Is.True, "Expected: has edge W-H"); // W-H
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge H-Z"); // H-Z
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 800), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 400, 800), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 400, 600), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 600, 800), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 200), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 800, 1000), Is.True, "Expected: site #2 has F"); // #2 has F
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 800), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 400, 800), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 800, 1000), Is.True, "Expected: site #3 has F"); // #3 has F
        Assume.That(HasPoint(sites[2].Points, 200, 1000), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(5), "Expected: site #4 point count 5"); // #4
        Assume.That(HasPoint(sites[3].Points, 400, 800), Is.True, "Expected: site #4 has C"); // #4 has C
        Assume.That(HasPoint(sites[3].Points, 400, 600), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 200, 1000), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 0, 200), Is.True, "Expected: site #4 has H"); // #4 has H
        Assume.That(HasPoint(sites[3].Points, 0, 1000), Is.True, "Expected: site #4 has W"); // #4 has W
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(6), "Expected: site #5 point count 6"); // #5
        Assume.That(HasPoint(sites[4].Points, 600, 600), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 400, 600), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 1000, 200), Is.True, "Expected: site #5 has E"); // #5 has E
        Assume.That(HasPoint(sites[4].Points, 0, 200), Is.True, "Expected: site #5 has H"); // #5 has H
        Assume.That(HasPoint(sites[4].Points, 1000, 0), Is.True, "Expected: site #5 has X"); // #5 has X
        Assume.That(HasPoint(sites[4].Points, 0, 0), Is.True, "Expected: site #5 has Z"); // #5 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(16), "Expected: edge count 16");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 400, 800, 400), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 800, 400, 800, 600), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 800, 600, 600, 600), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 600, 600, 600, 400), Is.True, "Expected: has edge D-A"); // D-A
        Assume.That(HasEdge(edges, 600, 400, 200, 0), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 800, 400, 1000, 200), Is.True, "Expected: has edge B-F"); // B-F
        Assume.That(HasEdge(edges, 800, 600, 1000, 800), Is.True, "Expected: has edge C-G"); // C-G
        Assume.That(HasEdge(edges, 600, 600, 200, 1000), Is.True, "Expected: has edge D-H"); // D-H
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge X-E"); // X-E
        Assume.That(HasEdge(edges, 200, 0, 1000, 0), Is.True, "Expected: has edge E-Y"); // E-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 200), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 1000, 200, 1000, 800), Is.True, "Expected: has edge F-G"); // F-G
        Assume.That(HasEdge(edges, 1000, 800, 1000, 1000), Is.True, "Expected: has edge G-W"); // G-W
        Assume.That(HasEdge(edges, 1000, 1000, 200, 1000), Is.True, "Expected: has edge W-H"); // W-H
        Assume.That(HasEdge(edges, 200, 1000, 0, 1000), Is.True, "Expected: has edge H-Z"); // H-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 800, 400), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 800, 600), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 600, 600), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 800, 400), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 200, 0), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 1000, 200), Is.True, "Expected: site #2 has F"); // #2 has F
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 800, 400), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 800, 600), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 200), Is.True, "Expected: site #3 has F"); // #3 has F
        Assume.That(HasPoint(sites[2].Points, 1000, 800), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(5), "Expected: site #4 point count 5"); // #4
        Assume.That(HasPoint(sites[3].Points, 800, 600), Is.True, "Expected: site #4 has C"); // #4 has C
        Assume.That(HasPoint(sites[3].Points, 600, 600), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 1000, 800), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 200, 1000), Is.True, "Expected: site #4 has H"); // #4 has H
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has W"); // #4 has W
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(6), "Expected: site #5 point count 6"); // #5
        Assume.That(HasPoint(sites[4].Points, 600, 400), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 600, 600), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 200, 0), Is.True, "Expected: site #5 has E"); // #5 has E
        Assume.That(HasPoint(sites[4].Points, 200, 1000), Is.True, "Expected: site #5 has H"); // #5 has H
        Assume.That(HasPoint(sites[4].Points, 0, 0), Is.True, "Expected: site #5 has X"); // #5 has X
        Assume.That(HasPoint(sites[4].Points, 0, 1000), Is.True, "Expected: site #5 has Z"); // #5 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 500, 500, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 0, 500), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 500, 500, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 500, 500, 1000, 500), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 500, 1000), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 1000, 500), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 500, 500, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 0, 500), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 500, 500, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 500, 500, 1000, 500), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 500, 1000), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 1000, 500), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 500, 1000, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 500, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 500, 0, 500), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 500, 500, 500, 0), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 1000, 500), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 500, 0), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 500, 0, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 0, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 500, 1000, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 500, 500, 1000, 1000), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge D-E"); // D-E
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge E-B"); // E-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has E"); // #1 has E
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(3), "Expected: site #4 point count 3"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 0, 1000), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has C"); // #4 has C

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 400, 100, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 400, 0, 200), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 400, 400, 600, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 400, 400, 1000, 700), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 0, 1000, 0, 200), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 600, 0, 1000, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 700), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 1000, 700, 1000, 1000), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 1000, 1000, 100, 1000), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 100, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 100, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 600, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 700), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 400, 400), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 100, 1000), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 1000, 700), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 600, 1000, 900), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 600, 200, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 400, 600, 0, 400), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 400, 600, 700, 0), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 1000, 1000, 200, 1000), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 200, 1000, 0, 1000), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 400), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 0, 400, 0, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 0, 0, 700, 0), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 700, 0, 1000, 0), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 900), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 1000, 900, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 900), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 200, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 200, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 400), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 700, 0), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 400, 600), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 1000, 900), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 700, 0), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 600, 900, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 600, 1000, 800), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 600, 400, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 600, 600, 0, 300), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 1000, 0, 1000, 800), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 1000, 800, 1000, 1000), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 1000, 1000, 400, 1000), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 400, 1000, 0, 1000), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 300), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 0, 300, 0, 0), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 0, 0, 900, 0), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 900, 0, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 900, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 800), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 800), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 400, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 300), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 600, 600), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 900, 0), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 0, 300), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 400, 0, 100), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 400, 800, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 400, 1000, 600), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 600, 400, 300, 1000), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 0, 0, 800, 0), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 800, 0, 1000, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 600), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 1000, 600, 1000, 1000), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 1000, 300, 1000), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 300, 1000, 0, 1000), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 100), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 0, 100, 0, 0), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 100), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 800, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 800, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 600), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 600), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 300, 1000), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 600, 400), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 0, 100), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 300, 1000), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 0, 1000), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 400, 900, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 400, 1000, 200), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 400, 400, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 600, 400, 0, 700), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 200), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 1000, 200, 1000, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 1000, 0, 400, 0), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 400, 0, 0, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 0, 0, 0, 700), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 0, 700, 0, 1000), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 0, 1000, 900, 1000), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 900, 1000, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 900, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 400, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 400, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 700), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 600, 400), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 900, 1000), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 0, 700), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 0, 1000), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 400, 1000, 100), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 400, 200, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 400, 400, 0, 600), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 400, 400, 700, 1000), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 1000, 0, 200, 0), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 200, 0, 0, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 0, 0, 600), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 0, 600, 0, 1000), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 0, 1000, 700, 1000), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 700, 1000, 1000, 1000), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 100), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 1000, 100, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 100), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 200, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 200, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 600), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 700, 1000), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 400, 400), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 1000, 100), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 700, 1000), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 600, 100, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 600, 0, 800), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 400, 600, 600, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 400, 600, 1000, 300), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 0, 0, 0, 800), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 0, 800, 0, 1000), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 1000, 600, 1000), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 600, 1000, 1000, 1000), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 300), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 1000, 300, 1000, 0), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 1000, 0, 100, 0), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 100, 0, 0, 0), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 100, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 800), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 800), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 600, 1000), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 600, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 300), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 400, 600), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 100, 0), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 1000, 300), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 600, 0, 900), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 600, 800, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 600, 1000, 400), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 600, 600, 300, 0), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 0, 1000, 800, 1000), Is.True, "Expected: has edge X-C"); // X-C
        Assume.That(HasEdge(edges, 800, 1000, 1000, 1000), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 400), Is.True, "Expected: has edge Y-D"); // Y-D
        Assume.That(HasEdge(edges, 1000, 400, 1000, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 0, 300, 0), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 300, 0, 0, 0), Is.True, "Expected: has edge E-Z"); // E-Z
        Assume.That(HasEdge(edges, 0, 0, 0, 900), Is.True, "Expected: has edge Z-B"); // Z-B
        Assume.That(HasEdge(edges, 0, 900, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 900), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 800, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 800, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 400), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 400), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 300, 0), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 600, 600), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 0, 900), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 300, 0), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has Z"); // #4 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(15), "Expected: edge count 15");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 400, 500, 700), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 700, 200, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 500, 700, 800, 1000), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 500, 400, 0, 400), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 500, 400, 1000, 400), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 500, 400, 500, 0), Is.True, "Expected: has edge A-G"); // A-G
        Assume.That(HasEdge(edges, 200, 1000, 0, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 400), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 0, 400, 0, 0), Is.True, "Expected: has edge E-X"); // E-X
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge X-G"); // X-G
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge G-Y"); // G-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 400), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 1000, 400, 1000, 1000), Is.True, "Expected: has edge F-Z"); // F-Z
        Assume.That(HasEdge(edges, 1000, 1000, 800, 1000), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 800, 1000, 200, 1000), Is.True, "Expected: has edge D-C"); // D-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 700), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 200, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 800, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 400), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 700), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 200, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 400), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 400), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 1000, 400), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 500, 0), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has Y"); // #4 has Y
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(5), "Expected: site #5 point count 5"); // #5
        Assume.That(HasPoint(sites[4].Points, 500, 400), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 500, 700), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 800, 1000), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 1000, 400), Is.True, "Expected: site #5 has F"); // #5 has F
        Assume.That(HasPoint(sites[4].Points, 1000, 1000), Is.True, "Expected: site #5 has Z"); // #5 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(15), "Expected: edge count 15");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 500, 700, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 700, 500, 1000, 800), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 700, 500, 1000, 200), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 400, 500, 400, 1000), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 400, 500, 400, 0), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 400, 500, 0, 500), Is.True, "Expected: has edge A-G"); // A-G
        Assume.That(HasEdge(edges, 1000, 800, 1000, 1000), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 1000, 400, 1000), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 400, 1000, 0, 1000), Is.True, "Expected: has edge E-X"); // E-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge X-G"); // X-G
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge G-Y"); // G-Y
        Assume.That(HasEdge(edges, 0, 0, 400, 0), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 400, 0, 1000, 0), Is.True, "Expected: has edge F-Z"); // F-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 200), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 1000, 200, 1000, 800), Is.True, "Expected: has edge D-C"); // D-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 800), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 200), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 400, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 700, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 800), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 400, 1000), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 400, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 400, 0), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 0, 500), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has Y"); // #4 has Y
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(5), "Expected: site #5 point count 5"); // #5
        Assume.That(HasPoint(sites[4].Points, 400, 500), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 700, 500), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 1000, 200), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 400, 0), Is.True, "Expected: site #5 has F"); // #5 has F
        Assume.That(HasPoint(sites[4].Points, 1000, 0), Is.True, "Expected: site #5 has Z"); // #5 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(15), "Expected: edge count 15");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 600, 500, 300), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 300, 800, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 500, 300, 200, 0), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 500, 600, 1000, 600), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 500, 600, 0, 600), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 500, 600, 500, 1000), Is.True, "Expected: has edge A-G"); // A-G
        Assume.That(HasEdge(edges, 800, 0, 1000, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 600), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 1000, 600, 1000, 1000), Is.True, "Expected: has edge E-X"); // E-X
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge X-G"); // X-G
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge G-Y"); // G-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 600), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge F-Z"); // F-Z
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 200, 0, 800, 0), Is.True, "Expected: has edge D-C"); // D-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 300), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 800, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 200, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 300), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 800, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 600), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 600), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 500, 1000), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 600), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 0, 600), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 500, 1000), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 0, 1000), Is.True, "Expected: site #4 has Y"); // #4 has Y
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(5), "Expected: site #5 point count 5"); // #5
        Assume.That(HasPoint(sites[4].Points, 500, 600), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 500, 300), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 200, 0), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 0, 600), Is.True, "Expected: site #5 has F"); // #5 has F
        Assume.That(HasPoint(sites[4].Points, 0, 0), Is.True, "Expected: site #5 has Z"); // #5 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(15), "Expected: edge count 15");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 500, 300, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 300, 500, 0, 200), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 300, 500, 0, 800), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 600, 500, 600, 0), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 600, 500, 600, 1000), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 600, 500, 1000, 500), Is.True, "Expected: has edge A-G"); // A-G
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge W-E"); // W-E
        Assume.That(HasEdge(edges, 600, 0, 1000, 0), Is.True, "Expected: has edge E-X"); // E-X
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge X-G"); // X-G
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge G-Y"); // G-Y
        Assume.That(HasEdge(edges, 1000, 1000, 600, 1000), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 600, 1000, 0, 1000), Is.True, "Expected: has edge F-Z"); // F-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 800), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 0, 800, 0, 200), Is.True, "Expected: has edge D-C"); // D-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 300, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 800), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 300, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has W"); // #2 has W
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 600, 0), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 600, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 600, 1000), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 1000, 500), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has Y"); // #4 has Y
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(5), "Expected: site #5 point count 5"); // #5
        Assume.That(HasPoint(sites[4].Points, 600, 500), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 300, 500), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 0, 800), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 600, 1000), Is.True, "Expected: site #5 has F"); // #5 has F
        Assume.That(HasPoint(sites[4].Points, 0, 1000), Is.True, "Expected: site #5 has Z"); // #5 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(13), "Expected: edge count 13");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 300, 500, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 0, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 500, 500, 1000, 1000), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 500, 300, 0, 300), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 500, 300, 1000, 300), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 500, 300, 500, 0), Is.True, "Expected: has edge A-G"); // A-G
        Assume.That(HasEdge(edges, 0, 1000, 0, 300), Is.True, "Expected: has edge C-E"); // C-E
        Assume.That(HasEdge(edges, 0, 300, 0, 0), Is.True, "Expected: has edge E-X"); // E-X
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge X-G"); // X-G
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge G-Y"); // G-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 300), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 1000, 300, 1000, 1000), Is.True, "Expected: has edge F-D"); // F-D
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge D-C"); // D-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 300), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 300), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 300), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 300), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 300), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 1000, 300), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 500, 0), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 1000, 0), Is.True, "Expected: site #4 has Y"); // #4 has Y
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 500, 300), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 500, 500), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 1000, 1000), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 1000, 300), Is.True, "Expected: site #5 has F"); // #5 has F

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(13), "Expected: edge count 13");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 300, 500, 500, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 1000, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 500, 500, 1000, 0), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 300, 500, 300, 1000), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 300, 500, 300, 0), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 300, 500, 0, 500), Is.True, "Expected: has edge A-G"); // A-G
        Assume.That(HasEdge(edges, 1000, 1000, 300, 1000), Is.True, "Expected: has edge C-E"); // C-E
        Assume.That(HasEdge(edges, 300, 1000, 0, 1000), Is.True, "Expected: has edge E-X"); // E-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge X-G"); // X-G
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge G-Y"); // G-Y
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 300, 0, 1000, 0), Is.True, "Expected: has edge F-D"); // F-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge D-C"); // D-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 300, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 300, 1000), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 300, 1000), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 300, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 300, 0), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 0, 500), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has Y"); // #4 has Y
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 300, 500), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 500, 500), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 1000, 0), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 300, 0), Is.True, "Expected: site #5 has F"); // #5 has F

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
    }

    /// <summary>
    /// This test basically repeats <see cref="FivePointsInAForkedStubbyCross"/> above,
    /// but all coordinates are rotated 180° around the center of the boundary.
    /// </summary>
    [Test]
    public void FivePointsInAForkedStubbyCross_Rotated180()
    {
        // Arrange

        List<VoronoiSite> sites = new List<VoronoiSite>
        {
            new VoronoiSite(500, 300), // #1
            new VoronoiSite(700, 500), // #2
            new VoronoiSite(700, 900), // #3
            new VoronoiSite(300, 900), // #4
            new VoronoiSite(300, 500), // #5
        };

        // 1000 Y------------------------G------------------------X
        //      |                        |                        |
        //  900 |              4         |         3              |
        //      |                        |                        |
        //  800 |                        |                        |
        //      |                        |                        |
        //  700 F------------------------A------------------------E
        //      |                        |                        |
        //  600 |                        |                        |
        //      |                        |                        |
        //  500 |              5        ,B,        2              |
        //      |                     ,'   ',                     |
        //  400 |                  ,·'       '·,                  |
        //      |                ,'             ',                |
        //  300 |             ,·'        1        '·,             |
        //      |           ,'                       ',           |
        //  200 |        ,·'                           '·,        |
        //      |      ,'                                 ',      |
        //  100 |   ,·'                                     '·,   |
        //      | ,'                                           ', |
        //    0 D#-----------------------------------------------#C
        //       0  100  200  300  400  500  600  700  800  900 1000 

        // Act

        List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

        // Assume

        Assume.That(edges.Count, Is.EqualTo(13), "Expected: edge count 13");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 700, 500, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 1000, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 500, 500, 0, 0), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 500, 700, 1000, 700), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 500, 700, 0, 700), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 500, 700, 500, 1000), Is.True, "Expected: has edge A-G"); // A-G
        Assume.That(HasEdge(edges, 1000, 0, 1000, 700), Is.True, "Expected: has edge C-E"); // C-E
        Assume.That(HasEdge(edges, 1000, 700, 1000, 1000), Is.True, "Expected: has edge E-X"); // E-X
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge X-G"); // X-G
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge G-Y"); // G-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 0, 700, 0, 0), Is.True, "Expected: has edge F-D"); // F-D
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge D-C"); // D-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 700), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 700), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 700), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 500, 1000), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 700), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 0, 700), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 500, 1000), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 0, 1000), Is.True, "Expected: site #4 has Y"); // #4 has Y
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 500, 700), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 500, 500), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 0, 0), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 0, 700), Is.True, "Expected: site #5 has F"); // #5 has F

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
    }

    /// <summary>
    /// This test basically repeats <see cref="FivePointsInAForkedStubbyCross"/> above,
    /// but all coordinates are rotated 270° around the center of the boundary.
    /// </summary>
    [Test]
    public void FivePointsInAForkedStubbyCross_Rotated270()
    {
        // Arrange

        List<VoronoiSite> sites = new List<VoronoiSite>
        {
            new VoronoiSite(300, 500), // #1
            new VoronoiSite(500, 300), // #2
            new VoronoiSite(900, 300), // #3
            new VoronoiSite(900, 700), // #4
            new VoronoiSite(500, 700), // #5
        };

        // 1000 D#---------------------------------F--------------Y
        //      | ',                               |              |
        //  900 |   '·,                            |              |
        //      |      ',                          |              |
        //  800 |        '·,                       |              |
        //      |           ',                     |              |
        //  700 |             '·,        5         |         4    |
        //      |                ',                |              |
        //  600 |                  '·,             |              |
        //      |                     ',           |              |
        //  500 |              1        #B---------A--------------G
        //      |                     ,'           |              |
        //  400 |                  ,·'             |              |
        //      |                ,'                |              |
        //  300 |             ,·'        2         |         3    |
        //      |           ,'                     |              |
        //  200 |        ,·'                       |              |
        //      |      ,'                          |              |
        //  100 |   ,·'                            |              |
        //      | ,'                               |              |
        //    0 C#---------------------------------E--------------X
        //       0  100  200  300  400  500  600  700  800  900 1000 

        // Act

        List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

        // Assume

        Assume.That(edges.Count, Is.EqualTo(13), "Expected: edge count 13");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 500, 500, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 500, 0, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 500, 500, 0, 1000), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 700, 500, 700, 0), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 700, 500, 700, 1000), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 700, 500, 1000, 500), Is.True, "Expected: has edge A-G"); // A-G
        Assume.That(HasEdge(edges, 0, 0, 700, 0), Is.True, "Expected: has edge C-E"); // C-E
        Assume.That(HasEdge(edges, 700, 0, 1000, 0), Is.True, "Expected: has edge E-X"); // E-X
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge X-G"); // X-G
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge G-Y"); // G-Y
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 700, 1000, 0, 1000), Is.True, "Expected: has edge F-D"); // F-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge D-C"); // D-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 700, 0), Is.True, "Expected: site #2 has E"); // #2 has E
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 700, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 700, 0), Is.True, "Expected: site #3 has E"); // #3 has E
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has X"); // #3 has X
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 700, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 700, 1000), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 1000, 500), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has Y"); // #4 has Y
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 700, 500), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 500, 500), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 0, 1000), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 700, 1000), Is.True, "Expected: site #5 has F"); // #5 has F

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(17), "Expected: edge count 17");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 300, 500, 700), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 700, 0, 700), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 500, 700, 1000, 700), Is.True, "Expected: has edge B-G"); // B-G
        Assume.That(HasEdge(edges, 500, 300, 0, 300), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 500, 300, 1000, 300), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 500, 300, 500, 0), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 500, 700, 500, 1000), Is.True, "Expected: has edge B-H"); // B-H
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 0, 700, 0, 300), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 0, 300, 0, 0), Is.True, "Expected: has edge D-X"); // D-X
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge X-E"); // X-E
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge E-Y"); // E-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 300), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 1000, 300, 1000, 700), Is.True, "Expected: has edge F-G"); // F-G
        Assume.That(HasEdge(edges, 1000, 700, 1000, 1000), Is.True, "Expected: has edge G-Z"); // G-Z
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Z-H"); // Z-H
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge H-W"); // H-W

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 700), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 700), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has H"); // #1 has H
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 700), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 700), Is.True, "Expected: site #2 has G"); // #2 has G
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has H"); // #2 has H
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 300), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 500, 700), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 700), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 300), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 300), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 500, 700), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 1000, 300), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 1000, 700), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 500, 300), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 0, 300), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 500, 0), Is.True, "Expected: site #5 has E"); // #5 has E
        Assume.That(HasPoint(sites[4].Points, 0, 0), Is.True, "Expected: site #5 has X"); // #5 has X
        Assume.That(sites[5].Points, Is.Not.Null);
        Assume.That(sites[5].Points.Count(), Is.EqualTo(4), "Expected: site #6 point count 4"); // #6
        Assume.That(HasPoint(sites[5].Points, 500, 300), Is.True, "Expected: site #6 has A"); // #6 has A
        Assume.That(HasPoint(sites[5].Points, 500, 0), Is.True, "Expected: site #6 has E"); // #6 has E
        Assume.That(HasPoint(sites[5].Points, 1000, 300), Is.True, "Expected: site #6 has F"); // #6 has F
        Assume.That(HasPoint(sites[5].Points, 1000, 0), Is.True, "Expected: site #6 has Y"); // #6 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
        Assert.That(sites[5].LiesOnEdge, Is.Null); // #6
        Assert.That(sites[5].LiesOnCorner, Is.Null);// #6
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

        Assume.That(edges.Count, Is.EqualTo(17), "Expected: edge count 17");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 300, 500, 700, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 700, 500, 700, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 700, 500, 700, 0), Is.True, "Expected: has edge B-G"); // B-G
        Assume.That(HasEdge(edges, 300, 500, 300, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 300, 500, 300, 0), Is.True, "Expected: has edge A-F"); // A-F
        Assume.That(HasEdge(edges, 300, 500, 0, 500), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 700, 500, 1000, 500), Is.True, "Expected: has edge B-H"); // B-H
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 700, 1000, 300, 1000), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 300, 1000, 0, 1000), Is.True, "Expected: has edge D-X"); // D-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge X-E"); // X-E
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge E-Y"); // E-Y
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge Y-F"); // Y-F
        Assume.That(HasEdge(edges, 300, 0, 700, 0), Is.True, "Expected: has edge F-G"); // F-G
        Assume.That(HasEdge(edges, 700, 0, 1000, 0), Is.True, "Expected: has edge G-Z"); // G-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge Z-H"); // Z-H
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge H-W"); // H-W

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 700, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1000, 500), Is.True, "Expected: site #1 has H"); // #1 has H
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has W"); // #1 has W
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 700, 0), Is.True, "Expected: site #2 has G"); // #2 has G
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has H"); // #2 has H
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 700, 500), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 700, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 300, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(4), "Expected: site #4 point count 4"); // #4
        Assume.That(HasPoint(sites[3].Points, 300, 500), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 700, 500), Is.True, "Expected: site #4 has B"); // #4 has B
        Assume.That(HasPoint(sites[3].Points, 300, 0), Is.True, "Expected: site #4 has F"); // #4 has F
        Assume.That(HasPoint(sites[3].Points, 700, 0), Is.True, "Expected: site #4 has G"); // #4 has G
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 300, 500), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 300, 1000), Is.True, "Expected: site #5 has D"); // #5 has D
        Assume.That(HasPoint(sites[4].Points, 0, 500), Is.True, "Expected: site #5 has E"); // #5 has E
        Assume.That(HasPoint(sites[4].Points, 0, 1000), Is.True, "Expected: site #5 has X"); // #5 has X
        Assume.That(sites[5].Points, Is.Not.Null);
        Assume.That(sites[5].Points.Count(), Is.EqualTo(4), "Expected: site #6 point count 4"); // #6
        Assume.That(HasPoint(sites[5].Points, 300, 500), Is.True, "Expected: site #6 has A"); // #6 has A
        Assume.That(HasPoint(sites[5].Points, 0, 500), Is.True, "Expected: site #6 has E"); // #6 has E
        Assume.That(HasPoint(sites[5].Points, 300, 0), Is.True, "Expected: site #6 has F"); // #6 has F
        Assume.That(HasPoint(sites[5].Points, 0, 0), Is.True, "Expected: site #6 has Y"); // #6 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
        Assert.That(sites[5].LiesOnEdge, Is.Null); // #6
        Assert.That(sites[5].LiesOnCorner, Is.Null);// #6
    }

    [Test]
    public void FivePointsInAKite()
    {
        // Arrange

        List<VoronoiSite> sites = new List<VoronoiSite>
        {
            new VoronoiSite(200, 800), // #1
            new VoronoiSite(200, 200), // #2
            new VoronoiSite(800, 200), // #3
            new VoronoiSite(800, 800), // #4
            new VoronoiSite(500, 500), // #5
        };

        // 1000 X------------------------A------------------------Z
        //      |                        |                        |
        //  900 |                        |                        |
        //      |                        |                        |
        //  800 |         1             ,E,             4         |
        //      |                     ,'   ',                     |
        //  700 |                  ,·'       '·,                  |
        //      |                ,'             ',                |
        //  600 |             ,·'                 '·,             |
        //      |           ,'                       ',           |
        //  500 B---------F#             5             #H---------D
        //      |           ',                       ,'           |
        //  400 |             '·,                 ,·'             |
        //      |                ',             ,'                |
        //  300 |                  '·,       ,·'                  |
        //      |                     ',   ,'                     |
        //  200 |         2             'G'             3         |
        //      |                        |                        |
        //  100 |                        |                        |
        //      |                        |                        |
        //    0 Y------------------------C------------------------W
        //       0  100  200  300  400  500  600  700  800  900 1000 

        // Act

        List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, 0, 0, 1000, 1000);

        // Assume

        Assume.That(edges.Count, Is.EqualTo(16), "Expected: edge count 16");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 1000, 500, 800), Is.True, "Expected: has edge A-E"); // A-E
        Assume.That(HasEdge(edges, 1000, 500, 800, 500), Is.True, "Expected: has edge D-H"); // D-H
        Assume.That(HasEdge(edges, 500, 0, 500, 200), Is.True, "Expected: has edge C-G"); // C-G
        Assume.That(HasEdge(edges, 0, 500, 200, 500), Is.True, "Expected: has edge B-F"); // B-F
        Assume.That(HasEdge(edges, 500, 800, 800, 500), Is.True, "Expected: has edge E-H"); // E-H
        Assume.That(HasEdge(edges, 800, 500, 500, 200), Is.True, "Expected: has edge H-G"); // H-G
        Assume.That(HasEdge(edges, 500, 200, 200, 500), Is.True, "Expected: has edge G-F"); // G-F
        Assume.That(HasEdge(edges, 200, 500, 500, 800), Is.True, "Expected: has edge F-E"); // F-E
        Assume.That(HasEdge(edges, 0, 1000, 500, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 500, 1000, 1000, 1000), Is.True, "Expected: has edge A-Z"); // A-Z
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 500), Is.True, "Expected: has edge Z-D"); // Z-D
        Assume.That(HasEdge(edges, 1000, 500, 1000, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 0, 500, 0), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 500, 0, 0, 0), Is.True, "Expected: has edge C-Y"); // C-Y
        Assume.That(HasEdge(edges, 0, 0, 0, 500), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 0, 500, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(5), "Expected: site #1 point count 5"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 500, 800), Is.True, "Expected: site #1 has E"); // #1 has E
        Assume.That(HasPoint(sites[0].Points, 200, 500), Is.True, "Expected: site #1 has F"); // #1 has F
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(5), "Expected: site #2 point count 5"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 200, 500), Is.True, "Expected: site #2 has F"); // #2 has F
        Assume.That(HasPoint(sites[1].Points, 500, 200), Is.True, "Expected: site #2 has G"); // #2 has G
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(5), "Expected: site #3 point count 5"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 500, 200), Is.True, "Expected: site #3 has G"); // #3 has G
        Assume.That(HasPoint(sites[2].Points, 800, 500), Is.True, "Expected: site #3 has H"); // #3 has H
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(5), "Expected: site #4 point count 5"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 1000), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 1000, 500), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 500, 800), Is.True, "Expected: site #4 has E"); // #4 has E
        Assume.That(HasPoint(sites[3].Points, 800, 500), Is.True, "Expected: site #4 has H"); // #4 has H
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has Z"); // #4 has Z
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 500, 800), Is.True, "Expected: site #5 has E"); // #5 has E
        Assume.That(HasPoint(sites[4].Points, 200, 500), Is.True, "Expected: site #5 has F"); // #5 has F
        Assume.That(HasPoint(sites[4].Points, 500, 200), Is.True, "Expected: site #5 has G"); // #5 has G
        Assume.That(HasPoint(sites[4].Points, 800, 500), Is.True, "Expected: site #5 has H"); // #5 has H

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(12), "Expected: edge count 12");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 1000, 0, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 500, 500, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 500, 0, 1000, 500), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 1000, 500, 500, 1000), Is.True, "Expected: has edge D-A"); // D-A
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge X-B"); // X-B
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge B-Y"); // B-Y
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge C-W"); // C-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge D-Z"); // D-Z
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Z-A"); // Z-A
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge A-X"); // A-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(3), "Expected: site #4 point count 3"); // #4
        Assume.That(HasPoint(sites[3].Points, 500, 1000), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 1000, 500), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 1000, 1000), Is.True, "Expected: site #4 has Z"); // #4 has Z
        Assume.That(sites[4].Points, Is.Not.Null);
        Assume.That(sites[4].Points.Count(), Is.EqualTo(4), "Expected: site #5 point count 4"); // #5
        Assume.That(HasPoint(sites[4].Points, 500, 1000), Is.True, "Expected: site #5 has A"); // #5 has A
        Assume.That(HasPoint(sites[4].Points, 0, 500), Is.True, "Expected: site #5 has B"); // #5 has B
        Assume.That(HasPoint(sites[4].Points, 500, 0), Is.True, "Expected: site #5 has C"); // #5 has C
        Assume.That(HasPoint(sites[4].Points, 1000, 500), Is.True, "Expected: site #5 has D"); // #5 has D

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Not.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.EqualTo(FindPoint(edges, 0, 1000))); // #1 on X
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Not.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.EqualTo(FindPoint(edges, 0, 0))); // #2 on Y
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Not.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.EqualTo(FindPoint(edges, 1000, 0))); // #3 on W
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Not.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.EqualTo(FindPoint(edges, 1000, 1000))); // #4 on Z
        Assert.That(sites[4].LiesOnEdge, Is.Null); // #5
        Assert.That(sites[4].LiesOnCorner, Is.Null);// #5
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 500, 1000, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 500, 1000, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge C-B"); // C-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has C"); // #3 has C

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 1000, 1000, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 1000, 0, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge C-B"); // C-B
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 1000), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has C"); // #3 has C

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 500, 0, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 500, 0, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge C-B"); // C-B
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has C"); // #3 has C

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(7), "Expected: edge count 7");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 0, 0, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 500, 0, 1000, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge C-B"); // C-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge B-X"); // B-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has C"); // #3 has C

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 600, 800, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 400, 800, 0), Is.True, "Expected: has edge D-C"); // D-C
        Assume.That(HasEdge(edges, 800, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 600), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 600, 0, 400), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 400, 0, 0), Is.True, "Expected: has edge D-Y"); // D-Y
        Assume.That(HasEdge(edges, 0, 0, 800, 0), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 800, 0, 1000, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge Z-W"); // Z-W
        Assume.That(HasEdge(edges, 1000, 1000, 800, 1000), Is.True, "Expected: has edge W-B"); // W-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 800, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 800, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(6), "Expected: site #3 point count 6"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 800, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 800, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 400), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 1000, 1000, 200), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 400, 1000, 0, 200), Is.True, "Expected: has edge D-C"); // D-C
        Assume.That(HasEdge(edges, 1000, 200, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 1000, 600, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 600, 1000, 400, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 400, 1000, 0, 1000), Is.True, "Expected: has edge D-Y"); // D-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 200), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge Z-W"); // Z-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 200), Is.True, "Expected: has edge W-B"); // W-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 200), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(6), "Expected: site #3 point count 6"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 1000), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 200), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 200), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 400, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 400, 200, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 600, 200, 1000), Is.True, "Expected: has edge D-C"); // D-C
        Assume.That(HasEdge(edges, 200, 0, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 0, 1000, 400), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1000, 400, 1000, 600), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 600, 1000, 1000), Is.True, "Expected: has edge D-Y"); // D-Y
        Assume.That(HasEdge(edges, 1000, 1000, 200, 1000), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 200, 1000, 0, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge Z-W"); // Z-W
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge W-B"); // W-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 400), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 200, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 200, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 600), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(6), "Expected: site #3 point count 6"); // #3
        Assume.That(HasPoint(sites[2].Points, 1000, 400), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 200, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 200, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 600), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 400, 0, 0, 800), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 600, 0, 1000, 800), Is.True, "Expected: has edge D-C"); // D-C
        Assume.That(HasEdge(edges, 0, 800, 0, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 0, 400, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 400, 0, 600, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 600, 0, 1000, 0), Is.True, "Expected: has edge D-Y"); // D-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 800), Is.True, "Expected: has edge Y-C"); // Y-C
        Assume.That(HasEdge(edges, 1000, 800, 1000, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge Z-W"); // Z-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 800), Is.True, "Expected: has edge W-B"); // W-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 400, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 800), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 800), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(6), "Expected: site #3 point count 6"); // #3
        Assume.That(HasPoint(sites[2].Points, 400, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 800), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1000, 800), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 600, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has Z"); // #3 has Z

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 600, 1200, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 600, 1200, 200), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1200, 0, 600), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 0, 1200, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1200, 0, 1200, 200), Is.True, "Expected: has edge W-B"); // W-B
        Assume.That(HasEdge(edges, 1200, 200, 1200, 1000), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 1200, 1000, 1200, 1200), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1200, 1200, 0, 1200), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1200, 200), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1200, 1000), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1200, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1200), Is.True, "Expected: site #2 has X"); // #2 has X
        Assume.That(HasPoint(sites[1].Points, 1200, 1200), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1200, 200), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1200, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 1200, 1000, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 1200, 200, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1200, 1200, 600, 1200), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 600, 1200, 0, 1200), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 1200, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge W-B"); // W-B
        Assume.That(HasEdge(edges, 200, 0, 1000, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 1000, 0, 1200, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1200, 0, 1200, 1200), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 1200), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 200, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 1200), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1200, 1200), Is.True, "Expected: site #2 has X"); // #2 has X
        Assume.That(HasPoint(sites[1].Points, 1200, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 1200), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 200, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 1200), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1200, 600, 0, 200), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 1200, 600, 0, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1200, 0, 1200, 600), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1200, 600, 1200, 1200), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1200, 1200, 0, 1200), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1200, 0, 1000), Is.True, "Expected: has edge W-B"); // W-B
        Assume.That(HasEdge(edges, 0, 1000, 0, 200), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 200, 0, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 0, 1200, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1200, 600), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 1200, 600), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1200, 0), Is.True, "Expected: site #2 has X"); // #2 has X
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 1200, 600), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 1200), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1200, 1200), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 600, 0, 200, 1200), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 600, 0, 1000, 1200), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 600, 0, 1200, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1200, 0, 1200, 1200), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1200, 1200, 1000, 1200), Is.True, "Expected: has edge W-B"); // W-B
        Assume.That(HasEdge(edges, 1000, 1200, 200, 1200), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 200, 1200, 0, 1200), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 1200, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 600, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 1200), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 200, 1200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 200, 1200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has X"); // #2 has X
        Assume.That(HasPoint(sites[1].Points, 0, 1200), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 600, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 1200), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1200, 1200), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1200, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 700, 1200, 1100), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1200, 100, 0, 500), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 1200, 100, 1200, 1100), Is.True, "Expected: has edge C-B"); // C-B
        Assume.That(HasEdge(edges, 1200, 1100, 1200, 1200), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1200, 1200, 0, 1200), Is.True, "Expected: has edge Z-X"); // Z-X
        Assume.That(HasEdge(edges, 0, 1200, 0, 700), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 700, 0, 500), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge D-Y"); // D-Y
        Assume.That(HasEdge(edges, 0, 0, 1200, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1200, 0, 1200, 100), Is.True, "Expected: has edge W-C"); // W-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 700), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1200, 1100), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1200, 100), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 700), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1200, 1100), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 1200), Is.True, "Expected: site #2 has X"); // #2 has X
        Assume.That(HasPoint(sites[1].Points, 1200, 1200), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 1200, 100), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1200, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 700, 1200, 1100, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 100, 0, 500, 1200), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 100, 0, 1100, 0), Is.True, "Expected: has edge C-B"); // C-B
        Assume.That(HasEdge(edges, 1100, 0, 1200, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 1200, 0, 1200, 1200), Is.True, "Expected: has edge Z-X"); // Z-X
        Assume.That(HasEdge(edges, 1200, 1200, 700, 1200), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 700, 1200, 500, 1200), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 500, 1200, 0, 1200), Is.True, "Expected: has edge D-Y"); // D-Y
        Assume.That(HasEdge(edges, 0, 1200, 0, 0), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 0, 100, 0), Is.True, "Expected: has edge W-C"); // W-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 700, 1200), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1100, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 100, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 500, 1200), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 700, 1200), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1100, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1200, 1200), Is.True, "Expected: site #2 has X"); // #2 has X
        Assume.That(HasPoint(sites[1].Points, 1200, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 100, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 500, 1200), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 0, 1200), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1200, 500, 0, 100), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1100, 1200, 700), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 0, 1100, 0, 100), Is.True, "Expected: has edge C-B"); // C-B
        Assume.That(HasEdge(edges, 0, 100, 0, 0), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 0, 0, 1200, 0), Is.True, "Expected: has edge Z-X"); // Z-X
        Assume.That(HasEdge(edges, 1200, 0, 1200, 500), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1200, 500, 1200, 700), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1200, 700, 1200, 1200), Is.True, "Expected: has edge D-Y"); // D-Y
        Assume.That(HasEdge(edges, 1200, 1200, 0, 1200), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 0, 1200, 0, 1100), Is.True, "Expected: has edge W-C"); // W-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1200, 500), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 100), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1100), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1200, 700), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 1200, 500), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 100), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1200, 0), Is.True, "Expected: site #2 has X"); // #2 has X
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 1100), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1200, 700), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1200), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1200, 1200), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 500, 0, 100, 1200), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1100, 1200, 700, 0), Is.True, "Expected: has edge C-D"); // C-D
        Assume.That(HasEdge(edges, 1100, 1200, 100, 1200), Is.True, "Expected: has edge C-B"); // C-B
        Assume.That(HasEdge(edges, 100, 1200, 0, 1200), Is.True, "Expected: has edge B-Z"); // B-Z
        Assume.That(HasEdge(edges, 0, 1200, 0, 0), Is.True, "Expected: has edge Z-X"); // Z-X
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 500, 0, 700, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 700, 0, 1200, 0), Is.True, "Expected: has edge D-Y"); // D-Y
        Assume.That(HasEdge(edges, 1200, 0, 1200, 1200), Is.True, "Expected: has edge Y-W"); // Y-W
        Assume.That(HasEdge(edges, 1200, 1200, 1100, 1200), Is.True, "Expected: has edge W-C"); // W-C

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 500, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 100, 1200), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1100, 1200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 700, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 100, 1200), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has X"); // #2 has X
        Assume.That(HasPoint(sites[1].Points, 0, 1200), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 1100, 1200), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 700, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1200, 1200), Is.True, "Expected: site #3 has W"); // #3 has W
        Assume.That(HasPoint(sites[2].Points, 1200, 0), Is.True, "Expected: site #3 has Y"); // #3 has Y

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 200, 200, 600, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 200, 200, 1000, 600), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 200, 200, 0, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 600, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-D"); // X-D
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 600), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 1000, 600, 1000, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 1000, 600, 1000), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 200, 200), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 200, 200), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 600, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 600), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 200, 200), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 600), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 200, 800, 1000, 400), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 200, 800, 600, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 200, 800, 0, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 1000, 400, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-D"); // X-D
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 600, 0, 1000, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 400), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 200, 800), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 400), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 200, 800), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 400), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 200, 800), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 600, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 800, 800, 400, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 800, 800, 0, 400), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 800, 800, 1000, 1000), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 400, 0, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-D"); // X-D
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 400), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 0, 400, 0, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 0, 400, 0), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 800, 800), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 400, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 800, 800), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 400, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 800, 800), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 400), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 800, 200, 0, 600), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 800, 200, 400, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 800, 200, 1000, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-D"); // X-D
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge D-W"); // D-W
        Assume.That(HasEdge(edges, 1000, 1000, 400, 1000), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 400, 1000, 0, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 600), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 800, 200), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 600), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has D"); // #1 has D
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 800, 200), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(4), "Expected: site #3 point count 4"); // #3
        Assume.That(HasPoint(sites[2].Points, 800, 200), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 400, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 500, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 1000, 500), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 500), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 1000, 1000, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 1000, 500, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 1000, 500, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 500), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 500, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 1000, 500, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 1000, 0, 500), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 500, 0, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 0, 500, 0), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 500, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 500, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 500), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(8), "Expected: edge count 8");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 0, 0, 500), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 0, 500, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 500, 0, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 1000, 1000, 500, 1000), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 500, 1000, 0, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 500), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 500), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 500), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 500, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 500, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 200, 0, 700, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 200, 0, 1000, 400), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 700, 1000, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 1000, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 200, 0), Is.True, "Expected: has edge Y-A"); // Y-A
        Assume.That(HasEdge(edges, 200, 0, 1000, 0), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 1000, 0, 1000, 400), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 1000, 400, 1000, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 1000, 700, 1000), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 200, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 700, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 200, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 700, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 400), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 200, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 400), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 800, 1000, 300), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 800, 400, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 1000, 300, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 1000, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 0, 800), Is.True, "Expected: has edge Y-A"); // Y-A
        Assume.That(HasEdge(edges, 0, 800, 0, 0), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 0, 0, 400, 0), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 400, 0, 1000, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 0, 1000, 300), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 800), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 300), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 800), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 300), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 400, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 800), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 400, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 800, 1000, 300, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 800, 1000, 0, 600), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 300, 0, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 0, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 800, 1000), Is.True, "Expected: has edge Y-A"); // Y-A
        Assume.That(HasEdge(edges, 800, 1000, 0, 1000), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 0, 1000, 0, 600), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 800, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 300, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 800, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 300, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 800, 1000), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 600), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 200, 0, 700), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 200, 600, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 700, 0, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 0, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 1000, 200), Is.True, "Expected: has edge Y-A"); // Y-A
        Assume.That(HasEdge(edges, 1000, 200, 1000, 1000), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 1000, 1000, 600, 1000), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 600, 1000, 0, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 1000, 0, 700), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 200), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 700), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 200), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 700), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 600, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 1000, 200), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 600, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 800, 0, 300, 1000), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 800, 0, 0, 400), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 300, 1000, 1000, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 0, 800, 0), Is.True, "Expected: has edge Y-A"); // Y-A
        Assume.That(HasEdge(edges, 800, 0, 0, 0), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 0, 0, 0, 400), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 0, 400, 0, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 1000, 300, 1000), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 800, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 300, 1000), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 800, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 300, 1000), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 400), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 800, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 400), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 200, 1000, 700), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 200, 400, 1000), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 1000, 700, 1000, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 1000, 0, 0, 0), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 0, 0, 200), Is.True, "Expected: has edge Y-A"); // Y-A
        Assume.That(HasEdge(edges, 0, 200, 0, 1000), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 0, 1000, 400, 1000), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 400, 1000, 1000, 1000), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 700), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 200), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1000, 700), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 1000, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 200), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1000, 700), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 400, 1000), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 1000), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 200), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 400, 1000), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 0, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 200, 1000, 700, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 200, 1000, 1000, 600), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 700, 0, 0, 0), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 0, 0, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 0, 1000, 200, 1000), Is.True, "Expected: has edge Y-A"); // Y-A
        Assume.That(HasEdge(edges, 200, 1000, 1000, 1000), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 600), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 1000, 600, 1000, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 1000, 0, 700, 0), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 200, 1000), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 700, 0), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 200, 1000), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 700, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1000, 600), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1000, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 200, 1000), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 1000, 600), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 1000), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1000, 800, 0, 300), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 1000, 800, 600, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 300, 0, 1000), Is.True, "Expected: has edge B-X"); // B-X
        Assume.That(HasEdge(edges, 0, 1000, 1000, 1000), Is.True, "Expected: has edge X-Y"); // X-Y
        Assume.That(HasEdge(edges, 1000, 1000, 1000, 800), Is.True, "Expected: has edge Y-A"); // Y-A
        Assume.That(HasEdge(edges, 1000, 800, 1000, 0), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 1000, 0, 600, 0), Is.True, "Expected: has edge W-C"); // W-C
        Assume.That(HasEdge(edges, 600, 0, 0, 0), Is.True, "Expected: has edge C-Z"); // C-Z
        Assume.That(HasEdge(edges, 0, 0, 0, 300), Is.True, "Expected: has edge Z-B"); // Z-B

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(4), "Expected: site #1 point count 4"); // #1
        Assume.That(HasPoint(sites[0].Points, 1000, 800), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 300), Is.True, "Expected: site #1 has B"); // #1 has B
        Assume.That(HasPoint(sites[0].Points, 0, 1000), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(HasPoint(sites[0].Points, 1000, 1000), Is.True, "Expected: site #1 has Y"); // #1 has Y
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(4), "Expected: site #2 point count 4"); // #2
        Assume.That(HasPoint(sites[1].Points, 1000, 800), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 300), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 1000, 800), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 600, 0), Is.True, "Expected: site #3 has C"); // #3 has C
        Assume.That(HasPoint(sites[2].Points, 1000, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 300, 600, 1200), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 300, 0, 1200, 600), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 0, 1200, 0, 300), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 0, 300, 0, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 300, 0, 1200, 0), Is.True, "Expected: has edge B-W"); // B-W
        Assume.That(HasEdge(edges, 1200, 0, 1200, 600), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 1200, 600, 1200, 1200), Is.True, "Expected: has edge D-Z"); // D-Z
        Assume.That(HasEdge(edges, 1200, 1200, 600, 1200), Is.True, "Expected: has edge Z-C"); // Z-C
        Assume.That(HasEdge(edges, 600, 1200, 0, 1200), Is.True, "Expected: has edge C-X"); // C-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 300), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 1200), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 1200), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(6), "Expected: site #2 point count 6"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 300), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 300, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 600, 1200), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 1200, 600), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 1200, 1200), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 300, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 1200, 600), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1200, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 300, 1200, 1200, 600), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 900, 600, 0), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 1200, 1200, 300, 1200), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 300, 1200, 0, 1200), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 0, 1200, 0, 900), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 0, 900, 0, 0), Is.True, "Expected: has edge B-W"); // B-W
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 600, 0, 1200, 0), Is.True, "Expected: has edge D-Z"); // D-Z
        Assume.That(HasEdge(edges, 1200, 0, 1200, 600), Is.True, "Expected: has edge Z-C"); // Z-C
        Assume.That(HasEdge(edges, 1200, 600, 1200, 1200), Is.True, "Expected: has edge C-X"); // C-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 300, 1200), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 1200, 600), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1200, 1200), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(6), "Expected: site #2 point count 6"); // #2
        Assume.That(HasPoint(sites[1].Points, 300, 1200), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 900), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 1200, 600), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 0, 1200), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 1200, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 900), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 600, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 1200, 900, 600, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 900, 1200, 0, 600), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 1200, 0, 1200, 900), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 1200, 900, 1200, 1200), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1200, 1200, 900, 1200), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 900, 1200, 0, 1200), Is.True, "Expected: has edge B-W"); // B-W
        Assume.That(HasEdge(edges, 0, 1200, 0, 600), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge D-Z"); // D-Z
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge Z-C"); // Z-C
        Assume.That(HasEdge(edges, 600, 0, 1200, 0), Is.True, "Expected: has edge C-X"); // C-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 1200, 900), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 1200, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(6), "Expected: site #2 point count 6"); // #2
        Assume.That(HasPoint(sites[1].Points, 1200, 900), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 900, 1200), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1200, 1200), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 900, 1200), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 600), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 0, 1200), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(10), "Expected: edge count 10");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 900, 0, 0, 600), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 1200, 300, 600, 1200), Is.True, "Expected: has edge B-D"); // B-D
        Assume.That(HasEdge(edges, 0, 0, 900, 0), Is.True, "Expected: has edge X-A"); // X-A
        Assume.That(HasEdge(edges, 900, 0, 1200, 0), Is.True, "Expected: has edge A-Y"); // A-Y
        Assume.That(HasEdge(edges, 1200, 0, 1200, 300), Is.True, "Expected: has edge Y-B"); // Y-B
        Assume.That(HasEdge(edges, 1200, 300, 1200, 1200), Is.True, "Expected: has edge B-W"); // B-W
        Assume.That(HasEdge(edges, 1200, 1200, 600, 1200), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 600, 1200, 0, 1200), Is.True, "Expected: has edge D-Z"); // D-Z
        Assume.That(HasEdge(edges, 0, 1200, 0, 600), Is.True, "Expected: has edge Z-C"); // Z-C
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge C-X"); // C-X

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 900, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 600), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(6), "Expected: site #2 point count 6"); // #2
        Assume.That(HasPoint(sites[1].Points, 900, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 1200, 300), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 600), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(HasPoint(sites[1].Points, 600, 1200), Is.True, "Expected: site #2 has D"); // #2 has D
        Assume.That(HasPoint(sites[1].Points, 1200, 0), Is.True, "Expected: site #2 has Y"); // #2 has Y
        Assume.That(HasPoint(sites[1].Points, 0, 1200), Is.True, "Expected: site #2 has Z"); // #2 has Z
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 1200, 300), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 600, 1200), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(HasPoint(sites[2].Points, 1200, 1200), Is.True, "Expected: site #3 has W"); // #3 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 0, 900, 900), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 0, 300, 900), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 0, 900, 300), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 0, 900, 0), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 900, 0, 900, 300), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 900, 300, 900, 900), Is.True, "Expected: has edge D-B"); // D-B
        Assume.That(HasEdge(edges, 900, 900, 300, 900), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 300, 900, 0, 900), Is.True, "Expected: has edge C-X"); // C-X
        Assume.That(HasEdge(edges, 0, 900, 0, 0), Is.True, "Expected: has edge X-A"); // X-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 300, 900), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 900), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 900, 900), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 300, 900), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 900, 900), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 900, 300), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(3), "Expected: site #4 point count 3"); // #4
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 900, 300), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 900, 0), Is.True, "Expected: site #4 has W"); // #4 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 0, 900, 900, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 0, 900, 900, 600), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 0, 900, 300, 0), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 0, 900, 0, 0), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 0, 0, 300, 0), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 300, 0, 900, 0), Is.True, "Expected: has edge D-B"); // D-B
        Assume.That(HasEdge(edges, 900, 0, 900, 600), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 900, 600, 900, 900), Is.True, "Expected: has edge C-X"); // C-X
        Assume.That(HasEdge(edges, 900, 900, 0, 900), Is.True, "Expected: has edge X-A"); // X-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 0, 900), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 900, 600), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 900, 900), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 0, 900), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 900, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 900, 600), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 0, 900), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 900, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 300, 0), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(3), "Expected: site #4 point count 3"); // #4
        Assume.That(HasPoint(sites[3].Points, 0, 900), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 300, 0), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 0, 0), Is.True, "Expected: site #4 has W"); // #4 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 900, 900, 0, 0), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 900, 900, 600, 0), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 900, 900, 0, 600), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 900, 900, 0, 900), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 0, 900, 0, 600), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 0, 600, 0, 0), Is.True, "Expected: has edge D-B"); // D-B
        Assume.That(HasEdge(edges, 0, 0, 600, 0), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 600, 0, 900, 0), Is.True, "Expected: has edge C-X"); // C-X
        Assume.That(HasEdge(edges, 900, 0, 900, 900), Is.True, "Expected: has edge X-A"); // X-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 900, 900), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 600, 0), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 900, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 900, 900), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 0), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 600, 0), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 900, 900), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 0), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 0, 600), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(3), "Expected: site #4 point count 3"); // #4
        Assume.That(HasPoint(sites[3].Points, 900, 900), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 0, 600), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 0, 900), Is.True, "Expected: site #4 has W"); // #4 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
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

        Assume.That(edges.Count, Is.EqualTo(9), "Expected: edge count 9");
        Assume.That(edges, Is.Not.Null);
        Assume.That(HasEdge(edges, 900, 0, 0, 900), Is.True, "Expected: has edge A-B"); // A-B
        Assume.That(HasEdge(edges, 900, 0, 0, 300), Is.True, "Expected: has edge A-C"); // A-C
        Assume.That(HasEdge(edges, 900, 0, 600, 900), Is.True, "Expected: has edge A-D"); // A-D
        Assume.That(HasEdge(edges, 900, 0, 900, 900), Is.True, "Expected: has edge A-W"); // A-W
        Assume.That(HasEdge(edges, 900, 900, 600, 900), Is.True, "Expected: has edge W-D"); // W-D
        Assume.That(HasEdge(edges, 600, 900, 0, 900), Is.True, "Expected: has edge D-B"); // D-B
        Assume.That(HasEdge(edges, 0, 900, 0, 300), Is.True, "Expected: has edge B-C"); // B-C
        Assume.That(HasEdge(edges, 0, 300, 0, 0), Is.True, "Expected: has edge C-X"); // C-X
        Assume.That(HasEdge(edges, 0, 0, 900, 0), Is.True, "Expected: has edge X-A"); // X-A

        Assume.That(sites[0].Points, Is.Not.Null);
        Assume.That(sites[0].Points.Count(), Is.EqualTo(3), "Expected: site #1 point count 3"); // #1
        Assume.That(HasPoint(sites[0].Points, 900, 0), Is.True, "Expected: site #1 has A"); // #1 has A
        Assume.That(HasPoint(sites[0].Points, 0, 300), Is.True, "Expected: site #1 has C"); // #1 has C
        Assume.That(HasPoint(sites[0].Points, 0, 0), Is.True, "Expected: site #1 has X"); // #1 has X
        Assume.That(sites[1].Points, Is.Not.Null);
        Assume.That(sites[1].Points.Count(), Is.EqualTo(3), "Expected: site #2 point count 3"); // #2
        Assume.That(HasPoint(sites[1].Points, 900, 0), Is.True, "Expected: site #2 has A"); // #2 has A
        Assume.That(HasPoint(sites[1].Points, 0, 900), Is.True, "Expected: site #2 has B"); // #2 has B
        Assume.That(HasPoint(sites[1].Points, 0, 300), Is.True, "Expected: site #2 has C"); // #2 has C
        Assume.That(sites[2].Points, Is.Not.Null);
        Assume.That(sites[2].Points.Count(), Is.EqualTo(3), "Expected: site #3 point count 3"); // #3
        Assume.That(HasPoint(sites[2].Points, 900, 0), Is.True, "Expected: site #3 has A"); // #3 has A
        Assume.That(HasPoint(sites[2].Points, 0, 900), Is.True, "Expected: site #3 has B"); // #3 has B
        Assume.That(HasPoint(sites[2].Points, 600, 900), Is.True, "Expected: site #3 has D"); // #3 has D
        Assume.That(sites[3].Points, Is.Not.Null);
        Assume.That(sites[3].Points.Count(), Is.EqualTo(3), "Expected: site #4 point count 3"); // #4
        Assume.That(HasPoint(sites[3].Points, 900, 0), Is.True, "Expected: site #4 has A"); // #4 has A
        Assume.That(HasPoint(sites[3].Points, 600, 900), Is.True, "Expected: site #4 has D"); // #4 has D
        Assume.That(HasPoint(sites[3].Points, 900, 900), Is.True, "Expected: site #4 has W"); // #4 has W

        // Assert

        Assert.That(sites[0].LiesOnEdge, Is.Null); // #1
        Assert.That(sites[0].LiesOnCorner, Is.Null);// #1
        Assert.That(sites[1].LiesOnEdge, Is.Null); // #2
        Assert.That(sites[1].LiesOnCorner, Is.Null);// #2
        Assert.That(sites[2].LiesOnEdge, Is.Null); // #3
        Assert.That(sites[2].LiesOnCorner, Is.Null);// #3
        Assert.That(sites[3].LiesOnEdge, Is.Null); // #4
        Assert.That(sites[3].LiesOnCorner, Is.Null);// #4
    }

}
