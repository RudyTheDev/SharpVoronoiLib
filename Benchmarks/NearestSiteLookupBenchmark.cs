using System;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;

namespace SharpVoronoiLib.Benchmarks;

[SimpleJob]
public class NearestSiteLookupBenchmark
{
    [Params(500, 5000)]
    [UsedImplicitly]
    public int NumberOfSites { get; set; }

    [Params(100, 100000)]
    [UsedImplicitly]
    public int NumberOfLookups { get; set; }
    
    [ParamsAllValues]
    [UsedImplicitly]
    public bool PreWarm { get; set; }

    [ParamsAllValues]
    [UsedImplicitly]
    public NearestSiteLookupMethod LookupMethod { get; set; }


    private VoronoiPlane _plane = null!;

    private (double x, double y)[] _points = null!;
    private VoronoiSite[] _sites = null!;


    [IterationSetup]
    public void Setup()
    {
        _plane = new VoronoiPlane(0, 0, 1000, 1000);
        _plane.GenerateRandomSites(NumberOfSites);
        _plane.Tessellate();

        _points = new (double, double)[NumberOfLookups];
        _sites = new VoronoiSite[NumberOfLookups];
        
        for (int i = 0; i < NumberOfLookups; i++)
        {
            _points[i].x = Random.Shared.NextDouble() * 1200 - 100;
            _points[i].y = Random.Shared.NextDouble() * 1200 - 100;
        }
        
        if (PreWarm)
            _plane.GetNearestSiteTo(0, 0, LookupMethod);
    }

    [Benchmark]
    public VoronoiSite[] Lookup()
    {
        for (int i = 0; i < NumberOfLookups; i++)
            _sites[i] = _plane.GetNearestSiteTo(_points[i].x, _points[i].y, LookupMethod);
        return _sites;
    }
}