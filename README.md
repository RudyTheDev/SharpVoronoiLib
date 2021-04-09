# VoronoiLib

![build workflow](https://github.com/sesopenko/VoronoiLib/actions/workflows/pipeline.yml/badge.svg?branch=master)

C# implementation of Fortune's Algorithm, [originally written by Logan Lembke](https://github.com/Zalgo2462/VoronoiLib) and updated with nuget unit tests and package publishing to nuget.
Unlike several implemenations of Fortune's Algorithm, this implementation guarantees O(n ln(n)) performance by way of a specialized Red Black Tree (Credit: Raymond Hill).

# Dependencies
- The library (VoronoiLib) is compiled for .net standard 1.1.

As such, projects should be able to be built on Linux or OS X.
# Use

Install with dotnet CLI:

```
dotnet add package VoronoiLib
```

Create points, run algorithm.

```
var points = new List<FortuneSite> {
  new FortuneSite(100, 200),
  new FortuneSite(500, 200),
  new FortuneSite(300, 300)
}
//FortunesAlgorithm.Run(points, min x, min y, max x, max y)
LinkedList<VEdge> = FortunesAlgorithm.Run(points, 0, 0, 800, 800);

//VEdge.Start is a VPoint with location VEdge.Start.X and VEdge.End.Y
//VEdge.End is the ending point for the edge
//FortuneSite.Neighbors contains the site's neighbors in the Delaunay Triangulation
```

## Issues and feature suggestions
See the issue manager of the repo to see work in progress and to suggest new features.

## Implementation inspired by:
- Ivan Kuckir's project (MIT) @ http://blog.ivank.net/fortunes-algorithm-and-implementation.html
- Raymond Hill's project (MIT) @ https://github.com/gorhill/Javascript-Voronoi 

Feel free to use the code under [MIT license](License.md). However, if you find the code useful, feel free to send mysel and/or [Logan Lembke](https://github.com/Zalgo2462/VoronoiLib) a message or make a link back to the repos.

