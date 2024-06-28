using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace SharpVoronoiLib
{
    /// <summary>
    /// The vertices/nodes of the Voronoi cells, i.e. the points equidistant to three or more Voronoi sites.
    /// These are the end points of a <see cref="VoronoiEdge"/>.
    /// These are the <see cref="VoronoiSite.Points"/>.
    /// Also used for some other derived locations.
    /// </summary>
    public class VoronoiPoint
    {
        [PublicAPI]
        public double X { get; }
        
        [PublicAPI]
        public double Y { get; }
        
        /// <summary>
        /// Specifies if this point is on the border of the bounds and where.
        /// </summary>
        /// <remarks>
        /// Using this would be preferrable to comparing against the X/Y values due to possible precision issues.
        /// </remarks>
        [PublicAPI]
        public PointBorderLocation BorderLocation { get; internal set; }

        // TODO: Edges
        
        
        internal VoronoiPoint(double x, double y, PointBorderLocation borderLocation = PointBorderLocation.NotOnBorder)
        {
            if (double.IsNaN(x)) throw new ArgumentException("x cannot be NaN", nameof(x));
            if (double.IsNaN(y)) throw new ArgumentException("y cannot be NaN", nameof(y));
            
            X = x;
            Y = y;
            BorderLocation = borderLocation;
        }
        
        
        internal double AngleTo(VoronoiPoint other)
        {
            return Math.Atan2(other.Y - Y, other.X - X);
        }


#if DEBUG
        public override string ToString()
        {
            return
                "("
                + (X == double.MinValue ? "-∞" : X == double.MaxValue ? "+∞" : X.ToString("F3"))
                + ","
                + (Y == double.MinValue ? "-∞" : Y == double.MaxValue ? "+∞" : Y.ToString("F3"))
                + ")"
                + BorderLocationToString(BorderLocation);
        }

        public string ToString(string format)
        {
            return
                "("
                + (X == double.MinValue ? "-∞" : X == double.MaxValue ? "+∞" : X.ToString(format))
                + ","
                + (Y == double.MinValue ? "-∞" : Y == double.MaxValue ? "+∞" : Y.ToString(format))
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
#endif
    }
    
    
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

    
    internal static class VPointExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ApproxEqual(this VoronoiPoint value1, VoronoiPoint value2)
        {
            return
                value1.X.ApproxEqual(value2.X) &&
                value1.Y.ApproxEqual(value2.Y);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ApproxEqual(this VoronoiPoint value1, double x, double y)
        {
            return
                value1.X.ApproxEqual(x) &&
                value1.Y.ApproxEqual(y);
        }
    }
}
