using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVoronoiLib;

internal class GenericBorderClosing : IBorderClosingAlgorithm
{
    public List<VoronoiEdge> Close(List<VoronoiEdge> edges, double minX, double minY, double maxX, double maxY, List<VoronoiSite> sites)
    {
        // We construct edges in clockwise order on the border:
        // →→→→→→→→↓
        // ↑       ↓
        // ↑       ↓
        // ↑       ↓
        // O←←←←←←←←
            
        // We construct edges between nodes on this border.
        // Nodes are points that need edges between them and are either:
        // * Edge start/end points (any edge touching the border "breaks" it into two sections except if it's in a corner)
        // * Corner points (unless an edge ends in a corner, then these are "terminal" points along each edge)
            
        // As we collect the nodes (basically, edge points on the border).
        // we keep them in a sorted order in the above clockwise manner.

        BorderNodeComparer comparer = new BorderNodeComparer();

        SortedSet<BorderNode> nodes = new SortedSet<BorderNode>(comparer);

        bool hadBottomLeft = false;
        bool hadBottomRight = false;
        bool hadTopRight = false;
        bool hadTopLeft = false;

        for (int i = 0; i < edges.Count; i++)
        {
            VoronoiEdge edge = edges[i];
                
            if (edge.Start.BorderLocation != PointBorderLocation.NotOnBorder)
            {
                nodes.Add(new EdgeStartBorderNode(edge, i * 2));

                if (edge.Start.BorderLocation == PointBorderLocation.BottomLeft) hadBottomLeft = true;
                else if (edge.Start.BorderLocation == PointBorderLocation.BottomRight) hadBottomRight = true;
                else if (edge.Start.BorderLocation == PointBorderLocation.TopRight) hadTopRight = true;
                else if (edge.Start.BorderLocation == PointBorderLocation.TopLeft) hadTopLeft = true;
            }

            if (edge.End!.BorderLocation != PointBorderLocation.NotOnBorder)
            {
                nodes.Add(new EdgeEndBorderNode(edge, i * 2 + 1));
                    
                if (edge.End.BorderLocation == PointBorderLocation.BottomLeft) hadBottomLeft = true;
                else if (edge.End.BorderLocation == PointBorderLocation.BottomRight) hadBottomRight = true;
                else if (edge.End.BorderLocation == PointBorderLocation.TopRight) hadTopRight = true;
                else if (edge.End.BorderLocation == PointBorderLocation.TopLeft) hadTopLeft = true;
            }
        }

        // If none of the edges hit any of the corners, then we need to add those as generic non-edge nodes 
            
        if (!hadBottomLeft) nodes.Add(new CornerBorderNode(new VoronoiPoint(minX, minY, PointBorderLocation.BottomLeft)));
        if (!hadBottomRight) nodes.Add(new CornerBorderNode(new VoronoiPoint(maxX, minY, PointBorderLocation.BottomRight)));
        if (!hadTopRight) nodes.Add(new CornerBorderNode(new VoronoiPoint(maxX, maxY, PointBorderLocation.TopRight)));
        if (!hadTopLeft) nodes.Add(new CornerBorderNode(new VoronoiPoint(minX, maxY, PointBorderLocation.TopLeft)));

            
        EdgeBorderNode? previousEdgeNode = null;

        if (nodes.Min is EdgeBorderNode febn)
            previousEdgeNode = febn;

        if (previousEdgeNode == null)
        {
            foreach (BorderNode node in nodes.Reverse())
            {
                if (node is EdgeBorderNode rebn)
                {
                    previousEdgeNode = rebn;
                    break;
                }
            }
        }

        VoronoiSite? defaultSite = null;
        if (previousEdgeNode == null)
        {
            // We have no edges within bounds

            if (sites.Any())
            {
                // But we may have site(s), so it's possible a site is in the bounds
                // (two sites couldn't be or there would be an edge)
                    
                defaultSite = sites.FirstOrDefault(s =>
                                                       s.X.ApproxGreaterThanOrEqualTo(minX) &&
                                                       s.X.ApproxLessThanOrEqualTo(maxX) &&
                                                       s.Y.ApproxGreaterThanOrEqualTo(minY) &&
                                                       s.Y.ApproxLessThanOrEqualTo(maxY)
                );
            }
        }

        // Edge tracking for neighbour recording
        VoronoiEdge firstEdge = null!; // to "loop" last edge back to first
        VoronoiEdge? previousEdge = null; // to connect each new edge to previous edge
            
        BorderNode? node2 = null; // i.e. last node
            
        foreach (BorderNode node in nodes)
        {
            BorderNode? node1 = node2;
            node2 = node;

            if (node1 == null) // i.e. node == nodes.Min
                continue; // we are looking at first node, we will start from Min and next one

            VoronoiSite? site = previousEdgeNode != null ? previousEdgeNode is EdgeStartBorderNode ? previousEdgeNode.Edge.Right : previousEdgeNode.Edge.Left : defaultSite;

            if (node1.Point != node2.Point)
            {
                VoronoiEdge newEdge = new VoronoiEdge(
                    node1.Point,
                    node2.Point, // we are building these clockwise, so by definition the left side is out of bounds
                    site
                );

                // Record edge neighbours
                if (previousEdge != null)
                {
                    // Add the neighbours for the edge
                    newEdge.BorderNeighbour1 = previousEdge; // counter-clockwise = previous
                    previousEdge.BorderNeighbour2 = newEdge; // clockwise = next
                }
                else
                {
                    // Record the first created edge for the last edge to "loop" around
                    firstEdge = newEdge;
                }

                edges.Add(newEdge);

                if (site != null)
                    site.AddEdge(newEdge);

                previousEdge = newEdge;
            }
            else
            {
                // Skip this node, it's the same as last one, we don't need an edge between identical coordinates
                // Just move to the next node.
            }

            // Passing an edge node means that the site changes as we are now on the other side of this edge
            // (this doesn't happen in non-edge corner, which keep the same site)
            if (node is EdgeBorderNode cebn)
                previousEdgeNode = cebn;
        }

        VoronoiSite? finalSite = previousEdgeNode != null ? previousEdgeNode is EdgeStartBorderNode ? previousEdgeNode.Edge.Right : previousEdgeNode.Edge.Left : defaultSite;

        VoronoiEdge finalEdge = new VoronoiEdge(
            nodes.Max.Point,
            nodes.Min.Point, // we are building these clockwise, so by definition the left side is out of bounds
            finalSite
        );
            
        // Add the neighbours for the final edge
        finalEdge.BorderNeighbour1 = previousEdge; // counter-clockwise = previous
        previousEdge!.BorderNeighbour2 = finalEdge; // clockwise = next
            
        edges.Add(finalEdge);
            
        // And finish the neighbour edges by "looping" back to the first edge
        firstEdge.BorderNeighbour1 = finalEdge; // counter-clockwise = previous
        finalEdge.BorderNeighbour2 = firstEdge; // clockwise = next

        if (finalSite != null)
            finalSite.AddEdge(finalEdge);

        return edges;
    }
        

    private abstract class BorderNode
    {
        public abstract PointBorderLocation BorderLocation { get; }

        public abstract VoronoiPoint Point { get; }
            
        public abstract double Angle { get; }
            
        public abstract int FallbackComparisonIndex { get; }
            
            
        public int CompareAngleTo(BorderNode node2, PointBorderLocation pointBorderLocation)
        {
            // "Normal" Atan2 returns an angle between -π ≤ θ ≤ π as "seen" on the Cartesian plane,
            // that is, starting at the "right" of x axis and increasing counter-clockwise.
            // But we want the angle sortable (counter-)clockwise along each side.
            // So we cannot have the origin be "crossable" by the angle.
                
            //             0..-π or π
            //             ↓←←←←←←←←
            //             ↓       ↑  π/2..π
            //  -π/2..π/2  X       O  -π/2..-π
            //             ↑       ↓
            //             ↑←←←←←←←←
            //             0..π or -π

            // Now we need to decide how to compare them based on the side 
                
            double angle1 = Angle;
            double angle2 = node2.Angle;
                
            switch (pointBorderLocation)
            {
                case PointBorderLocation.Left:
                    // Angles are -π/2..π/2
                    // We don't need to adjust to have it in the same directly-comparable range
                    // Smaller angle comes first
                    break;

                case PointBorderLocation.Top:
                    // Angles are 0..-π or π
                    // We can swap π to -π
                    // Smaller angle comes first
                    if (angle1.ApproxGreaterThan(0)) angle1 -= 2 * Math.PI;
                    if (angle2.ApproxGreaterThan(0)) angle2 -= 2 * Math.PI;
                    break;

                case PointBorderLocation.Right:
                    // Angles are π/2..π or -π/2..-π
                    // We can swap <0 to >0
                    // Angles are now π/2..π or 3/2π..π, i.e. π/2..3/2π
                    if (angle1.ApproxLessThan(0)) angle1 += 2 * Math.PI;
                    if (angle2.ApproxLessThan(0)) angle2 += 2 * Math.PI;
                    break;
                    
                case PointBorderLocation.Bottom:
                    // Angles are 0..π or -π
                    // We can swap -π to π 
                    // Smaller angle comes first
                    if (angle1.ApproxLessThan(0)) angle1 += 2 * Math.PI;
                    if (angle2.ApproxLessThan(0)) angle2 += 2 * Math.PI;
                    break;

                case PointBorderLocation.TopRight:
                case PointBorderLocation.BottomRight:
                case PointBorderLocation.TopLeft:
                case PointBorderLocation.BottomLeft:
                case PointBorderLocation.NotOnBorder:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(pointBorderLocation), pointBorderLocation, null);
            }
                
            // Smaller angle comes first
            return angle1.ApproxCompareTo(angle2);
        }
            

#if DEBUG
        public override string ToString()
        {
            return Point + " @ " + BorderLocation;
        }
            
        public string ToString(string format)
        {
            return Point.ToString(format) + " @ " + BorderLocation;
        }
#endif
    }

    private abstract class EdgeBorderNode : BorderNode
    {
        public VoronoiEdge Edge { get; }

        public override int FallbackComparisonIndex { get; }


        protected EdgeBorderNode(VoronoiEdge edge, int fallbackComparisonIndex)
        {
            Edge = edge;
            FallbackComparisonIndex = fallbackComparisonIndex;
        }
    }

    private class EdgeStartBorderNode : EdgeBorderNode
    {
        public override PointBorderLocation BorderLocation => Edge.Start.BorderLocation;

        public override VoronoiPoint Point => Edge.Start;

        public override double Angle => Point.AngleTo(Edge.End); // away from border


        public EdgeStartBorderNode(VoronoiEdge edge, int fallbackComparisonIndex)
            : base(edge, fallbackComparisonIndex)
        {
        }
            
            
#if DEBUG
        public override string ToString()
        {
            return "Edge Start " + base.ToString();
        }
#endif
    }

    private class EdgeEndBorderNode : EdgeBorderNode
    {
        public override PointBorderLocation BorderLocation => Edge.End.BorderLocation;

        public override VoronoiPoint Point => Edge.End;
            
        public override double Angle => Point.AngleTo(Edge.Start); // away from border

            
        public EdgeEndBorderNode(VoronoiEdge edge, int fallbackComparisonIndex)
            : base(edge, fallbackComparisonIndex)
        {
        }
            
            
#if DEBUG
        public override string ToString()
        {
            return "Edge End " + base.ToString();
        }
#endif
    }

    private class CornerBorderNode : BorderNode
    {
        public override PointBorderLocation BorderLocation { get; }

        public override VoronoiPoint Point { get; }

        public override double Angle => throw new InvalidOperationException();
            
        public override int FallbackComparisonIndex => throw new InvalidOperationException();


        public CornerBorderNode(VoronoiPoint point)
        {
            BorderLocation = point.BorderLocation;
            Point = point;
        }

#if DEBUG
        public override string ToString()
        {
            return "Corner " + base.ToString();
        }
#endif
    }

    private class BorderNodeComparer : IComparer<BorderNode>
    {
        public int Compare(BorderNode n1, BorderNode n2)
        {
            int locationCompare = n1.BorderLocation.CompareTo(n2.BorderLocation);

            if (locationCompare != 0)
                return locationCompare;

            switch (n1.BorderLocation) // same for n2
            {
                case PointBorderLocation.Left: // going up
                case PointBorderLocation.BottomLeft:
                    return NodeCompareTo(n1.Point.Y, n2.Point.Y, n1, n2, n1.BorderLocation);

                case PointBorderLocation.Top: // going right
                case PointBorderLocation.TopLeft:
                    return NodeCompareTo(n1.Point.X, n2.Point.X, n1, n2, n1.BorderLocation);

                case PointBorderLocation.Right: // going down
                case PointBorderLocation.TopRight:
                    return NodeCompareTo(n2.Point.Y, n1.Point.Y, n1, n2, n1.BorderLocation);

                case PointBorderLocation.Bottom: // going left
                case PointBorderLocation.BottomRight:
                    return NodeCompareTo(n2.Point.X, n1.Point.X, n1, n2, n1.BorderLocation);
                        
                case PointBorderLocation.NotOnBorder:
                    throw new InvalidOperationException();
                        
                default:
                    throw new ArgumentOutOfRangeException();
            }

                
            static int NodeCompareTo(double coord1, double coord2,
                                     BorderNode node1, BorderNode node2, 
                                     PointBorderLocation pointBorderLocation)
            {
                int comparison = coord1.ApproxCompareTo(coord2);

                if (comparison != 0)
                    return comparison;

                int angleComparison = node1.CompareAngleTo(node2, pointBorderLocation);

                if (angleComparison != 0)
                    return angleComparison;

                // Extremely unlikely, but just return something that sorts and doesn't equate
                int fallbackComparison = node1.FallbackComparisonIndex.CompareTo(node2.FallbackComparisonIndex);
                    
                if (fallbackComparison != 0)
                    return fallbackComparison;

                throw new InvalidOperationException(); // we should never get here if fallback index is proper
            }
        }
    }
}