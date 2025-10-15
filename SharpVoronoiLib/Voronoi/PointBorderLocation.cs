namespace SharpVoronoiLib;

/// <remarks>
/// Note that these are ordered clock-wise starting at bottom-left
/// </remarks>
public enum PointBorderLocation
{
    NotOnBorder = -1,
    BottomLeft = 0,
    Left = 1,
    TopLeft = 2,
    Top = 3,
    TopRight = 4,
    Right = 5,
    BottomRight = 6,
    Bottom = 7
}