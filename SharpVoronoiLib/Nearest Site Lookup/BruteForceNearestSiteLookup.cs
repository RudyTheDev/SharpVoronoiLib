using System;
using System.Collections.Generic;

namespace SharpVoronoiLib
{
    public class BruteForceNearestSiteLookup : INearestSiteLookup
    {
        public VoronoiSite GetNearestSiteTo(List<VoronoiSite> sites, double x, double y)
        {
            VoronoiSite closestSite = sites[0];
            double closestDistanceSqr = double.MaxValue;

            foreach (VoronoiSite site in sites)
            {
                double distance = (site.X - x) * (site.X - x) + (site.Y - y) * (site.Y - y);

                if (distance < closestDistanceSqr)
                {
                    closestDistanceSqr = distance;
                    closestSite = site;
                }
            }

            return closestSite;
        }
    }
}