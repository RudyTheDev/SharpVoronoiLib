namespace SharpVoronoiLib;

/// <summary>
/// The vertices/nodes of the Voronoi cells, i.e. the points equidistant to three or more Voronoi sites.
/// These are the end points of a <see cref="VoronoiEdge"/>.
/// These are the <see cref="VoronoiSite.Points"/>.
/// Also used for some other derived locations.
/// </summary>
public class VoronoiPoint : IEquatable<VoronoiPoint>
{
    [PublicAPI]
    public double X { get; }
        
    [PublicAPI]
    public double Y { get; }
        
    /// <summary>
    /// Specifies if this point is on the border of the bounds and where.
    /// </summary>
    /// <remarks>
    /// Using this would be preferable to comparing against the X/Y values due to possible precision issues.
    /// </remarks>
    [PublicAPI]
    public PointBorderLocation BorderLocation { get; internal set; }
    
    /// <summary>
    /// Edges that have this point as their Start or End.
    /// </summary>
    [PublicAPI]
    public IReadOnlyList<VoronoiEdge> Edges => _edges;

    /// <summary>
    /// Sites adjacent to this point, i.e. sites on whose corners this point lies.
    /// </summary>
    [PublicAPI]
    public IReadOnlyList<VoronoiSite> Sites
    {
        get
        {
            if (_sites == null)
            {
                List<VoronoiSite> sites = new List<VoronoiSite>(4);

                // Collect distinct non-null sites touching this point via its edges
                foreach (VoronoiEdge edge in _edges)
                {
                    if (edge.Left != null && !sites.ContainsAsReference(edge.Left))
                        sites.Add(edge.Left);

                    if (edge.Right != null && !sites.ContainsAsReference(edge.Right))
                        sites.Add(edge.Right);
                    
                    // This isn't very efficient, but the number of edges per point is usually small,
                    // while doing something like a HashSet would be overhead overkill
                }

                _sites = sites;
            }

            return _sites;
        }
    }


    private readonly List<VoronoiEdge> _edges = new List<VoronoiEdge>(3);
    private List<VoronoiSite>? _sites;
        
        
    internal VoronoiPoint(double x, double y, PointBorderLocation borderLocation = PointBorderLocation.NotOnBorder)
    {
        if (double.IsNaN(x)) throw new ArgumentException("x cannot be NaN", nameof(x));
        if (double.IsNaN(y)) throw new ArgumentException("y cannot be NaN", nameof(y));
        if (double.IsInfinity(x)) throw new ArgumentException("x cannot be infinite", nameof(x));
        if (double.IsInfinity(y)) throw new ArgumentException("y cannot be infinite", nameof(y));
            
        X = x;
        Y = y;
        BorderLocation = borderLocation;
    }
        
        
    [Pure]
    internal double AngleTo(VoronoiPoint other)
    {
        return Math.Atan2(other.Y - Y, other.X - X);
    }

    /// <summary>
    /// Tells this point that it is attached to the given edge.
    /// This is not final (before the tessellation is complete) and edges may be <see cref="DetachEdge"/> later.
    /// </summary>
    internal void AttachEdge(VoronoiEdge edge)
    {
        if (_edges.ContainsAsReference(edge))
            return;
        
        _edges.Add(edge);
    }

    /// <summary>
    /// Tells this point that it is actually not attached to the given edge.
    /// This is due to the particulars of Fortune's algorithm,
    /// but it's still more efficient to do it this way than to somehow gather edges (or sites) afterwards.
    /// </summary>
    internal void DetachEdge(VoronoiEdge edge)
    {
        for (int i = 0; i < _edges.Count; i++)
        {
            if (ReferenceEquals(_edges[i], edge))
            {
                _edges.RemoveAt(i);
                return;
            }
        }

        throw new Exception(); // should never happen
    }


    #region Equality
    
    public bool Equals(VoronoiPoint? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return X.ApproxEqual(other.X) && Y.ApproxEqual(other.Y);
    }

    public override bool Equals(object? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        if (other.GetType() != GetType()) return false;
        return Equals((VoronoiPoint)other);
    }
    
    public static bool operator ==(VoronoiPoint? left, VoronoiPoint? right)
    {
        if (left is null) return right is null;
        return left.Equals(right);
    }
    
    public static bool operator !=(VoronoiPoint? left, VoronoiPoint? right)
    {
        return !(left == right);
    }
    
    /// <summary>
    /// <inheritdoc cref="object.GetHashCode()"/>
    /// Takes float precision and epsilon into account.
    /// </summary>
    public override int GetHashCode()
    {
        int qx = EpsilonUtils.Quantize(X);
        int qy = EpsilonUtils.Quantize(Y);
        
        unchecked
        {
            return (qx.GetHashCode() * 397) ^ qy.GetHashCode();
        }
    }
    
    #endregion


    public override string ToString() => ToString("F3");

    [PublicAPI]
    public string ToString(string floatFormat)
    {
        return
            "("
            + (X == double.MinValue ? "-∞" : X == double.MaxValue ? "+∞" : X.ToString(floatFormat))
            + ","
            + (Y == double.MinValue ? "-∞" : Y == double.MaxValue ? "+∞" : Y.ToString(floatFormat))
            + ")"
            + BorderLocationToString(BorderLocation);
    }

    private static string BorderLocationToString(PointBorderLocation location)
    {
        switch (location)
        {
            case PointBorderLocation.NotOnBorder:
                return "";
            case PointBorderLocation.BottomLeft:
                return "BL";
            case PointBorderLocation.Left:
                return "L";
            case PointBorderLocation.TopLeft:
                return "TL";
            case PointBorderLocation.Top:
                return "T";
            case PointBorderLocation.TopRight:
                return "TR";
            case PointBorderLocation.Right:
                return "R";
            case PointBorderLocation.BottomRight:
                return "BR";
            case PointBorderLocation.Bottom:
                return "B";
            default:
                return "?";
        }
    }
}