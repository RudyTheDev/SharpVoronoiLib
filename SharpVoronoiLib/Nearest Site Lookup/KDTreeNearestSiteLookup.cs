using System;
using System.Collections.Generic;
using Supercluster.KDTree;

namespace SharpVoronoiLib;

public class KDTreeNearestSiteLookup : INearestSiteLookup
{
    private int _lastVersion = -1;
    
    private KDTree<VoronoiSite> _kdTree = null!;
    
    
    public VoronoiSite GetNearestSiteTo(List<VoronoiSite> sites, double x, double y, int version)
    {
        if (version != _lastVersion)
            _kdTree = new KDTree<VoronoiSite>(PointsFromSites(sites), sites.ToArray());
        
        _lastVersion = version;
        
        Tuple<double[], VoronoiSite>[] nearest = _kdTree.NearestNeighbors([ x, y ], 1);

        return nearest[0].Item2;
    }

    
    private static double[][] PointsFromSites(List<VoronoiSite> sites)
    {
        double[][] points = new double[sites.Count][];

        for (int i = 0; i < sites.Count; i++)
            points[i] = [ sites[i].X, sites[i].Y ];

        return points;
    }
}