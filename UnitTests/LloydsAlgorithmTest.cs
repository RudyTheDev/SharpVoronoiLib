namespace SharpVoronoiLib.UnitTests;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class LloydsAlgorithmTest
{
    [Test]
    public void TestRelax()
    {
        // Arrange
            
        List<VoronoiSite> originalSites =
        [
            new VoronoiSite(-100, 300),
            new VoronoiSite(300, -100),
            new VoronoiSite(800, 300),
            new VoronoiSite(300, 800)
        ];

        List<VoronoiSite> sites = new List<VoronoiSite>(originalSites); // copy so any changes to list don't affect the source list 

        VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

        plane.SetSites(sites);

        plane.Tessellate();
            
        // Act

        List<VoronoiEdge> edges = plane.Relax();

        // Assert

        Assert.That(edges, Is.Not.Null);
        Assert.That(edges, Is.Not.Empty);
        Assert.That(sites, Has.Count.EqualTo(originalSites.Count));
        // todo: check movement
    }

    [TestCase(1)]
    [TestCase(2)] // this will tessellate in-between
    public void TestRelaxingShouldNotUseDuplicateSites(int iterations)
    {
        // Arrange

        List<VoronoiSite> originalSites =
        [
            new VoronoiSite(200, 100),
            new VoronoiSite(100, 300),
            new VoronoiSite(300, 400),
            new VoronoiSite(400, 200),
            new VoronoiSite(200, 100), // duplicate
            new VoronoiSite(100, 300) // duplicate
        ];

        List<VoronoiSite> sites = new List<VoronoiSite>(originalSites); // copy so any changes to list don't affect the source list 

        VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

        plane.SetSites(sites);

        plane.Tessellate();
        
        Assert.That(originalSites[0].SkippedAsDuplicate, Is.False);
        Assert.That(originalSites[1].SkippedAsDuplicate, Is.False);
        Assert.That(originalSites[2].SkippedAsDuplicate, Is.False);
        Assert.That(originalSites[3].SkippedAsDuplicate, Is.False);
        Assert.That(originalSites[4].SkippedAsDuplicate, Is.True);
        Assert.That(originalSites[5].SkippedAsDuplicate, Is.True);

        // Act

        plane.Relax(iterations);

        // Assert

        Assert.That(originalSites[4].SkippedAsDuplicate, Is.True);
        Assert.That(originalSites[5].SkippedAsDuplicate, Is.True);
    }
}