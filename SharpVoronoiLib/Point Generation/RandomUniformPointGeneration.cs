namespace SharpVoronoiLib;

internal class RandomUniformPointGeneration : RandomPointGeneration
{
    public override void Prepare(Random random, double minX, double minY, double maxX, double maxY, int count)
    {
        // Don't need to do anything
    }

    protected override double GetNextRandomValue(Random random, double min, double max, int index, ValuePurpose valuePurpose)
    {
        do
        {
            double value = min + random.NextDouble() * (max - min);
                
            if (value > min && value < max)
                return value;
                
        } while (true);
    }

    public override void Conclude()
    {
        // Don't need to do anything
    }
}