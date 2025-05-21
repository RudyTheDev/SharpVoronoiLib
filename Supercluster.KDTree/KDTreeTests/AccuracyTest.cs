using Supercluster.KDTree.Utilities;

namespace KDTreeTests;

using System.Linq;

using NUnit.Framework;

using Supercluster.KDTree;

[TestFixture]
public class AccuracyTest
{

    /// <summary>
    /// Should build the tree displayed in the article:
    /// https://en.wikipedia.org/wiki/K-d_tree
    /// </summary>
    [Test]
    public void WikipediaBuildTests()
    {
        // Should generate the following tree:
        //             7,2
        //              |
        //       +------+-----+
        //      5,4          9,6
        //       |            |
        //   +---+---+     +--+
        //  2,3     4,7   8,1 


        double[][] points = new double[][]
        {
            new double[] { 7, 2 }, new double[] { 5, 4 }, new double[] { 2, 3 },
            new double[] { 4, 7 }, new double[] { 9, 6 }, new double[] { 8, 1 }
        };

        string[] nodes = new string[] { "Eric", "Is", "A", "Really", "Stubborn", "Ferret" };
        KDTree<double, string> tree = new KDTree<double, string>(
            points,
            nodes,
            Utilities.L2Norm_Squared_Double,
            double.MinValue,
            double.MaxValue);

        Assert.That(tree.InternalPointArray[0], Is.EqualTo(points[0]));
        Assert.That(tree.InternalPointArray[LeftChildIndex(0)], Is.EqualTo(points[1]));
        Assert.That(tree.InternalPointArray[LeftChildIndex(LeftChildIndex(0))], Is.EqualTo(points[2]));
        Assert.That(tree.InternalPointArray[RightChildIndex(LeftChildIndex(0))], Is.EqualTo(points[3]));
        Assert.That(tree.InternalPointArray[RightChildIndex(0)], Is.EqualTo(points[4]));
        Assert.That(tree.InternalPointArray[LeftChildIndex(RightChildIndex(0))], Is.EqualTo(points[5]));
    }



    /// <summary>
    /// Should build the tree displayed in the article:
    /// https://en.wikipedia.org/wiki/K-d_tree
    /// </summary>
    [Test]
    public void NodeNavigatorTests()
    {
        // Should generate the following tree:
        //             7,2
        //              |
        //       +------+-----+
        //      5,4          9,6
        //       |            |
        //   +---+---+     +--+
        //  2,3     4,7   8,1 


        double[][] points = new double[][]
        {
            new double[] { 7, 2 }, new double[] { 5, 4 }, new double[] { 2, 3 },
            new double[] { 4, 7 }, new double[] { 9, 6 }, new double[] { 8, 1 }
        };

        string[] nodes = new string[] { "Eric", "Is", "A", "Really", "Stubborn", "Ferret" };

        KDTree<double, string> tree = new KDTree<double, string>(points, nodes, Utilities.L2Norm_Squared_Double);

        BinaryTreeNavigator<double[], string> nav = tree.Navigator;

        Assert.That(nav.Point, Is.EqualTo(points[0]));
        Assert.That(nav.Left.Point, Is.EqualTo(points[1]));
        Assert.That(nav.Left.Left.Point, Is.EqualTo(points[2]));
        Assert.That(nav.Left.Right.Point, Is.EqualTo(points[3]));
        Assert.That(nav.Right.Point, Is.EqualTo(points[4]));
        Assert.That(nav.Right.Left.Point, Is.EqualTo(points[5]));



        Assert.That(nav.Node, Is.EqualTo(nodes[0]));
        Assert.That(nav.Left.Node, Is.EqualTo(nodes[1]));
        Assert.That(nav.Left.Left.Node, Is.EqualTo(nodes[2]));
        Assert.That(nav.Left.Right.Node, Is.EqualTo(nodes[3]));
        Assert.That(nav.Right.Node, Is.EqualTo(nodes[4]));
        Assert.That(nav.Right.Left.Node, Is.EqualTo(nodes[5]));
    }




    [Test]
    public void FindNearestNeighborTest()
    {
        int dataSize = 10000;
        int testDataSize = 100;
        int range = 1000;

        double[][] treePoints = Utilities.GenerateDoubles(dataSize, range);
        string[] treeNodes = Utilities.GenerateDoubles(dataSize, range).Select(d => d.ToString()).ToArray();
        double[][] testData = Utilities.GenerateDoubles(testDataSize, range);


        KDTree<double, string> tree = new KDTree<double, string>(treePoints, treeNodes, Utilities.L2Norm_Squared_Double);

        for (int i = 0; i < testDataSize; i++)
        {
            Tuple<double[], string>[] treeNearest = tree.NearestNeighbors(testData[i], 1);
            Tuple<double[], string> linearNearest = Utilities.LinearSearch(treePoints, treeNodes, testData[i], Utilities.L2Norm_Squared_Double);

            Assert.That(Utilities.L2Norm_Squared_Double(testData[i], linearNearest.Item1), Is.EqualTo(Utilities.L2Norm_Squared_Double(testData[i], treeNearest[0].Item1)));

            // TODO: wrote linear search for both node and point arrays
            Assert.That(treeNearest[0].Item2, Is.EqualTo(linearNearest.Item2));
        }
    }

    [Test]
    public void RadialSearchTest()
    {
        int dataSize = 10000;
        int testDataSize = 100;
        int range = 1000;
        int radius = 100;

        double[][] treeData = Utilities.GenerateDoubles(dataSize, range);
        string[] treeNodes = Utilities.GenerateDoubles(dataSize, range).Select(d => d.ToString()).ToArray();
        double[][] testData = Utilities.GenerateDoubles(testDataSize, range);
        KDTree<double, string> tree = new KDTree<double, string>(treeData, treeNodes, Utilities.L2Norm_Squared_Double);

        for (int i = 0; i < testDataSize; i++)
        {
            Tuple<double[], string>[] treeRadial = tree.RadialSearch(testData[i], radius);
            Tuple<double[], string>[] linearRadial = Utilities.LinearRadialSearch(
                treeData,
                treeNodes,
                testData[i],
                Utilities.L2Norm_Squared_Double,
                radius);

            for (int j = 0; j < treeRadial.Length; j++)
            {
                Assert.That(treeRadial[j].Item1, Is.EqualTo(linearRadial[j].Item1));
                Assert.That(treeRadial[j].Item2, Is.EqualTo(linearRadial[j].Item2));
            }


        }
    }
    
    
    /// <summary>
    /// Computes the index of the right child of the current node-index.
    /// </summary>
    /// <param name="index">The index of the current node.</param>
    /// <returns>The index of the right child.</returns>
    private static int RightChildIndex(int index)
    {
        return (2 * index) + 2;
    }

    /// <summary>
    /// Computes the index of the left child of the current node-index.
    /// </summary>
    /// <param name="index">The index of the current node.</param>
    /// <returns>The index of the left child.</returns>
    private static int LeftChildIndex(int index)
    {
        return (2 * index) + 1;
    }
}