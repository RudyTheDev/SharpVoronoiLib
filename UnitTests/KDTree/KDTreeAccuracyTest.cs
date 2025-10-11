using Supercluster.KDTree.Utilities;

namespace KDTreeTests;

using Supercluster.KDTree;

[TestFixture]
public class KDTreeAccuracyTest
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
        KDTree<string> tree = new KDTree<string>(
            points,
            nodes,
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

        KDTree<string> tree = new KDTree<string>(points, nodes);

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

        double[][] treePoints = GenerateDoubles(dataSize, range);
        string[] treeNodes = GenerateDoubles(dataSize, range).Select(d => d.ToString()).ToArray();
        double[][] testData = GenerateDoubles(testDataSize, range);


        KDTree<string> tree = new KDTree<string>(treePoints, treeNodes);

        for (int i = 0; i < testDataSize; i++)
        {
            Tuple<double[], string>[] treeNearest = tree.NearestNeighbors(testData[i], 1);
            Tuple<double[], string> linearNearest = LinearSearch(treePoints, treeNodes, testData[i]);

            Assert.That(L2Norm_Squared_Double(testData[i], linearNearest.Item1), Is.EqualTo(L2Norm_Squared_Double(testData[i], treeNearest[0].Item1)));

            // TODO: wrote linear search for both node and point arrays
            Assert.That(treeNearest[0].Item2, Is.EqualTo(linearNearest.Item2));
        }
    }


    private static double[][] GenerateDoubles(int points, double range)
    {
        List<double[]> data = new List<double[]>();
        Random random = new Random();

        for (int i = 0; i < points; i++)
        {
            data.Add(new double[] { (random.NextDouble() * range), (random.NextDouble() * range) });
        }

        return data.ToArray();
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
    
    private static Tuple<double[], TNode> LinearSearch<TNode>(double[][] points, TNode[] nodes, double[] target)
    {
        int bestIndex = 0;
        double bestDist = Double.MaxValue;

        for (int i = 0; i < points.Length; i++)
        {
            double currentDist = L2Norm_Squared_Double(points[i], target);
            if (bestDist > currentDist)
            {
                bestDist = currentDist;
                bestIndex = i;
            }
        }

        return new Tuple<double[], TNode>(points[bestIndex], nodes[bestIndex]);
    }
    
    private static Func<double[], double[], double> L2Norm_Squared_Double = (x, y) =>
    {
        double dist = 0f;
        for (int i = 0; i < x.Length; i++)
        {
            dist += (x[i] - y[i]) * (x[i] - y[i]);
        }

        return dist;
    };
}