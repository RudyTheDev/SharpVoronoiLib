namespace Supercluster.KDTree.Utilities;

using System;
using System.Runtime.CompilerServices;

/// <summary>
/// Contains extension methods for <see cref="BoundedPriorityList{TElement,TPriority}"/> class.
/// </summary>
public static class BoundedPriorityListExtensions
{
    /// <summary>
    /// Takes a <see cref="BoundedPriorityList{TElement,TPriority}"/> storing the indexes of the points and nodes of a KDTree
    /// and returns the points and nodes.
    /// </summary>
    /// <param name="list">The <see cref="BoundedPriorityList{TElement,TPriority}"/>.</param>
    /// <param name="tree">The</param>
    /// <typeparam name="TPriority">THe type of the priority of the <see cref="BoundedPriorityList{TElement,TPriority}"/></typeparam>
    /// <typeparam name="TNode">The type of the nodes of the <see cref="KDTree{double,TNode}"/></typeparam>
    /// <returns>The points and nodes in the <see cref="KDTree{TNode}"/> implicitly referenced by the <see cref="BoundedPriorityList{TElement,TPriority}"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Tuple<double[], TNode>[] ToResultSet<TNode>(
        this BoundedPriorityList<int> list,
        KDTree<TNode> tree)
    {
        Tuple<double[], TNode>[] array = new Tuple<double[], TNode>[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = new Tuple<double[], TNode>(
                tree.InternalPointArray[list[i]],
                tree.InternalNodeArray[list[i]]);
        }

        return array;
    }
}