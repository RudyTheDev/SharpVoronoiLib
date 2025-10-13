namespace SharpVoronoiLib;

public class VoronoiPointComparer : IEqualityComparer<VoronoiPoint>
{
    [PublicAPI]
    public static VoronoiPointComparer Instance { get; } = new VoronoiPointComparer();
    private VoronoiPointComparer() { }


    public bool Equals(VoronoiPoint? point1, VoronoiPoint? point2)
    {
        return point1!.X.ApproxEqual(point2!.X) && point1.Y.ApproxEqual(point2.Y);
    }

    public int GetHashCode(VoronoiPoint point)
    {
#if NET8_0_OR_GREATER
        return HashCode.Combine(point.X, point.Y);
#else
        unchecked
        {
            return (point.X.GetHashCode() * 397) ^ point.Y.GetHashCode();
        }
#endif
    }
}