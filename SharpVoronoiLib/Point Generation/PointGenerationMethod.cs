namespace SharpVoronoiLib;

public enum PointGenerationMethod
{
    Uniform,
    Gaussian,
    
#if DEBUG
    Naughty
#endif
}