﻿using System.Collections.Generic;
using JetBrains.Annotations;

namespace VoronoiLib.Structures
{
    public class VoronoiEdge
    {
        public VoronoiPoint Start { get; internal set; }
        public VoronoiPoint? End { get; internal set; }
        
        public VoronoiSite? Left { get; }
        public VoronoiSite? Right { get; }
        
        
        [PublicAPI]
        public VoronoiPoint Mid
        {
            get
            {
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

                    if (Left != null)
                    {
                        List<VoronoiEdge> leftPointCell = Left.cell;

                        foreach (VoronoiEdge edge in leftPointCell)
                            if (edge != this) // one of its edges is us by definition
                                if (edge.Start == Start || edge.End == End || edge.Start == End || edge.End == Start)
                                    _neighbours.Add(edge);
                    }

                    if (Right != null)
                    {
                        List<VoronoiEdge> rightPointCell = Right.cell;

                        foreach (VoronoiEdge edge in rightPointCell)
                            if (edge != this) // one of its edges is us by definition
                                if (edge.Start == Start || edge.End == End || edge.Start == End || edge.End == Start)
                                    _neighbours.Add(edge);
                    }

                    // Note that this only works when assuming that edge end points can have 2 neighbours,
                    // that is, 4+ equidistant points actually create an additional 0-length edge.
                    // And this is indeed how the algorithm works at the moment.
                    // This makes this neighbour lookup simpler (one doesn't need to recursively "walk around" the edge end point).
                    
                    // There is a special case though, the border edges that have non-tesselated "void" as their neighbour.
                    // These only have one site, so the above logic can't handle connections on the border (which is any clipped edge).
                    // One neighbour will be part of the site, but the other neighbour will be part of some other cell that we don't know about.
                    // Thankfully, we can solve this without much additional work just by explicitly keeping those two neighbours recorded when closing the border.
                    
                    if (ClockwiseNeighbourBorder != null)
                        if (!_neighbours.Contains(ClockwiseNeighbourBorder)) 
                            _neighbours.Add(ClockwiseNeighbourBorder);        
                    
                    if (CounterclockwiseNeighbourBorder != null)
                        if (!_neighbours.Contains(CounterclockwiseNeighbourBorder))
                            _neighbours.Add(CounterclockwiseNeighbourBorder);
                }

                return _neighbours;
            }
        }
        
        internal VoronoiEdge? CounterclockwiseNeighbourBorder { get; set; }
        internal VoronoiEdge? ClockwiseNeighbourBorder { get; set; }

        internal double SlopeRise { get; }
        internal double SlopeRun { get; }
        internal double? Slope { get; }
        internal double? Intercept { get; }
        internal VoronoiEdge? LastBeachLineNeighbor { get; set; } // I am not entirely sure this is the right name for this, but I just want to make it clear it's not something usable publicly

        private VoronoiPoint? _mid;
        private List<VoronoiEdge>? _neighbours;
        
        
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
        
        internal VoronoiEdge(VoronoiPoint start, VoronoiPoint end, VoronoiSite? left, VoronoiSite? right)
        {
            Start = start;
            End = end;
            Left = left;
            Right = right;
            
            // Don't bother with slope stuff if we are given explicit coords
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
}
