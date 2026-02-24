![build_and_test](https://github.com/RudyTheDev/SharpVoronoiLib/actions/workflows/test.yml/badge.svg)

# SharpVoronoiLib

C# implementation of generating a Voronoi diagram from a set of points in a plane (using Fortune's Algorithm) with edge clipping and border closure. This implementation guarantees O(n×ln(n)) performance.

![voronoi example](https://user-images.githubusercontent.com/3857299/213494520-4295378c-9759-4864-aeb7-4cd032b0f3d0.png)

# Installation

The library is available as `SharpVoronoiLib` [NuGet package](https://www.nuget.org/packages/SharpVoronoiLib): `dotnet add package SharpVoronoiLib` via CLI or via your preferred NuGet package manager.

Alternatively, you can download the solution and either copy the `SharpVoronoiLib` project code or build the project and use the `SharpVoronoiLib.dll`.

# Usage

### Quick-start

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

(Note that the algorithm will ignore duplicate sites, so check `VoronoiSite.Tesselated` for skipped sites if duplicates are possible in your data.)

### Full syntax

Full syntax (leaving a reusable `VoronoiPlane` instance):

```
VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

plane.SetSites(sites);

List<VoronoiEdge> edges = plane.Tessellate();
```

### Result structure

The tesselation result for the given `VoronoiSite`s contains `VoronoiEdge`s and `VoronoiPoint`s. The returned collection contains the generated edges.

![voronoi terms](https://user-images.githubusercontent.com/3857299/213494489-4a6030a2-64d8-4e7e-b556-6f5674d89911.png)

* `VoronoiEdge.Start` and `.End` are the start and end points of the edge.
* `VoronoiEdge.Right` and `.Left` are the sites the edge encloses. Border edges move clockwise and will only have the `.Right` site. And if no points are within the region, both will be `null`.
* Edge end `VoronoiPoint`s also contain a `.BorderLocation` specifying if it's on a border and which one.
* `VoronoiEdge.Neighbours` (on-demand) are edges directly "connecting" to this edge, basically creating a traversable edge graph.
* `VoronoiEdge.Length` (on-demand) is the distance between its end points.
* `VoronoiSite.Edges` (aka cell) contains the edges that enclose the site (the order is not guaranteed).
* `VoronoiSite.ClockwiseEdges` (on-demand) contains these edges sorted clockwise (starting from the bottom-right "corner" end point).
* `VoronoiSite.ClockwiseEdgesWound` (on-demand) contains these edges also "wound" in the clockwise order so their start/end points form a loop.
* `VoronoiSite.Neighbours` contains the site's neighbours (in the Delaunay Triangulation), that is, other sites across its edges.
* `VoronoiSite.Points` (on-demand) contains points/vertices of the site's cell, that is, edge end points / edge nodes.
* `VoronoiSite.ClockwisePoints` (on-demand) contains these points sorted clockwise (starting from the bottom-right "corner").
* `VoronoiPoint.Edges` are edges emerging from this point.
* `VoronoiPoint.Sites` (on-demand) are sites touching this point.

![voronoi terms - site](https://user-images.githubusercontent.com/3857299/213494492-18b23ddb-9ca2-41f7-a4ef-73dc28c54e17.png)
![voronoi terms - edge](https://user-images.githubusercontent.com/3857299/213494501-3a5510dd-072d-422b-bb28-18016857ac53.png)

### Border closing

If closing borders around the boundary is not desired (leaving sites with unclosed edges/polygons):

```
List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(
    sites, 
    0, 0, 
    600, 600,
    BorderEdgeGeneration.DoNotMakeBorderEdges
);
```

Closed versus unclosed:

<img width="484" height="343" alt="closed borders" src="https://github.com/user-attachments/assets/b9d59c77-18f8-4478-9809-9646d59af5be" />
<img width="484" height="343" alt="unclosed borders" src="https://github.com/user-attachments/assets/c2e28f2a-4cf4-4132-bc0f-b5003ddcb27d" />

### Site generation

Sites can be quickly randomly-generated (this will guarantee no duplicates and no sites on edges):

```
VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

plane.GenerateRandomSites(1000, PointGenerationMethod.Uniform); // also supports .Gaussian or custom implementations

plane.Tessellate();
```

Uniform and Gaussian:

<img width="475" height="328" alt="random uniform" src="https://github.com/user-attachments/assets/cae69f77-c5cb-4005-ae40-e68f8bcfa868" />
<img width="475" height="328" alt="random gaussian" src="https://github.com/user-attachments/assets/b1a1fea1-d804-4ea5-afd1-adb719894e1a" />

A custom random number generator may also be provided.

### Site relaxation

Lloyds relaxation algorithm can be applied to "smooth" cells by spacing them out over several tessalation passes:

```
VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

plane.SetSites(sites);

plane.Tessellate();

List<VoronoiEdge> edges = plane.Relax();
// List<VoronoiEdge> edges = plane.Relax(3, 0.7f); // relax 3 times with 70% strength each time 
```

<img width="475" height="328" alt="no relaxing" src="https://github.com/user-attachments/assets/5294cbb2-2a07-4d3a-98c2-0bfe399013a9" /> → <img width="475" height="328" alt="twice relaxing" src="https://github.com/user-attachments/assets/2ba08672-1c28-4217-b745-2cddf7fc700d" />

### Delaunay triangulation

A Voronoi diagram has a corresponding Delaunay triangulation, i.e. site neighbour links:

<img width="475" height="328" alt="site neighbours subtle" src="https://github.com/user-attachments/assets/d4e81817-8650-4761-bacd-63ac83652365" />
<img width="475" height="328" alt="site neighbours distinct" src="https://github.com/user-attachments/assets/c6793e3b-2102-43a3-88b4-0e8e9921ca3e" />

While these normally form triangles, be aware that four or more points in a circle will make this mathematically ambiguous; sites will have neighbours across a vertex crossing other neighbour links. This is extremely rare with random points, but must be checked if using the results for something like a triangle mesh. The library does not currently provide a direct way to gather a list of these triangles.

# MonoGame example

A simple interactive [MonoGame](https://github.com/MonoGame/MonoGame) example is included in `MonoGameExample` project:

<img width="994" height="498" alt="monogame demo enhanced" src="https://github.com/user-attachments/assets/40be8056-a54f-44c9-85f9-3b1c5f00a03d" />

# Dependencies

The main library targets .NET 10.0, 9.0 and .NET Standard 2.0, 2.1 and targets compatible OSes - Windows, Linux & macOS - and .NET and Mono frameworks - Xamarin, Mono, UWP, Unity, etc.

# Original library

The key differences from the [original VoronoiLib repo](https://github.com/Zalgo2462/VoronoiLib):
* Borders can be closed, that is, edges generated along the boundary
* Edges and points/sites contain additional useful data
* Multiple critical and annoyingly-rare bugs and edge cases fixes
* LOTS more unit testing!

# Credits

- [Originally written by Logan Lembke as VoronoiLib](https://github.com/Zalgo2462/VoronoiLib)
- [Updated with unit tests and nuget package by Sean Esopenko](https://github.com/sesopenko/VoronoiLib)
- [Improvements by Jeffrey Jones](https://github.com/rurounijones/VoronoiLib)
- Various code pieces attributed inline, notably:
  - [KD tree algorithm by ericreg](https://github.com/ericreg/Supercluster.KDTree), originally [by codeandcats](https://github.com/codeandcats/KdTree)

Original implementation inspired by:
- [Ivan Kuckir's project](http://blog.ivank.net/fortunes-algorithm-and-implementation.html)
- [Raymond Hill's project](https://github.com/gorhill/Javascript-Voronoi)
