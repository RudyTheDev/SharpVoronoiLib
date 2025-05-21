using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace SharpVoronoiLib.Benchmarks;

[SimpleJob]
public class RandomPointGenerationBenchmark
{
    [Params(100, 1000, 10000)]
    [UsedImplicitly]
    public int NumberOfSites { get; set; }

    [ParamsAllValues]
    [UsedImplicitly]
    public PointGenerationMethod PointGenerationMethod { get; set; }
        
        
    private VoronoiPlane _plane = null!;

        
    [IterationSetup]
    public void Setup()
    {
        _plane = new VoronoiPlane(0, 0, 1000, 1000);
    }

    [Benchmark]
    public List<VoronoiSite> Generate()
    {
        return _plane.GenerateRandomSites(NumberOfSites, PointGenerationMethod);
    }
}