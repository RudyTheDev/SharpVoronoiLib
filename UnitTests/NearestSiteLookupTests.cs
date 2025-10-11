namespace SharpVoronoiLib.UnitTests;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class NearestSiteLookupTests
{
    [TestCase(NearestSiteLookupMethod.BruteForce)]
    [TestCase(NearestSiteLookupMethod.KDTree)]
    public void Test_NearestSite_IgnoresDuplicates_BruteForce(NearestSiteLookupMethod method)
    {
        // Arrange

        VoronoiPlane plane = new VoronoiPlane(0, 0, 10, 10);
        List<VoronoiSite> sites =
        [
            new VoronoiSite(5, 5),
            new VoronoiSite(5, 5), // duplicate
            new VoronoiSite(5, 5) // duplicate
        ];
        plane.SetSites(sites);
        plane.Tessellate();

        // Act

        VoronoiSite nearest = plane.GetNearestSiteTo(4, 6, method);

        // Assert

        Assert.That(nearest, Is.Not.Null);
        Assert.That(nearest.SkippedAsDuplicate, Is.False);
    }
}

