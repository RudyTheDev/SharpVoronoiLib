namespace SharpVoronoiLib.UnitTests;

[TestFixture]
public class CachedLinkedListTests
{
    [Test]
    public void TestAddOnce()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e = NewEdge(0, 0, 1, 0);

        // Act
        list.AddFirst(e);
        List<VoronoiEdge> items = list.ToList();

        // Assert
        Assert.That(items, Has.Count.EqualTo(1));
        Assert.That(items[0], Is.SameAs(e));
    }
    
    [Test]
    public void TestAddFirstThrice()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e1 = NewEdge(0, 0, 1, 0);
        VoronoiEdge e2 = NewEdge(0, 1, 1, 1);
        VoronoiEdge e3 = NewEdge(0, 2, 1, 2);

        // Act
        list.AddFirst(e1);
        list.AddFirst(e2);
        list.AddFirst(e3);
        List<VoronoiEdge> items = list.ToList();

        // Assert
        Assert.That(items, Has.Count.EqualTo(3));
        Assert.That(items[0], Is.SameAs(e3));
        Assert.That(items[1], Is.SameAs(e2));
        Assert.That(items[2], Is.SameAs(e1));
    }

    [Test]
    public void TestRemoveOnlyElement()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e = NewEdge(0, 0, 1, 0);
        list.AddFirst(e);

        // Act
        list.Remove(e);
        List<VoronoiEdge> items = list.ToList();

        // Assert
        Assert.That(items, Is.Empty);
    }

    [Test]
    public void TestRemoveHeadOfTwo()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e1 = NewEdge(0, 0, 1, 0);
        VoronoiEdge e2 = NewEdge(0, 1, 1, 1);
        list.AddFirst(e1);
        list.AddFirst(e2);
        
        // Act
        list.Remove(e2);
        List<VoronoiEdge> items = list.ToList();
        
        // Assert
        Assert.That(items, Has.Count.EqualTo(1));
        Assert.That(items[0], Is.SameAs(e1));
    }
    
    [Test]
    public void TestRemoveTailOfTwo()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e1 = NewEdge(0, 0, 1, 0);
        VoronoiEdge e2 = NewEdge(0, 1, 1, 1);
        list.AddFirst(e1);
        list.AddFirst(e2);
        
        // Act
        list.Remove(e1);
        List<VoronoiEdge> items = list.ToList();
        
        // Assert
        Assert.That(items, Has.Count.EqualTo(1));
        Assert.That(items[0], Is.SameAs(e2));
    }

    [Test]
    public void TestRemoveMiddleFromThree()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e1 = NewEdge(0, 0, 1, 0);
        VoronoiEdge e2 = NewEdge(0, 1, 1, 1);
        VoronoiEdge e3 = NewEdge(0, 2, 1, 2);
        list.AddFirst(e1);
        list.AddFirst(e2);
        list.AddFirst(e3);

        // Act
        list.Remove(e2);
        List<VoronoiEdge> items = list.ToList();

        // Assert
        Assert.That(items, Has.Count.EqualTo(2));
        Assert.That(items[0], Is.SameAs(e3));
        Assert.That(items[1], Is.SameAs(e1));
    }

    [Test]
    public void TestRemoveHeadAndTail()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e1 = NewEdge(0, 0, 1, 0);
        VoronoiEdge e2 = NewEdge(0, 1, 1, 1);
        VoronoiEdge e3 = NewEdge(0, 2, 1, 2);
        list.AddFirst(e1);
        list.AddFirst(e2);
        list.AddFirst(e3);

        // Act
        list.Remove(e3); // remove head
        List<VoronoiEdge> afterHeadRemove = list.ToList(false);

        list.Remove(e1); // remove tail
        List<VoronoiEdge> afterTailRemove = list.ToList();

        // Assert
        Assert.That(afterHeadRemove, Has.Count.EqualTo(2));
        Assert.That(afterHeadRemove[0], Is.SameAs(e2));
        Assert.That(afterHeadRemove[1], Is.SameAs(e1));

        Assert.That(afterTailRemove, Has.Count.EqualTo(1));
        Assert.That(afterTailRemove[0], Is.SameAs(e2));
    }

    [Test]
    public void TestToListOnEmpty()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();

        // Act
        List<VoronoiEdge> items = list.ToList();

        // Assert
        Assert.That(items, Is.Empty);
    }

    [Test]
    public void TestAddSameItemTwiceThrows()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e = NewEdge(0, 0, 1, 0);
        list.AddFirst(e);

        // Act
        TestDelegate act = () => list.AddFirst(e);

        // Assert
        Assert.That(act, Throws.Exception);
    }

    [Test]
    public void TestRemoveMissingItemThrows()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge present = NewEdge(0, 0, 1, 0);
        VoronoiEdge missing = NewEdge(1, 0, 2, 0);
        list.AddFirst(present);

        // Act
        TestDelegate act = () => list.Remove(missing);

        // Assert
        Assert.That(act, Throws.Exception);
    }

    [Test]
    public void TestReferenceEqualityAllowsDistinctButValueEqualItems()
    {
        // Arrange
        CachedLinkedList<VoronoiEdge> list = new CachedLinkedList<VoronoiEdge>();
        VoronoiEdge e1 = NewEdge(0, 0, 1, 0);
        // Create a distinct instance with the same coordinates (value-equal but different reference)
        VoronoiEdge e2 = NewEdge(0, 0, 1, 0);

        // Act
        list.AddFirst(e1);
        list.AddFirst(e2);
        List<VoronoiEdge> items = list.ToList();

        // Assert
        Assert.That(items, Has.Count.EqualTo(2));
        Assert.That(items[0], Is.SameAs(e2));
        Assert.That(items[1], Is.SameAs(e1));
        Assert.That(e1, Is.EqualTo(e2)); // value-equal
        Assert.That(items[0], Is.Not.SameAs(items[1])); // but different references
    }


    private static VoronoiEdge NewEdge(double x1, double y1, double x2, double y2)
    {
        VoronoiPoint start = new VoronoiPoint(x1, y1);
        VoronoiPoint end = new VoronoiPoint(x2, y2);
        return new VoronoiEdge(start, end, null, null);
    }
}