using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace SharpVoronoiLib.Benchmarks;

[SimpleJob]
public class TesselationBenchmark
{
    [Params(1000, 10000, 100000)]
    [UsedImplicitly]
    public int NumberOfSites { get; set; }

    [ParamsAllValues]
    [UsedImplicitly]
    public BorderEdgeGeneration BorderEdgeGeneration { get; set; }

        
    private VoronoiPlane _plane = null!;

        
    [IterationSetup]
    public void Setup()
    {
        _plane = new VoronoiPlane(0, 0, 1000, 1000);
        _plane.GenerateRandomSites(NumberOfSites);
    }
        
    [Benchmark]
    public List<VoronoiEdge> Tessellate()
    {
        return _plane.Tessellate(BorderEdgeGeneration);            
    }
}