namespace SharpVoronoiLib.UnitTests;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BugReproTests
{
    /// <summary>
    /// Issue #2
    /// </summary>
    [Test]
    public void IncorrectNeighours()
    {
        // Arrange

        VoronoiSite site0 = new VoronoiSite(309.2762, 29.37344);
        VoronoiSite site1 = new VoronoiSite(498.7968, 410.0901);
        VoronoiSite site2 = new VoronoiSite(328.3032, 284.3138);
        VoronoiSite site3 = new VoronoiSite(25.5397, 184.688);
        VoronoiSite site4 = new VoronoiSite(373.5264, 73.77794);

        List<VoronoiSite> sites = new List<VoronoiSite>
        {
            site0,
            site1,
            site2,
            site3,
            site4
        };

        // Act

        VoronoiPlane.TessellateOnce(
            sites,
            0, 0, 500, 500
        );

        // Assert

        Assert.That(site0.Neighbours, Is.EquivalentTo(new[] { site2, site3, site4 }));
        Assert.That(site1.Neighbours, Is.EquivalentTo(new[] { site2 }));
        Assert.That(site2.Neighbours, Is.EquivalentTo(new[] { site0, site1, site3, site4 }));
        Assert.That(site3.Neighbours, Is.EquivalentTo(new[] { site0, site2 }));
        Assert.That(site4.Neighbours, Is.EquivalentTo(new[] { site0, site2 }));
    }

    /// <summary>
    /// Issue #7
    /// </summary>
    [Test]
    public void DuplicatePoints()
    {
        List<VoronoiSite> sites = new List<VoronoiSite>
        {
            new VoronoiSite(200, 100),
            new VoronoiSite(100, 300),
            new VoronoiSite(300, 400),
            new VoronoiSite(400, 200),
            new VoronoiSite(300, 100),
            new VoronoiSite(100, 200),
                
            // Duplicate
            new VoronoiSite(300, 400),
            new VoronoiSite(400, 200),
            new VoronoiSite(100, 300),
                
            // Triplicate
            new VoronoiSite(300, 400),

            new VoronoiSite(250, 350),
            new VoronoiSite(150, 150),
            new VoronoiSite(350, 250),
            new VoronoiSite(250, 150)
        };

        VoronoiPlane plane = new VoronoiPlane(0, 0, 1200, 1200);
            
        plane.SetSites(sites);
            
        plane.Tessellate();

        plane.Relax();
    }
}