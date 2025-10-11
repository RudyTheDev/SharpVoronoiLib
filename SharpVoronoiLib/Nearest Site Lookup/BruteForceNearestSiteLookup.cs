using System;
using System.Collections.Generic;

namespace SharpVoronoiLib;

public class BruteForceNearestSiteLookup : INearestSiteLookup
{
    public VoronoiSite GetNearestSiteTo(List<VoronoiSite> sites, double x, double y, int version, int duplicateCount)
    {
        VoronoiSite closestSite = null!;
        double closestDistanceSqr = double.MaxValue;

        foreach (VoronoiSite site in sites)
        {
            if (site.SkippedAsDuplicate)
                continue;

            double distance = (site.X - x) * (site.X - x) + (site.Y - y) * (site.Y - y);

            if (distance < closestDistanceSqr)
            {
                closestDistanceSqr = distance;
                closestSite = site;
            }
        }

        if (closestSite == null)
            throw new Exception(); // cannot really get here

        return closestSite;
    }
}