using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SharpVoronoiLib.UnitTests;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class ClosestSitesTests
{
    [Test]
    [Repeat(100, true)]
    public void Test([Values(
                         NearestSiteLookupMethod.BruteForce,
                         NearestSiteLookupMethod.KDTree
                     )] NearestSiteLookupMethod lookupMethod)
    {
        // Arrange

        const int size = 600;

        VoronoiPlane plane = new VoronoiPlane(0, 0, size, size);

        List<VoronoiSite> sites = plane.GenerateRandomSites(500);

        plane.Tessellate();

        // Act - Assert

        for (int i = 0; i < 500; i++)
        {
            double x = Random.Shared.NextDouble() * size * 1.2 - size * 0.1;
            double y = Random.Shared.NextDouble() * size * 1.2 - size * 0.1;

            VoronoiSite site = plane.GetNearestSiteTo(x, y, lookupMethod);

            VoronoiSite actual = GetClosestSite(sites, x, y);

            Assert.That(site, Is.Not.Null);
            Assert.That(site, Is.SameAs(actual));
        }
    }


    private static VoronoiSite GetClosestSite(List<VoronoiSite> sites, double x, double y)
    {
        VoronoiSite closest = null!;
        double closestDistance = double.MaxValue;

        foreach (VoronoiSite site in sites)
        {
            double distance = Math.Sqrt((site.X - x) * (site.X - x) + (site.Y - y) * (site.Y - y));

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closest = site;
            }
        }

        return closest;
    }
}