namespace SharpVoronoiLib;

internal interface IPointGenerationAlgorithm
{
    void Prepare(double minX, double minY, double maxX, double maxY, int count);

    List<VoronoiSite> Generate(double minX, double minY, double maxX, double maxY, int count);
    
    void Conclude();
}