using BenchmarkDotNet.Running;

namespace SharpVoronoiLib.Benchmarks;

public class Benchmarks
{
    public static void Main(string[] args)
    {
        // // For IDE profiling:
        //
        // do
        // {
        //     
        //     VoronoiPlane plane = new VoronoiPlane(0, 0, 1000, 1000);
        //     plane.GenerateRandomSites(1000);
        //     plane.Tessellate(BorderEdgeGeneration.MakeBorderEdges);
        //     
        // } while (!Console.KeyAvailable);
            
            
        BenchmarkRunner.Run<TesselationBenchmark>();
        
        // | Method     | NumberOfSites | BorderEdgeGeneration | Mean       | Error     | StdDev      | Median     |
        // |----------- |-------------- |--------------------- |-----------:|----------:|------------:|-----------:|
        // | Tessellate | 100           | DoNotMakeBorderEdges |   453.1 us |   8.94 us |    10.98 us |   450.6 us |
        // | Tessellate | 100           | MakeBorderEdges      |   483.6 us |   9.03 us |     9.27 us |   483.0 us |
        // | Tessellate | 500           | DoNotMakeBorderEdges | 2,457.1 us |  48.57 us |    61.43 us | 2,449.5 us |
        // | Tessellate | 500           | MakeBorderEdges      | 2,365.4 us |  46.92 us |    71.66 us | 2,341.8 us |
        // | Tessellate | 2000          | DoNotMakeBorderEdges | 5,139.8 us | 587.55 us | 1,647.54 us | 4,348.9 us |
        // | Tessellate | 2000          | MakeBorderEdges      | 4,835.6 us | 230.55 us |   676.16 us | 4,534.8 us |
            
        //BenchmarkRunner.Run<RandomPointGenerationBenchmark>();
            
        // |   Method | NumberOfSites | PointGenerationMethod |        Mean |      Error |     StdDev |      Median |
        // |--------- |-------------- |---------------------- |------------:|-----------:|-----------:|------------:|
        // | Generate |           100 |               Uniform |    18.88 us |   1.754 us |   5.089 us |    17.60 us |
        // | Generate |           100 |              Gaussian |    31.22 us |   2.417 us |   6.972 us |    28.05 us |
        // | Generate |          1000 |               Uniform |   127.58 us |   9.041 us |  26.373 us |   125.45 us |
        // | Generate |          1000 |              Gaussian |   229.74 us |  11.569 us |  33.747 us |   221.60 us |
        // | Generate |         10000 |               Uniform |   989.62 us |  19.377 us |  32.375 us |   988.90 us |
        // | Generate |         10000 |              Gaussian | 1,535.13 us | 150.404 us | 443.468 us | 1,290.40 us |
        
        
        //BenchmarkRunner.Run<NearestSiteLookupBenchmark>();
        
        // | Method | NumberOfSites | NumberOfLookups | PreWarm | LookupMethod | Mean         |
        // |------- |-------------- |---------------- |-------- |------------- |-------------:|
        // | Lookup | 500           | 100             | False   | BruteForce   |     409.8 us |
        // | Lookup | 500           | 100             | False   | KDTree       |     745.4 us |
        // | Lookup | 500           | 100000          | False   | BruteForce   |  33,836.6 us |
        // | Lookup | 500           | 100000          | False   | KDTree       |  69,768.9 us |
        // | Lookup | 5000          | 100             | False   | BruteForce   |     338.7 us |
        // | Lookup | 5000          | 100             | False   | KDTree       |   4,324.0 us |
        // | Lookup | 5000          | 100000          | False   | BruteForce   | 306,600.1 us |
        // | Lookup | 5000          | 100000          | False   | KDTree       | 105,169.4 us |
        
        // | Lookup | 500           | 100             | True    | BruteForce   |     394.2 us |
        // | Lookup | 500           | 100             | True    | KDTree       |     209.8 us |
        // | Lookup | 500           | 100000          | True    | BruteForce   |  32,460.3 us |
        // | Lookup | 500           | 100000          | True    | KDTree       |  68,462.9 us |
        // | Lookup | 5000          | 100             | True    | BruteForce   |     334.9 us |
        // | Lookup | 5000          | 100             | True    | KDTree       |     116.3 us |
        // | Lookup | 5000          | 100000          | True    | BruteForce   | 306,142.8 us |
        // | Lookup | 5000          | 100000          | True    | KDTree       |  99,907.1 us |
    }
}