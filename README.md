![build_and_test](https://github.com/RudyTheDev/SharpVoronoiLib/actions/workflows/test.yml/badge.svg)

# SharpVoronoiLib

C# implementation of generating a Voronoi diagram from a set of points in a plane (using Fortune's Algorithm) with edge clipping and border closure. This implementation guarantees O(n×ln(n)) performance.

![voronoi example](https://user-images.githubusercontent.com/3857299/213494520-4295378c-9759-4864-aeb7-4cd032b0f3d0.png)

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
List<VoronoiSite> sites = new List<VoronoiSite>
{
    new VoronoiSite(300, 300),
    new VoronoiSite(300, 400),
    new VoronoiSite(400, 300)
};

List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(
    sites, 
    0, 0, 
    600, 600
);
```

The tesselation result for the given `VoronoiSite`s contains `VoronoiEdge`s and `VoronoiPoint`s. The returned collection contains the generated edges.

![voronoi terms](https://user-images.githubusercontent.com/3857299/213494489-4a6030a2-64d8-4e7e-b556-6f5674d89911.png)

* `VoronoiEdge.Start` and `.End` are the start and end points of the edge.
* `VoronoiEdge.Right` and `.Left` are the sites the edge encloses. Border edges move clockwise and will only have the `.Right` site. And if no points are within the region, both will be `null`.
* Edge end `VoronoiPoint`s also contain a `.BorderLocation` specifying if it's on a border and which one.
* `VoronoiEdge.Neighbours` (on-demand) are edges directly "connecting" to this edge, basically creating a traversable edge graph.
* `VoronoiEdge.Length` (on-demand) is the distance between its end points.
* `VoronoiSite.Cell` contains the edges that enclose the site (the order is not guaranteed).
* `VoronoiSite.ClockwiseCell` (on-demand) contains these edges sorted clockwise (starting from the bottom-right "corner" end point).
* `VoronoiSite.Neighbors` contains the site's neighbors (in the Delaunay Triangulation), that is, other sites across its edges.
* `VoronoiSite.Points` (on-demand) contains points of the cell, that is, edge end points / edge nodes.
* `VoronoiSite.ClockwisePoints` (on-demand) contains these points sorted clockwise (starting from the bottom-right "corner").

![voronoi terms - site](https://user-images.githubusercontent.com/3857299/213494492-18b23ddb-9ca2-41f7-a4ef-73dc28c54e17.png)
![voronoi terms - edge](https://user-images.githubusercontent.com/3857299/213494501-3a5510dd-072d-422b-bb28-18016857ac53.png)

If closing borders around the boundary is not desired (leaving sites with unclosed cells/polygons):

```
List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(
    sites, 
    0, 0, 
    600, 600,
    BorderEdgeGeneration.DoNotMakeBorderEdges
);
```

Full syntax (leaving a reusable `VoronoiPlane` instance):

```
VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

plane.SetSites(sites);

List<VoronoiEdge> edges = plane.Tessellate();
```

(Note that the algorithm will ignore duplicate sites, so check `VoronoiSite.Tesselated` for skipped sites if duplicates are possible in your data.)

Sites can be quickly randomly-generated (this will guarantee no duplicates):

```
VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

plane.GenerateRandomSites(1000, PointGenerationMethod.Uniform); // also supports .Gaussian

plane.Tessellate();
```

Lloyds relaxation algorithm can be applied to "smooth" cells:

```
VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

plane.SetSites(sites);

plane.Tessellate();

List<VoronoiEdge> edges = plane.Relax();
// List<VoronoiEdge> edges = plane.Relax(3, 0.7f); // relax 3 times with 70% strength each time 
```

# MonoGame example

A very simple MonoGame example is included in `MonoGameExample` project:

![SVL MG](https://github.com/user-attachments/assets/28dfb592-f6b1-4044-96a9-e32110c237a0)


# Dependencies

The main library is compiled for .NET (Core) 6.0 and .NET Standard 2.0 at C# 8.0 and targets compatible OSes - Windows, Linux & macOS - and frameworks like Xamarin, Mono, UWP, or Unity.

# Credits

- [Originally written by Logan Lembke as VoronoiLib](https://github.com/Zalgo2462/VoronoiLib)
- [Updated with unit tests and nuget package by Sean Esopenko](https://github.com/sesopenko/VoronoiLib)
- [Improvements by Jeffrey Jones](https://github.com/rurounijones/VoronoiLib)
- Various code pieces attributed inline

Original implementation inspired by:
- [Ivan Kuckir's project](http://blog.ivank.net/fortunes-algorithm-and-implementation.html)
- [Raymond Hill's project](https://github.com/gorhill/Javascript-Voronoi)
