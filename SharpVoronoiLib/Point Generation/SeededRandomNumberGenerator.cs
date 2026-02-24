namespace SharpVoronoiLib;

[PublicAPI]
public class SeededRandomNumberGenerator : IRandomNumberGenerator
{
    private readonly Random _random;
    
    
    public SeededRandomNumberGenerator(int seed)
    {
        _random = new Random(seed);
    }
    
    
    public double NextDouble() => _random.NextDouble();
}