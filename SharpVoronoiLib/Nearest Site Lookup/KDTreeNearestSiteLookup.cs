using Supercluster.KDTree;

namespace SharpVoronoiLib;

public class KDTreeNearestSiteLookup : INearestSiteLookup
{
    private int _lastVersion = -1;
    
    private KDTree<VoronoiSite> _kdTree = null!;
    
    
    public VoronoiSite GetNearestSiteTo(List<VoronoiSite> sites, double x, double y, int version, int duplicateCount)
    {
        if (_lastVersion != version)
        {
            int capacity = sites.Count - duplicateCount;

            double[][] points = new double[capacity][];
            VoronoiSite[] nodes = new VoronoiSite[capacity];

            int index = 0;
            foreach (VoronoiSite site in sites)
            {
                if (site.SkippedAsDuplicate)
                    continue;

                points[index] = [ site.X, site.Y ];
                nodes[index] = site;
                index++;
            }

            _kdTree = new KDTree<VoronoiSite>(points, nodes);
            _lastVersion = version;
        }

        Tuple<double[], VoronoiSite>[] nearest = _kdTree.NearestNeighbors([ x, y ], 1);

        return nearest[0].Item2;
    }
}