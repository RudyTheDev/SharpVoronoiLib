namespace SharpVoronoiLib.UnitTests;

[TestFixture]
public class EqualityTests
{
    private const double tinyDelta = EpsilonUtils.epsilon * 9 / 10; // smaller than epsilon - should be considered equal by ApproxEqual
    private const double largeDelta = EpsilonUtils.epsilon * 10 / 9; // larger than epsilon but not by much, but should be considered different by ApproxEqual

    
    #region Point

    [Test]
    public void TestPoint_Equals_ReturnsTrue_ForExactEqualCoordinates()
    {
        // Arrange
        VoronoiPoint firstPoint = new VoronoiPoint(1.0, 2.0);
        VoronoiPoint secondPoint = new VoronoiPoint(1.0, 2.0);

        // Act
        bool areEqual = firstPoint.Equals(secondPoint);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPoint_Equals_ReturnsTrue_ForApproxEqualCoordinates()
    {
        // Arrange
        VoronoiPoint originalPoint = new VoronoiPoint(1.0, 2.0);
        VoronoiPoint approximatePoint = new VoronoiPoint(1.0 + tinyDelta, 2.0 - tinyDelta);

        // Act
        bool areEqual = originalPoint.Equals(approximatePoint);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPoint_Equals_ReturnsFalse_ForDifferentCoordinates()
    {
        // Arrange
        VoronoiPoint originalPoint = new VoronoiPoint(1.0, 2.0);
        VoronoiPoint differentPoint = new VoronoiPoint(1.0 + largeDelta, 2.0 - largeDelta);

        // Act
        bool areEqual = originalPoint.Equals(differentPoint);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    [Test]
    public void TestPoint_OperatorEquals_ReturnsTrue_ForEqualPoints()
    {
        // Arrange
        VoronoiPoint firstPoint = new VoronoiPoint(1.0, 2.0);
        VoronoiPoint secondPoint = new VoronoiPoint(1.0, 2.0);

        // Act
        bool areEqual = firstPoint == secondPoint;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPoint_OperatorEquals_ReturnsTrue_ForApproxEqualPoints()
    {
        // Arrange
        VoronoiPoint originalPoint = new VoronoiPoint(1.0, 2.0);
        VoronoiPoint approximatePoint = new VoronoiPoint(1.0 + tinyDelta, 2.0 - tinyDelta);

        // Act
        bool areEqual = originalPoint == approximatePoint;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPoint_OperatorEquals_ReturnsTrue_ForBothNull()
    {
        // Arrange
        VoronoiPoint? nullPoint1 = null;
        VoronoiPoint? nullPoint2 = null;

        // Act
        bool areEqual = nullPoint1 == nullPoint2;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPoint_OperatorNotEquals_ReturnsTrue_ForDifferentPoints()
    {
        // Arrange
        VoronoiPoint originalPoint = new VoronoiPoint(1.0, 2.0);
        VoronoiPoint differentPoint = new VoronoiPoint(1.0 + largeDelta, 2.0 - largeDelta);

        // Act
        bool areNotEqual = originalPoint != differentPoint;

        // Assert
        Assert.That(areNotEqual, Is.True);
    }

    [Test]
    public void TestPoint_OperatorNotEquals_ReturnsFalse_ForEqualPoints()
    {
        // Arrange
        VoronoiPoint firstPoint = new VoronoiPoint(1.0, 2.0);
        VoronoiPoint secondPoint = new VoronoiPoint(1.0, 2.0);

        // Act
        bool areNotEqual = firstPoint != secondPoint;

        // Assert
        Assert.That(areNotEqual, Is.False);
    }

    [Test]
    public void TestPoint_OperatorNotEquals_ReturnsFalse_ForApproxEqualPoints()
    {
        // Arrange
        VoronoiPoint originalPoint = new VoronoiPoint(1.0, 2.0);
        VoronoiPoint approximatePoint = new VoronoiPoint(1.0 + tinyDelta, 2.0 - tinyDelta);

        // Act
        bool areNotEqual = originalPoint != approximatePoint;

        // Assert
        Assert.That(areNotEqual, Is.False);
    }

    [Test]
    public void TestPoint_OperatorNotEquals_ReturnsFalse_ForBothNull()
    {
        // Arrange
        VoronoiPoint? nullPoint1 = null;
        VoronoiPoint? nullPoint2 = null;

        // Act
        bool areNotEqual = nullPoint1 != nullPoint2;

        // Assert
        Assert.That(areNotEqual, Is.False);
    }

    [Test]
    public void TestPoint_EqualsObject_ReturnsTrue_ForSameReference()
    {
        // Arrange
        VoronoiPoint point = new VoronoiPoint(3.0, 4.0);
        object sameReference = point;

        // Act
        bool areEqual = point.Equals(sameReference);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPoint_EqualsObject_ReturnsTrue_ForEqualValues()
    {
        // Arrange
        VoronoiPoint point = new VoronoiPoint(3.0, 4.0);
        object equalObject = new VoronoiPoint(3.0, 4.0);

        // Act
        bool areEqual = point.Equals(equalObject);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPoint_EqualsObject_ReturnsTrue_ForApproxEqualValues()
    {
        // Arrange
        VoronoiPoint point = new VoronoiPoint(3.0, 4.0);
        object approximateObject = new VoronoiPoint(3.0 + tinyDelta, 4.0);

        // Act
        bool areEqual = point.Equals(approximateObject);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPoint_EqualsObject_ReturnsFalse_ForDifferentType()
    {
        // Arrange
        VoronoiPoint point = new VoronoiPoint(3.0, 4.0);
        object differentType = new object();

        // Act
        bool areEqual = point.Equals(differentType);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    [Test]
    public void TestPoint_GetHashCode_Equals_ForExactEqualValues()
    {
        // Arrange
        VoronoiPoint firstPoint = new VoronoiPoint(10.0, -5.0);
        VoronoiPoint secondPoint = new VoronoiPoint(10.0, -5.0);

        // Act
        int firstHash = firstPoint.GetHashCode();
        int secondHash = secondPoint.GetHashCode();

        // Assert
        Assert.That(firstHash, Is.EqualTo(secondHash));
    }

    [Test]
    public void TestPoint_GetHashCode_Equals_ForApproxEqualValues()
    {
        // Arrange
        VoronoiPoint basePoint = new VoronoiPoint(10.0, -5.0);
        VoronoiPoint approxPoint = new VoronoiPoint(10.0 + tinyDelta, -5.0 - tinyDelta);

        // Assume
        Assume.That(basePoint.Equals(approxPoint), Is.True);

        // Act
        int baseHash = basePoint.GetHashCode();
        int approxHash = approxPoint.GetHashCode();

        // Assert
        Assert.That(baseHash, Is.EqualTo(approxHash));
    }

    [Test]
    public void TestPointComparer_Equals_ReturnsTrue_ForEqualPoints()
    {
        // Arrange
        VoronoiPoint firstPoint = new VoronoiPoint(7.0, 8.0);
        VoronoiPoint secondPoint = new VoronoiPoint(7.0, 8.0);

        // Act
        bool areEqual = VoronoiPointComparer.Instance.Equals(firstPoint, secondPoint);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPointComparer_Equals_ReturnsTrue_ForApproxEqualPoints()
    {
        // Arrange
        VoronoiPoint originalPoint = new VoronoiPoint(7.0, 8.0);
        VoronoiPoint approximatePoint = new VoronoiPoint(7.0 + tinyDelta, 8.0 - tinyDelta);

        // Act
        bool areEqual = VoronoiPointComparer.Instance.Equals(originalPoint, approximatePoint);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestPointComparer_Equals_ReturnsFalse_ForDifferentPoints()
    {
        // Arrange
        VoronoiPoint originalPoint = new VoronoiPoint(7.0, 8.0);
        VoronoiPoint differentPoint = new VoronoiPoint(7.0 + largeDelta, 8.0 - largeDelta);

        // Act
        bool areEqual = VoronoiPointComparer.Instance.Equals(originalPoint, differentPoint);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    #endregion // VoronoiPoint


    #region Site

    [Test]
    public void TestSite_Equals_ReturnsTrue_ForExactEqualCoordinates()
    {
        // Arrange
        VoronoiSite firstSite = new VoronoiSite(1.0, 2.0);
        VoronoiSite secondSite = new VoronoiSite(1.0, 2.0);

        // Act
        bool areEqual = firstSite.Equals(secondSite);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSite_Equals_ReturnsTrue_ForApproxEqualCoordinates()
    {
        // Arrange
        VoronoiSite originalSite = new VoronoiSite(1.0, 2.0);
        VoronoiSite approximateSite = new VoronoiSite(1.0 + tinyDelta, 2.0 - tinyDelta);

        // Act
        bool areEqual = originalSite.Equals(approximateSite);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSite_Equals_ReturnsFalse_ForDifferentCoordinates()
    {
        // Arrange
        VoronoiSite originalSite = new VoronoiSite(1.0, 2.0);
        VoronoiSite differentSite = new VoronoiSite(1.1, 2.2);

        // Act
        bool areEqual = originalSite.Equals(differentSite);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    [Test]
    public void TestSite_OperatorEquals_ReturnsTrue_ForEqualSites()
    {
        // Arrange
        VoronoiSite firstSite = new VoronoiSite(1.0, 2.0);
        VoronoiSite secondSite = new VoronoiSite(1.0, 2.0);

        // Act
        bool areEqual = firstSite == secondSite;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSite_OperatorEquals_ReturnsTrue_ForApproxEqualSites()
    {
        // Arrange
        VoronoiSite originalSite = new VoronoiSite(1.0, 2.0);
        VoronoiSite approximateSite = new VoronoiSite(1.0 + tinyDelta, 2.0 - tinyDelta);

        // Act
        bool areEqual = originalSite == approximateSite;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSite_OperatorEquals_ReturnsTrue_ForBothNull()
    {
        // Arrange
        VoronoiSite? nullSite1 = null;
        VoronoiSite? nullSite2 = null;

        // Act
        bool areEqual = nullSite1 == nullSite2;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSite_OperatorNotEquals_ReturnsTrue_ForDifferentSites()
    {
        // Arrange
        VoronoiSite originalSite = new VoronoiSite(1.0, 2.0);
        VoronoiSite differentSite = new VoronoiSite(1.1, 2.2);

        // Act
        bool areNotEqual = originalSite != differentSite;

        // Assert
        Assert.That(areNotEqual, Is.True);
    }

    [Test]
    public void TestSite_OperatorNotEquals_ReturnsFalse_ForEqualSites()
    {
        // Arrange
        VoronoiSite firstSite = new VoronoiSite(1.0, 2.0);
        VoronoiSite secondSite = new VoronoiSite(1.0, 2.0);

        // Act
        bool areNotEqual = firstSite != secondSite;

        // Assert
        Assert.That(areNotEqual, Is.False);
    }

    [Test]
    public void TestSite_OperatorNotEquals_ReturnsFalse_ForApproxEqualSites()
    {
        // Arrange
        VoronoiSite originalSite = new VoronoiSite(1.0, 2.0);
        VoronoiSite approximateSite = new VoronoiSite(1.0 + tinyDelta, 2.0 - tinyDelta);

        // Act
        bool areNotEqual = originalSite != approximateSite;

        // Assert
        Assert.That(areNotEqual, Is.False);
    }

    [Test]
    public void TestSite_OperatorNotEquals_ReturnsFalse_ForBothNull()
    {
        // Arrange
        VoronoiSite? nullSite1 = null;
        VoronoiSite? nullSite2 = null;

        // Act
        bool areNotEqual = nullSite1 != nullSite2;

        // Assert
        Assert.That(areNotEqual, Is.False);
    }

    [Test]
    public void TestSite_EqualsObject_ReturnsTrue_ForSameReference()
    {
        // Arrange
        VoronoiSite site = new VoronoiSite(3.0, 4.0);
        object sameReference = site;

        // Act
        bool areEqual = site.Equals(sameReference);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSite_EqualsObject_ReturnsTrue_ForEqualValues()
    {
        // Arrange
        VoronoiSite site = new VoronoiSite(3.0, 4.0);
        object equalObject = new VoronoiSite(3.0, 4.0);

        // Act
        bool areEqual = site.Equals(equalObject);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSite_EqualsObject_ReturnsTrue_ForApproxEqualValues()
    {
        // Arrange
        VoronoiSite site = new VoronoiSite(3.0, 4.0);
        object approximateObject = new VoronoiSite(3.0, 4.0 + tinyDelta);

        // Act
        bool areEqual = site.Equals(approximateObject);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSite_EqualsObject_ReturnsFalse_ForDifferentType()
    {
        // Arrange
        VoronoiSite site = new VoronoiSite(3.0, 4.0);
        object differentType = new object();

        // Act
        bool areEqual = site.Equals(differentType);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    [Test]
    public void TestSite_GetHashCode_Equals_ForExactEqualValues()
    {
        // Arrange
        VoronoiSite firstSite = new VoronoiSite(10.0, -5.0);
        VoronoiSite secondSite = new VoronoiSite(10.0, -5.0);

        // Act
        int firstHash = firstSite.GetHashCode();
        int secondHash = secondSite.GetHashCode();

        // Assert
        Assert.That(firstHash, Is.EqualTo(secondHash));
    }

    [Test]
    public void TestSite_GetHashCode_Equals_ForApproxEqualValues()
    {
        // Arrange
        VoronoiSite baseSite = new VoronoiSite(10.0, -5.0);
        VoronoiSite approxSite = new VoronoiSite(10.0 + tinyDelta, -5.0 - tinyDelta);

        // Assume
        Assume.That(baseSite.Equals(approxSite), Is.True);
        
        // Act
        int baseHash = baseSite.GetHashCode();
        int approxHash = approxSite.GetHashCode();

        // Assert
        Assert.That(baseHash, Is.EqualTo(approxHash));
    }

    [Test]
    public void TestSiteComparer_Equals_ReturnsTrue_ForEqualSites()
    {
        // Arrange
        VoronoiSite firstSite = new VoronoiSite(7.0, 8.0);
        VoronoiSite secondSite = new VoronoiSite(7.0, 8.0);

        // Act
        bool areEqual = VoronoiSiteComparer.Instance.Equals(firstSite, secondSite);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSiteComparer_Equals_ReturnsTrue_ForApproxEqualSites()
    {
        // Arrange
        VoronoiSite originalSite = new VoronoiSite(7.0, 8.0);
        VoronoiSite approximateSite = new VoronoiSite(7.0 + tinyDelta, 8.0);

        // Act
        bool areEqual = VoronoiSiteComparer.Instance.Equals(originalSite, approximateSite);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestSiteComparer_Equals_ReturnsFalse_ForDifferentSites()
    {
        // Arrange
        VoronoiSite originalSite = new VoronoiSite(7.0, 8.0);
        VoronoiSite differentSite = new VoronoiSite(7.0 + largeDelta, 8.0 - largeDelta);

        // Act
        bool areEqual = VoronoiSiteComparer.Instance.Equals(originalSite, differentSite);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    #endregion // VoronoiSite


    #region Edge

    [Test]
    public void TestEdge_Equals_ReturnsTrue_ForExactEqualEndpoints()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge firstEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge secondEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);

        // Act
        bool areEqual = firstEdge.Equals(secondEdge);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestEdge_Equals_ReturnsTrue_ForApproxEqualEndpoints()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge originalEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge approximateEdge = new VoronoiEdge(new VoronoiPoint(5.0 + tinyDelta, 0.0), new VoronoiPoint(5.0 + tinyDelta, 10.0), rightSite, leftSite);

        // Act
        bool areEqual = originalEdge.Equals(approximateEdge);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestEdge_Equals_ReturnsFalse_ForDifferentEndpoints()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge originalEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge differentEdge = new VoronoiEdge(new VoronoiPoint(0.0, 0.0), new VoronoiPoint(1.0, 1.0), rightSite, leftSite);

        // Act
        bool areEqual = originalEdge.Equals(differentEdge);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    [Test]
    public void TestEdge_Equals_ReturnsFalse_ForReversedEndpoints()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiPoint startPoint = new VoronoiPoint(5.0, 0.0);
        VoronoiPoint endPoint = new VoronoiPoint(5.0, 10.0);
        VoronoiEdge originalEdge = new VoronoiEdge(startPoint, endPoint, rightSite, leftSite);
        VoronoiEdge reversedEdge = new VoronoiEdge(endPoint, startPoint, rightSite, leftSite);

        // Act
        bool areEqual = originalEdge.Equals(reversedEdge);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    [Test]
    public void TestEdge_OperatorEquals_ReturnsTrue_ForEqualEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge firstEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge secondEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);

        // Act
        bool areEqual = firstEdge == secondEdge;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestEdge_OperatorEquals_ReturnsTrue_ForApproxEqualEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge originalEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge approximateEdge = new VoronoiEdge(new VoronoiPoint(5.0 + tinyDelta, 0.0), new VoronoiPoint(5.0 + tinyDelta, 10.0), rightSite, leftSite);

        // Act
        bool areEqual = originalEdge == approximateEdge;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestEdge_OperatorEquals_ReturnsTrue_ForBothNull()
    {
        // Arrange
        VoronoiEdge? nullEdge1 = null;
        VoronoiEdge? nullEdge2 = null;

        // Act
        bool areEqual = nullEdge1 == nullEdge2;

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestEdge_OperatorNotEquals_ReturnsTrue_ForDifferentEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge originalEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge differentEdge = new VoronoiEdge(new VoronoiPoint(0.0, 0.0), new VoronoiPoint(1.0, 1.0), rightSite, leftSite);

        // Act
        bool areNotEqual = originalEdge != differentEdge;

        // Assert
        Assert.That(areNotEqual, Is.True);
    }

    [Test]
    public void TestEdge_OperatorNotEquals_ReturnsTrue_ForReversedEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiPoint startPoint = new VoronoiPoint(5.0, 0.0);
        VoronoiPoint endPoint = new VoronoiPoint(5.0, 10.0);
        VoronoiEdge originalEdge = new VoronoiEdge(startPoint, endPoint, rightSite, leftSite);
        VoronoiEdge reversedEdge = new VoronoiEdge(endPoint, startPoint, rightSite, leftSite);

        // Act
        bool areNotEqual = originalEdge != reversedEdge;

        // Assert
        Assert.That(areNotEqual, Is.True);
    }

    [Test]
    public void TestEdge_OperatorNotEquals_ReturnsFalse_ForEqualEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge firstEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge secondEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);

        // Act
        bool areNotEqual = firstEdge != secondEdge;

        // Assert
        Assert.That(areNotEqual, Is.False);
    }

    [Test]
    public void TestEdge_OperatorNotEquals_ReturnsFalse_ForApproxEqualEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge originalEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge approximateEdge = new VoronoiEdge(new VoronoiPoint(5.0 + tinyDelta, 0.0), new VoronoiPoint(5.0 + tinyDelta, 10.0), rightSite, leftSite);

        // Act
        bool areNotEqual = originalEdge != approximateEdge;

        // Assert
        Assert.That(areNotEqual, Is.False);
    }

    [Test]
    public void TestEdge_GetHashCode_Equals_ForExactEqualValues()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge firstEdge = new VoronoiEdge(new VoronoiPoint(2.0, 3.0), new VoronoiPoint(4.0, 5.0), rightSite, leftSite);
        VoronoiEdge secondEdge = new VoronoiEdge(new VoronoiPoint(2.0, 3.0), new VoronoiPoint(4.0, 5.0), rightSite, leftSite);

        // Act
        int firstHash = firstEdge.GetHashCode();
        int secondHash = secondEdge.GetHashCode();

        // Assert
        Assert.That(firstHash, Is.EqualTo(secondHash));
    }

    [Test]
    public void TestEdge_GetHashCode_Equals_ForApproxEqualValues()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge baseEdge = new VoronoiEdge(new VoronoiPoint(2.0, 3.0), new VoronoiPoint(4.0, 5.0), rightSite, leftSite);
        VoronoiEdge approxEdge = new VoronoiEdge(new VoronoiPoint(2.0 + tinyDelta, 3.0 - tinyDelta), new VoronoiPoint(4.0 + tinyDelta, 5.0 - tinyDelta), rightSite, leftSite);

        // Assume
        Assume.That(baseEdge.Equals(approxEdge), Is.True);

        // Act
        int baseHash = baseEdge.GetHashCode();
        int approxHash = approxEdge.GetHashCode();

        // Assert
        Assert.That(baseHash, Is.EqualTo(approxHash));
    }

    [Test]
    public void TestEdgeComparer_Equals_ReturnsTrue_ForEqualEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge firstEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge secondEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);

        // Act
        bool areEqual = VoronoiEdgeComparer.Instance.Equals(firstEdge, secondEdge);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestEdgeComparer_Equals_ReturnsTrue_ForApproxEqualEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiEdge originalEdge = new VoronoiEdge(new VoronoiPoint(5.0, 0.0), new VoronoiPoint(5.0, 10.0), rightSite, leftSite);
        VoronoiEdge approximateEdge = new VoronoiEdge(new VoronoiPoint(5.0 + tinyDelta, 0.0), new VoronoiPoint(5.0 + tinyDelta, 10.0), rightSite, leftSite);

        // Act
        bool areEqual = VoronoiEdgeComparer.Instance.Equals(originalEdge, approximateEdge);

        // Assert
        Assert.That(areEqual, Is.True);
    }

    [Test]
    public void TestEdgeComparer_Equals_ReturnsFalse_ForReversedEdges()
    {
        // Arrange
        VoronoiSite leftSite = new VoronoiSite(0.0, 0.0);
        VoronoiSite rightSite = new VoronoiSite(10.0, 0.0);
        VoronoiPoint startPoint = new VoronoiPoint(5.0, 0.0);
        VoronoiPoint endPoint = new VoronoiPoint(5.0, 10.0);
        VoronoiEdge originalEdge = new VoronoiEdge(startPoint, endPoint, rightSite, leftSite);
        VoronoiEdge reversedEdge = new VoronoiEdge(endPoint, startPoint, rightSite, leftSite);

        // Act
        bool areEqual = VoronoiEdgeComparer.Instance.Equals(originalEdge, reversedEdge);

        // Assert
        Assert.That(areEqual, Is.False);
    }

    #endregion // VoronoiEdge
}