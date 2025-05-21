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
        
        // | Method | PreWarm | LookupMethod | NumberOfSites | NumberOfLookups | Mean         |
        // |------- |-------- |------------- |-------------- |---------------- |-------------:|
        // | Lookup | False   | BruteForce   | 500           | 100             |     414.1 us |
        // | Lookup | False   | KDTree       | 500           | 100             |     779.5 us |
        // | Lookup | False   | BruteForce   | 500           | 100000          |  32,990.6 us |
        // | Lookup | False   | KDTree       | 500           | 100000          |  73,251.7 us |
        // | Lookup | False   | BruteForce   | 5000          | 100             |     337.2 us |
        // | Lookup | False   | KDTree       | 5000          | 100             |   4,553.1 us |
        // | Lookup | False   | BruteForce   | 5000          | 100000          | 308,954.6 us |
        // | Lookup | False   | KDTree       | 5000          | 100000          | 107,869.5 us |

        // | Lookup | True    | BruteForce   | 500           | 100             |     353.1 us |
        // | Lookup | True    | KDTree       | 500           | 100             |     305.9 us |
        // | Lookup | True    | BruteForce   | 500           | 100000          |  33,663.3 us |
        // | Lookup | True    | KDTree       | 500           | 100000          |  70,469.7 us |
        // | Lookup | True    | BruteForce   | 5000          | 100             |     340.6 us |
        // | Lookup | True    | KDTree       | 5000          | 100             |     126.1 us |
        // | Lookup | True    | BruteForce   | 5000          | 100000          | 309,755.2 us |
        // | Lookup | True    | KDTree       | 5000          | 100000          | 106,434.0 us |
    }
}