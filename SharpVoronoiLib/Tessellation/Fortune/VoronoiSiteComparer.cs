using System.Collections.Generic;

namespace SharpVoronoiLib;

internal class VoronoiSiteComparer : IEqualityComparer<VoronoiSite>
{
    public static VoronoiSiteComparer Instance { get; } = new VoronoiSiteComparer();
    private VoronoiSiteComparer() { }


    public bool Equals(VoronoiSite a, VoronoiSite b)
    {
        return a.X.ApproxEqual(b.X) && a.Y.ApproxEqual(b.Y);
    }

    public int GetHashCode(VoronoiSite obj)
    {
        unchecked
        {
            return (obj.X.GetHashCode() * 397) ^ obj.Y.GetHashCode();
        }
    }
}