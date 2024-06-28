using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using SharpVoronoiLib.Exceptions;

namespace SharpVoronoiLib
{
    /// <summary>
    /// The point/site/seed on the Voronoi plane.
    /// This has a <see cref="Cell"/> of <see cref="VoronoiEdge"/>s.
    /// This has <see cref="Points"/> of <see cref="VoronoiPoint"/>s that are the edge end points, i.e. the cell's vertices.
    /// This also has <see cref="Neighbours"/>, i.e. <see cref="VoronoiSite"/>s across the <see cref="VoronoiEdge"/>s.
    /// </summary>
    public class VoronoiSite
    {
        [PublicAPI]
        public double X { get; private set; }

        [PublicAPI]
        public double Y { get; private set; }

        /// <summary>
        /// The edges that make up this cell.
        /// The vertices of these edges are the <see cref="Points"/>.
        /// These are also known as Thiessen polygons.
        /// </summary>
        [PublicAPI]
        public IEnumerable<VoronoiEdge> Cell
        {
            get
            {
                if (!_tessellated)
                    throw new VoronoiNotTessellatedException();
                
                return cell;
            }
        }

        /// <summary>
        ///
        /// If the site lies on any of the edges (or corners), then the starting order is not defined.
        /// </summary>
        [PublicAPI]
        public IEnumerable<VoronoiEdge> ClockwiseCell
        {
            get
            {
                if (!_tessellated)
                    throw new VoronoiNotTessellatedException();
                
                if (_clockwiseCell == null)
                {
                    _clockwiseCell = new List<VoronoiEdge>(cell);
                    _clockwiseCell.Sort(SortCellEdgesClockwise);
                }

                return _clockwiseCell;
            }
        }

        /// <summary>
        /// The sites across the edges.
        /// </summary>
        [PublicAPI]
        public IEnumerable<VoronoiSite> Neighbours
        {
            get
            {
                if (!_tessellated)
                    throw new VoronoiNotTessellatedException();
                
                return neighbours;
            }
        }

        /// <summary>
        /// The vertices of the <see cref="Cell"/>.
        /// </summary>
        [PublicAPI]
        public IEnumerable<VoronoiPoint> Points
        {
            get
            {
                if (!_tessellated)
                    throw new VoronoiNotTessellatedException();
                
                if (_points == null)
                {
                    _points = new List<VoronoiPoint>();

                    foreach (VoronoiEdge edge in cell)
                    {
                        if (!_points.Contains(edge.Start))
                        {
                            _points.Add(edge.Start);
                        }

                        if (!_points.Contains(edge.End!))
                        {
                            _points.Add(edge.End);
                        }
                        // Note that .End is guaranteed to be set since we don't expose edges externally that aren't clipped in bounds

                        // Note that the order of .Start and .End is not guaranteed in VoronoiEdge,
                        // so we couldn't simply only add either .Start or .End, this would skip and duplicate points
                    }
                }

                return _points;
            }
        }
        
        /// <summary>
        /// 
        /// If the site lies on any of the edges (or corners), then the starting order is not defined.
        /// </summary>
        [PublicAPI]
        public IEnumerable<VoronoiPoint> ClockwisePoints
        {
            get
            {
                if (!_tessellated)
                    throw new VoronoiNotTessellatedException();
                
                if (_clockwisePoints == null)
                {
                    _clockwisePoints = new List<VoronoiPoint>(Points);
                    _clockwisePoints.Sort(SortPointsClockwise);
                }

                return _clockwisePoints;
            }
        }

        /// <summary>
        /// Whether this site lies directly on exactly one of its <see cref="Cell"/>'s edges.
        /// This happens when sites overlap or are on the border.
        /// This won't be set if instead <see cref="LiesOnCorner"/> is set, i.e. the site lies on the intersection of 2 of its edges.
        /// </summary>
        [PublicAPI]
        public VoronoiEdge? LiesOnEdge
        {
            get
            {
                if (!_tessellated)
                    throw new VoronoiNotTessellatedException();
                
                return _liesOnEdge;
            }
        }

        /// <summary>
        /// Whether this site lies directly on the intersection point of two of its <see cref="Cell"/>'s edges.
        /// This happens when sites overlap or are on the border's corner.
        /// </summary>
        [PublicAPI]
        public VoronoiPoint? LiesOnCorner
        {
            get
            {
                if (!_tessellated)
                    throw new VoronoiNotTessellatedException();
                
                return _liesOnCorner;
            }
        }

        /// <summary>
        /// The center of our cell.
        /// Specifically, the geometric center aka center of mass, i.e. the arithmetic mean position of all the edge end points.
        /// This is assuming a non-self-intersecting closed polygon of our cell.
        /// If we don't have a closed cell (i.e. unclosed "polygon"), then this will produce approximate results that aren't mathematically sound, but work for most purposes. 
        /// </summary>
        public VoronoiPoint Centroid
        {
            get
            {
                if (!_tessellated)
                    throw new VoronoiNotTessellatedException();
                
                if (_centroid != null)
                    return _centroid;

                _centroid = ComputeCentroid();
                
                return _centroid;
            }
        }

        
        internal readonly List<VoronoiEdge> cell;
        internal readonly List<VoronoiSite> neighbours;


        private bool _tessellated;

        private List<VoronoiPoint>? _points;
        private List<VoronoiPoint>? _clockwisePoints;
        private List<VoronoiEdge>? _clockwiseCell;
        private VoronoiEdge? _liesOnEdge;
        private VoronoiPoint? _liesOnCorner;
        private VoronoiPoint? _centroid;
        // Note: if adding something new, don't forget to clear it in Relocate() if it doesn't apply pre-tessellation


        [PublicAPI]
        public VoronoiSite(double x, double y)
        {
            if (double.IsNaN(x)) throw new ArgumentException("x cannot be NaN", nameof(x));
            if (double.IsNaN(y)) throw new ArgumentException("y cannot be NaN", nameof(y));
            
            X = x;
            Y = y;
            
            cell = new List<VoronoiEdge>();
            neighbours = new List<VoronoiSite>();
        }

        
        [PublicAPI]
        public bool Contains(double x, double y)
        {
            if (!_tessellated)
                throw new VoronoiNotTessellatedException();
            
            // If we don't have points generated yet, do so now (by calling the property that does so when read)
            if (_clockwisePoints == null)
            {
                IEnumerable<VoronoiPoint> _ = ClockwisePoints;
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

        
        internal void TessellationStarted()
        {
            _tessellated = true;
        }

        internal void AddEdge(VoronoiEdge newEdge)
        {
            cell.Add(newEdge);

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
            
            // Clear all the values we used before
            
            cell.Clear();
            neighbours.Clear();
            _points = null;
            _clockwisePoints = null;
            _clockwiseCell = null;
            _liesOnEdge = null;
            _liesOnCorner = null;
            _centroid = null;
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
            double target = cell.Sum(c => c.Start.X + c.End.X) / cell.Count / 2;
            return X + (target - X) * shiftAmount;
        }

        [Pure]
        private double GetCenterShiftedY()
        {
            double target = cell.Sum(c => c.Start.Y + c.End.Y) / cell.Count / 2;
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
                IEnumerable<VoronoiPoint> _ = ClockwisePoints;
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
            _clockwiseCell = null;
        }
        
        internal void Invalidated()
        {
            _tessellated = false;
            
            cell.Clear(); // don't cling to any references
            neighbours.Clear(); // don't cling to any references
            _centroid = null; // don't cling to any references
            _liesOnEdge = null; // don't cling to any references
            _liesOnCorner = null; // don't cling to any references

            InvalidateComputedValues();
        }


#if DEBUG
        public override string ToString()
        {
            return "(" + X.ToString("F3") + "," + Y.ToString("F3") + ")";
        }
#endif
    }
}
