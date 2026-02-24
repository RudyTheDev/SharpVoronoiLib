namespace SharpVoronoiLib;

/// <summary>
/// The point/site/seed on the Voronoi plane.
/// This has a list of <see cref="Edges"/> of <see cref="VoronoiEdge"/>s.
/// This has a list of <see cref="Points"/> of <see cref="VoronoiPoint"/>s that are the edge end points, i.e. the cell's vertices.
/// This also has a list of <see cref="Neighbours"/>, i.e. <see cref="VoronoiSite"/>s across the <see cref="VoronoiEdge"/>s.
/// </summary>
public class VoronoiSite : IEquatable<VoronoiSite>
{
    [PublicAPI]
    public double X { get; private set; }

    [PublicAPI]
    public double Y { get; private set; }

    /// <summary>
    /// The state of this site.
    /// It may be untesselated, if the algorithm hasn't been run yet.
    /// Or it may be skipped if it's a duplicate to another site, in which case <see cref="SkippedAsDuplicate"/> will be true.
    /// </summary>
    [PublicAPI]
    public bool Tesselated => _tessellated;

    /// <summary>
    /// When not <see cref="Tesselated"/>, but the main <see cref="VoronoiPlane"/> is,
    /// this may be true if tessellation skipped this site because it duplicates another site.
    /// </summary>
    [PublicAPI]
    public bool SkippedAsDuplicate => _skippedAsDuplicate;

    /// <summary>
    /// The edges that make up this site's cell.
    /// The vertices of these edges are the <see cref="Points"/>.
    /// These are also known as Thiessen polygons.
    /// </summary>
    /// <seealso cref="ClockwiseEdges"/>
    [PublicAPI]
    public IReadOnlyList<VoronoiEdge> Edges
    {
        get
        {
            ThrowIfUnavailable();
                
            return edges;
        }
    }
    
    [PublicAPI]
    [Obsolete("Use Edges instead", false)]
    public IReadOnlyList<VoronoiEdge> Cell => Edges;

    /// <summary>
    /// Same as <see cref="Edges"/>, but sorted in clockwise order around the site.
    /// If the site lies on any of the edges (or corners), then the starting order is not defined.
    /// Note that edge direction is undefined and their start/end points aren't sorted (see <see cref="ClockwiseEdgesWound"/>). 
    /// </summary>
    [PublicAPI]
    public IReadOnlyList<VoronoiEdge> ClockwiseEdges
    {
        get
        {
            ThrowIfUnavailable();
                
            if (_clockwiseEdges == null)
            {
                _clockwiseEdges = new List<VoronoiEdge>(edges);
                _clockwiseEdges.Sort(SortCellEdgesClockwise);
            }

            return _clockwiseEdges;
        }
    }

    [PublicAPI]
    [Obsolete("Use ClockwiseEdges instead", false)]
    public IReadOnlyList<VoronoiEdge> ClockwiseCell => ClockwiseEdges;

    /// <summary>
    /// Similar to <see cref="ClockwiseEdges"/>, but each edge is "wound" so that its start point is the previous edge's end point.
    /// In other words, the edges form a directional loop (assuming the site is not on the border with unclosed edges).
    /// This will match the order of <see cref="ClockwisePoints"/>.
    /// This will fail if the site is not properly <see cref="Closed"/>.
    /// </summary>
    [PublicAPI]
    public IReadOnlyList<WoundVoronoiEdge> ClockwiseEdgesWound
    {
        get
        {
            ThrowIfUnavailable();

            if (!Closed)
                throw new VoronoiSiteNotClosedException();
            // todo: technically this is not REQUIRED logically, but it's just a mess to handle such disjoint edges
            // not sure what the use case even is for "winding" edges of unclosed cells...
                
            if (_clockwiseEdgesWound == null)
            {
                IReadOnlyList<VoronoiEdge> _ = ClockwiseEdges; // this will initialize if not yet done
                IReadOnlyList<VoronoiPoint> __ = ClockwisePoints; // this will initialize if not yet done

                _clockwiseEdgesWound = WindEdges(_clockwiseEdges!, _clockwisePoints!); 
            }

            return _clockwiseEdgesWound;
        }
    }

    /// <summary>
    /// The sites across the edges.
    /// </summary>
    [PublicAPI]
    public IReadOnlyList<VoronoiSite> Neighbours
    {
        get
        {
            ThrowIfUnavailable();
                
            return neighbours;
        }
    }

    /// <summary>
    /// The vertices of the <see cref="Edges"/>.
    /// </summary>
    /// <seealso cref="ClockwisePoints"/>
    [PublicAPI]
    public IReadOnlyList<VoronoiPoint> Points
    {
        get
        {
            ThrowIfUnavailable();
                
            if (_points == null)
            {
                _points = new List<VoronoiPoint>(edges.Count); // afaik only unclosed cells will have more points than edges

                foreach (VoronoiEdge edge in edges)
                {
                    if (!_points.ContainsAsReference(edge.Start))
                        _points.Add(edge.Start);

                    if (!_points.ContainsAsReference(edge.End))
                        _points.Add(edge.End);
                    
                    // Note that .End is guaranteed to be set since we don't expose edges externally that aren't clipped in bounds

                    // Note that the order of .Start and .End is not guaranteed in VoronoiEdge,
                    // so we couldn't simply only add either .Start or .End, this would skip and duplicate points
                }
            }

            return _points;
        }
    }
        
    /// <summary>
    /// Same as <see cref="Points"/>, but sorted in clockwise order around the site.
    /// If the site lies on any of the edges (or corners), then the starting order is not defined.
    /// </summary>
    [PublicAPI]
    public IReadOnlyList<VoronoiPoint> ClockwisePoints
    {
        get
        {
            ThrowIfUnavailable();
                
            if (_clockwisePoints == null)
            {
                _clockwisePoints = new List<VoronoiPoint>(Points);
                _clockwisePoints.Sort(SortPointsClockwise);
            }

            return _clockwisePoints;
        }
    }

    /// <summary>
    /// Whether this site lies directly on exactly one of its <see cref="Edges"/>'s edges.
    /// This happens when sites overlap or are on the border.
    /// This won't be set if instead <see cref="LiesOnCorner"/> is set, i.e. the site lies on the intersection of 2 of its edges.
    /// </summary>
    [PublicAPI]
    public VoronoiEdge? LiesOnEdge
    {
        get
        {
            ThrowIfUnavailable();
                
            return _liesOnEdge;
        }
    }

    /// <summary>
    /// Whether this site lies directly on the intersection point of two of its <see cref="Edges"/>'s.
    /// This happens when sites overlap or are on the border's corner.
    /// </summary>
    [PublicAPI]
    public VoronoiPoint? LiesOnCorner
    {
        get
        {
            ThrowIfUnavailable();
                
            return _liesOnCorner;
        }
    }

    /// <summary>
    /// The center of our cell bounded by <see cref="Edges"/>.
    /// Specifically, the geometric center aka center of mass, i.e. the arithmetic mean position of all the <see cref="Points"/>.
    /// This is assuming a non-self-intersecting closed polygon of our cell.
    /// If we don't have a closed cell (i.e. unclosed "polygon"), then this will produce approximate results that aren't mathematically sound, but work for most purposes. 
    /// </summary>
    public VoronoiPoint Centroid
    {
        get
        {
            ThrowIfUnavailable();
                
            if (_centroid != null)
                return _centroid;

            _centroid = ComputeCentroid();
                
            return _centroid;
        }
    }

    /// <summary>
    /// Whether our site's cell is closed, i.e. all edges connect and form a closed polygon.
    /// This is only not true for sites touching edges when tesselation is set to <see cref="BorderEdgeGeneration.DoNotMakeBorderEdges"/>.
    /// </summary>
    public bool Closed => edges.Count > 0 && edges.Count == Points.Count;

        
    internal readonly List<VoronoiEdge> edges;
    internal readonly List<VoronoiSite> neighbours;


    private bool _tessellated;
    private bool _skippedAsDuplicate;

    private List<VoronoiPoint>? _points;
    private List<VoronoiPoint>? _clockwisePoints;
    private List<VoronoiEdge>? _clockwiseEdges;
    private List<WoundVoronoiEdge>? _clockwiseEdgesWound;
    private VoronoiEdge? _liesOnEdge;
    private VoronoiPoint? _liesOnCorner;
    private VoronoiPoint? _centroid;
    // Note: if adding something new, don't forget to clear it in Relocate() if it doesn't apply pre-tessellation


    [PublicAPI]
    public VoronoiSite(double x, double y)
    {
        if (double.IsNaN(x)) throw new ArgumentException("x cannot be NaN", nameof(x));
        if (double.IsNaN(y)) throw new ArgumentException("y cannot be NaN", nameof(y));
        if (double.IsInfinity(x)) throw new ArgumentException("x cannot be infinite", nameof(x));
        if (double.IsInfinity(y)) throw new ArgumentException("y cannot be infinite", nameof(y));
            
        X = x;
        Y = y;
            
        edges = new List<VoronoiEdge>(8);
        neighbours = new List<VoronoiSite>(8);

        // Average random site graphs are something like:
        
        // Generated 8343 sites, 25030 edges, 16688 points
        // Edges per site: 5.958
        // Sites with >8 edges: 111
        // Neighbours per site: 5.916
        // Sites with >8 neighbours: 111
        // Points per site: 5.958
        // Sites with >8 points: 111
        // Sites per point: 2.979
        // Points with >3 sites: 0
        // Edges per point: 3.000
        // Points with >3 edges: 0

        // So capacity 8 will occasionally underallocate,
        // but much rarer than allowing the default (4)
        // while basically being what the default would have been after it doubled internally.
        // Same reasoning is true for other places in code that use custom capacities.
    }

        
    [PublicAPI]
    public bool Contains(double x, double y)
    {
        ThrowIfUnavailable();
            
        // If we don't have points generated yet, do so now (by calling the property that does so when read)
        if (_clockwisePoints == null)
        {
            IReadOnlyList<VoronoiPoint> _ = ClockwisePoints;
        }

        // helper method to determine if a point is inside the cell
        // based on meowNET's answer from: https://stackoverflow.com/questions/4243042/c-sharp-point-in-polygon
        bool result = false;
        int j = _clockwisePoints!.Count - 1;
        for (int i = 0; i < _clockwisePoints.Count; i++)
        {
            if (_clockwisePoints[i].Y < y && _clockwisePoints[j].Y >= y || _clockwisePoints[j].Y < y && _clockwisePoints[i].Y >= y)
            {
                if (_clockwisePoints[i].X + ((y - _clockwisePoints[i].Y) / (_clockwisePoints[j].Y - _clockwisePoints[i].Y) * (_clockwisePoints[j].X - _clockwisePoints[i].X)) < x)
                {
                    result = !result;
                }
            }
            j = i;
        }
        return result;
    }

        
    internal void Tessellated()
    {
        _tessellated = true;
    }

    internal void AddEdge(VoronoiEdge newEdge)
    {
        edges.Add(newEdge);

        // Set the "flags" whether we are on an edge or corner

        if (LiesOnCorner != null)
            return; // we already are on a corner, we cannot be on 2 corners, so no need to check anything
            
        bool onEdge = DoesLieOnEdge(newEdge);

        if (!onEdge)
            return; // we are not on this edge - no changes needed
            
        if (LiesOnEdge == null)
        {
            _liesOnEdge = newEdge;
        }
        else
        {
            // We are already on an edge, so this must be the second edge, i.e. we lie on the corner
                
            if (newEdge.Start == LiesOnEdge.Start ||
                newEdge.Start == LiesOnEdge.End)
                _liesOnCorner = newEdge.Start;
            else
                _liesOnCorner = newEdge.End; 
                        
            _liesOnEdge = null; // we only keep this for one and only one edge
        }
    }

    internal void AddNeighbour(VoronoiSite newNeighbour)
    {
        neighbours.Add(newNeighbour);
    }
        
    internal void RemoveNeighbour(VoronoiSite badNeighbour)
    {
        neighbours.Remove(badNeighbour);
    }
        
    internal void Relocate(double newX, double newY)
    {
        X = newX;
        Y = newY;
            
        // We are no longer part of voronoi
        _tessellated = false;
        
        // We are not skipped as duplicate anymore as we have not been tessellated yet
        _skippedAsDuplicate = false;
            
        // Clear all the values we used before
            
        edges.Clear();
        neighbours.Clear();
        _points = null;
        _clockwisePoints = null;
        _clockwiseEdges = null;
        _clockwiseEdgesWound = null;
        _liesOnEdge = null;
        _liesOnCorner = null;
        _centroid = null;
    }

    internal void MarkSkippedAsDuplicate()
    {
        _skippedAsDuplicate = true;
    }

    internal static List<WoundVoronoiEdge> WindEdges(List<VoronoiEdge> edges, List<VoronoiPoint> points)
    {
        List<WoundVoronoiEdge> list = new List<WoundVoronoiEdge>(edges.Count);
        
        // Find an edge with the first point
        // This may be not the first edge even in a sorted list due to border edge/point ambiguity

        int edgeOffset = 0;
        
        for (int i = 0; i < edges.Count; i++)
        {
            // Edge must be between the first two points
            // (we can't check just one point, because this could be a neighbouring edge)
            if ((ReferenceEquals(points[0], edges[i].Start) && ReferenceEquals(points[1], edges[i].End)) ||
                ReferenceEquals(points[0], edges[i].End) && ReferenceEquals(points[1], edges[i].Start))
            {
                edgeOffset = i;
                break;
            }
        }
        
        // We check each edge
        for (int i = 0; i < edges.Count; i++)
        {
            // The starting point should match the edge
            VoronoiPoint point = points[i];
            
            // Edge that should be starting at this point
            int edgeIndex = (i + edgeOffset) % edges.Count;
            VoronoiEdge edge = edges[edgeIndex];

            // We need to flip if it doesn't
            bool flipped = ReferenceEquals(point, edge.End);

            list.Add(new WoundVoronoiEdge(edge, flipped));
        }

        return list;
    }

    [Pure]
    private static int SortPointsClockwise(VoronoiPoint point1, VoronoiPoint point2, double x, double y)
    {
        // originally, based on: https://social.msdn.microsoft.com/Forums/en-US/c4c0ce02-bbd0-46e7-aaa0-df85a3408c61/sorting-list-of-xy-coordinates-clockwise-sort-works-if-list-is-unsorted-but-fails-if-list-is?forum=csharplanguage

        // comparer to sort the array based on the points relative position to the center
        double atan1 = Atan2(point1.Y - y, point1.X - x);
        double atan2 = Atan2(point2.Y - y, point2.X - x);
            
        if (atan1 > atan2) return -1;
        if (atan1 < atan2) return 1;
        return 0;
    }

    [Pure]
    private static double Atan2(double y, double x)
    {
        // "Normal" Atan2 returns an angle between -π ≤ θ ≤ π as "seen" on the Cartesian plane,
        // that is, starting at the "right" of x axis and increasing counter-clockwise.
        // But we want the angle sortable where the origin is the "lowest" angle: 0 ≤ θ ≤ 2×π

        double a = Math.Atan2(y, x);
		
        if (a < 0)
            a += 2 * Math.PI;
			
        return a;
    }

        
    [Pure]
    private int SortCellEdgesClockwise(VoronoiEdge edge1, VoronoiEdge edge2)
    {
        int result;

        if (DoesLieOnEdge(edge1) || DoesLieOnEdge(edge2))
        {
            // If we are on either edge then we can't compare directly to that edge,
            // because angle to the edge is basically "along the edge", i.e. undefined.
            // We don't know which "direction" the cell will turn, we don't know if the cell is to the right/or left of the edge.
            // So we "step away" a little bit towards our cell's/polygon's center so that we are no longer on either edge.
            // This means we can now get the correct angle, which is slightly different now, but all we care about is the origin/quadrant.
            // This is a roundabout way to do this, but it seems to work well enough.
                
            double centerX = GetCenterShiftedX();
            double centerY = GetCenterShiftedY();
                
            if (EdgeCrossesOrigin(edge1, centerX, centerY))
                result = 1; // this makes edge 1 the last edge among all (cell's) edges

            else if (EdgeCrossesOrigin(edge2, centerX, centerY))
                result = -1; // this makes edge 2 the last edge among all (cell's) edges
                
            else
                result = SortPointsClockwise(edge1.Mid, edge2.Mid, centerX, centerY);
        }
        else
        {
            if (EdgeCrossesOrigin(edge1))
                result = 1; // this makes edge 1 the last edge among all (cell's) edges

            else if (EdgeCrossesOrigin(edge2))
                result = -1; // this makes edge 2 the last edge among all (cell's) edges
                
            else 
                result = SortPointsClockwise(edge1.Mid, edge2.Mid, X, Y);

        }
            
        return result;

        // Note that we don't assume that edges connect.
    }

    [Pure]
    private bool DoesLieOnEdge(VoronoiEdge edge)
    {
        return ArePointsColinear(
            X, Y, 
            edge.Start.X, edge.Start.Y, 
            edge.End.X, edge.End.Y
        );
    }

    [Pure]
    private static bool ArePointsColinear(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Based off https://stackoverflow.com/a/328110

        // Cross product 2-1 x 3-1
        return ((x2 - x1) * (y3 - y1)).ApproxEqual((x3 - x1) * (y2 - y1));
    }

    [Pure]
    private bool EdgeCrossesOrigin(VoronoiEdge edge)
    {
        double atanA = Atan2(edge.Start.Y - Y, edge.Start.X - X);
        double atanB = Atan2(edge.End!.Y - Y, edge.End.X - X);
            
        // Edge can only "cover" less than half the circle by definition, otherwise then it wouldn't actually "contain" the site
        // So when the difference between end point angles is greater than half a circle, we know we have and edge that "crossed" the angle origin.
            
        return Math.Abs(atanA - atanB) > Math.PI;
    }

    [Pure]
    private bool EdgeCrossesOrigin(VoronoiEdge edge, double originX, double originY)
    {
        double atanA = Atan2(edge.Start.Y - originY, edge.Start.X - originX);
        double atanB = Atan2(edge.End!.Y - originY, edge.End.X - originX);
            
        // Edge can only "cover" less than half the circle by definition, otherwise then it wouldn't actually "contain" the site
        // So when the difference between end point angles is greater than half a circle, we know we have and edge that "crossed" the angle origin.
            
        return Math.Abs(atanA - atanB) > Math.PI;
    }

    [Pure]
    private int SortPointsClockwise(VoronoiPoint point1, VoronoiPoint point2)
    {
        // When the point lies on top of us, we don't know what to use as an angle because that depends on which way the other edges "close".
        // So we "shift" the center a little towards the (approximate*) centroid of the polygon, which would "restore" the angle.
        // (* We don't want to waste time computing the actual true centroid though.)
            
        if (point1.ApproxEqual(X, Y) ||
            point2.ApproxEqual(X, Y))
            return SortPointsClockwise(point1, point2, GetCenterShiftedX(), GetCenterShiftedY());
            
        return SortPointsClockwise(point1, point2, X, Y);
    }
        
    [Pure]
    private double GetCenterShiftedX()
    {
        double target = edges.Sum(c => c.Start.X + c.End.X) / edges.Count / 2;
        return X + (target - X) * shiftAmount;
    }

    [Pure]
    private double GetCenterShiftedY()
    {
        double target = edges.Sum(c => c.Start.Y + c.End.Y) / edges.Count / 2;
        return Y + (target - Y) * shiftAmount;
    }
        
    private const double shiftAmount = 1 / 1E14;// the point of shifting coordinates is to "change the angle", but Atan cannot distinguish anything smaller than something like double significant digits, so we need this "epsilon" to be fairly large
        
    private VoronoiPoint ComputeCentroid()
    {
        // Basically, https://stackoverflow.com/a/34732659
        // https://en.wikipedia.org/wiki/Centroid#Of_a_polygon
            
        // If we don't have points generated yet, do so now (by calling the property that does so when read)
        if (_clockwisePoints == null)
        {
            IReadOnlyList<VoronoiPoint> _ = ClockwisePoints;
        }
            
        // Cx = (1 / 6A) * ∑ (x1 + x2) * (x1 * y2 - x2 + y1)
        // Cy = (1 / 6A) * ∑ (y1 + y2) * (x1 * y2 - x2 + y1)
        // A = (1 / 2) * ∑ (x1 * y2 - x2 * y1)
        // where x2/y2 is next point after x1/y1, including looping last
            
        double centroidX = 0; // just for compiler to be happy, we won't use these default values
        double centroidY = 0;
        double area = 0;

        for (int i = 0; i < _clockwisePoints!.Count; i++)
        {
            int i2 = i == _clockwisePoints.Count - 1 ? 0 : i + 1;

            double xi = _clockwisePoints[i].X;
            double yi = _clockwisePoints[i].Y;
            double xi2 = _clockwisePoints[i2].X;
            double yi2 = _clockwisePoints[i2].Y;

            double mult = (xi * yi2 - xi2 * yi) / 3;
            // Second multiplier is the same for both x and y, so "extract"
            // Also since C = 1/(6A)... and A = (1/2)..., we can just apply the /3 divisor here to not lose precision on large numbers 

            double addX = (xi + xi2) * mult;
            double addY = (yi + yi2) * mult;
                
            double addArea = xi * yi2 - xi2 * yi;

            if (i == 0)
            {
                centroidX = addX;
                centroidY = addY;
                area = addArea;
            }
            else
            {
                centroidX += addX;
                centroidY += addY;
                area += addArea;
            }
        }
            
        // If the area is 0, then we are basically squashed on top of other points... weird, but ok, this makes centroid exactly us
        if (area.ApproxEqual(0))
            return new VoronoiPoint(X, Y);
            
        centroidX /= area;
        centroidY /= area;

        return new VoronoiPoint(centroidX, centroidY);
    }
        
        
    internal void InvalidateComputedValues()
    {
        _points = null;
        _clockwisePoints = null;
        _clockwiseEdges = null;
        _clockwiseEdgesWound = null;
    }
        
    internal void Invalidated()
    {
        _tessellated = false;
            
        edges.Clear(); // don't cling to any references
        neighbours.Clear(); // don't cling to any references
        _centroid = null; // don't cling to any references
        _liesOnEdge = null; // don't cling to any references
        _liesOnCorner = null; // don't cling to any references

        InvalidateComputedValues();
    }

    
    private void ThrowIfUnavailable()
    {
        if (!_tessellated)
        {
            if (_skippedAsDuplicate)
                throw new VoronoiSiteSkippedAsDuplicateException();
            
            throw new VoronoiNotTessellatedException();
        }
    }

    #region Equality
    
    public bool Equals(VoronoiSite? other)
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
        return Equals((VoronoiSite)other);
    }
    
    public static bool operator ==(VoronoiSite? left, VoronoiSite? right)
    {
        if (left is null) return right is null;
        return left.Equals(right);
    }
    
    public static bool operator !=(VoronoiSite? left, VoronoiSite? right)
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
        return "(" + X.ToString(floatFormat) + "," + Y.ToString(floatFormat) + ")";
    }
}