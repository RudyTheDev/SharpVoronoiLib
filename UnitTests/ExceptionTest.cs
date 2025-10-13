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

        plane.SetSites([ ]);
            
        // Act - Assert

        Assert.Throws<VoronoiNotTessellatedException>(() => _ = plane.Edges);
    }
        
    [Test]
    public void AccessSiteDataBeforeTesselate()
    {
        // Arrange

        VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

        List<VoronoiSite> sites = [ new VoronoiSite(100, 100) ];
            
        plane.SetSites(sites);
            
        // Act - Assert

        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Edges);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].ClockwiseEdges);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Neighbours);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Points);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].ClockwisePoints);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].LiesOnEdge);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].LiesOnCorner);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Centroid);
        Assert.Throws<VoronoiNotTessellatedException>(() => _ = sites[0].Contains(100, 100));
    }
    
    [Test]
    public void DuplicateSiteAccess()
    {
        // Arrange

        VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);
        List<VoronoiSite> sites =
        [
            new VoronoiSite(100, 100),
            new VoronoiSite(100, 100)
        ];
        plane.SetSites(sites);

        // Act

        plane.Tessellate();

        // Assert

        Assert.That(sites[0].Tesselated, Is.True);
        Assert.That(sites[0].SkippedAsDuplicate, Is.False);

        Assert.That(sites[1].Tesselated, Is.False);
        Assert.That(sites[1].SkippedAsDuplicate, Is.True);

        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].Edges);
        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].ClockwiseEdges);
        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].Neighbours);
        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].Points);
        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].ClockwisePoints);
        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].LiesOnEdge);
        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].LiesOnCorner);
        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].Centroid);
        Assert.Throws<VoronoiSiteSkippedAsDuplicateException>(() => _ = sites[1].Contains(100, 100));
    }
}