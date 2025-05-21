using System;

namespace SharpVoronoiLib;

internal class RandomGaussianPointGeneration : RandomPointGeneration
{
    protected override double GetNextRandomValue(Random random, double min, double max)
    {
        // Box-Muller transform
        // From: https://stackoverflow.com/a/218600

        const double stdDev = 1.0 / 3.0; // this covers 99.73% of cases in (-1..1) range

        double mid = (max + min) / 2;

        do
        {
            double u1 = 1.0 - random.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - random.NextDouble();

            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                   Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)

            double value = stdDev * randStdNormal;

            double coord = mid + value * mid;

            if (coord > min && coord < max)
                return coord;

        } while (true);
    }
}