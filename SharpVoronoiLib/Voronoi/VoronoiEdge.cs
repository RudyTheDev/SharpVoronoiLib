using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace SharpVoronoiLib;

/// <summary>
/// The line segment making the Voronoi cells, i.e. the points equidistant to the two nearest Voronoi sites.
/// These are the lines in the <see cref="VoronoiSite.Cell"/>.
/// This has <see cref="VoronoiPoint"/> end points, i.e. <see cref="Start"/> and <see cref="End"/>.
/// This has the two <see cref="VoronoiSite"/>s they separate, i.e. <see cref="Right"/> and <see cref="Left"/>.
/// This connects in a <see cref="Neighbours"/> node graph to other <see cref="VoronoiEdge"/>s, i.e. shares end points with them.
/// </summary>
public class VoronoiEdge
{
    /// <summary>
    /// One of the two points making up this line segment, the other being <see cref="End"/>.
    /// Note that the order of start/<see cref="End"/> points is random.
    /// </summary>
    [PublicAPI]
    public VoronoiPoint Start { get; internal set; }
        
    /// <summary>
    /// One of the two points making up this line segment, the other being <see cref="Start"/>.
    /// Note that the order of <see cref="Start"/>/end points is random.
    /// </summary>
    [PublicAPI]
    public VoronoiPoint End { get; internal set; } = null!; // it will be set eventually if not immediatelly from constructor

    /// <summary>
    /// One of the two sites that this edge separates, the other being <see cref="Left"/>.
    /// Can be null if this is a border edge and there are no sites within the bounds.
    /// </summary>
    [PublicAPI]
    public VoronoiSite? Right { get; }

    /// <summary>
    /// One of the two sites that this edge separates, the other being <see cref="Right"/>.
    /// Can be null if this is a border edge.
    ///  </summary>
    [PublicAPI]
    public VoronoiSite? Left { get; }


    /// <summary>
    /// The mid-point between <see cref="Start"/> and <see cref="End"/> points.
    /// </summary>
    [PublicAPI]
    public VoronoiPoint Mid
    {
        get
        {
            // todo: make null/undefined when the End is infinite
                
            if (_mid == null)
                _mid = new VoronoiPoint((Start.X + End!.X) / 2, (Start.Y + End.Y) / 2);
            // Note that .End is guaranteed to be set since we don't expose edges extrenally that aren't clipped in bounds

            return _mid;
        }
    }
        
    [PublicAPI]
    public IEnumerable<VoronoiEdge> Neighbours
    {
        get
        {
            if (_neighbours == null)
            {
                _neighbours = new List<VoronoiEdge>();

                // Special case - we are a border edge with no sites on the plane
                if (Left == null && Right == null)
                {
                    // This is an annoying case because there are no sites, so there's nothing to loop around to find the edges.
                    // So we have to explicitly keep track of the two neighbouring edge as we close the borders.
                    // We can then use these for this special case.
                        
                    _neighbours.Add(BorderNeighbour2!);
                    _neighbours.Add(BorderNeighbour1!);
                        
                    return _neighbours;
                }

                // Gather edges that connect to either of our end points.
                // We will loop "around" both points through the sites that have them,
                // and record the edges that connect to the points.
                // We may encounter the border, so then we also go the other way around for that point.
                    
                //         C                     D                             
                //           \        3        /                               
                //             \             /                                 
                //               \         /                                   
                //                 \     /                                    
                //                   \ /                                       
                //                    A                                        
                //                    #                                        
                //          1         #         2                              
                //                    #                                        
                //                    #                                        
                //   E----------------B-----------------G                                        
                //                    |                                       
                //                    |                                       
                //          4         |         3                             
                //                    |                                       
                //                    |                                       
                //                    F
                //
                // Suppose our edge is the #### one.
                // We have two end points A and B.
                // We will loop around the point A going to site 2 (noting that site 1 is on the other end).
                // At site 2 we will find two edges that share the point A: A-B and A-D.
                // A-B is where we came from, so we ignore that.
                // A-D must then be a neighbour, which we record.
                // We continue to loop around the A point, now going to site 3 across A-D.
                // Here we find A-D and A-C around A, so we choose A-C as a neighbour (A-D is where we came from).
                // We see that the next site is site 1, which we noted before as the first/starting site.
                // So we are done with point A (in this loop we added A-D and A-C as neighbour).
                // Now loop around point B, starting at site 2.
                // At 2, we find B-G; at 3 we find B-F; at 4 we find B-E and finish as we reach 1.
                // We now have all the neighbours - A-D, A-C, B-G, B-F, B-E.
                // Here, both loops did not encounter missing sites (no further edges), so consider instead:
                //         \                     /                             
                //           \        ·        /                               
                //             \             /                                 
                //               \         /                                   
                //                 \     /                                    
                //                   \ /                                       
                //                    A                                        
                //                    #                                        
                //          1         #         2                              
                //                    #                                        
                //                    #                                        
                //   E----------------B-----------------G 
                // This time, we loop around B starting at 2.
                // At site 2, we find A-B and B-G; we dismiss A-B and we record B-G.
                // But now we have no site on the other side of B-G.
                // Our loop around B notes that it encountered a "missing" site.
                // We see this back at start and loop again around B but to the other side, i.e. site 1.
                // At site 1 we find A-B and B-E; we dismiss A-B and we record B-E.
                // Again, we have a case with no site on the other side of B-E.
                // But now we have looped in both direction and reached the border (or corner) both times.
                // One can think of the "missing" site as the "out of bounds site" -
                // we reached it in both loop directions and recorded both its edges, so we're done.
                // Similar case happens with multiple edges meeting at the border.
                    
                if (!GatherNeighbours(Start, this, Right!, Left))
                    if (Left != null)
                        GatherNeighbours(Start, this, Left, null);
                    
                if (!GatherNeighbours(End, this, Right!, Left))
                    if (Left != null)
                        GatherNeighbours(End, this, Left, null);

                bool GatherNeighbours(VoronoiPoint aroundPoint, VoronoiEdge comingFromEdge, VoronoiSite comingIntoSite, VoronoiSite? ultimateSite)
                {
                    foreach (VoronoiEdge edge in comingIntoSite.Cell)
                    {
                        if (edge == comingFromEdge)
                            continue; // this would be the edge we came from, we need the other edge
                            
                        if (edge.Start == aroundPoint || 
                            edge.End == aroundPoint)
                        {
                            // This edge is connected to us, so we can add it to the list
                            _neighbours.Add(edge);

                            // Continue circling around the point,
                            // now past the newfound edge
                                
                            // We came from one side of the edge, so we go to the other side
                            VoronoiSite? nextSite = edge.Left == comingIntoSite ? edge.Right : edge.Left;

                            if (nextSite != null) // this we could be a border edge, in which case we can't continue
                            {
                                if (ultimateSite != null && // the other side of the original edge could have been a border/void
                                    nextSite == ultimateSite) // we reached the other side of the original edge, so no more edges remain around this point
                                    return true; // we completed the "circle"

                                // Go the next site
                                return GatherNeighbours(aroundPoint, edge, nextSite, ultimateSite);
                            }
                            else
                            {
                                // We encountered an edge with no site on the other side, which means it's a border edge.
                                // We must tell the caller to loop the other way now, since we cannot finish our "circle".
                                return false; // we didn't complete the "circle"
                            }
                        }
                        else
                        {
                            if (edge.Start.ApproxEqual(aroundPoint)) throw new InvalidOperationException("Equal but not same " + edge.Start + " and " + aroundPoint);
                            if (edge.End.ApproxEqual(aroundPoint)) throw new InvalidOperationException("Equal but not same " + edge.End + " and " + aroundPoint);
                        }
                    }

                    // This means the only edge shared with this cell was the common edge and there's no second edge
                    // We must tell the caller to loop the other way now, since we cannot assume we finished our "circle".
                    return false; // we didn't complete the "circle"
                }
            }

            return _neighbours;
        }
    }

    /// <summary>
    /// The length of this line segment, i.e. the distance between <see cref="Start"/> and <see cref="End"/> points.
    /// </summary>
    [PublicAPI]
    public double Length
    {
        get
        {
            if (_length == null)
            {
                double xd = End.X - Start.X;
                double yd = End.Y - Start.Y;
                _length = Math.Sqrt(xd * xd + yd * yd);
            }

            return _length.Value;
        }
    }

        
    internal VoronoiEdge? BorderNeighbour1 { get; set; }
    internal VoronoiEdge? BorderNeighbour2 { get; set; }
        
    internal double SlopeRise { get; }
    internal double SlopeRun { get; }
    internal double? Slope { get; }
    internal double? Intercept { get; }
    internal VoronoiEdge? LastBeachLineNeighbor { get; set; } // I am not entirely sure this is the right name for this, but I just want to make it clear it's not something usable publicly

        
    private VoronoiPoint? _mid;
    private List<VoronoiEdge>? _neighbours;
    private double? _length;

        
    internal VoronoiEdge(VoronoiPoint start, VoronoiSite left, VoronoiSite right)
    {
        Start = start;
        Left = left;
        Right = right;
            
        // Suspending this check because this never happens
        // //for bounding box edges
        // if (left == null || right == null)
        //     return;

        //from negative reciprocal of slope of line from left to right
        //ala m = (left.y -right.y / left.x - right.x)
        SlopeRise = left.X - right.X;
        SlopeRun = -(left.Y - right.Y);
        Intercept = null;

        if (SlopeRise.ApproxEqual(0) || SlopeRun.ApproxEqual(0)) return;
        Slope = SlopeRise/SlopeRun;
        Intercept = start.Y - Slope*start.X;
    }
        
    internal VoronoiEdge(VoronoiPoint start, VoronoiPoint end, VoronoiSite? right)
    {
        Start = start;
        End = end;
        Right = right;
            
        // Don't bother with slope stuff if we are given explicit coords
    }
        
    internal VoronoiEdge(VoronoiPoint start, VoronoiPoint end, VoronoiSite? right, VoronoiSite? left)
    {
        Start = start;
        End = end;
        Right = right;
        Left = left;
    }
        
    internal VoronoiEdge Reversed()
    {
        return new VoronoiEdge(End, Start, Left, Right);
    }


#if DEBUG
    public override string ToString()
    {
        return (Start?.ToString() ?? "NONE") + "->" + (End?.ToString() ?? "NONE");
    }
        
    public string ToString(string format)
    {
        return (Start?.ToString(format) ?? "NONE") + "->" + (End?.ToString(format) ?? "NONE");
    }
#endif
}