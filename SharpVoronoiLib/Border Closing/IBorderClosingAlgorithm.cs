namespace SharpVoronoiLib;

internal interface IBorderClosingAlgorithm
{
    List<VoronoiEdge> Close(List<VoronoiEdge> edges, double minX, double minY, double maxX, double maxY, List<VoronoiSite> sites);
}