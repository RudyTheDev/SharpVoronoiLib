namespace SharpVoronoiLib
{
    internal static class EpsilonUtils
    {
        //private const double epsilon = double.Epsilon * 1E100;
        // The above is the original epsilon used for the algorithm.
        // This doesn't actually work since precision is lost after 15 digits for double.
        // Even with multiplier it's still like 4.94E-224, which is ridiculously beyond the loss of precision threshold.
        // For example, beach line edge intercept stuff would only capture precision to something like:
        // 999.99999999999989 vs 1000
        // In fact, anything less than e^-12 will immediatelly fail some coordinate comparisons because of all the compounding precision losses.
        // Of course, numbers too large will start failing again since we can't exactly compare significant digits (cheaply).

        private const double epsilon = 1E-12;
        // todo: make ParabolaTest use this too


        public static bool ApproxEqual(this double value1, double value2)
        {
            return value1 - value2 < epsilon && 
                   value2 - value1 < epsilon;
        }

        public static bool ApproxGreaterThan(this double value1, double value2)
        {
            return value1 > value2 + epsilon;
        }
        
        public static bool ApproxGreaterThanOrEqualTo(this double value1, double value2)
        {
            return value1 > value2 - epsilon;
        }

        public static bool ApproxLessThan(this double value1, double value2)
        {
            return value1 < value2 - epsilon;
        }

        public static bool ApproxLessThanOrEqualTo(this double value1, double value2)
        {
            return value1 < value2 + epsilon;
        }

        public static int ApproxCompareTo(this double value1, double value2)
        {
            if (ApproxGreaterThan(value1, value2))
                return 1;

            if (ApproxLessThan(value1, value2))
                return -1;

            return 0;
        }
    }
}