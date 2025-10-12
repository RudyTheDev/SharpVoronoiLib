namespace SharpVoronoiLib;

internal class GenericClipping : IBorderClippingAlgorithm
{
    public List<VoronoiEdge> Clip(List<VoronoiEdge> edges, double minX, double minY, double maxX, double maxY)
    {
        for (int i = 0; i < edges.Count; i++)
        {
            VoronoiEdge edge = edges[i];
                
            bool valid = ClipEdge(edge, minX, minY, maxX, maxY);
                
            if (valid)
            {
                edge.Left!.AddEdge(edge);
                edge.Right!.AddEdge(edge);
            }
            else
            {
                // Since the edge is not valid, then it also cannot "connect" sites as neighbours.
                // Technically, the sites are neighbours on an infinite place, but clipping at borders means foregoing such neighbouring.
                edge.Left!.RemoveNeighbour(edge.Right!);
                edge.Right!.RemoveNeighbour(edge.Left!);
                    
                edges.RemoveAt(i);
                i--;
            }
        }

        return edges;
    }
        
        
    /// <summary>
    /// Combination of personal ray clipping alg and cohen sutherland
    /// </summary>
    private static bool ClipEdge(VoronoiEdge edge, double minX, double minY, double maxX, double maxY)
    {
        bool accept = false;

        // If it's a ray
        if (edge.End == null!)
        {
            accept = ClipRay(edge, minX, minY, maxX, maxY);
        }
        else
        {
            //Cohen–Sutherland
            Outcode start = ComputeOutCode(edge.Start.X, edge.Start.Y, minX, minY, maxX, maxY);
            Outcode end = ComputeOutCode(edge.End.X, edge.End.Y, minX, minY, maxX, maxY);

            while (true)
            {
                if ((start | end) == Outcode.None)
                {
                    accept = true;
                    break;
                }
                if ((start & end) != Outcode.None)
                {
                    break;
                }

                double x = -1, y = -1;
                Outcode outcode = start != Outcode.None ? start : end;

                if (outcode.HasFlag(Outcode.Top))
                {
                    x = edge.Start.X + (edge.End.X - edge.Start.X) * (maxY - edge.Start.Y) / (edge.End.Y - edge.Start.Y);
                    y = maxY;
                }
                else if (outcode.HasFlag(Outcode.Bottom))
                {
                    x = edge.Start.X + (edge.End.X - edge.Start.X) * (minY - edge.Start.Y) / (edge.End.Y - edge.Start.Y);
                    y = minY;
                }
                else if (outcode.HasFlag(Outcode.Right))
                {
                    y = edge.Start.Y + (edge.End.Y - edge.Start.Y) * (maxX - edge.Start.X) / (edge.End.X - edge.Start.X);
                    x = maxX;
                }
                else if (outcode.HasFlag(Outcode.Left))
                {
                    y = edge.Start.Y + (edge.End.Y - edge.Start.Y) * (minX - edge.Start.X) / (edge.End.X - edge.Start.X);
                    x = minX;
                }

                VoronoiPoint finalPoint = new VoronoiPoint(x, y, GetBorderLocationForCoordinate(x, y, minX, minY, maxX, maxY));
                    
                if (outcode == start)
                {
                    // If we are a 0-length edge after clipping, then we are a "connector" between more than 2 equidistant sites 
                    if (finalPoint.ApproxEqual(edge.End))
                    {
                        // We didn't consider this point to be on border before, so need reflag it
                        edge.End.BorderLocation = finalPoint.BorderLocation;
                        // (point is shared between edges, so we are basically setting this for all the other edges)
                        
                        // The neighbours in-between (ray away outside the border) are not actually connected
                        edge.Left!.RemoveNeighbour(edge.Right!);
                        edge.Right!.RemoveNeighbour(edge.Left!);

                        // Not a valid edge
                        return false;
                    }
                        
                    edge.Start = finalPoint;
                    start = ComputeOutCode(x, y, minX, minY, maxX, maxY);
                }
                else
                {
                    // If we are a 0-length edge after clipping, then we are a "connector" between more than 2 equidistant sites 
                    if (finalPoint.ApproxEqual(edge.Start))
                    {
                        // We didn't consider this point to be on border before, so need reflag it
                        edge.Start.BorderLocation = finalPoint.BorderLocation;
                        // (point is shared between edges, so we are basically setting this for all the other edges)
                        
                        // The neighbours in-between (ray away outside the border) are not actually connected
                        edge.Left!.RemoveNeighbour(edge.Right!);
                        edge.Right!.RemoveNeighbour(edge.Left!);
                        
                        // Not a valid edge
                        return false;
                    }
                        
                    edge.End = finalPoint;
                    end = ComputeOutCode(x, y, minX, minY, maxX, maxY);
                }
            }
        }
            
        // If we have a neighbor
        if (edge.LastBeachLineNeighbor != null)
        {
            // Check it
            bool valid = ClipEdge(edge.LastBeachLineNeighbor, minX, minY, maxX, maxY);
                
            // Both are valid
            if (accept && valid)
            {
                edge.Start = edge.LastBeachLineNeighbor.End;
            }
                
            // This edge isn't valid, but the neighbor is
            // Flip and set
            if (!accept && valid)
            {
                edge.Start = edge.LastBeachLineNeighbor.End;
                edge.End = edge.LastBeachLineNeighbor.Start;
                accept = true;
            }
        }
            
        return accept;
            
            
        static Outcode ComputeOutCode(double x, double y, double minX, double minY, double maxX, double maxY)
        {
            Outcode code = Outcode.None;
            if (x.ApproxEqual(minX) || x.ApproxEqual(maxX))
            { }
            else if (x < minX)
                code |= Outcode.Left;
            else if (x > maxX)
                code |= Outcode.Right;

            if (y.ApproxEqual(minY) || y.ApproxEqual(maxY))
            { }
            else if (y < minY)
                code |= Outcode.Bottom;
            else if (y > maxY)
                code |= Outcode.Top;
            return code;
        }
    }

    private static bool ClipRay(VoronoiEdge edge, double minX, double minY, double maxX, double maxY)
    {
        VoronoiPoint start = edge.Start;
            
        //horizontal ray
        if (edge.SlopeRise.ApproxEqual(0))
        {
            if (!Within(start.Y, minY, maxY))
                return false;

            if (edge.SlopeRun.ApproxGreaterThan(0) && start.X.ApproxGreaterThan(maxX))
                return false;

            if (edge.SlopeRun.ApproxLessThan(0) && start.X.ApproxLessThan(minX))
                return false;

            if (Within(start.X, minX, maxX))
            {
                VoronoiPoint endPoint = 
                    edge.SlopeRun.ApproxGreaterThan(0) ? 
                        new VoronoiPoint(maxX, start.Y, PointBorderLocation.Right) : 
                        new VoronoiPoint(minX, start.Y, start.Y.ApproxEqual(minY) ? PointBorderLocation.BottomLeft : start.Y.ApproxEqual(maxY) ? PointBorderLocation.TopLeft : PointBorderLocation.Left);

                // If we are a 0-length edge after clipping, then we are a "connector" between more than 2 equidistant sites 
                if (endPoint.ApproxEqual(edge.Start))
                {
                    // We didn't consider this point to be on border before, so need reflag it
                    start.BorderLocation = endPoint.BorderLocation;
                    // (point is shared between edges, so we are basically setting this for all the other edges)
                        
                    // The neighbours in-between (ray away outside the border) are not actually connected
                    edge.Left!.RemoveNeighbour(edge.Right!);
                    edge.Right!.RemoveNeighbour(edge.Left!);
                        
                    // Not a valid edge
                    return false;
                }

                edge.End = endPoint;
            }
            else
            {
                if (edge.SlopeRun.ApproxGreaterThan(0))
                {
                    edge.Start = new VoronoiPoint(minX, start.Y, PointBorderLocation.Left);
                    edge.End = new VoronoiPoint(maxX, start.Y, PointBorderLocation.Right);
                }
                else
                {
                    edge.Start = new VoronoiPoint(maxX, start.Y, PointBorderLocation.Right);
                    edge.End = new VoronoiPoint(minX, start.Y, PointBorderLocation.Left);
                }
            }
                
            return true;
        }

        //vertical ray
        if (edge.SlopeRun.ApproxEqual(0))
        {
            if (start.X.ApproxLessThan(minX) || start.X.ApproxGreaterThan(maxX))
                return false;

            if (edge.SlopeRise.ApproxGreaterThan(0) && start.Y.ApproxGreaterThan(maxY))
                return false;

            if (edge.SlopeRise.ApproxLessThan(0) && start.Y.ApproxLessThan(minY))
                return false;

            if (Within(start.Y, minY, maxY))
            {
                VoronoiPoint endPoint = 
                    edge.SlopeRise.ApproxGreaterThan(0) ?
                        new VoronoiPoint(start.X, maxY, start.X.ApproxEqual(minX) ? PointBorderLocation.TopLeft : start.X.ApproxEqual(maxX) ? PointBorderLocation.TopRight : PointBorderLocation.Top) :
                        new VoronoiPoint(start.X, minY, PointBorderLocation.Bottom);

                // If we are a 0-length edge after clipping, then we are a "connector" between more than 2 equidistant sites 
                if (endPoint.ApproxEqual(edge.Start))
                {
                    // We didn't consider this point to be on border before, so need reflag it
                    start.BorderLocation = endPoint.BorderLocation;
                    // (point is shared between edges, so we are basically setting this for all the other edges)
                        
                    // The neighbours in-between (ray away outside the border) are not actually connected
                    edge.Left!.RemoveNeighbour(edge.Right!);
                    edge.Right!.RemoveNeighbour(edge.Left!);
                        
                    // Not a valid edge
                    return false;
                }

                edge.End = endPoint;
            }
            else
            {
                if (edge.SlopeRise.ApproxGreaterThan(0))
                {
                    edge.Start = new VoronoiPoint(start.X, minY, PointBorderLocation.Bottom);
                    edge.End = new VoronoiPoint(start.X, maxY, PointBorderLocation.Top);
                }
                else
                {
                    edge.Start = new VoronoiPoint(start.X, maxY, PointBorderLocation.Top);
                    edge.End = new VoronoiPoint(start.X, minY, PointBorderLocation.Bottom);
                }
            }
            return true;
        }
            
        //works for outside

        double topXValue = CalcX(edge.Slope!.Value, maxY, edge.Intercept!.Value);
        VoronoiPoint topX = new VoronoiPoint(topXValue, maxY, topXValue.ApproxEqual(minX) ? PointBorderLocation.TopLeft : topXValue.ApproxEqual(maxX) ? PointBorderLocation.TopRight : PointBorderLocation.Top);

        double rightYValue = CalcY(edge.Slope.Value, maxX, edge.Intercept.Value);
        VoronoiPoint rightY = new VoronoiPoint(maxX, rightYValue, rightYValue.ApproxEqual(minY) ? PointBorderLocation.BottomRight : rightYValue.ApproxEqual(maxY) ? PointBorderLocation.TopRight : PointBorderLocation.Right);

        double bottomXValue = CalcX(edge.Slope.Value, minY, edge.Intercept.Value);
        VoronoiPoint bottomX = new VoronoiPoint(bottomXValue, minY, bottomXValue.ApproxEqual(minX) ? PointBorderLocation.BottomLeft : bottomXValue.ApproxEqual(maxX) ? PointBorderLocation.BottomRight : PointBorderLocation.Bottom);

        double leftYValue = CalcY(edge.Slope.Value, minX, edge.Intercept.Value);
        VoronoiPoint leftY = new VoronoiPoint(minX, leftYValue, leftYValue.ApproxEqual(minY) ? PointBorderLocation.BottomLeft : leftYValue.ApproxEqual(maxY) ? PointBorderLocation.TopLeft : PointBorderLocation.Left);

        // Note: these points may be duplicates if the ray goes through a border corner,
        // so we have to check for repeats when building the candidate list below.
        // We can optimize slightly since we are adding them one at a time and only "neighbouring" points can be the same,
        // e.g. topX and rightY can but not topX and bottomX.
            
        //reject intersections not within bounds
            
        List<VoronoiPoint> candidates = new List<VoronoiPoint>();

        bool withinTopX = Within(topX.X, minX, maxX);
        bool withinRightY = Within(rightY.Y, minY, maxY);
        bool withinBottomX = Within(bottomX.X, minX, maxX);
        bool withinLeftY = Within(leftY.Y, minY, maxY);

        if (withinTopX)
            candidates.Add(topX);

        if (withinRightY)
            if (!withinTopX || !rightY.ApproxEqual(topX))
                candidates.Add(rightY);

        if (withinBottomX)
            if (!withinRightY || !bottomX.ApproxEqual(rightY))
                candidates.Add(bottomX);

        if (withinLeftY)
            if (!withinTopX || !leftY.ApproxEqual(topX))
                if (!withinBottomX || !leftY.ApproxEqual(bottomX))
                    candidates.Add(leftY);

        // This also works as a condition above, but is slower and checks against redundant values
        // if (candidates.All(c => !c.X.ApproxEqual(leftY.X) || !c.Y.ApproxEqual(leftY.Y)))
            

        //reject candidates which don't align with the slope
        for (int i = candidates.Count - 1; i >= 0; i--)
        {
            VoronoiPoint candidate = candidates[i];
            //grab vector representing the edge
            double ax = candidate.X - start.X;
            double ay = candidate.Y - start.Y;
            if ((edge.SlopeRun*ax + edge.SlopeRise*ay).ApproxLessThan(0))
                candidates.RemoveAt(i);
        }

        // If there are two candidates, we are outside the plane.
        // The closer candidate is the start point while the further one is the end point.
        if (candidates.Count == 2)
        {
            double ax = candidates[0].X - start.X;
            double ay = candidates[0].Y - start.Y;
            double bx = candidates[1].X - start.X;
            double by = candidates[1].Y - start.Y;
                
            if ((ax*ax + ay*ay).ApproxGreaterThan(bx*bx + by*by))
            {
                // Candidate 1 is closer
                    
                if (!edge.Start.ApproxEqual(candidates[1]))
                    edge.Start = candidates[1];
                // If the point is already at the right location (i.e. edge.Start == candidates[1]), then keep it.
                // This preserves the same instance between potential multiple edges.
                // If not, it's a new clipped point, which will be unique
                    
                // It didn't have a border location being an unfinished edge point.
                edge.Start.BorderLocation = GetBorderLocationForCoordinate(edge.Start.X, edge.Start.Y, minX, minY, maxX, maxY);
                        
                // The other point, i.e. end, didn't have a value yet
                edge.End = candidates[0]; // candidate point already has the border location set correctly
            }
            else
            {
                // Candidate 2 is closer

                if (!edge.Start.ApproxEqual(candidates[0]))
                    edge.Start = candidates[0];
                // If the point is already at the right location (i.e. edge.Start == candidates[0]), then keep it.
                // This preserves the same instance between potential multiple edges.
                // If not, it's a new clipped point, which will be unique

                // It didn't have a border location being an unfinished edge point.
                edge.Start.BorderLocation = GetBorderLocationForCoordinate(edge.Start.X, edge.Start.Y, minX, minY, maxX, maxY);
                    
                // The other point, i.e. end, didn't have a value yet
                edge.End = candidates[1]; // candidate point already has the border location set correctly
            }
        }

        // If there is one candidate, we are inside the plane
        if (candidates.Count == 1)
        { 
            // If we are already at the candidate point, then we are already on the border at the "clipping" location
            if (candidates[0].ApproxEqual(edge.Start))
            {
                // We didn't consider this point to be on border before, so need reflag it
                start.BorderLocation = candidates[0].BorderLocation;
                // (point is shared between edges, so we are basically setting this for all the other edges)
                    
                // We did not actually clip anything, we are already clipped correctly, so to speak
                return false;
            }

            // Start remains as is

            // The other point has a value now
            edge.End = candidates[0]; // candidate point already has the border location set correctly
        }

        // There were no candidates
        return edge.End != null!; // can be null for now until we fully clip it
            
            
        static bool Within(double x, double a, double b)
        {
            return x.ApproxGreaterThanOrEqualTo(a) && x.ApproxLessThanOrEqualTo(b);
        }

        static double CalcY(double m, double x, double b)
        {
            return m * x + b;
        }

        static double CalcX(double m, double y, double b)
        {
            return (y - b) / m;
        }
    }

    private static PointBorderLocation GetBorderLocationForCoordinate(double x, double y, double minX, double minY, double maxX, double maxY)
    {
        if (x.ApproxEqual(minX) && y.ApproxEqual(minY)) return PointBorderLocation.BottomLeft;
        if (x.ApproxEqual(minX) && y.ApproxEqual(maxY)) return PointBorderLocation.TopLeft;
        if (x.ApproxEqual(maxX) && y.ApproxEqual(minY)) return PointBorderLocation.BottomRight;
        if (x.ApproxEqual(maxX) && y.ApproxEqual(maxY)) return PointBorderLocation.TopRight;
            
        if (x.ApproxEqual(minX)) return PointBorderLocation.Left;
        if (y.ApproxEqual(minY)) return PointBorderLocation.Bottom;
        if (x.ApproxEqual(maxX)) return PointBorderLocation.Right;
        if (y.ApproxEqual(maxY)) return PointBorderLocation.Top;
            
        return PointBorderLocation.NotOnBorder;
    }


    [Flags]
    private enum Outcode
    {
        None = 0x0,
        Left = 0x1,
        Right = 0x2,
        Bottom = 0x4,
        Top = 0x8
    }
}