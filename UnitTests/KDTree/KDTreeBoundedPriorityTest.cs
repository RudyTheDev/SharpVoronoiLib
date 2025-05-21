namespace KDTreeTests;

using NUnit.Framework;

using Supercluster.KDTree;

[TestFixture]
public class KDTreeBoundedPriorityTest
{
    [Test]
    public void InsertTest()
    {
        BoundedPriorityList<int> bp = new BoundedPriorityList<int>(3, true)
        {
            { 34, 98744.90383 },
            { 23, 67.39030 },
            { 2, 2 },
            { 89, 3 }
        };


        Assert.That(bp[0], Is.EqualTo(2));
        Assert.That(bp[1], Is.EqualTo(89));
        Assert.That(bp[2], Is.EqualTo(23));
    }
}