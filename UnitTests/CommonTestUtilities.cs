namespace SharpVoronoiLib.UnitTests;

internal static class CommonTestUtilities
{
    internal static VoronoiPoint FindPoint(IEnumerable<VoronoiEdge> edges, double x, double y)
    {
        VoronoiEdge? edge = edges.FirstOrDefault(e => e.Start != null && e.Start.X.ApproxEqual(x) && e.Start.Y.ApproxEqual(y));
        if (edge != null)
            return edge.Start;

        return edges.First(e => e.End != null && e.End.X.ApproxEqual(x) && e.End.Y.ApproxEqual(y))
                    .End;
    }

    internal static bool HasPoint(IEnumerable<VoronoiPoint> points, double x, double y)
    {
        return points.Any(p => p.X.ApproxEqual(x) && p.Y.ApproxEqual(y));
    }

    internal static bool PointIs(VoronoiPoint point, double x, double y)
    {
        return point.X.ApproxEqual(x) && point.Y.ApproxEqual(y);
    }

    internal static bool PointsAreSequential(IEnumerable<VoronoiPoint> points, double x1, double y1, double x2, double y2)
    {
        List<VoronoiPoint> asList = points.ToList();
            
        int i1 = asList.FindIndex(p => p.X.ApproxEqual(x1) && p.Y.ApproxEqual(y1));
        int i2 = asList.FindIndex(p => p.X.ApproxEqual(x2) && p.Y.ApproxEqual(y2));
            
        return 
            i2 == i1 + 1 || 
            (i2 == 0 && i1 == asList.Count - 1);
    }

    internal static VoronoiEdge FindEdge(IEnumerable<VoronoiEdge> edges, double x1, double y1, double x2, double y2)
    {
        return edges.First(
            e =>
                e.Start != null! && e.End != null! &&
                (e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                 e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1))
        );
    }

    internal static bool EdgeIs(VoronoiEdge edge, double x1, double y1, double x2, double y2)
    {
        return
            edge.Start != null! && 
            edge.End != null! &&
            (edge.Start.X.ApproxEqual(x1) && edge.Start.Y.ApproxEqual(y1) && edge.End.X.ApproxEqual(x2) && edge.End.Y.ApproxEqual(y2) ||
             edge.Start.X.ApproxEqual(x2) && edge.Start.Y.ApproxEqual(y2) && edge.End.X.ApproxEqual(x1) && edge.End.Y.ApproxEqual(y1));
    }

    internal static bool HasEdge(IEnumerable<VoronoiEdge> edges, double x1, double y1, double x2, double y2)
    {
        return edges.Any(e =>
                             e.Start != null! &&
                             e.End != null! &&
                             (e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                              e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1))
        );
    }

    internal static bool EdgesAreSequential(IEnumerable<VoronoiEdge> edges, double e1x1, double e1y1, double e1x2, double e1y2, double e2x1, double e2y1, double e2x2, double e2y2)
    {
        List<VoronoiEdge> asList = edges.ToList();

        int i1 = FindEdgeIndex(asList, e1x1, e1y1, e1x2, e1y2);
        int i2 = FindEdgeIndex(asList, e2x1, e2y1, e2x2, e2y2);
            
        return 
            i2 == i1 + 1 || 
            (i2 == 0 && i1 == asList.Count - 1);

            
        static int FindEdgeIndex(List<VoronoiEdge> edges, double x1, double y1, double x2, double y2)
        {
            return edges.FindIndex(
                e =>
                    e.Start != null! && e.End != null! &&
                    (e.Start.X.ApproxEqual(x1) && e.Start.Y.ApproxEqual(y1) && e.End.X.ApproxEqual(x2) && e.End.Y.ApproxEqual(y2) ||
                     e.Start.X.ApproxEqual(x2) && e.Start.Y.ApproxEqual(y2) && e.End.X.ApproxEqual(x1) && e.End.Y.ApproxEqual(y1))
            );
        }
    }

    internal static bool EdgeHasSite(VoronoiEdge edge, double x, double y)
    {
        return
            (edge.Left != null &&
             edge.Left.X.ApproxEqual(x) &&
             edge.Left.Y.ApproxEqual(y))
            ||
            (edge.Right != null &&
             edge.Right.X.ApproxEqual(x) &&
             edge.Right.Y.ApproxEqual(y));
    }
}