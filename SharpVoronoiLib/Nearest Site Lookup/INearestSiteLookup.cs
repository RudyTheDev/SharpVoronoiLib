namespace SharpVoronoiLib;

internal interface INearestSiteLookup
{
    VoronoiSite GetNearestSiteTo(List<VoronoiSite> sites, double x, double y, int version, int duplicateCount);
}