namespace SharpVoronoiLib;

internal class DefaultRandomNumberGenerator : IRandomNumberGenerator
{
    public static DefaultRandomNumberGenerator Instance { get; } = new DefaultRandomNumberGenerator();
    
    
    private readonly Random _random = new Random();
    
    
    public double NextDouble() => _random.NextDouble();
}