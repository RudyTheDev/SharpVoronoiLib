namespace KDTreeTests;

public static class Utilities
{
    #region Data Generation

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
    
    #endregion
}