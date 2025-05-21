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
            
            
        //BenchmarkRunner.Run<TesselationBenchmark>();
            
        // |     Method | NumberOfSites | BorderEdgeGeneration |       Mean |     Error |    StdDev |     Median |
        // |----------- |-------------- |--------------------- |-----------:|----------:|----------:|-----------:|
        // | Tessellate |           100 | DoNotMakeBorderEdges |   593.9 us |  24.18 us |  68.58 us |   576.1 us |
        // | Tessellate |           100 |      MakeBorderEdges |   650.0 us |  23.20 us |  67.67 us |   639.2 us |
        // | Tessellate |           500 | DoNotMakeBorderEdges | 2,723.4 us | 282.20 us | 832.06 us | 2,329.7 us |
        // | Tessellate |           500 |      MakeBorderEdges | 2,707.7 us | 260.85 us | 769.12 us | 2,368.1 us |
        // | Tessellate |          2000 | DoNotMakeBorderEdges | 9,498.0 us | 182.53 us | 415.72 us | 9,462.5 us |
        // | Tessellate |          2000 |      MakeBorderEdges | 9,619.9 us | 181.31 us | 496.34 us | 9,482.5 us |
            
            
        //BenchmarkRunner.Run<RandomPointGenerationBenchmark>();
            
        // |   Method | NumberOfSites | PointGenerationMethod |        Mean |      Error |     StdDev |      Median |
        // |--------- |-------------- |---------------------- |------------:|-----------:|-----------:|------------:|
        // | Generate |           100 |               Uniform |    18.88 us |   1.754 us |   5.089 us |    17.60 us |
        // | Generate |           100 |              Gaussian |    31.22 us |   2.417 us |   6.972 us |    28.05 us |
        // | Generate |          1000 |               Uniform |   127.58 us |   9.041 us |  26.373 us |   125.45 us |
        // | Generate |          1000 |              Gaussian |   229.74 us |  11.569 us |  33.747 us |   221.60 us |
        // | Generate |         10000 |               Uniform |   989.62 us |  19.377 us |  32.375 us |   988.90 us |
        // | Generate |         10000 |              Gaussian | 1,535.13 us | 150.404 us | 443.468 us | 1,290.40 us |
        
        
        BenchmarkRunner.Run<NearestSiteLookupBenchmark>();
        
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