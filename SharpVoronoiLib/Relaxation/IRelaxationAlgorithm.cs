using System.Collections.Generic;

namespace SharpVoronoiLib;

internal interface IRelaxationAlgorithm
{
    void Relax(List<VoronoiSite> sites, double minX, double minY, double maxX, double maxY, float strength);
}