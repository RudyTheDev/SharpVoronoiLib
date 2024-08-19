using System;
using System.Collections.Generic;

namespace SharpVoronoiLib
{
    internal class BeachSection
    {
        internal VoronoiSite Site { get;}
        internal VoronoiEdge Edge { get; set; }
        //NOTE: this will change
        internal FortuneCircleEvent CircleEvent { get; set; }

        internal BeachSection(VoronoiSite site)
        {
            Site = site;
            CircleEvent = null;
        }
    }

    internal class BeachLine
    {
        private readonly RBTree<BeachSection> beachLine;

        internal BeachLine()
        {
            beachLine = new RBTree<BeachSection>();
        }

        internal void AddBeachSection(FortuneSiteEvent siteEvent, SortedSet<FortuneEvent> eventQueue, HashSet<FortuneCircleEvent> deleted, LinkedList<VoronoiEdge> edges)
        {
            VoronoiSite site = siteEvent.Site;
            double x = site.X;
            double directrix = site.Y;

            RBTreeNode<BeachSection> leftSection = null;
            RBTreeNode<BeachSection> rightSection = null;
            RBTreeNode<BeachSection> node = beachLine.Root;

            //find the parabola(s) above this site
            while (node != null && leftSection == null && rightSection == null)
            {
                double distanceLeft = LeftBreakpoint(node, directrix) - x;
                if (distanceLeft > 0)
                {
                    //the new site is before the left breakpoint
                    if (node.Left == null)
                    {
                        // TODO: this is never covered by unit tests; need to figure out what triggers this and add a test, or if this is unreachable?
                        rightSection = node;
                    }
                    else
                    {
                        node = node.Left;
                    }
                    continue;
                }

                double distanceRight = x - RightBreakpoint(node, directrix);
                if (distanceRight > 0)
                {
                    //the new site is after the right breakpoint
                    if (node.Right == null)
                    {
                        leftSection = node;
                    }
                    else
                    {
                        node = node.Right;
                    }
                    continue;
                }

                //the point lies below the left breakpoint
                if (distanceLeft.ApproxEqual(0))
                {
                    leftSection = node.Previous;
                    rightSection = node;
                    continue;
                }

                //the point lies below the right breakpoint
                if (distanceRight.ApproxEqual(0))
                {
                    leftSection = node;
                    rightSection = node.Next;
                    continue;
                }

                // distance Right < 0 and distance Left < 0
                // this section is above the new site
                leftSection = rightSection = node;
            }

            //our goal is to insert the new node between the
            //left and right sections
            BeachSection section = new BeachSection(site);

            //left section could be null, in which case this node is the first
            //in the tree
            RBTreeNode<BeachSection> newSection = beachLine.InsertSuccessor(leftSection, section);

            //new beach section is the first beach section to be added
            if (leftSection == null && rightSection == null)
            {
                return;
            }

            //main case:
            //if both left section and right section point to the same valid arc
            //we need to split the arc into a left arc and a right arc with our
            //new arc sitting in the middle
            if (leftSection != null && leftSection == rightSection)
            {
                //if the arc has a circle event, it was a false alarm.
                //remove it
                if (leftSection.Data.CircleEvent != null)
                {
                    if (!deleted.Add(leftSection.Data.CircleEvent))
                        throw new Exception();
                    
                    leftSection.Data.CircleEvent = null;
                }

                //we leave the existing arc as the left section in the tree
                //however we need to insert the right section defined by the arc
                BeachSection copy = new BeachSection(leftSection.Data.Site);
                rightSection = beachLine.InsertSuccessor(newSection, copy);

                //grab the projection of this site onto the parabola
                double y = ParabolaMath.EvalParabola(leftSection.Data.Site.X, leftSection.Data.Site.Y, directrix, x);
                VoronoiPoint intersection = new VoronoiPoint(x, y);

                //create the two half edges corresponding to this intersection
                VoronoiEdge leftEdge = new VoronoiEdge(intersection, site, leftSection.Data.Site);
                VoronoiEdge rightEdge = new VoronoiEdge(intersection, leftSection.Data.Site, site);
                leftEdge.LastBeachLineNeighbor = rightEdge;

                //put the edge in the list
                edges.AddFirst(leftEdge);

                //store the left edge on each arc section
                newSection.Data.Edge = leftEdge;
                rightSection.Data.Edge = rightEdge;

                //store neighbors for delaunay
                leftSection.Data.Site.AddNeighbour(newSection.Data.Site);
                newSection.Data.Site.AddNeighbour(leftSection.Data.Site);

                //create circle events
                CheckCircle(leftSection, eventQueue);
                CheckCircle(rightSection, eventQueue);
            }

            //site is the last beach section on the beach line
            //this can only happen if all previous sites
            //had the same y value
            else if (leftSection != null && rightSection == null)
            {
                VoronoiPoint start = new VoronoiPoint((leftSection.Data.Site.X + site.X)/ 2, double.MinValue);
                VoronoiEdge infEdge = new VoronoiEdge(start, leftSection.Data.Site, site);
                VoronoiEdge newEdge = new VoronoiEdge(start, site, leftSection.Data.Site);

                newEdge.LastBeachLineNeighbor = infEdge;
                edges.AddFirst(newEdge);

                leftSection.Data.Site.AddNeighbour(newSection.Data.Site);
                newSection.Data.Site.AddNeighbour(leftSection.Data.Site);

                newSection.Data.Edge = newEdge;

                //cant check circles since they are colinear
            }

            //site is directly above a break point
            else if (leftSection != null && leftSection != rightSection)
            {
                //remove false alarms
                if (leftSection.Data.CircleEvent != null)
                {
                    if (!deleted.Add(leftSection.Data.CircleEvent))
                        throw new Exception();
                    
                    leftSection.Data.CircleEvent = null;
                }

                if (rightSection.Data.CircleEvent != null)
                {
                    if (!deleted.Add(rightSection.Data.CircleEvent))
                        throw new Exception();
                    
                    rightSection.Data.CircleEvent = null;
                }

                //the breakpoint will dissapear if we add this site
                //which means we will create an edge
                //we treat this very similar to a circle event since
                //an edge is finishing at the center of the circle
                //created by circumscribing the left center and right
                //sites

                //bring a to the origin
                VoronoiSite leftSite = leftSection.Data.Site;
                double ax = leftSite.X;
                double ay = leftSite.Y;
                double bx = site.X - ax;
                double by = site.Y - ay;

                VoronoiSite rightSite = rightSection.Data.Site;
                double cx = rightSite.X - ax;
                double cy = rightSite.Y - ay;
                double d = bx*cy - by*cx;
                double magnitudeB = bx*bx + by*by;
                double magnitudeC = cx*cx + cy*cy;
                VoronoiPoint vertex = new VoronoiPoint(
                    (cy*magnitudeB - by * magnitudeC)/(2*d) + ax,
                    (bx*magnitudeC - cx * magnitudeB)/(2*d) + ay);


                // If the edge ends up being 0 length (i.e. start and end are the same point),
                // then this is a location with 4+ equidistant sites.
                if (rightSection.Data.Edge.Start.ApproxEqual(vertex)) // i.e. what we would set as .End
                {
                    // Reuse vertex (or we will have 2 ongoing points at the same location)
                    vertex = rightSection.Data.Edge.Start;

                    // Discard the edge
                    edges.Remove(rightSection.Data.Edge);

                    // Disconnect (delaunay) neighbours
                    leftSite.RemoveNeighbour(rightSite);
                    rightSite.RemoveNeighbour(leftSite);
                }
                else
                {
                    rightSection.Data.Edge.End = vertex;
                }

                //next we create a two new edges
                newSection.Data.Edge = new VoronoiEdge(vertex, site, leftSection.Data.Site);
                rightSection.Data.Edge = new VoronoiEdge(vertex, rightSection.Data.Site, site);

                edges.AddFirst(newSection.Data.Edge);
                edges.AddFirst(rightSection.Data.Edge);

                //add neighbors for delaunay
                newSection.Data.Site.AddNeighbour(leftSection.Data.Site);
                leftSection.Data.Site.AddNeighbour(newSection.Data.Site);

                newSection.Data.Site.AddNeighbour(rightSection.Data.Site);
                rightSection.Data.Site.AddNeighbour(newSection.Data.Site);

                CheckCircle(leftSection, eventQueue);
                CheckCircle(rightSection, eventQueue);
            }
        }

        internal void RemoveBeachSection(FortuneCircleEvent circle, SortedSet<FortuneEvent> eventQueue, HashSet<FortuneCircleEvent> deleted, LinkedList<VoronoiEdge> edges)
        {
            RBTreeNode<BeachSection> section = circle.ToDelete;
            double x = circle.X;
            double y = circle.YCenter;
            VoronoiPoint vertex = new VoronoiPoint(x, y);

            //multiple edges could end here
            List<RBTreeNode<BeachSection>> toBeRemoved = new List<RBTreeNode<BeachSection>>();

            //look left
            RBTreeNode<BeachSection> prev = section.Previous;
            while (prev.Data.CircleEvent != null &&
                   x.ApproxEqual(prev.Data.CircleEvent.X) &&
                   y.ApproxEqual(prev.Data.CircleEvent.YCenter))
            {
                toBeRemoved.Add(prev);
                prev = prev.Previous;
            }

            RBTreeNode<BeachSection> next = section.Next;
            while (next.Data.CircleEvent != null &&
                   x.ApproxEqual(next.Data.CircleEvent.X) &&
                   y.ApproxEqual(next.Data.CircleEvent.YCenter))
            {
                toBeRemoved.Add(next);
                next = next.Next;
            }

            section.Data.Edge.End = vertex;
            section.Next.Data.Edge.End = vertex;
            section.Data.CircleEvent = null;

            //odds are this double writes a few edges but this is clean...
            foreach (RBTreeNode<BeachSection> remove in toBeRemoved)
            {
                remove.Data.Edge.End = vertex;
                remove.Next.Data.Edge.End = vertex;
                if (!deleted.Add(remove.Data.CircleEvent))
                    throw new Exception();
                remove.Data.CircleEvent = null;
            }


            //need to delete all upcoming circle events with this node
            if (prev.Data.CircleEvent != null)
            {
                if (!deleted.Add(prev.Data.CircleEvent))
                    throw new Exception();
                prev.Data.CircleEvent = null;
            }
            if (next.Data.CircleEvent != null)
            {
                if (!deleted.Add(next.Data.CircleEvent))
                    throw new Exception();
                next.Data.CircleEvent = null;
            }


            //create a new edge with start point at the vertex and assign it to next
            VoronoiEdge newEdge = new VoronoiEdge(vertex, next.Data.Site, prev.Data.Site);
            next.Data.Edge = newEdge;
            edges.AddFirst(newEdge);

            //add neighbors for delaunay
            prev.Data.Site.AddNeighbour(next.Data.Site);
            next.Data.Site.AddNeighbour(prev.Data.Site);

            //remove the sectionfrom the tree
            beachLine.RemoveNode(section);
            foreach (RBTreeNode<BeachSection> remove in toBeRemoved)
            {
                beachLine.RemoveNode(remove);
            }

            CheckCircle(prev, eventQueue);
            CheckCircle(next, eventQueue);
        }

        private static double LeftBreakpoint(RBTreeNode<BeachSection> node, double directrix)
        {
            RBTreeNode<BeachSection> leftNode = node.Previous;
            //degenerate parabola
            if ((node.Data.Site.Y - directrix).ApproxEqual(0))
                return node.Data.Site.X;
            //node is the first piece of the beach line
            if (leftNode == null)
                return double.NegativeInfinity;
            //left node is degenerate
            if ((leftNode.Data.Site.Y - directrix).ApproxEqual(0))
                return leftNode.Data.Site.X;
            VoronoiSite site = node.Data.Site;
            VoronoiSite leftSite = leftNode.Data.Site;
            return ParabolaMath.IntersectParabolaX(leftSite.X, leftSite.Y, site.X, site.Y, directrix);
        }

        private static double RightBreakpoint(RBTreeNode<BeachSection> node, double directrix)
        {
            RBTreeNode<BeachSection> rightNode = node.Next;
            //degenerate parabola
            if ((node.Data.Site.Y - directrix).ApproxEqual(0))
                return node.Data.Site.X;
            //node is the last piece of the beach line
            if (rightNode == null)
                return double.PositiveInfinity;
            //left node is degenerate
            if ((rightNode.Data.Site.Y - directrix).ApproxEqual(0))
                return rightNode.Data.Site.X;
            VoronoiSite site = node.Data.Site;
            VoronoiSite rightSite = rightNode.Data.Site;
            return ParabolaMath.IntersectParabolaX(site.X, site.Y, rightSite.X, rightSite.Y, directrix);
        }

        private static void CheckCircle(RBTreeNode<BeachSection> section, SortedSet<FortuneEvent> eventQueue)
        {
            //if (section == null)
            //    return;
            RBTreeNode<BeachSection> left = section.Previous;
            RBTreeNode<BeachSection> right = section.Next;
            if (left == null || right == null)
                return;

            VoronoiSite leftSite = left.Data.Site;
            VoronoiSite centerSite = section.Data.Site;
            VoronoiSite rightSite = right.Data.Site;

            //if the left arc and right arc are defined by the same
            //focus, the two arcs cannot converge
            if (leftSite == rightSite)
            {
                // TODO: this is never covered by unit tests; need to figure out what triggers this and add a test, or if this is unreachable?
                return;
            }

            //MATH HACKS: place center at origin and
            //draw vectors a and c to
            //left and right respectively
            double bx = centerSite.X,
                by = centerSite.Y,
                ax = leftSite.X - bx,
                ay = leftSite.Y - by,
                cx = rightSite.X - bx,
                cy = rightSite.Y - by;

            //The center beach section can only dissapear when
            //the angle between a and c is negative
            double d = ax*cy - ay*cx;
            if (d.ApproxGreaterThanOrEqualTo(0))
                return;

            double magnitudeA = ax*ax + ay*ay;
            double magnitudeC = cx*cx + cy*cy;
            double x = (cy*magnitudeA - ay*magnitudeC)/(2*d);
            double y = (ax*magnitudeC - cx*magnitudeA)/(2*d);

            //add back offset
            double ycenter = y + by;
            //y center is off
            FortuneCircleEvent circleEvent = new FortuneCircleEvent(
                new VoronoiPoint(x + bx, ycenter + Math.Sqrt(x * x + y * y)),
                ycenter, section
            );
            section.Data.CircleEvent = circleEvent;
            eventQueue.Add(circleEvent); // this is allowed to "fail"
        }
    }
}
