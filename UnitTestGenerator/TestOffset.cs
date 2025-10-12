namespace SharpVoronoiLib.UnitTestGenerator;

/// <summary>
/// How the layout should be "placed" in relation to the axis.
/// </summary>
public enum TestOffset
{
    /// <summary>
    /// 0..width, 0..height
    /// </summary>
    PositiveQuadrant,
    
    /// <summary>
    /// -width/2..width/2, -height/2..height/2
    /// </summary>
    CenteredAtOrigin,
}