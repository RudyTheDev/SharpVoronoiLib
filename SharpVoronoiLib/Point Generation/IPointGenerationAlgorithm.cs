namespace SharpVoronoiLib;

public interface IPointGenerationAlgorithm
{
    List<VoronoiSite> Generate(double minX, double minY, double maxX, double maxY, int count, IRandomNumberGenerator? random = null);
}