namespace SharpVoronoiLib;

/// <summary>
/// A <see cref="VoronoiEdge"/> with a strictly defined direction,
/// i.e. the order of its <see cref="VoronoiEdge.Start"/> and <see cref="VoronoiEdge.End"/> points matters.
/// This is used by <see cref="VoronoiSite.ClockwiseEdgesWound"/> to return a well-defined winding order.
/// </summary>
[PublicAPI]
public readonly struct WoundVoronoiEdge
{
    /// <summary>
    /// The underlying edge that we are wrapping.
    /// Its start and end points are not guaranteed to be in any particular order by themselves.
    /// Instead, use <see cref="Start"/> and <see cref="End"/> to get the points in the correct order.
    /// </summary>
    public VoronoiEdge Edge { get; }

    /// <summary>
    /// Is this edge's start and end points flipped so that it forms a winding loop?
    /// It's not necessary to use this property directly, use <see cref="Start"/> and <see cref="End"/> instead.
    /// </summary>
    public bool Flipped { get; }
    
    
    /// <summary>
    /// The start point of this <see cref="Edge"/>, taking winding order (i.e. are we <see cref="Flipped"/>?) into account.
    /// </summary>
    public VoronoiPoint Start => Flipped ? Edge.End : Edge.Start;
    
    /// <summary>
    /// The end point of this <see cref="Edge"/>, taking winding order (i.e. are we <see cref="Flipped"/>?) into account.
    /// </summary>
    public VoronoiPoint End => Flipped ? Edge.Start : Edge.End;
    

    public WoundVoronoiEdge(VoronoiEdge edge, bool flipped)
    {
        Edge = edge;
        Flipped = flipped;
    }
    
    
    public override string ToString() => ToString("F3");

    [PublicAPI]
    public string ToString(string floatFormat)
    {
        return 
            Start.ToString(floatFormat) + "-" +
            (Flipped ? "↺" : "") +
            ">" + End.ToString(floatFormat);
    }
}