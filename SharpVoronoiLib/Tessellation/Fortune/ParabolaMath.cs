namespace SharpVoronoiLib;

internal static class ParabolaMath
{
    public static double EvalParabola(double focusX, double focusY, double directrix, double x)
    {
        return .5*( (x - focusX) * (x - focusX) /(focusY - directrix) + focusY + directrix);
    }

    //gives the intersect point such that parabola 1 will be on top of parabola 2 slightly before the intersect
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IntersectParabolaX(double focus1X, double focus1Y, double focus2X, double focus2Y,
                                            double directrix)
    {
        //admittedly this is pure voodoo.
        //there is attached documentation for this function
        return focus1Y.ApproxEqual(focus2Y)
            ? (focus1X + focus2X)/2
            : (focus1X*(directrix - focus2Y) + focus2X*(focus1Y - directrix) +
               Math.Sqrt((directrix - focus1Y)*(directrix - focus2Y)*
                         ((focus1X - focus2X)*(focus1X - focus2X) +
                          (focus1Y - focus2Y)*(focus1Y - focus2Y))
               )
            )/(focus1Y - focus2Y);
    }
}