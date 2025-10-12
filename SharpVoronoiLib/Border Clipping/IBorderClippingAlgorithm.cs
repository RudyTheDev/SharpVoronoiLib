namespace SharpVoronoiLib;

internal interface IBorderClippingAlgorithm
{
    List<VoronoiEdge> Clip(List<VoronoiEdge> edges, double minX, double minY, double maxX, double maxY);
}