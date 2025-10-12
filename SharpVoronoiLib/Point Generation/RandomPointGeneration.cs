namespace SharpVoronoiLib;

internal abstract class RandomPointGeneration : IPointGenerationAlgorithm
{
    public List<VoronoiSite> Generate(double minX, double minY, double maxX, double maxY, int count)
    {
        HashSet<VoronoiSite> sites = new HashSet<VoronoiSite>(VoronoiSiteComparer.Instance);

        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            VoronoiSite site = new VoronoiSite(
                GetNextRandomValue(random, minX, maxX),
                GetNextRandomValue(random, minY, maxY)
            );

            // // To test if duplicates get retried
            // if (sites.Count > 0)
            // {
            //     if (random.Next(10) == 0)
            //     {
            //         VoronoiSite other = sites.ToList()[random.Next(sites.Count)];
            //         site = new VoronoiSite(other.X, other.Y);
            //     }
            // }

            if (!sites.Add(site))
                i--;
        }

        return sites.ToList();
    }

        
    protected abstract double GetNextRandomValue(Random random, double min, double max);
}