namespace SharpVoronoiLib;

public class VoronoiEdgeComparer : IEqualityComparer<VoronoiEdge>
{
    [PublicAPI]
    public static VoronoiEdgeComparer Instance { get; } = new VoronoiEdgeComparer();
    private VoronoiEdgeComparer() { }


    public bool Equals(VoronoiEdge? edge1, VoronoiEdge? edge2)
    {
        return 
            edge1!.Start.X.ApproxEqual(edge2!.Start.X) && 
            edge1.Start.Y.ApproxEqual(edge2.Start.Y) &&
            edge1.End.X.ApproxEqual(edge2.End.X) && 
            edge1.End.Y.ApproxEqual(edge2.End.Y);
        // This is directional, but we also shouldn't be expecting duplicate edges like that
    }

    public int GetHashCode(VoronoiEdge edge)
    {
#if NET8_0_OR_GREATER
        return HashCode.Combine(edge.Start.X, edge.Start.Y, edge.End.X, edge.End.Y);
#else
        unchecked
        {
            int hash = 17;
            hash = hash * 31 + edge.Start.X.GetHashCode();
            hash = hash * 31 + edge.Start.Y.GetHashCode();
            hash = hash * 31 + edge.End.X.GetHashCode();
            hash = hash * 31 + edge.End.Y.GetHashCode();
            return hash;
        }
#endif
    }
}