using JetBrains.Annotations;

namespace SharpVoronoiLib.UnitTests;

[TestFixture]
public class SiteEdgeWindingTests
{
    [TestCase("ABC", "AB BC CA", "AB BC CA", TestName = "ABC - AB BC CA => AB× BC× CA×")]
    [TestCase("ABC", "AB CB CA", "AB BC CA", TestName = "ABC - AB CB CA => AB× CB↺ CA×")]
    [TestCase("ABC", "BA BC CA", "AB BC CA", TestName = "ABC - BA BC CA => BA↺ BC× CA×")]
    [TestCase("ABC", "BA CB CA", "AB BC CA", TestName = "ABC - BA CB CA => BA↺ CB↺ CA×")]
    [TestCase("ABC", "AB BC AC", "AB BC CA", TestName = "ABC - AB BC AC => AB× BC× AC↺")]
    [TestCase("ABC", "AB CB AC", "AB BC CA", TestName = "ABC - AB CB AC => AB× CB↺ AC↺")]
    [TestCase("ABC", "BA BC AC", "AB BC CA", TestName = "ABC - BA BC AC => BA↺ BC× AC↺")]
    [TestCase("ABC", "BA CB AC", "AB BC CA", TestName = "ABC - BA CB AC => BA↺ CB↺ AC↺")]
    
    [TestCase("BCA", "AB BC CA", "BC CA AB", TestName = "BCA - AB BC CA => BC× CA× AB×")]
    [TestCase("BCA", "AB CB CA", "BC CA AB", TestName = "BCA - AB CB CA => BC× CB↺ CA×")]
    [TestCase("BCA", "BA BC CA", "BC CA AB", TestName = "BCA - BA BC CA => BA↺ BC× CA×")]
    [TestCase("BCA", "BA CB CA", "BC CA AB", TestName = "BCA - BA CB CA => BA↺ CB↺ CA×")]
    [TestCase("BCA", "AB BC AC", "BC CA AB", TestName = "BCA - AB BC AC => AB× BC× AC↺")]
    [TestCase("BCA", "AB CB AC", "BC CA AB", TestName = "BCA - AB CB AC => AB× CB↺ AC↺")]
    [TestCase("BCA", "BA BC AC", "BC CA AB", TestName = "BCA - BA BC AC => BA↺ BC× AC↺")]
    [TestCase("BCA", "BA CB AC", "BC CA AB", TestName = "BCA - BA CB AC => BA↺ CB↺ AC↺")]
    
    [TestCase("CAB", "AB BC CA", "CA AB BC", TestName = "CAB - AB BC CA => CA× AB× BC×")]
    [TestCase("CAB", "AB CB CA", "CA AB BC", TestName = "CAB - AB CB CA => CA× CB↺ AB×")]
    [TestCase("CAB", "BA BC CA", "CA AB BC", TestName = "CAB - BA BC CA => BA↺ BC× CA×")]
    [TestCase("CAB", "BA CB CA", "CA AB BC", TestName = "CAB - BA CB CA => BA↺ CB↺ CA×")]
    [TestCase("CAB", "AB BC AC", "CA AB BC", TestName = "CAB - AB BC AC => AB× BC× AC↺")]
    [TestCase("CAB", "AB CB AC", "CA AB BC", TestName = "CAB - AB CB AC => AB× CB↺ AC↺")]
    [TestCase("CAB", "BA BC AC", "CA AB BC", TestName = "CAB - BA BC AC => BA↺ BC× AC↺")]
    [TestCase("CAB", "BA CB AC", "CA AB BC", TestName = "CAB - BA CB AC => BA↺ CB↺ AC↺")]
    public void TestWindEdges(string pointsRaw, string edgesRaw, string woundRaw)
    {
        // Arrange
        
        (List<VoronoiEdge> edges, List<VoronoiPoint> points, List<VoronoiEdge> expected, bool[] flipped) = 
            ParseRawInputsIntoVoronoiElements(pointsRaw, edgesRaw, woundRaw);

        // Act

        List<WoundVoronoiEdge> woundEdges = VoronoiSite.WindEdges(edges, points);

        // Assert

        for (int i = 0; i < woundEdges.Count; i++)
        {
            Assert.That(woundEdges[i].Edge, Is.EqualTo(expected[i]), $"Expected edges {woundRaw} but got " + string.Join(" ", woundEdges.Select(e => ((TestEdge)e.Edge).ID + (e.Flipped ? "↺" : "×"))) + ".");
            Assert.That(woundEdges[i].Flipped, Is.EqualTo(flipped[i]), $"Expected edges {woundRaw} but got " + string.Join(" ", woundEdges.Select(e => ((TestEdge)e.Edge).ID + (e.Flipped ? "↺" : "×"))) + ".");
        }
    }
    

    [Pure]
    private static (List<VoronoiEdge> edges, List<VoronoiPoint> points, List<VoronoiEdge> expected, bool[] flipped) 
        ParseRawInputsIntoVoronoiElements(string pointsRaw, string edgesRaw, string woundedRaw)
    {
        // Gather points from something like "ABC" to ['A', 'B', 'C']
        
        string[] edgesSplits = edgesRaw.Split(' ');

        Dictionary<char, TestPoint> pointsLookup = pointsRaw.ToDictionary(
            p => p,
            p => new TestPoint(p.ToString(), p + 1, 33) // mainly making sure they are all different
        );

        // Gather edges from something like "AB BC CA" to [("AB", A, B), ("BC", B, C), ("CA", C, A)]
        
        List<TestEdge> edges = edgesSplits
                               .Select(es => new TestEdge(es, pointsLookup[es[0]], pointsLookup[es[1]]))
                               .ToList();
        
        List<TestPoint> points = pointsLookup.Values.ToList();

        // Gather expected wounded edges similar to edges, just looking them up from the edges list from possibly flipped IDs
        
        string[] woundSplits = woundedRaw.Split(' ');
        
        List<TestEdge> expected = woundSplits
                                  .Select(ws => edges.First(e => e.ID == ws || e.ID == new string(new[] { ws[1], ws[0] })))
                                  .ToList();
        
        // But also gather flipped state of wound input versus given edges like [false, true, false] for ["AB", "CB", "CA"]
        
        bool[] flipped = new bool[woundSplits.Length];
        for (int i = 0; i < woundSplits.Length; i++)
            flipped[i] = woundSplits[i][0] != expected[i].ID[0];
        
        return (
            edges.Cast<VoronoiEdge>().ToList(),
            points.Cast<VoronoiPoint>().ToList(), 
            expected.Cast<VoronoiEdge>().ToList(),
            flipped
        );
    }


    /// <summary> Just a wrapper around regular edge to give it a readable ID </summary>
    private class TestEdge : VoronoiEdge
    {
        public string ID { get; }
        internal TestEdge(string id, TestPoint start, TestPoint end) : base(start, end, null) => ID = id;
        public override string ToString() => ID + ": " + base.ToString();
    }

    /// <summary> Just a wrapper around regular point to give it a readable ID </summary>
    private class TestPoint : VoronoiPoint
    {
        public string ID { get; }
        internal TestPoint(string id, double x, double y) : base(x, y) => ID = id;
        public override string ToString() => ID + ": " + base.ToString();
    }
}