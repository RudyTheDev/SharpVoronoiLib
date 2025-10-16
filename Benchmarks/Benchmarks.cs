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
            
        // HashedLinkedList
        // | Method     | NumberOfSites | BorderEdgeGeneration | Mean       | Error      | StdDev    | Median     |
        // |----------- |-------------- |--------------------- |-----------:|-----------:|----------:|-----------:|
        // | Tessellate | 1000          | DoNotMakeBorderEdges |   3.275 ms |  0.5887 ms |  1.727 ms |   2.339 ms |
        // | Tessellate | 1000          | MakeBorderEdges      |   3.769 ms |  0.7245 ms |  2.136 ms |   3.021 ms |
        // | Tessellate | 10000         | DoNotMakeBorderEdges |  47.504 ms |  0.9489 ms |  1.873 ms |  46.981 ms |
        // | Tessellate | 10000         | MakeBorderEdges      |  47.501 ms |  0.9471 ms |  1.825 ms |  47.173 ms |
        // | Tessellate | 100000        | DoNotMakeBorderEdges | 891.820 ms | 18.6315 ms | 54.935 ms | 894.322 ms |
        // | Tessellate | 100000        | MakeBorderEdges      | 889.135 ms | 17.7824 ms | 19.027 ms | 889.210 ms |

        
        // LinkedList + edges.ToList();
        // | Method     | NumberOfSites | BorderEdgeGeneration | Mean       | Error      | StdDev    | Median     |
        // |----------- |-------------- |--------------------- |-----------:|-----------:|----------:|-----------:|
        // | Tessellate | 1000          | DoNotMakeBorderEdges |   3.666 ms |  0.6253 ms |  1.844 ms |   2.460 ms |
        // | Tessellate | 1000          | MakeBorderEdges      |   3.771 ms |  0.6869 ms |  2.025 ms |   2.182 ms |
        // | Tessellate | 10000         | DoNotMakeBorderEdges |  40.164 ms |  0.7984 ms |  1.613 ms |  39.832 ms |
        // | Tessellate | 10000         | MakeBorderEdges      |  40.438 ms |  0.8063 ms |  1.255 ms |  40.507 ms |
        // | Tessellate | 100000        | DoNotMakeBorderEdges | 924.920 ms | 18.1821 ms | 36.729 ms | 928.722 ms |
        // | Tessellate | 100000        | MakeBorderEdges      | 927.620 ms | 18.3575 ms | 37.912 ms | 928.387 ms |
        
        // so it's better at insane number of points but not better at normal...
        // I think random removals just happen so rarely that all the "optimization" overhead I add doesn't overcome
        // the simple final ToList of the built-in LinkedList.
            
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