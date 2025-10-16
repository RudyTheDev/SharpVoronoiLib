#nullable disable // This code hasn't been converted to nullable yet

namespace SharpVoronoiLib;

/// <summary>
/// The dynamic structure (implemented as a red-black tree) that stores the sequence of arcs in Fortune's algorithm.
/// </summary>
internal class BeachLine
{
    private readonly RBTree<BeachSection> _beachLine;

    
    internal BeachLine()
    {
        _beachLine = new RBTree<BeachSection>();
    }

    
    /// <summary>
    /// Inserts a new arc for the given site event into the beach line and creates any edges/circle events implied by the insertion.
    /// </summary>
    /// <param name="siteEvent">The new site event</param>
    /// <param name="eventQueue">Global event queue to which new circle events are added</param>
    /// <param name="deleted">A set of circle events that have been invalidated and must be ignored when popped</param>
    /// <param name="edges">A list of Voronoi edges under construction (head contains most recent edges)</param>
    internal void AddBeachSection(FortuneSiteEvent siteEvent, MinHeap<FortuneEvent> eventQueue, List<VoronoiEdge> edges)
    {
        VoronoiSite site = siteEvent.Site;
        double x = site.X;
        double directrix = site.Y;

        FindSectionsForInsertion(x, directrix, out RBTreeNode<BeachSection> leftSection, out RBTreeNode<BeachSection> rightSection);

        // Our goal is to insert the new node between the left and right sections.
        BeachSection section = new BeachSection(site);

        // Left section could be null, in which case this node is the first in the tree.
        RBTreeNode<BeachSection> newSection = _beachLine.InsertSuccessor(leftSection, section);

        // New beach section is the first beach section to be added.
        if (leftSection == null && rightSection == null)
        {
            return;
        }

        // Main case: if both left section and right section point to the same valid arc
        // we need to split the arc into a left arc and a right arc with our new arc sitting in the middle.
        if (leftSection != null && leftSection == rightSection)
        {
            // If the arc has a circle event, it was a false alarm: remove it
            if (leftSection.Data.CircleEvent != null)
            {
                leftSection.Data.CircleEvent.Discarded = true;
                leftSection.Data.CircleEvent = null;
            }

            // We leave the existing arc as the left section in the tree, however we need to insert the
            // right section defined by the arc.
            BeachSection copy = new BeachSection(leftSection.Data.Site);
            rightSection = _beachLine.InsertSuccessor(newSection, copy);

            // Grab the projection of this site onto the parabola.
            double y = ParabolaMath.EvalParabola(leftSection.Data.Site.X, leftSection.Data.Site.Y, directrix, x);
            VoronoiPoint intersection = new VoronoiPoint(x, y);

            // Create the two half edges corresponding to this intersection
            VoronoiEdge leftEdge = new VoronoiEdge(intersection, site, leftSection.Data.Site);
            VoronoiEdge rightEdge = new VoronoiEdge(intersection, leftSection.Data.Site, site);
            leftEdge.LastBeachLineNeighbor = rightEdge;

            // Put the edge in the list
            edges.Add(leftEdge);

            // Store the left edge on each arc section
            newSection.Data.Edge = leftEdge;
            rightSection.Data.Edge = rightEdge;

            // Store neighbors for Delaunay triangulation
            leftSection.Data.Site.AddNeighbour(newSection.Data.Site);
            newSection.Data.Site.AddNeighbour(leftSection.Data.Site);

            // Create circle events
            CheckCircle(leftSection, eventQueue);
            CheckCircle(rightSection, eventQueue);
        }

        // Site is the last beach section on the beach line
        // This can only happen if all previous sites had the same y value
        else if (leftSection != null && rightSection == null)
        {
            VoronoiPoint start = new VoronoiPoint((leftSection.Data.Site.X + site.X) / 2, double.MinValue);
            VoronoiEdge infEdge = new VoronoiEdge(start, leftSection.Data.Site, site);
            VoronoiEdge newEdge = new VoronoiEdge(start, site, leftSection.Data.Site);

            newEdge.LastBeachLineNeighbor = infEdge;
            edges.Add(newEdge);

            leftSection.Data.Site.AddNeighbour(newSection.Data.Site);
            newSection.Data.Site.AddNeighbour(leftSection.Data.Site);

            newSection.Data.Edge = newEdge;

            // Can't check circles since they are colinear
        }

        // Site is directly above a break point
        else if (leftSection != null && leftSection != rightSection)
        {
            // Remove false alarms.
            if (leftSection.Data.CircleEvent != null)
            {
                leftSection.Data.CircleEvent.Discarded = true;
                leftSection.Data.CircleEvent = null;
            }

            if (rightSection.Data.CircleEvent != null)
            {
                rightSection.Data.CircleEvent.Discarded = true;
                rightSection.Data.CircleEvent = null;
            }

            // The breakpoint will disappear if we add this site which means we will create an edge.
            // We treat this very similar to a circle event since an edge is finishing at the center of the circle
            // created by circumscribing the left center and right sites.

            // Bring A to the origin
            VoronoiSite leftSite = leftSection.Data.Site;
            double ax = leftSite.X;
            double ay = leftSite.Y;
            double bx = site.X - ax;
            double by = site.Y - ay;

            VoronoiSite rightSite = rightSection.Data.Site;
            double cx = rightSite.X - ax;
            double cy = rightSite.Y - ay;
            double d = bx * cy - by * cx;
            double magnitudeB = bx * bx + by * by;
            double magnitudeC = cx * cx + cy * cy;
            VoronoiPoint vertex = new VoronoiPoint(
                (cy * magnitudeB - by * magnitudeC) / (2 * d) + ax,
                (bx * magnitudeC - cx * magnitudeB) / (2 * d) + ay);

            // If the edge ends up being 0 length (i.e. start and end are the same point),
            // then this is a location with 4+ equidistant sites.
            if (rightSection.Data.Edge.Start.ApproxEqual(vertex)) // i.e. what we would set as .End
            {
                // Reuse vertex (or we will have 2 ongoing points at the same location)
                vertex = rightSection.Data.Edge.Start;

                // Discard the edge
                rightSection.Data.Edge.Discard();
                edges.RemoveAsReference(rightSection.Data.Edge);
                // Note that this is very rare and the only time we do this, so having a List<> is fine

                // Disconnect (Delaunay) neighbours
                leftSite.RemoveNeighbour(rightSite);
                rightSite.RemoveNeighbour(leftSite);
            }
            else
            {
                rightSection.Data.Edge.End = vertex;
            }

            // Next we create two new edges
            newSection.Data.Edge = new VoronoiEdge(vertex, site, leftSection.Data.Site);
            rightSection.Data.Edge = new VoronoiEdge(vertex, rightSection.Data.Site, site);

            edges.Add(newSection.Data.Edge);
            edges.Add(rightSection.Data.Edge);

            // Add neighbors for Delaunay triangulation
            newSection.Data.Site.AddNeighbour(leftSection.Data.Site);
            leftSection.Data.Site.AddNeighbour(newSection.Data.Site);

            newSection.Data.Site.AddNeighbour(rightSection.Data.Site);
            rightSection.Data.Site.AddNeighbour(newSection.Data.Site);

            CheckCircle(leftSection, eventQueue);
            CheckCircle(rightSection, eventQueue);
        }
    }

    /// <summary>
    /// Removes the disappearing arc at a circle event from the beach line and finalizes edges
    /// </summary>
    internal void RemoveBeachSection(FortuneCircleEvent circle, MinHeap<FortuneEvent> eventQueue, List<VoronoiEdge> edges)
    {
        RBTreeNode<BeachSection> section = circle.ToDelete;
        double x = circle.X;
        double y = circle.YCenter;
        VoronoiPoint vertex = new VoronoiPoint(x, y);

        // Multiple edges could end here
        List<RBTreeNode<BeachSection>> toBeRemoved = [ ];

        // Look left
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

        foreach (RBTreeNode<BeachSection> remove in toBeRemoved)
        {
            remove.Data.Edge.End = vertex;
            remove.Next.Data.Edge.End = vertex;
            remove.Data.CircleEvent.Discarded = true;
            remove.Data.CircleEvent = null;
        }

        // Need to delete all upcoming circle events with this node
        if (prev.Data.CircleEvent != null)
        {
            prev.Data.CircleEvent.Discarded = true;
            prev.Data.CircleEvent = null;
        }
        if (next.Data.CircleEvent != null)
        {
            next.Data.CircleEvent.Discarded = true;
            next.Data.CircleEvent = null;
        }

        // Create a new edge with start point at the vertex and assign it to next
        VoronoiEdge newEdge = new VoronoiEdge(vertex, next.Data.Site, prev.Data.Site);
        next.Data.Edge = newEdge;
        edges.Add(newEdge);

        // Add neighbors for Delaunay triangulation
        prev.Data.Site.AddNeighbour(next.Data.Site);
        next.Data.Site.AddNeighbour(prev.Data.Site);

        // Remove the section from the tree
        _beachLine.RemoveNode(section);
        foreach (RBTreeNode<BeachSection> remove in toBeRemoved)
        {
            _beachLine.RemoveNode(remove);
        }

        CheckCircle(prev, eventQueue);
        CheckCircle(next, eventQueue);
    }

    /// <summary>
    /// Computes the x-coordinate of the left breakpoint between the given node's arc and its left neighbor for the provided directrix.
    /// </summary>
    private static double LeftBreakpoint(RBTreeNode<BeachSection> node, double directrix)
    {
        RBTreeNode<BeachSection> leftNode = node.Previous;
        // Degenerate parabola
        if ((node.Data.Site.Y - directrix).ApproxEqual(0))
            return node.Data.Site.X;
        // Node is the first piece of the beach line
        if (leftNode == null)
            return double.NegativeInfinity;
        // Left node is degenerate
        if ((leftNode.Data.Site.Y - directrix).ApproxEqual(0))
            return leftNode.Data.Site.X;
        VoronoiSite site = node.Data.Site;
        VoronoiSite leftSite = leftNode.Data.Site;
        return ParabolaMath.IntersectParabolaX(leftSite.X, leftSite.Y, site.X, site.Y, directrix);
    }

    /// <summary>
    /// Computes the x-coordinate of the right breakpoint between the given node's arc and its right neighbor for the provided directrix.
    /// </summary>
    private static double RightBreakpoint(RBTreeNode<BeachSection> node, double directrix)
    {
        RBTreeNode<BeachSection> rightNode = node.Next;
        // Degenerate parabola
        if ((node.Data.Site.Y - directrix).ApproxEqual(0))
            return node.Data.Site.X;
        // Node is the last piece of the beach line
        if (rightNode == null)
            return double.PositiveInfinity;
        // Right node is degenerate
        if ((rightNode.Data.Site.Y - directrix).ApproxEqual(0))
            return rightNode.Data.Site.X;
        VoronoiSite site = node.Data.Site;
        VoronoiSite rightSite = rightNode.Data.Site;
        return ParabolaMath.IntersectParabolaX(site.X, site.Y, rightSite.X, rightSite.Y, directrix);
    }

    /// <summary>
    /// Creates a circle event for the given center section if appropriate, queuing it for processing
    /// </summary>
    private static void CheckCircle(RBTreeNode<BeachSection> section, MinHeap<FortuneEvent> eventQueue)
    {
        RBTreeNode<BeachSection> left = section.Previous;
        RBTreeNode<BeachSection> right = section.Next;
        if (left == null || right == null)
            return;

        VoronoiSite leftSite = left.Data.Site;
        VoronoiSite centerSite = section.Data.Site;
        VoronoiSite rightSite = right.Data.Site;

        // If the left arc and right arc are defined by the same focus, the two arcs cannot converge
        if (leftSite == rightSite)
        {
            // TODO: this is never covered by unit tests; need to figure out what triggers this and add a test, or if this is unreachable?
            return;
        }

        // MATH HACKS: place center at origin and draw vectors a and c to left and right respectively
        double bx = centerSite.X,
            by = centerSite.Y,
            ax = leftSite.X - bx,
            ay = leftSite.Y - by,
            cx = rightSite.X - bx,
            cy = rightSite.Y - by;

        // The center beach section can only disappear when the angle between a and c is negative
        double d = ax * cy - ay * cx;
        if (d.ApproxGreaterThanOrEqualTo(0))
            return;

        double magnitudeA = ax * ax + ay * ay;
        double magnitudeC = cx * cx + cy * cy;
        double x = (cy * magnitudeA - ay * magnitudeC) / (2 * d);
        double y = (ax * magnitudeC - cx * magnitudeA) / (2 * d);

        // Add back offset
        double ycenter = y + by;
        // y center is off
        FortuneCircleEvent circleEvent = new FortuneCircleEvent(
            new VoronoiPoint(x + bx, ycenter + Math.Sqrt(x * x + y * y)),
            ycenter, section
        );
        section.Data.CircleEvent = circleEvent;

        eventQueue.Insert(circleEvent);
    }

    /// <summary>
    /// Finds the immediate left and right beach sections above the site (x, directrix).
    /// </summary>
    private void FindSectionsForInsertion(double x, double directrix, out RBTreeNode<BeachSection> leftSection, out RBTreeNode<BeachSection> rightSection)
    {
        leftSection = null;
        rightSection = null;

        RBTreeNode<BeachSection> node = _beachLine.Root;

        // Find the parabola(s) above this site.
        while (node != null && leftSection == null && rightSection == null)
        {
            double distanceLeft = LeftBreakpoint(node, directrix) - x;
            if (distanceLeft > 0)
            {
                // The new site is before the left breakpoint.
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
                // The new site is after the right breakpoint.
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

            // The point lies below the left breakpoint.
            if (distanceLeft.ApproxEqual(0))
            {
                leftSection = node.Previous;
                rightSection = node;
                continue;
            }

            // The point lies below the right breakpoint.
            if (distanceRight.ApproxEqual(0))
            {
                leftSection = node;
                rightSection = node.Next;
                continue;
            }

            // distanceRight < 0 and distanceLeft < 0 => this section is above the new site.
            leftSection = rightSection = node;
        }
    }
}