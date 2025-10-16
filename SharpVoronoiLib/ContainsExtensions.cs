namespace SharpVoronoiLib;

/// <summary>
/// Helper methods to do .Contains, but directly check references for quicker comparison
/// when we internally never expect to be matching objects by values.
/// </summary>
internal static class ContainsExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool ContainsAsReference(this List<VoronoiSite> sites, VoronoiSite site)
    {
        foreach (VoronoiSite s in sites)
            if (ReferenceEquals(s, site))
                return true;

        return false;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool ContainsAsReference(this List<VoronoiPoint> points, VoronoiPoint point)
    {
        foreach (VoronoiPoint p in points)
            if (ReferenceEquals(p, point))
                return true;

        return false;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool ContainsAsReference(this List<VoronoiEdge> edges, VoronoiEdge edge)
    {
        foreach (VoronoiEdge e in edges)
            if (ReferenceEquals(e, edge))
                return true;

        return false;
    }
}