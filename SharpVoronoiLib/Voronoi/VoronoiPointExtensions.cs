namespace SharpVoronoiLib;

internal static class VoronoiPointExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool ApproxEqual(this VoronoiPoint value1, VoronoiPoint value2)
    {
        return
            value1.X.ApproxEqual(value2.X) &&
            value1.Y.ApproxEqual(value2.Y);
    }
        
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool ApproxEqual(this VoronoiPoint value1, double x, double y)
    {
        return
            value1.X.ApproxEqual(x) &&
            value1.Y.ApproxEqual(y);
    }
}