using NUnit.Framework;

namespace SharpVoronoiLib.UnitTests;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ParabolaTest
{
    private const double Epsilon = double.Epsilon * 1E100;
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        int fX = 0;
        int fY = 0;
        int directrix = 2;
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, 0), Is.EqualTo(1).Within(Epsilon));
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, 10), Is.EqualTo(-24).Within(Epsilon));
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, 10), Is.EqualTo(ParabolaMath.EvalParabola(fX, fY, directrix, -10)).Within(Epsilon));
    }
        
    [Test]
    public void TestEvalXAtFOne()
    {
        int fX = 1;
        int fY = 1;
        int directrix = 3;
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, 1), Is.EqualTo(2).Within(Epsilon));
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, 15), Is.EqualTo(-47).Within(Epsilon));
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, -13), Is.EqualTo(ParabolaMath.EvalParabola(fX, fY, directrix, 15)).Within(Epsilon));
    }
    [Test]
    public void TestEvalXAt123()
    {
        int fX = 1;
        int fY = 2;
        int directrix = 3;
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, 1), Is.EqualTo(5.0 / 2).Within(Epsilon));
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, 11), Is.EqualTo(-95.0 / 2).Within(Epsilon));
        Assert.That(ParabolaMath.EvalParabola(fX, fY, directrix, 11), Is.EqualTo(ParabolaMath.EvalParabola(fX, fY, directrix, -9)).Within(Epsilon));
    }

    [Test]
    public void TestCollinearIntersect()
    {
        int fX1 = 0;
        int fY1 = 0;
        int fX2 = 5;
        int fY2 = 0;
        int directrix = 5;
        Assert.That(ParabolaMath.IntersectParabolaX(fX1, fY1, fX2, fY2, directrix), Is.EqualTo(5.0 / 2).Within(Epsilon));
    }

    [Test]
    public void TestIntersect()
    {
        int fX1 = 1;
        int fY1 = 2;
        int fX2 = 5;
        int fY2 = 4;
        int directrix = 14;
        Assert.That(ParabolaMath.IntersectParabolaX(fX1, fY1, fX2, fY2, directrix), Is.EqualTo(0.50510257).Within(.00000001));
        Assert.That(ParabolaMath.IntersectParabolaX(fX2, fY2, fX1, fY1, directrix), Is.EqualTo(49.49489743).Within(.00000001));
    }
}