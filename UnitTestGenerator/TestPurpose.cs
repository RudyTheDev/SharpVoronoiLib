namespace SharpVoronoiLib.UnitTestGenerator;

/// <summary>
/// What part of the Voronoi structure is being tested in the generated test?
/// </summary>
public enum TestPurpose
{
    AssertEdges,
    AssertPoints,
    AssertSiteEdges,
    AssertEdgeSites,
    AssertSitePoints,
    AssertPointEdges,
    AssertPointSites,
    AssertPointBorderLocation,
    AssertEdgeNeighbours,
    AssertSiteNeighbours,
    AssertSiteEdgesClockwise,
    AssertSiteEdgesClockwiseWound,
    AssertSitePointsClockwise,
    AssertLiesOnEdgeOrCorner,
    AssertSiteCentroids
}