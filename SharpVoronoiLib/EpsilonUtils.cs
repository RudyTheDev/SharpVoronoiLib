namespace SharpVoronoiLib;

internal static class EpsilonUtils
{
    //private const double epsilon = double.Epsilon * 1E100;
    // The above is the original epsilon used for the algorithm.
    // This doesn't actually work since precision is lost after 15 digits for double.
    // Even with multiplier it's still like 4.94E-224, which is ridiculously beyond the loss of precision threshold.
    // For example, beach line edge intercept stuff would only capture precision to something like:
    // 999.99999999999989 vs 1000
    // In fact, anything less than e^-12 will immediately fail some coordinate comparisons because of all the compounding precision losses.
    // Of course, numbers too large will start failing again since we can't exactly compare significant digits (cheaply).

    internal const double epsilon = 1E-12;
    // todo: make ParabolaTest use this too

    internal const double quantizer = epsilon * 10; // for hashing, see Quantize()
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxEqual(this double value1, double value2)
    {
        return value1 - value2 < epsilon && 
               value2 - value1 < epsilon;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxGreaterThan(this double value1, double value2)
    {
        return value1 > value2 + epsilon;
    }
        
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxGreaterThanOrEqualTo(this double value1, double value2)
    {
        return value1 > value2 - epsilon;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxLessThan(this double value1, double value2)
    {
        return value1 < value2 - epsilon;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ApproxLessThanOrEqualTo(this double value1, double value2)
    {
        return value1 < value2 + epsilon;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ApproxCompareTo(this double value1, double value2)
    {
        if (ApproxGreaterThan(value1, value2))
            return 1;

        if (ApproxLessThan(value1, value2))
            return -1;

        return 0;
    }

    /// <summary>
    /// Rounds a floating point value to the nearest epsilon multiple.
    /// For use by hashing to avoid precision issues when elements report equality but cannot have different hash codes.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Quantize(double value)
    {
        return Math.Round(value / quantizer) * quantizer;
        
        // Note that we can't use epsilon directly since it will still clash.
        
        // Larger "epsilon" is fine though since with e^-12 epsilon, it's still e^-11,
        // so hash collisions are extremely unlikely for reasonable coordinates
    }
}