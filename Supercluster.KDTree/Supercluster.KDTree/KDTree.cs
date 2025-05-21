namespace Supercluster.KDTree;

using System;
using System.Collections.Generic;
using System.Linq;

using Utilities;
using static Utilities.BinaryTreeNavigation;

/// <summary>
/// Represents a KD-Tree. KD-Trees are used for fast spatial searches. Searching in a
/// balanced KD-Tree is O(log n) where linear search is O(n). Points in the KD-Tree are
/// equi-length arrays of doubles. The node objects associated
/// with the points is an array of type <typeparamref name="TNode"/>.
/// </summary>
/// <remarks>
/// KDTrees can be fairly difficult to understand at first. The following references helped me
/// understand what exactly a KDTree is doing and the contain the best descriptions of searches in a KDTree.
/// Samet's book is the best reference of multidimensional data structures I have ever seen. Wikipedia is also a good starting place.
/// References:
/// <ul style="list-style-type:none">
/// <li> <a href="http://store.elsevier.com/product.jsp?isbn=9780123694461">Foundations of Multidimensional and Metric Data Structures, 1st Edition, by Hanan Samet. ISBN: 9780123694461</a> </li>
/// <li> <a href="https://en.wikipedia.org/wiki/K-d_tree"> https://en.wikipedia.org/wiki/K-d_tree</a> </li>
/// </ul>
/// </remarks>
/// <typeparam name="TNode">The type representing the actual node objects.</typeparam>
[Serializable]
public class KDTree<TNode>
{
    /// <summary>
    /// The number of points in the KDTree
    /// </summary>
    public int Count { get; }

    /// <summary>
    /// The array in which the binary tree is stored. Enumerating this array is a level-order traversal of the tree.
    /// </summary>
    public double[][] InternalPointArray { get; }

    /// <summary>
    /// The array in which the node objects are stored. There is a one-to-one correspondence with this array and the <see cref="InternalPointArray"/>.
    /// </summary>
    public TNode[] InternalNodeArray { get; }

    /// <summary>
    /// Gets a <see cref="BinaryTreeNavigator{TPoint,TNode}"/> that allows for manual tree navigation,
    /// </summary>
    public BinaryTreeNavigator<double[], TNode> Navigator
        => new BinaryTreeNavigator<double[], TNode>(InternalPointArray, InternalNodeArray);

    /// <summary>
    /// The maximum value along any dimension.
    /// </summary>
    private double MaxValue { get; }

    /// <summary>
    /// The minimum value along any dimension.
    /// </summary>
    private double MinValue { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KDTree{TNode}"/> class.
    /// </summary>
    /// <param name="points">The points to be constructed into a <see cref="KDTree{TNode}"/></param>
    /// <param name="nodes">The nodes associated with each point.</param>
    /// <param name="searchWindowMinValue">The minimum value to be used in node searches.</param>
    /// <param name="searchWindowMaxValue">The maximum value to be used in node searches.</param>
    public KDTree(
        double[][] points,
        TNode[] nodes,
        double searchWindowMinValue = double.MinValue,
        double searchWindowMaxValue = double.MaxValue)
    {
        MinValue = searchWindowMinValue;
        MaxValue = searchWindowMaxValue;

        // Calculate the number of nodes needed to contain the binary tree.
        // This is equivalent to finding the power of 2 greater than the number of points
        int elementCount = (int)Math.Pow(2, (int)(Math.Log(points.Length) / Math.Log(2)) + 1);
        InternalPointArray = Enumerable.Repeat(default(double[]), elementCount).ToArray();
        InternalNodeArray = Enumerable.Repeat(default(TNode), elementCount).ToArray();
        Count = points.Length;
        GenerateTree(0, 0, points, nodes);
    }

    /// <summary>
    /// Finds the nearest neighbors in the <see cref="KDTree{TNode}"/> of the given <paramref name="point"/>.
    /// </summary>
    /// <param name="point">The point whose neighbors we search for.</param>
    /// <param name="neighbors">The number of neighbors to look for.</param>
    public Tuple<double[], TNode>[] NearestNeighbors(double[] point, int neighbors)
    {
        BoundedPriorityList<int> nearestNeighborList = new BoundedPriorityList<int>(neighbors, true);
        HyperRect rect = HyperRect.Infinite(MaxValue, MinValue);
        SearchForNearestNeighbors(0, point, rect, 0, nearestNeighborList, double.MaxValue);

        return nearestNeighborList.ToResultSet(this);
    }

    /// <summary>
    /// Grows a KD tree recursively via median splitting. We find the median by doing a full sort.
    /// </summary>
    /// <param name="index">The array index for the current node.</param>
    /// <param name="dim">The current splitting dimension.</param>
    /// <param name="points">The set of points remaining to be added to the kd-tree</param>
    /// <param name="nodes">The set of nodes RE</param>
    private void GenerateTree(
        int index,
        int dim,
        IReadOnlyCollection<double[]> points,
        IEnumerable<TNode> nodes)
    {
        // See wikipedia for a good explanation kd-tree construction.
        // https://en.wikipedia.org/wiki/K-d_tree

        // zip both lists so we can sort nodes according to points
        var zippedList = points.Zip(nodes, (p, n) => new { Point = p, Node = n });

        // sort the points along the current dimension
        var sortedPoints = zippedList.OrderBy(z => z.Point[dim]).ToArray();

        // get the point which has the median value of the current dimension.
        var medianPoint = sortedPoints[points.Count / 2];
        int medianPointIdx = sortedPoints.Length / 2;

        // The point with the median value all the current dimension now becomes the value of the current tree node
        // The previous node becomes the parents of the current node.
        InternalPointArray[index] = medianPoint.Point;
        InternalNodeArray[index] = medianPoint.Node;

        // We now split the sorted points into 2 groups
        // 1st group: points before the median
        double[][] leftPoints = new double[medianPointIdx][];
        TNode[] leftNodes = new TNode[medianPointIdx];
        Array.Copy(sortedPoints.Select(z => z.Point).ToArray(), leftPoints, leftPoints.Length);
        Array.Copy(sortedPoints.Select(z => z.Node).ToArray(), leftNodes, leftNodes.Length);

        // 2nd group: Points after the median
        double[][] rightPoints = new double[sortedPoints.Length - (medianPointIdx + 1)][];
        TNode[] rightNodes = new TNode[sortedPoints.Length - (medianPointIdx + 1)];
        Array.Copy(
            sortedPoints.Select(z => z.Point).ToArray(),
            medianPointIdx + 1,
            rightPoints,
            0,
            rightPoints.Length);
        Array.Copy(sortedPoints.Select(z => z.Node).ToArray(), medianPointIdx + 1, rightNodes, 0, rightNodes.Length);

        // We new recurse, passing the left and right arrays for arguments.
        // The current node's left and right values become the "roots" for
        // each recursion call. We also forward cycle to the next dimension.
        int nextDim = (dim + 1) % 2; // select next dimension

        // We only need to recurse if the point array contains more than one point
        // If the array has no points then the node stay a null value
        if (leftPoints.Length <= 1)
        {
            if (leftPoints.Length == 1)
            {
                InternalPointArray[LeftChildIndex(index)] = leftPoints[0];
                InternalNodeArray[LeftChildIndex(index)] = leftNodes[0];
            }
        }
        else
        {
            GenerateTree(LeftChildIndex(index), nextDim, leftPoints, leftNodes);
        }

        // Do the same for the right points
        if (rightPoints.Length <= 1)
        {
            if (rightPoints.Length == 1)
            {
                InternalPointArray[RightChildIndex(index)] = rightPoints[0];
                InternalNodeArray[RightChildIndex(index)] = rightNodes[0];
            }
        }
        else
        {
            GenerateTree(RightChildIndex(index), nextDim, rightPoints, rightNodes);
        }
    }

    /// <summary>
    /// A top-down recursive method to find the nearest neighbors of a given point.
    /// </summary>
    /// <param name="nodeIndex">The index of the node for the current recursion branch.</param>
    /// <param name="target">The point whose neighbors we are trying to find.</param>
    /// <param name="rect">The <see cref="HyperRect{T}"/> containing the possible nearest neighbors.</param>
    /// <param name="dimension">The current splitting dimension for this recursion branch.</param>
    /// <param name="nearestNeighbors">The <see cref="BoundedPriorityList{TElement,TPriority}"/> containing the nearest neighbors already discovered.</param>
    /// <param name="maxSearchRadiusSquared">The squared radius of the current largest distance to search from the <paramref name="target"/></param>
    private void SearchForNearestNeighbors(
        int nodeIndex,
        double[] target,
        HyperRect rect,
        int dimension,
        BoundedPriorityList<int> nearestNeighbors,
        double maxSearchRadiusSquared)
    {
        if (InternalPointArray.Length <= nodeIndex || nodeIndex < 0
                                                        || InternalPointArray[nodeIndex] == null)
        {
            return;
        }

        // Work out the current dimension
        int dim = dimension % 2;

        // Split our hyper-rectangle into 2 sub rectangles along the current
        // node's point on the current dimension
        HyperRect leftRect = rect.Clone();
        leftRect.MaxPoint[dim] = InternalPointArray[nodeIndex][dim];

        HyperRect rightRect = rect.Clone();
        rightRect.MinPoint[dim] = InternalPointArray[nodeIndex][dim];

        // Determine which side the target resides in
        int compare = target[dim].CompareTo(InternalPointArray[nodeIndex][dim]);

        HyperRect nearerRect = compare <= 0 ? leftRect : rightRect;
        HyperRect furtherRect = compare <= 0 ? rightRect : leftRect;

        int nearerNode = compare <= 0 ? LeftChildIndex(nodeIndex) : RightChildIndex(nodeIndex);
        int furtherNode = compare <= 0 ? RightChildIndex(nodeIndex) : LeftChildIndex(nodeIndex);

        // Move down into the nearer branch
        SearchForNearestNeighbors(
            nearerNode,
            target,
            nearerRect,
            dimension + 1,
            nearestNeighbors,
            maxSearchRadiusSquared);

        // Walk down into the further branch but only if our capacity hasn't been reached
        // OR if there's a region in the further rectangle that's closer to the target than our
        // current furtherest nearest neighbor
        double[] closestPointInFurtherRect = furtherRect.GetClosestPoint(target);
        double distanceSquaredToTarget = CalculateDistance(closestPointInFurtherRect, target);

        if (distanceSquaredToTarget.CompareTo(maxSearchRadiusSquared) <= 0)
        {
            if (nearestNeighbors.IsFull)
            {
                if (distanceSquaredToTarget.CompareTo(nearestNeighbors.MaxPriority) < 0)
                {
                    SearchForNearestNeighbors(
                        furtherNode,
                        target,
                        furtherRect,
                        dimension + 1,
                        nearestNeighbors,
                        maxSearchRadiusSquared);
                }
            }
            else
            {
                SearchForNearestNeighbors(
                    furtherNode,
                    target,
                    furtherRect,
                    dimension + 1,
                    nearestNeighbors,
                    maxSearchRadiusSquared);
            }
        }

        // Try to add the current node to our nearest neighbors list
        if (CalculateDistance(InternalPointArray[nodeIndex], target).CompareTo(maxSearchRadiusSquared) <= 0)
        {
            nearestNeighbors.Add(nodeIndex, CalculateDistance(InternalPointArray[nodeIndex], target));
        }
    }

    private static double CalculateDistance(double[] x, double[] y)
    {
        double dist = 0f;
        for (int i = 0; i < x.Length; i++)
        {
            dist += (x[i] - y[i]) * (x[i] - y[i]);
        }

        return dist;
    }
}