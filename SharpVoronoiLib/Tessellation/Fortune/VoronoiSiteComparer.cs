namespace SharpVoronoiLib;

public class VoronoiSiteComparer : IEqualityComparer<VoronoiSite>
{
    [PublicAPI]
    public static VoronoiSiteComparer Instance { get; } = new VoronoiSiteComparer();
    private VoronoiSiteComparer() { }


    public bool Equals(VoronoiSite? site1, VoronoiSite? site2)
    {
        return site1!.X.ApproxEqual(site2!.X) && site1.Y.ApproxEqual(site2.Y);
    }

    public int GetHashCode(VoronoiSite site) => site.GetHashCode();
}