namespace SharpVoronoiLib;

internal static class ParabolaMath
{
    public static double EvalParabola(double focusX, double focusY, double directrix, double x)
    {
        double dx = x - focusX;
        return 0.5 * (dx * dx / (focusY - directrix) + focusY + directrix);
    }

    //gives the intersect point such that parabola 1 will be on top of parabola 2 slightly before the intersect
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IntersectParabolaX(double focus1X, double focus1Y, double focus2X, double focus2Y, double directrix)
    {
        //admittedly this is pure voodoo.
        //there is attached documentation for this function

        double fx = focus1X - focus2X;
        double fy = focus1Y - focus2Y;
        double df1 = directrix - focus1Y;
        double df2 = directrix - focus2Y;

        if (focus1Y.ApproxEqual(focus2Y))
            return (focus1X + focus2X) / 2;

        return (focus1X * df2 + focus2X * -df1 + Math.Sqrt(df1 * df2 * (fx * fx + fy * fy))) / fy;
    }
}