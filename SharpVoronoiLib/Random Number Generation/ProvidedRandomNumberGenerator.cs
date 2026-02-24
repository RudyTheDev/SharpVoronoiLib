namespace SharpVoronoiLib;

[PublicAPI]
public class ProvidedRandomNumberGenerator : IRandomNumberGenerator
{
    private readonly Random _random;
    
    
    public ProvidedRandomNumberGenerator(Random random)
    {
        _random = random;
    }
    
    
    public double NextDouble() => _random.NextDouble();
}