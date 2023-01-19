# SharpVoronoiLib

C# implementation of generating a Voronoi diagram from a set of points in a plane (using Fortune's Algorithm) with edge clipping and border closure. This implementation guarantees O(n×ln(n)) performance.

TODO: pretty picture here

The key differences from the [original VoronoiLib repo](https://github.com/Zalgo2462/VoronoiLib)
* Borders can be closed, that is, edges generated along the boundary
* Edges and points/sites contain additional useful data
* Multiple critical and annoyingly-rare bugs and edge cases fixes
* LOTS more unit testing

Known issues:
* The algorithm uses a lot of allocations, forcing garbage collection
* There is no visual output/example since the original used MonoGame

# Examples

TODO: several pretty pictures here

# Use

Quick-start:

```
IEnumerable<VoronoiSite> sites = new List<VoronoiSite>
{
    new FortuneSite(300, 300),
    new FortuneSite(300, 400),
    new FortuneSite(400, 300)
};

LinkedList<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(
    sites, 
    0, 0, 
    600, 600
);
```

The returned collection contains the generated edges as `VoronoiEdge`s.
* `VoronoiEdge.Start` and `.End` are the start and end points of the edge.
* `VoronoiEdge.Right` and `.Left` are the sites the edge encloses. Border edges move clockwise and will only have the `.Right` site. And if no points are within the region, both will be `null`.
* Edge end `VoronoiPoint`s also contain a `.BorderLocation` specifying if it's on a border and which one.
* `VoronoiEdge.Neighbours` (on-demand) are edges directly "connecting" to this edge, basically creating a traversable edge graph.
* `VoronoiEdge.Length` (on-demand) is the distance between its end points.
* `FortuneSite.Cell` contains the edges that enclose the site (starting from the bottom-left "corner").
* `FortuneSite.ClockwiseCell` (on-demand) contains these edges sorted clockwise (starting from the bottom-left "corner" end point).
* `FortuneSite.Neighbors` contains the site's neighbors (in the Delaunay Triangulation), that is, other sites across its edges.
* `FortuneSite.Points` (on-demand) contains points of the cell, that is, edge end points / edge nodes.
* `FortuneSite.ClockwisePoints` (on-demand) contains these points sorted clockwise (starting from the bottom-left "corner").

If closing borders around the boundary is not desired (leaving sites with unclosed cells/polygons):

```
LinkedList<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(
    sites, 
    0, 0, 
    600, 600,
    BorderEdgeGeneration.DoNotMakeBorderEdges
);
```

Full syntax (leaving a reusable `VoronoiPlane` instance):

```
VoronoiPlane plane = new VoronoiPlane(
    sites, 
    0, 0, 
    600, 600
);

plane.Tessellate();
```

# Dependencies

TODO: Actually version, compile and publish the library

The library is compiled for .NET Standard 1.1 at C# 9.0 and can target compatible platforms/frameworks, like UWP, Mono/Linux or Xamarin/Mac, Unity.

# Credits

- [Originally written by Logan Lembke as VoronoiLib](https://github.com/Zalgo2462/VoronoiLib)
- [Updated with unit tests and nuget package by Sean Esopenko](https://github.com/sesopenko/VoronoiLib)
- [Improvements by Jeffrey Jones](https://github.com/rurounijones/VoronoiLib)
- Various code pieces atributed inline

Original implementation inspired by:
- [Ivan Kuckir's project](http://blog.ivank.net/fortunes-algorithm-and-implementation.html)
- [Raymond Hill's project](https://github.com/gorhill/Javascript-Voronoi)