using System.Collections.Generic;

namespace SharpVoronoiLib;

internal interface ISiteMergingAlgorithm
{
    void MergeSites(List<VoronoiSite> sites, List<VoronoiEdge> edges, VoronoiSiteMergeQuery mergeQuery);
}