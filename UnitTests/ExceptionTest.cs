using System.Collections.Generic;
using NUnit.Framework;
using SharpVoronoiLib.Exceptions;

namespace SharpVoronoiLib.UnitTests;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class ExceptionTest
{
    [Test]
    public void TessellateBeforeSites()
    {
        // Arrange
            
        VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);
            
        // Act - Assert

        Assert.Throws<VoronoiDoesntHaveSitesException>(() => plane.Tessellate());
    }
        
    [Test]
    public void AccessPlaneEdgesBeforeTesselate()
    {
        // Arrange

        VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

        plane.SetSites(new List<VoronoiSite>());
            
        // Act - Assert

        Assert.Throws<VoronoiNotTessellatedException>(() => _ = plane.Edges);
    }
        
    [Test]
    public void AccessSiteDataBeforeTesselate()
    {
        // Arrange

        VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

        List<VoronoiSite> sites = new List<VoronoiSite>() { new VoronoiSite(100, 100) };
            
        plane.SetSites(sites);
            
        // Act - Assert

        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Cell);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].ClockwiseCell);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Neighbours);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Points);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].ClockwisePoints);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].LiesOnEdge);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].LiesOnCorner);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Centroid);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Contains(100, 100));
    }
}