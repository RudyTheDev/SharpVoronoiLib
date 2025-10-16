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
            
        // EdgeLinkedList
        // ...
        
        // LinkedList + edges.ToList();
        // | Method     | NumberOfSites | BorderEdgeGeneration | Mean      | Error     | StdDev    | Median    |
        // |----------- |-------------- |--------------------- |----------:|----------:|----------:|----------:|
        // | Tessellate | 300           | DoNotMakeBorderEdges |  1.520 ms | 0.0259 ms | 0.0354 ms |  1.515 ms |
        // | Tessellate | 300           | MakeBorderEdges      |  2.026 ms | 0.1809 ms | 0.5333 ms |  1.832 ms |
        // | Tessellate | 1000          | DoNotMakeBorderEdges |  4.643 ms | 0.8075 ms | 2.3810 ms |  3.618 ms |
        // | Tessellate | 1000          | MakeBorderEdges      |  4.546 ms | 0.8015 ms | 2.3633 ms |  3.500 ms |
        // | Tessellate | 10000         | DoNotMakeBorderEdges | 51.933 ms | 1.1274 ms | 3.3063 ms | 51.067 ms |
        // | Tessellate | 10000         | MakeBorderEdges      | 52.544 ms | 1.0392 ms | 2.7376 ms | 51.883 ms |
            
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