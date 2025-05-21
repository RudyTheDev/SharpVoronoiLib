namespace KDTreeTests;

using System.Linq;

using Supercluster.KDTree;

public static class Utilities
{
    #region Metrics
    public static Func<float[], float[], double> L2Norm_Squared_Float = (x, y) =>
    {
        float dist = 0f;
        for (int i = 0; i < x.Length; i++)
        {
            dist += (x[i] - y[i]) * (x[i] - y[i]);
        }

        return dist;
    };

    public static Func<double[], double[], double> L2Norm_Squared_Double = (x, y) =>
    {
        double dist = 0f;
        for (int i = 0; i < x.Length; i++)
        {
            dist += (x[i] - y[i]) * (x[i] - y[i]);
        }

        return dist;
    };
    #endregion

    #region Data Generation

    public static double[][] GenerateDoubles(int points, double range, int dimensions)
    {
        List<double[]> data = new List<double[]>();
        Random random = new Random();

        for (int i = 0; i < points; i++)
        {
            double[] array = new double[dimensions];
            for (int j = 0; j < dimensions; j++)
            {
                array[j] = random.NextDouble() * range;
            }
            data.Add(array);
        }

        return data.ToArray();
    }

    public static double[][] GenerateDoubles(int points, double range)
    {
        List<double[]> data = new List<double[]>();
        Random random = new Random();

        for (int i = 0; i < points; i++)
        {
            data.Add(new double[] { (random.NextDouble() * range), (random.NextDouble() * range) });
        }

        return data.ToArray();
    }

    public static float[][] GenerateFloats(int points, double range)
    {
        List<float[]> data = new List<float[]>();
        Random random = new Random();

        for (int i = 0; i < points; i++)
        {
            data.Add(new float[] { (float)(random.NextDouble() * range), (float)(random.NextDouble() * range) });
        }

        return data.ToArray();
    }

    public static float[][] GenerateFloats(int points, double range, int dimensions)
    {
        List<float[]> data = new List<float[]>();
        Random random = new Random();

        for (int i = 0; i < points; i++)
        {
            float[] array = new float[dimensions];
            for (int j = 0; j < dimensions; j++)
            {
                array[j] = (float)(random.NextDouble() * range);
            }
            data.Add(array);
        }

        return data.ToArray();
    }
    #endregion


    #region Searches

    /// <summary>
    /// Performs a linear search on a given points set to find a nodes that is closest to the given nodes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="point"></param>
    /// <param name="metric"></param>
    /// <returns></returns>
    public static T[] LinearSearch<T>(T[][] data, T[] point, Func<T[], T[], float> metric)
    {
        double bestDist = Double.PositiveInfinity;
        T[] bestPoint = null;

        for (int i = 0; i < data.Length; i++)
        {
            float currentDist = metric(point, data[i]);
            if (bestDist > currentDist)
            {
                bestDist = currentDist;
                bestPoint = data[i];
            }
        }

        return bestPoint;
    }

    public static T[] LinearSearch<T>(T[][] data, T[] point, Func<T[], T[], double> metric)
    {
        double bestDist = Double.PositiveInfinity;
        T[] bestPoint = null;

        for (int i = 0; i < data.Length; i++)
        {
            double currentDist = metric(point, data[i]);
            if (bestDist > currentDist)
            {
                bestDist = currentDist;
                bestPoint = data[i];
            }
        }

        return bestPoint;
    }

    public static Tuple<TPoint[], TNode> LinearSearch<TPoint, TNode>(TPoint[][] points, TNode[] nodes, TPoint[] target, Func<TPoint[], TPoint[], double> metric)
    {
        int bestIndex = 0;
        double bestDist = Double.MaxValue;

        for (int i = 0; i < points.Length; i++)
        {
            double currentDist = metric(points[i], target);
            if (bestDist > currentDist)
            {
                bestDist = currentDist;
                bestIndex = i;
            }
        }

        return new Tuple<TPoint[], TNode>(points[bestIndex], nodes[bestIndex]);
    }


    public static T[][] LinearRadialSearch<T>(T[][] data, T[] point, Func<T[], T[], double> metric, double radius)
    {
        BoundedPriorityList<T[], double> pointsInRadius = new BoundedPriorityList<T[], double>(data.Length, true);

        for (int i = 0; i < data.Length; i++)
        {
            double currentDist = metric(point, data[i]);
            if (radius >= currentDist)
            {
                pointsInRadius.Add(data[i], currentDist);
            }
        }

        return pointsInRadius.ToArray();
    }


    public static Tuple<TPoint[], TNode>[] LinearRadialSearch<TPoint, TNode>(TPoint[][] points, TNode[] nodes, TPoint[] target, Func<TPoint[], TPoint[], double> metric, double radius)
    {
        BoundedPriorityList<int, double> pointsInRadius = new BoundedPriorityList<int, double>(points.Length, true);

        for (int i = 0; i < points.Length; i++)
        {
            double currentDist = metric(target, points[i]);
            if (radius >= currentDist)
            {
                pointsInRadius.Add(i, currentDist);
            }
        }

        return pointsInRadius.Select(idx => new Tuple<TPoint[], TNode>(points[idx], nodes[idx])).ToArray();
    }

    #endregion
}