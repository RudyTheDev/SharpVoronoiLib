#nullable disable // This code hasn't been converted to nullable yet

namespace SharpVoronoiLib;

/// <summary>
/// Represents a single arc (parabolic segment) on the beach line associated with a <see cref="VoronoiSite"/>.
/// </summary>
internal class BeachSection
{
    /// <summary>
    /// The site (focus) that defines this arc.
    /// </summary>
    internal VoronoiSite Site { get;}

    /// <summary>
    /// The Voronoi edge currently associated with this arc (may be updated as events occur).
    /// </summary>
    internal VoronoiEdge Edge { get; set; }

    // NOTE: this will change
    internal FortuneCircleEvent CircleEvent { get; set; }

    
    internal BeachSection(VoronoiSite site)
    {
        Site = site;
        CircleEvent = null;
    }
}