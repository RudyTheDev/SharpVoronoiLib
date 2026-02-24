namespace SharpVoronoiLib;

internal class RandomUniformPointGeneration : RandomPointGeneration
{
    protected override void Prepare(IRandomNumberGenerator random, double minX, double minY, double maxX, double maxY, int count)
    {
        // Don't need to do anything
    }

    protected override double GetNextRandomValue(IRandomNumberGenerator random, double min, double max, int index, ValuePurpose valuePurpose)
    {
        int safetyCounter = 0;
        
        do
        {
            double value = min + random.NextDouble() * (max - min);
                
            if (value > min && value < max)
                return value;

            safetyCounter++;
            
            if (safetyCounter > 100) throw new VoronoiRandomPointGenerationEncounteredTooManyInvalidSites();
                
        } while (true);
    }

    protected override void Conclude()
    {
        // Don't need to do anything
    }
}