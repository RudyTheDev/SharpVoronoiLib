namespace SharpVoronoiLib.UnitTestGenerator;

/// <summary>
/// What part of the Voronoi structure is being tested in the generated test?
/// </summary>
public enum TestPurpose
{
    AssertEdges,
    AssertSiteEdges,
    AssertEdgeSites,
    AssertSitePoints,
    AssertPointBorderLocation,
    AssertEdgeNeighbours,
    AssertSiteNeighbours,
    AssertSiteEdgesClockwise,
    AssertSitePointsClockwise,
    AssertLiesOnEdgeOrCorner,
    AssertSiteCentroids
}