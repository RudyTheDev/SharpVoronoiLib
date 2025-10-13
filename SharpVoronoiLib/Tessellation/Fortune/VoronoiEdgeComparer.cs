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

    public int GetHashCode(VoronoiEdge edge) => edge.GetHashCode();
}