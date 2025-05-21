using System.Collections.Generic;

namespace SharpVoronoiLib;

internal interface ITessellationAlgorithm
{
    List<VoronoiEdge> Run(List<VoronoiSite> sites, double minX, double minY, double maxX, double maxY);
}