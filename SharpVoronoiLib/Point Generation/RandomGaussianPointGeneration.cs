namespace SharpVoronoiLib;

internal class RandomGaussianPointGeneration : RandomPointGeneration
{
    protected override void Prepare(IRandomNumberGenerator random, double minX, double minY, double maxX, double maxY, int count)
    {
        // Don't need to do anything
    }

    protected override double GetNextRandomValue(IRandomNumberGenerator random, double min, double max, int index, ValuePurpose valuePurpose)
    {
        // Box-Muller transform
        // From: https://stackoverflow.com/a/218600

        const double stdDev = 1.0 / 3.0; // this covers 99.73% of cases in (-1..1) range

        double mid = (max + min) / 2;

        int safetyCounter = 0;
        
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

            safetyCounter++;
            
            if (safetyCounter > 100) throw new VoronoiRandomPointGenerationEncounteredTooManyInvalidSites();

        } while (true);
    }

    protected override void Conclude()
    {
        // Don't need to do anything
    }
}