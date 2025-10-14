namespace SharpVoronoiLib;

internal abstract class RandomPointGeneration : IPointGenerationAlgorithm
{
    public abstract void Prepare(double minX, double minY, double maxX, double maxY, int count);

    public List<VoronoiSite> Generate(double minX, double minY, double maxX, double maxY, int count)
    {
        Prepare(minX, minY, maxX, maxY, count);
        
        HashSet<VoronoiSite> sites = [ ];
        
        Random random = new Random();

        int failSafetyCounter = count * 3;
        
        for (int i = 0; i < count; i++)
        {
            VoronoiSite site = new VoronoiSite(
                GetNextRandomValue(random, minX, maxX, i, ValuePurpose.X),
                GetNextRandomValue(random, minY, maxY, i, ValuePurpose.Y)
            );

            if (site.X.ApproxLessThanOrEqualTo(minX) ||
                site.X.ApproxGreaterThanOrEqualTo(maxX) ||
                site.Y.ApproxLessThanOrEqualTo(minY) ||
                site.Y.ApproxGreaterThanOrEqualTo(maxY))
            {
                i--;
                failSafetyCounter--;
                if (failSafetyCounter == 0) throw new Exception("Too many invalid points generated");
                continue;
            }

            if (!sites.Add(site))
            {
                failSafetyCounter--;
                if (failSafetyCounter == 0) throw new Exception("Too many invalid points generated");
                i--;
            }
        }

        Conclude();
        
        return sites.ToList();
    }

    public abstract void Conclude();


    protected abstract double GetNextRandomValue(Random random, double min, double max, int index, ValuePurpose purpose);


    protected enum ValuePurpose
    {
        X,
        Y
    }
}