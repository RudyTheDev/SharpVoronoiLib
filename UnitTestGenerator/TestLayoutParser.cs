using System.Text;

namespace SharpVoronoiLib.UnitTestGenerator;

public class TestLayoutParser
{
    private readonly int _horStepSize;
    private readonly int _verStepSize;
    private readonly int _horPreviewStepSize;
    private readonly int _verPreviewStepSize;


    private readonly List<Test> _tests = [ ];


    public TestLayoutParser(int horStepSize, int verStepSize, int horPreviewStepSize, int verPreviewStepSize)
    {
        _horStepSize = horStepSize;
        _verStepSize = verStepSize;
        _horPreviewStepSize = horPreviewStepSize;
        _verPreviewStepSize = verPreviewStepSize;
    }


    public void AddTestLayout(string name, string layout, LayoutTransforms? transform = null)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty", nameof(name));
        if (string.IsNullOrWhiteSpace(layout)) throw new ArgumentException("Layout cannot be empty", nameof(layout));
        if (_tests.Any(t => t.Name == name)) throw new ArgumentException("Name must be unique", nameof(name));


        Console.WriteLine("Parsing data for test " + name + "...");


        string[] lines = layout.Split(Environment.NewLine, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        if (lines.Length == 0) throw new ArgumentException();

        int size = int.Parse(lines[0]);

        int minX = 0;
        int minY = 0;
        int maxX = size * 100;
        int maxY = size * 100;

        int width = maxX - minX;
        int height = maxY - minY;
        int horSteps = width / _horStepSize + 1;
        int verSteps = height / _verStepSize + 1;

        if (lines.Length < verSteps + 1) throw new ArgumentException();

        List<Site> sites = [ ];
        List<Point> points = [ ];

        for (int y = 0; y < verSteps; y++)
        {
            string line = lines[verSteps - y].Trim();

            if (line.Length < horSteps) throw new ArgumentException();

            for (int x = 0; x < horSteps + 1; x++)
            {
                char symbol = line[x];

                switch (symbol)
                {
                    case '·' or 'x':
                        // Filler
                        break;

                    case ' ':
                        if (x % 2 != 1) throw new ArgumentException();
                        // Spacing
                        break;

                    case >= '0' and <= '9':
                        if (x % 2 != 0) throw new ArgumentException();

                        sites.Add(new Site(x * _horStepSize, y * _verStepSize, int.Parse(symbol.ToString())));
                        break;

                    case >= 'A' and <= 'Z':
                        if (x % 2 == 0) // in main cell
                        {
                            points.Add(new Point(x * _horStepSize, y * _verStepSize, symbol, symbol >= 'W'));
                        }
                        else // in spacing, which means it's for the previous cell
                        {
                            if (line[x - 1] < '0' || line[x - 1] > '9') throw new ArgumentException();

                            points.Add(new Point((x - 1) * _horStepSize, y * _verStepSize, symbol, symbol >= 'W'));
                        }

                        break;

                    default:
                        throw new ArgumentException();
                }
            }
        }

        sites.Sort((s1, s2) => s1.Id.CompareTo(s2.Id));

        List<Edge> edges = [ ];

        bool seenSite = false;

        for (int ex = verSteps + 2; ex < lines.Length; ex++)
        {
            string line = lines[ex];

            // Expecting:
            // "A-B: 1,2"
            // "A-B: 1"
            // "1: ABCD"
            // "1: ABCD !"

            if (line.Length < 1) throw new ArgumentException();

            char firstSymbol = line[0];

            if (firstSymbol >= 'A' && firstSymbol <= 'Z')
            {
                if (seenSite) throw new ArgumentException();

                if (line.Length != 3 && line.Length < 6) throw new ArgumentException();

                int fromId = firstSymbol;
                Point? fromPoint = points.FirstOrDefault(p => p.Id == fromId);

                if (fromPoint == null) throw new ArgumentException();

                char toIdSymbol = line[2];
                if (toIdSymbol < 'A' || toIdSymbol > 'Z') throw new ArgumentException();

                int toId = toIdSymbol;
                Point? toPoint = points.FirstOrDefault(p => p.Id == toId);

                if (toPoint == null) throw new ArgumentException();

                if (line[1] != '-') throw new ArgumentException();

                if (fromPoint == toPoint) throw new ArgumentException();

                List<Site> edgeSites = [ ];

                if (line.Length != 3)
                {

                    if (line[3] != ':') throw new ArgumentException();
                    if (line[4] != ' ') throw new ArgumentException();

                    string siteString = line.Substring(5);

                    string[] siteSymbolStrings = siteString.Split(",");

                    if (siteSymbolStrings.Length > 2) throw new ArgumentException();

                    foreach (string siteSymbolString in siteSymbolStrings)
                    {
                        if (siteSymbolString.Length != 1) throw new ArgumentException();

                        char siteSymbol = siteSymbolString[0];

                        if (siteSymbol < '0' || siteSymbol > '9') throw new ArgumentException();

                        int siteId = int.Parse(siteSymbol.ToString());
                        Site? site = sites.FirstOrDefault(p => p.Id == siteId);

                        if (site == null) throw new ArgumentException();

                        if (edgeSites.Contains(site)) throw new ArgumentException();

                        edgeSites.Add(site);
                    }
                }

                bool border = edgeSites.Count <= 1; // any other edge has 2 sites by definition

                edges.Add(new Edge(fromPoint, toPoint, edgeSites, border));
            }
            else if (firstSymbol >= '0' && firstSymbol <= '9')
            {
                seenSite = true;

                int siteId = int.Parse(firstSymbol.ToString());
                Site? site = sites.FirstOrDefault(p => p.Id == siteId);

                if (site == null) throw new ArgumentException();

                if (line[1] != ':') throw new ArgumentException();

                if (line[2] != ' ') throw new ArgumentException();

                string pointString = line.Substring(3);

                string[] pointStringSections = pointString.Split(' ');

                if (pointStringSections.Length > 2) throw new ArgumentException();

                string pointSection = pointStringSections[0];

                if (pointStringSections.Length == 2)
                {
                    string modifierSection = pointStringSections[1];

                    if (modifierSection.Length != 1) throw new ArgumentException();
                    if (modifierSection[0] != '!') throw new ArgumentException();

                    site.UndefinedPointOrder = true;
                }

                if (site.UndefinedPointOrder)
                    site.Points = [ [ ] ];
                else
                    site.Points = [ [ ], [ ], [ ], [ ], [ ], [ ], [ ], [ ] ];

                for (int c = 0; c < pointSection.Length; c++)
                {
                    char idSymbol = pointSection[c];
                    int id = idSymbol;

                    Point? point = points.FirstOrDefault(p => p.Id == id);

                    if (point == null) throw new ArgumentException();

                    int quadrant;

                    if (site.UndefinedPointOrder)
                        quadrant = 0;
                    else
                        quadrant = GetQuadrant(minX, minY, maxX, maxY, site, point);

                    site.Points[quadrant].Add(point);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        // Base version of the test
        Test newTest = new Test(
            minX, minY, maxX, maxY, name,
            sites, points, edges,
            null, null, null
        );

        // Test variants
        
        List<LayoutTransform?> transforms = TransformToTransformsList();
        List<LayoutOffset?> offsets = [ null, LayoutOffset.CenteredAtOrigin, LayoutOffset.ShiftedTowardsOrigin, LayoutOffset.ShiftwedAwayFromOrigin ];

        foreach (LayoutTransform? wantedTransform in transforms)
        {
            foreach (LayoutOffset? offset in offsets)
            {
                Test test = newTest;
                
                if (wantedTransform != null)
                    test = test.Transform(wantedTransform.Value);

                if (offset != null)
                    test = test.Shift(offset.Value);
                    
                _tests.Add(test);
            }
        }

        return;

        
        List<LayoutTransform?> TransformToTransformsList()
        {
            if (transform == null) // we are not repeating
                return [ null ]; // just the original test
            
            if (width != height) throw new InvalidOperationException();

            return transform.Value switch
            {
                LayoutTransforms.Rotate90           => [ null, LayoutTransform.Rotate90 ],
                LayoutTransforms.Rotate180          => [ null, LayoutTransform.Rotate180 ],
                LayoutTransforms.Rotate270          => [ null, LayoutTransform.Rotate270 ],
                LayoutTransforms.Mirror             => [ null, LayoutTransform.Mirror ],
                LayoutTransforms.RotateAll          => [ null, LayoutTransform.Rotate90, LayoutTransform.Rotate180, LayoutTransform.Rotate270 ],
                LayoutTransforms.RotateAndMirrorAll => [ null, LayoutTransform.Rotate90, LayoutTransform.Rotate180, LayoutTransform.Rotate270, LayoutTransform.Mirror, LayoutTransform.MirrorAndRotate90, LayoutTransform.MirrorAndRotate180, LayoutTransform.MirrorAndRotate270 ],
                LayoutTransforms.MirrorAndRotate90  => [ null, LayoutTransform.MirrorAndRotate90 ],
                LayoutTransforms.MirrorAndRotate180 => [ null, LayoutTransform.MirrorAndRotate180 ],
                LayoutTransforms.MirrorAndRotate270 => [ null, LayoutTransform.MirrorAndRotate270 ],

                _ => throw new ArgumentOutOfRangeException()
            };

        }
    }

    internal string GenerateCode(string className, TestPurpose purpose, TestBorderLogic borderLogic)
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine(@"using NUnit.Framework;");
        stringBuilder.AppendLine(@"using System.Collections.Generic;");
        stringBuilder.AppendLine(@"using System.Linq;");
        stringBuilder.AppendLine(@"using static SharpVoronoiLib.UnitTests.CommonTestUtilities;");
        stringBuilder.AppendLine();
        stringBuilder.AppendLine(@"#pragma warning disable");
        stringBuilder.AppendLine(@"// ReSharper disable All");
        stringBuilder.AppendLine();
        stringBuilder.AppendLine(@"namespace SharpVoronoiLib.UnitTests;");
        stringBuilder.AppendLine();
        List<string> classSummary = BuildClassSummary(purpose, borderLogic);
        foreach (string summaryLine in classSummary)
            stringBuilder.AppendLine(summaryLine);
        stringBuilder.AppendLine(@"[Parallelizable(ParallelScope.All)]");
        stringBuilder.AppendLine(@"[TestFixture]");
        stringBuilder.AppendLine(@"public class " + className);
        stringBuilder.AppendLine(@"{");

        foreach (Test test in _tests)
        {
            // Header

            if (test.Transformed != null)
            {
                List<string> summary = BuildSummary(test.Transformed!.Value, test.OriginalName!);
                foreach (string summaryLine in summary)
                    stringBuilder.AppendPaddedLine(1, summaryLine);
            }

            stringBuilder.AppendPaddedLine(1, @"[Test]");
            stringBuilder.AppendPaddedLine(1, @"public void " + test.Name + @"()");
            stringBuilder.AppendPaddedLine(1, @"{");

            // Arrange

            stringBuilder.AppendPaddedLine(2, @"// Arrange", true);

            stringBuilder.AppendPaddedLine(2, @"List<VoronoiSite> sites = new List<VoronoiSite>");
            stringBuilder.AppendPaddedLine(2, @"{");
            List<string> siteDefinitions = BuildSiteDefinitions(test.Sites);
            foreach (string siteDefinition in siteDefinitions)
                stringBuilder.AppendPaddedLine(3, siteDefinition);
            stringBuilder.AppendPaddedLine(2, @"};");
            stringBuilder.AppendLine();

            List<string> visualLayout = BuildVisualLayout(test, borderLogic);
            foreach (string visualLayoutString in visualLayout)
                stringBuilder.AppendPaddedLine(2, visualLayoutString);
            stringBuilder.AppendLine();

            // Act

            stringBuilder.AppendPaddedLine(2, @"// Act", true);

            stringBuilder.AppendPaddedLine(2, @"List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, " + test.MinX + @", " + test.MinY + @", " + test.MaxX + @", " + test.MaxY + BorderLogicToRealEnumParam(borderLogic) + @");");
            stringBuilder.AppendLine();

            // Assume + Assert

            switch (purpose)
            {
                case TestPurpose.AssertEdges:
                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, true));
                    break;

                case TestPurpose.AssertSitePoints:
                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, true));
                    break;

                case TestPurpose.AssertEdgeSites:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildEdgeSiteAssertions(test.Edges, borderLogic, true));
                    break;

                case TestPurpose.AssertEdgeNeighbours:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildEdgeNeighboursAssertions(test.Edges, borderLogic, true));
                    break;

                case TestPurpose.AssertSiteEdges:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildSiteEdgeAssertions(test.Edges, test.Sites, borderLogic, false, true));
                    break;

                case TestPurpose.AssertSiteCentroids:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildSiteCentroidsAssertions(test.Sites, borderLogic, true));
                    break;

                case TestPurpose.AssertSiteEdgesClockwise:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                    stringBuilder.AppendLine();
                    AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildSiteEdgeAssertions(test.Edges, test.Sites, borderLogic, true, true));
                    break;

                case TestPurpose.AssertSiteNeighbours:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildSiteNeighboursAssertions(test.Sites, test.Edges, borderLogic, true));
                    break;

                case TestPurpose.AssertSitePointsClockwise:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, true, true));
                    break;

                case TestPurpose.AssertPointBorderLocation:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                    stringBuilder.AppendLine();
                    AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildPointBorderLocationAssertions(test, test.Edges, borderLogic, true));
                    break;

                case TestPurpose.AssertLiesOnEdgeOrCorner:
                    stringBuilder.AppendPaddedLine(2, @"// Assume", true);
                    AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                    stringBuilder.AppendLine();
                    AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                    stringBuilder.AppendLine();

                    stringBuilder.AppendPaddedLine(2, @"// Assert", true);
                    AppendAssertions(BuildLiesOnEdgeOrCornerAssertions(test.Edges, test.Sites, borderLogic, true));
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(purpose), purpose, null);
            }

            void AppendAssertions(IEnumerable<string> assertions)
            {
                foreach (string assertion in assertions)
                    stringBuilder.AppendPaddedLine(2, assertion);
            }

            // Footer

            stringBuilder.AppendPaddedLine(1, @"}", true);
        }

        stringBuilder.AppendLine(@"}");

        return stringBuilder.ToString();
    }


    private int GetQuadrant(int minX, int minY, int maxX, int maxY, Site site, Point point)
    {
        //            ^ Y
        //            |
        //         3  2  1
        //      3     |     1
        //     3      |      1
        // ---4-------+-------0--> X
        //     5      |      7
        //      5     |     7
        //         5  6  7
        //            |

        if (point.Y < site.Y)
        {
            if (point.X < site.X)
                return 5;
            else if (point.X > site.X)
                return 7;
            else // if (point.X == site.X)
                return 6;
        }
        else if (point.Y > site.Y)
        {
            if (point.X < site.X)
                return 3;
            else if (point.X > site.X)
                return 1;
            else // if (point.X == site.X)
                return 2;
        }
        else // if (point.Y == site.Y)
        {
            if (point.X < site.X)
                return 4;
            else if (point.X > site.X)
                return 0;
            else // if (point.X == site.X)
            {
                // Ambiguous - site and point are at the same location
                // Hard-coded to our cases where we know we place these as border/corner tests

                // 2 +---------+ 0
                //   |         |
                //   |    ·    |
                //   |         |
                // 4 +---------+ 6

                if (point.X == minX && point.Y == minY)
                    return 4;
                if (point.X == minX && point.Y == maxY)
                    return 2;
                if (point.X == maxX && point.Y == minY)
                    return 6;
                if (point.X == maxX && point.Y == maxY)
                    return 0;
                else
                    throw new InvalidOperationException();
            }
        }
    }

    private bool EdgeMatchesBorderLogic(Edge edge, TestBorderLogic borderLogic)
    {
        switch (borderLogic)
        {
            case TestBorderLogic.UnclosedBorders:
                return !edge.Border;

            case TestBorderLogic.ClosedBorders:
                return true;

            default:
                throw new ArgumentOutOfRangeException(nameof(borderLogic), borderLogic, null);
        }
    }

    private bool PointMatchesBorderLogic(Point point, TestBorderLogic borderLogic)
    {
        switch (borderLogic)
        {
            case TestBorderLogic.UnclosedBorders:
                return !point.Corner;

            case TestBorderLogic.ClosedBorders:
                return true;

            default:
                throw new ArgumentOutOfRangeException(nameof(borderLogic), borderLogic, null);
        }
    }

    private int CountExpectedRelevantEdges(List<Edge> edges, TestBorderLogic borderLogic)
    {
        return edges.Count(e => EdgeMatchesBorderLogic(e, borderLogic));
    }

    private string BorderLogicToRealEnumParam(TestBorderLogic borderLogic)
    {
        switch (borderLogic)
        {
            case TestBorderLogic.UnclosedBorders:
                return ", " + nameof(BorderEdgeGeneration) + "." + nameof(BorderEdgeGeneration.DoNotMakeBorderEdges);

            case TestBorderLogic.ClosedBorders:
                return ""; // nameof(BorderEdgeGeneration) + "." + nameof(BorderEdgeGeneration.MakeBorderEdges); -- default

            default:
                throw new ArgumentOutOfRangeException(nameof(borderLogic), borderLogic, null);
        }
    }

    private List<string> BuildClassSummary(TestPurpose purpose, TestBorderLogic borderLogic)
    {
        List<string> strings =
        [
            @"/// <summary>"
        ];

        switch (purpose)
        {
            case TestPurpose.AssertEdges:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiEdge) + @"""/>`s are returned as expected");
                strings.Add(@"/// Specifically, that the result of <see cref=""" + nameof(VoronoiPlane) + @"." + nameof(VoronoiPlane.Tessellate) + @"""/>() contains the expected edges.");
                break;

            case TestPurpose.AssertSiteEdges:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected <see cref=""" + nameof(VoronoiEdge) + @"""/>`s.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Cell) + @"""/> contains the expected edges.");
                break;

            case TestPurpose.AssertSiteEdgesClockwise:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected clockwise-sorted <see cref=""" + nameof(VoronoiEdge) + @"""/>`s.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.ClockwiseCell) + @"""/> contains the expected edges in clockwise order.");
                break;

            case TestPurpose.AssertEdgeSites:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiEdge) + @"""/>`s have expected <see cref=""" + nameof(VoronoiSite) + @"""/>`s.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiEdge) + @"." + nameof(VoronoiEdge.Left) + @"""/> and <see cref=""" + nameof(VoronoiEdge) + @"." + nameof(VoronoiEdge.Right) + @"""/> are the expected sites.");
                break;

            case TestPurpose.AssertEdgeNeighbours:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiEdge) + @"""/>`s have expected neighbouring edges.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiEdge) + @"." + nameof(VoronoiEdge.Neighbours) + @"""/> contains the expected <see cref=""" + nameof(VoronoiEdge) + @"""/>`s.");
                break;

            case TestPurpose.AssertSiteNeighbours:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected neighbouring sites.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Neighbours) + @"""/> contains the expected <see cref=""" + nameof(VoronoiSite) + @"""/>`s.");
                break;

            case TestPurpose.AssertSitePoints:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected <see cref=""" + nameof(VoronoiPoint) + @"""/>`s.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Points) + @"""/> contains the expected points.");
                break;

            case TestPurpose.AssertSitePointsClockwise:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected clockwise-sorted <see cref=""" + nameof(VoronoiPoint) + @"""/>`s.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.ClockwisePoints) + @"""/> contains the expected points in clockwise order.");
                break;

            case TestPurpose.AssertLiesOnEdgeOrCorner:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected flags for being on an edge or corner.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.LiesOnEdge) + @"""/> is set when the site is on exactly one of its <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Cell) + @"""/> edges.");
                strings.Add(@"/// And that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.LiesOnCorner) + @"""/> is set when the site is on exactly two of its <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Cell) + @"""/> edges, i.e. the point between them.");
                break;

            case TestPurpose.AssertPointBorderLocation:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiPoint) + @"""/>`s have the expected <see cref=""" + nameof(PointBorderLocation) + @"""/>.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiPoint) + @"." + nameof(VoronoiPoint.BorderLocation) + @"""/> has the expected value.");
                break;

            case TestPurpose.AssertSiteCentroids:
                strings.Add(@"/// These tests assert that <see cref=""" + nameof(VoronoiSite) + @"""/>`s have expected the expected centroid point.");
                strings.Add(@"/// Specifically, that the <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Centroid) + @"""/> matches the centroid of its closed polygon <see cref=""" + nameof(VoronoiSite) + @"." + nameof(VoronoiSite.Cell) + @"""/>.");
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(purpose), purpose, null);
        }

        switch (borderLogic)
        {
            case TestBorderLogic.UnclosedBorders:
                strings.Add(@"/// These tests are run without generating the border edges, i.e. <see cref=""" + nameof(BorderEdgeGeneration) + @"." + nameof(BorderEdgeGeneration.DoNotMakeBorderEdges) + @"""/>.");
                break;

            case TestBorderLogic.ClosedBorders:
                strings.Add(@"/// These tests are run with generating the border edges, i.e. <see cref=""" + nameof(BorderEdgeGeneration) + @"." + nameof(BorderEdgeGeneration.MakeBorderEdges) + @"""/>.");
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(borderLogic), borderLogic, null);
        }

        strings.Add(@"/// </summary>");

        strings.Add(@"/// <remarks>");
        strings.Add(@"/// This is an AUTO-GENERATED test fixture class from UnitTestGenerator.");
        strings.Add(@"/// This is one of the several auto-generated fixture classes each checking a different part of the algorithm's result.");
        strings.Add(@"/// It contains a bunch of known Voronoi site layouts, including many edge cases.");
        strings.Add(@"/// </remarks>");

        return strings;
    }

    private List<string> BuildSummary(LayoutTransform transform, string originalName)
    {
        List<string> strings =
        [
            @"/// <summary>",
            @"/// This test basically repeats <see cref=""" + originalName + @"""/> above,",
            @"/// but all coordinates are " + TransformToExplanation(transform) + ".",
            @"/// </summary>"
        ];

        return strings;
    }

    private string TransformToExplanation(LayoutTransform transform)
    {
        switch (transform)
        {
            case LayoutTransform.Rotate90:           return "rotated 90° around the center of the boundary";
            case LayoutTransform.Rotate180:          return "rotated 180° around the center of the boundary";
            case LayoutTransform.Rotate270:          return "rotated 270° around the center of the boundary";
            case LayoutTransform.Mirror:             return "mirrored horizontally";
            case LayoutTransform.MirrorAndRotate90:  return "mirrored horizontally and then rotated 90° around the center of the boundary";
            case LayoutTransform.MirrorAndRotate180: return "mirrored horizontally and then rotated 180° around the center of the boundary";
            case LayoutTransform.MirrorAndRotate270: return "mirrored horizontally and then rotated 270° around the center of the boundary";

            default:
                throw new ArgumentOutOfRangeException(nameof(transform), transform, null);
        }
    }

    private List<string> BuildSiteDefinitions(List<Site> sites)
    {
        List<string> strings = [ ];

        foreach (Site site in sites)
        {
            strings.Add(@"new VoronoiSite(" + site.X + @", " + site.Y + @"), // #" + site.Id);
        }

        return strings;
    }

    private List<string> BuildEdgeAssertions(List<Edge> edges, TestBorderLogic borderLogic, bool assert)
    {
        List<string> strings = [ ];

        int expectedCount = CountExpectedRelevantEdges(edges, borderLogic);
                
        strings.Add(
            GetAssertEqualsText(
                assert,
                expectedCount,
                @"edges.Count", "Expected: edge count " + expectedCount
            )
        );

        strings.Add(
            GetAssertNotNullText(
                assert,
                @"edges"
            )
        );

        foreach (Edge edge in edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)))
        {
            string comment = (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id;
                    
            strings.Add(
                GetAssertTrueText(
                    assert,
                    @"HasEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")",
                    @"Expected: has edge " + comment
                ) +
                @" // " + comment
            );
        }

        return strings;
    }

    private string GetAssertEqualsText(bool assert, object expected, object actual, string? message = null, object? within = null)
    {
        return
            (assert ? @"Assert" : @"Assume") + @".That(" +
            actual +
            @", Is.EqualTo(" + expected + @")" +
            (message != null ? @", """ + message + @"""" : null) +
            (within != null ? @".Within(" + within + @")" : null) +
            @");";
    }

    private string GetAssertNotNullText(bool assert, object actual, string? message = null)
    {
        return
            (assert ? @"Assert" : @"Assume") + @".That(" + 
            actual + 
            @", Is.Not.Null" +
            (message != null ? @", """ + message + @"""" : null) +
            @");";
    }

    private string GetAssertNullText(bool assert, object actual, string? message = null)
    {
        return
            (assert ? @"Assert" : @"Assume") + @".That(" + 
            actual + 
            @", Is.Null" +
            (message != null ? @", """ + message + @"""" : null) +
            @");";
    }

    private string GetAssertTrueText(bool assert, object actual, string? message = null)
    {
        return
            (assert ? @"Assert" : @"Assume") + @".That(" + 
            actual + 
            @", Is.True" +
            (message != null ? @", """ + message + @"""" : null) +
            @");";
    }

    private List<string> BuildEdgeSiteAssertions(List<Edge> edges, TestBorderLogic borderLogic, bool assert)
    {
        List<string> strings = [ ];

        List<Edge> matchingEdges = edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)).ToList();

        if (matchingEdges.Count > 0)
        {
            foreach (Edge edge in matchingEdges)
            {
                foreach (Site site in edge.EdgeSites)
                {
                    strings.Add(
                        GetAssertTrueText(
                            assert,
                            @"EdgeHasSite(FindEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @"), " + site.X + @", " + site.Y + @")"
                        ) +
                        @" // " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id + " has #" + site.Id + @""
                    );
                }
            }
        }
        else
        {
            if (assert)
            {
                strings.Add("// There are no edges, so nothing to check");
                strings.Add("Assert.Pass();");
            }
        }

        return strings;
    }

    private List<string> BuildEdgeNeighboursAssertions(List<Edge> edges, TestBorderLogic borderLogic, bool assert)
    {
        List<string> strings = [ ];

        bool first = true;

        List<Edge> matchingEdges = edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)).ToList();

        if (matchingEdges.Count > 0)
        {
            foreach (Edge edge in matchingEdges)
            {
                // Find other edges that have a point that we have

                List<Edge> neighbours = edges
                                        .Where(e =>
                                                   e != edge &&
                                                   EdgeMatchesBorderLogic(e, borderLogic) &&
                                                   e.Points()
                                                    .Any(p => p == edge.FromPoint || p == edge.ToPoint)
                                        ).ToList();

                strings.Add((first ? nameof(VoronoiEdge) + @" " : "") + @"edge = FindEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @"); // " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id);
                first = false; // don't redefine the variable again, only set value

                strings.Add(
                    GetAssertNotNullText(
                        assert,
                        "edge." + nameof(VoronoiEdge.Neighbours)
                    )
                );

                strings.Add(
                    GetAssertEqualsText(
                        assert,
                        neighbours.Count,
                        @"edge" + @"." + nameof(VoronoiEdge.Neighbours) + @".Count()",
                        "Expected: edge neighbour count " + neighbours.Count
                    )
                );

                foreach (Edge neighbour in neighbours)
                {
                    string comment = (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id + " neighbours " + (char)neighbour.FromPoint.Id + @"-" + (char)neighbour.ToPoint.Id;

                    strings.Add(
                        GetAssertTrueText(
                            assert,
                            @"edge." + nameof(VoronoiEdge.Neighbours) + @".Contains(FindEdge(edges, " + neighbour.FromPoint.X + @", " + neighbour.FromPoint.Y + @", " + neighbour.ToPoint.X + @", " + neighbour.ToPoint.Y + @"))",
                            "Expected: edge " + comment
                        ) + 
                        @" // " + comment
                    );
                }
            }
        }
        else
        {
            if (assert)
            {
                strings.Add("// There are no edges, so nothing to check");
                strings.Add("Assert.Pass();");
            }
        }

        return strings;
    }

    private List<string> BuildSiteNeighboursAssertions(List<Site> sites, List<Edge> edges, TestBorderLogic borderLogic, bool assert)
    {
        List<string> strings = [ ];

        if (sites.Count > 0)
        {
            foreach (Site site in sites.OrderBy(s => s.Id))
            {
                // Find other sites that have an edge that we have

                IEnumerable<Edge> siteEdges = edges
                                              .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                                              .Where(e => e.EdgeSites.Contains(site));

                List<Site> neighbours = sites
                                        .Where(s =>
                                                   s != site &&
                                                   siteEdges.Intersect(
                                                       // We need to get edges for the site
                                                       edges
                                                           .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                                                           .Where(e => e.EdgeSites.Contains(s))
                                                   ).Any())
                                        .OrderBy(s => s.Id)
                                        .ToList();

                strings.Add(
                    GetAssertNotNullText(
                        assert,
                        @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.Neighbours)
                    )
                );

                strings.Add(
                    GetAssertEqualsText(
                        assert,
                        neighbours.Count,
                        @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiEdge.Neighbours) + @".Count()"
                    )
                );

                foreach (Site neighbour in neighbours)
                {
                    strings.Add(
                        GetAssertTrueText(
                            assert,
                            @"sites[" + sites.IndexOf(site) + @"]." + nameof(VoronoiSite.Neighbours) + @".Contains(sites[" + sites.IndexOf(neighbour) + @"])"
                        ) +
                        @" // " + site.Id + @" neighbours " + neighbour.Id
                    );
                }
            }
        }
        else
        {
            if (assert)
            {
                strings.Add("// There are no sites, so nothing to check");
                strings.Add("Assert.Pass();");
            }
        }

        return strings;
    }

    private List<string> BuildSitePointsAssertions(List<Edge> edges, List<Site> sites, TestBorderLogic borderLogic, bool clockwise, bool assert)
    {
        List<string> strings = [ ];

        if (sites.Count > 0)
        {
            foreach (Site site in sites.OrderBy(s => s.Id))
            {
                List<Point> points = edges
                                     .Where(e =>
                                                EdgeMatchesBorderLogic(e, borderLogic) &&
                                                e.EdgeSites.Contains(site))
                                     .SelectMany(e => e.Points())
                                     .Distinct() // edges connect at points, so there's repeats
                                     .OrderBy(p => p.Id)
                                     .ToList();

                string listName = clockwise ? nameof(VoronoiSite.ClockwisePoints) : nameof(VoronoiSite.Points);

                strings.Add(
                    GetAssertNotNullText(
                        assert,
                        @"sites[" + sites.IndexOf(site) + @"]" + @"." + listName
                    )
                );

                strings.Add(
                    GetAssertEqualsText(
                        assert,
                        points.Count,
                        @"sites[" + sites.IndexOf(site) + @"]" + @"." + listName + @".Count()",
                        @"Expected: site #" + site.Id + @" point count " + points.Count
                    ) + 
                    @" // #" + site.Id
                );

                foreach (Point point in points)
                {
                    string comment = @"#" + site.Id + " has " + (char)point.Id;
                    strings.Add(
                        GetAssertTrueText(
                            assert,
                            @"HasPoint(sites[" + sites.IndexOf(site) + @"]." + listName + @", " + point.X + @", " + point.Y + @")",
                            @"Expected: site " + comment
                        ) + 
                        @" // " + comment
                    );
                }

                if (clockwise)
                {
                    int index = 0;

                    foreach (List<Point> quadrantPoints in site.Points.Reverse()) // we are counter-clockwise, so reverse
                    {
                        List<Point> applicablePoints = quadrantPoints.Where(p => PointMatchesBorderLogic(p, borderLogic)).Reverse().ToList(); // we are counter-clockwise, so reverse

                        if (applicablePoints.Count > 0)
                        {
                            if (!site.UndefinedPointOrder)
                            {
                                foreach (Point point in applicablePoints)
                                {
                                    strings.Add(
                                        GetAssertTrueText(
                                            assert,
                                            @"PointIs(sites[" + sites.IndexOf(site) + @"]" + @"." + listName + @".ElementAt(" + index + @"), " + point.X + @", " + point.Y + @")"
                                        ) +
                                        @" // #" + site.Id + @" " + (char)point.Id
                                    );

                                    index++;
                                }
                            }
                            else
                            {
                                strings.Add("// Exact starting point is undefined, so we only check that points are sequential");
                                // we only have 1 "quadrant" for undefined order, so this will only appear once so we can keep it nested

                                for (int i = 0; i < applicablePoints.Count; i++)
                                {
                                    Point point1 = applicablePoints[i];
                                    Point point2 = applicablePoints[i == applicablePoints.Count - 1 ? 0 : i + 1];

                                    strings.Add(
                                        GetAssertTrueText(
                                            assert,
                                            @"PointsAreSequential(sites[" + sites.IndexOf(site) + @"]" + @"." + listName + @", " + point1.X + @", " + point1.Y + @", " + point2.X + @", " + point2.Y + @")"
                                        ) + 
                                        @" // #" + site.Id + @" " + (char)point1.Id + " > " + (char)point2.Id
                                    );
                                }
                            }
                        }
                    }
                }
            }
        }
        else
        {
            if (assert)
            {
                strings.Add("// There are no sites, so nothing to check");
                strings.Add("Assert.Pass();");
            }
        }

        return strings;
    }

    private List<string> BuildSiteCentroidsAssertions(List<Site> sites, TestBorderLogic borderLogic, bool assert)
    {
        List<string> strings = [ ];

        if (sites.Count > 0)
        {
            foreach (Site site in sites.OrderBy(s => s.Id))
            {
                List<Point> points =
                    site.Points
                        .SelectMany(sp => sp)
                        .Where(p => PointMatchesBorderLogic(p, borderLogic))
                        .ToList();

                (double centroidX, double centroidY) = GetSiteCentroid(site, points, borderLogic, out string formula);

                strings.Add(@"// Centroid of #" + site.Id + @" in " + string.Join("-", points.Select(p => (char)p.Id)) + @" is at ~(" + centroidX.ToString("F0") + @", " + centroidY.ToString("F0") + ") (using " + formula + " formula)");

                strings.Add(
                    GetAssertEqualsText(
                        assert,
                        centroidX.ToString("F2"),
                        @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.Centroid) + @"." + nameof(VoronoiPoint.X),
                        null,
                        @"0.01"
                    )
                );

                strings.Add(
                    GetAssertEqualsText(
                        assert,
                        centroidY.ToString("F2"),
                        @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.Centroid) + @"." + nameof(VoronoiPoint.Y),
                        null,
                        @"0.01"
                    )
                );
            }
        }
        else
        {
            if (assert)
            {
                strings.Add("// There are no sites, so nothing to check");
                strings.Add("Assert.Pass();");
            }
        }

        return strings;
    }

    private (double centroidX, double centroidY) GetSiteCentroid(Site site, List<Point> points, TestBorderLogic borderLogic, out string formula)
    {
        if (borderLogic == TestBorderLogic.UnclosedBorders)
        {
            int allPointsCount = site.Points.Sum(sp => sp.Count);

            if (points.Count != allPointsCount) // unclosed polygon, just do regular
            {
                formula = "generic closed polygon";
                return ComputeCentroid(site, points);
            }
        }

        // At this point, I can just calculate the centroid with the generic formula above.
        // But the point is that I want to have some different methods when testing.
        // So these are hard-coded formulas for certain cases.
        // I can't really do anything about convoluted cases without manually verifying each result.
        // But if these work, then the generic formula likely works too.

        if (points.Count == 3)
        {
            // Triangle centroid is x = 1/3 (Ax + Bx + Cx) and same for y

            formula = "triangle";

            return (
                (points[0].X + points[1].X + points[2].X) / 3.0,
                (points[0].Y + points[1].Y + points[2].Y) / 3.0
            );
        }

        if (points.Count == 4)
        {
            if (IsRectangle(points, out Point? c1, out Point? c2))
            {
                // Rectangle centroid is x = Wx / 2 and y = Hy / 2

                formula = "rectangle";

                return (
                    (c1!.X + c2!.X) / 2.0,
                    (c1.Y + c2.Y) / 2.0
                );
            }

            // Any quadrilateral

            formula = "quadrilateral";
            return GetQuadrilateralCentroid(points[0], points[1], points[2], points[3]);
        }

        // At this point I have 4+ sides polygons and there aren't any useful formulas

        formula = "generic closed polygon";
        return ComputeCentroid(site, points);


        static (double centroidX, double centroidY) GetQuadrilateralCentroid(Point p1, Point p2, Point p3, Point p4)
        {
            // Quadrilateral centroid is the intersection point of lines between centroids of opposite triangles within the polygon
            // See https://math.stackexchange.com/a/2878092/478109

            // 1-----4
            // | \ / |
            // |  X  |
            // | / \ |
            // 2-----3

            (double x1, double y1) = ( // 1 2 3 (opposite 3 4 1)
                    (p1.X + p2.X + p3.X) / 3.0,
                    (p1.Y + p2.Y + p3.Y) / 3.0
                );
            (double x2, double y2) = ( // 3 4 1
                    (p3.X + p4.X + p1.X) / 3.0,
                    (p3.Y + p4.Y + p1.Y) / 3.0
                );
            (double x3, double y3) = ( // 2 3 4 (opposite 4 1 2)
                    (p2.X + p3.X + p4.X) / 3.0,
                    (p2.Y + p3.Y + p4.Y) / 3.0
                );
            (double x4, double y4) = ( // 4 1 2
                    (p4.X + p1.X + p2.X) / 3.0,
                    (p4.Y + p1.Y + p2.Y) / 3.0
                );

            // +-----+
            // | 4 2 |
            // |     |
            // | 1 3 |
            // +-----+

            double det12 = x1 * y2 - y1 * x2;
            double det34 = x3 * y4 - y3 * x4;
            double x12 = x1 - x2;
            double x34 = x3 - x4;
            double y12 = y1 - y2;
            double y34 = y3 - y4;
            double xnom = det12 * x34 - x12 * det34;
            double ynom = det12 * y34 - y12 * det34;
            double denom = x12 * y34 - y12 * x34;

            return (
                xnom / denom,
                ynom / denom
            );
        }

        // Copy of <see cref="VoronoiSite.ComputeCentroid"/>
        static (double x, double y) ComputeCentroid(Site site, List<Point> points)
        {
            double centroidX = 0;
            double centroidY = 0;
            double area = 0;

            for (int i = 0; i < points.Count; i++)
            {
                int i2 = i == points.Count - 1 ? 0 : i + 1;

                double xi = points[i].X;
                double yi = points[i].Y;
                double xi2 = points[i2].X;
                double yi2 = points[i2].Y;

                double mult = (xi * yi2 - xi2 * yi) / 3;
                double addX = (xi + xi2) * mult;
                double addY = (yi + yi2) * mult;

                double addArea = xi * yi2 - xi2 * yi;

                if (i == 0)
                {
                    centroidX = addX;
                    centroidY = addY;
                    area = addArea;
                }
                else
                {
                    centroidX += addX;
                    centroidY += addY;
                    area += addArea;
                }
            }

            if (area.ApproxEqual(0))
                return (site.X, site.Y);

            centroidX /= area;
            centroidY /= area;

            return (centroidX, centroidY);
        }

        static bool IsRectangle(List<Point> points, out Point? corner1, out Point? corner2)
        {
            // Points are ordered ccw,
            // so there are only 2 possible rectangles - as given and rotated 90°
            // 1--4      4--3
            // |  |  or  |  |
            // 2--3      1--2
            // All other cases are symmetric

            // 1-2-3-4
            if (ArePointsInARectangle(points[0], points[1], points[2], points[3]))
            {
                corner1 = points[0];
                corner2 = points[2];
                // This is 1-3 but could equally use 2-4 (or 3-1 or 4-2)
                return true;
            }

            // 4-1-2-3
            if (ArePointsInARectangle(points[3], points[0], points[1], points[2]))
            {
                corner1 = points[0];
                corner2 = points[2];
                // This is 4-2 but could equally use 1-3 (or 3-1 or 2-4)
                return true;
            }

            corner1 = null;
            corner2 = null;
            return false;


            static bool ArePointsInARectangle(Point p1, Point p2, Point p3, Point p4)
            {
                // Symmetric hor/ver, so:
                // 1--4      2--3      4--1      3--2
                // |  |  or  |  |  or  |  |  or  |  |
                // 2--3      1--4      3--2      4--1

                return p1.X == p2.X && // 1 and 2 on same vertical
                       p3.X == p4.X && // 3 and 4 on same vertical
                       p1.Y == p4.Y && // 1 and 4 on same horizontal
                       p2.Y == p3.Y; // 2 and 3 on same horizontal
            }
        }

    }

    private List<string> BuildLiesOnEdgeOrCornerAssertions(List<Edge> edges, List<Site> sites, TestBorderLogic borderLogic, bool assert)
    {
        List<string> strings = [ ];

        if (sites.Count > 0)
        {
            foreach (Site site in sites.OrderBy(s => s.Id))
            {
                List<Edge> onEdges = edges
                                     .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                                     .Where(e => e.EdgeSites.Contains(site))
                                     .Where(e => IsSiteOnEdge(site, e))
                                     .ToList();

                switch (onEdges.Count)
                {
                    case 0:
                        // Edge - null
                        strings.Add(
                            GetAssertNullText(
                                assert,
                                @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnEdge)
                            ) +
                            @" // #" + site.Id
                        );
                        // Corner - null
                        strings.Add(
                            GetAssertNullText(
                                assert,
                                @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnCorner)
                            ) +
                            @"// #" + site.Id
                        );
                        break;

                    case 1:
                        // Edge - set
                        Edge edge = onEdges[0];
                        strings.Add(
                            GetAssertNotNullText(
                                assert,
                                @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnEdge)
                            ) + 
                            @"// #" + site.Id
                        );
                        strings.Add(
                            GetAssertEqualsText(
                                assert,
                                @"FindEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")", 
                                @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnEdge)
                            ) +
                            @" // #" + site.Id + @" on " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id
                        );
                        // Corner - null
                        strings.Add(
                            GetAssertNullText(
                                assert,
                                @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnCorner)
                            ) +
                            @" // #" + site.Id
                        );
                        break;

                    case 2:
                        // Edge - null
                        strings.Add(
                            GetAssertNullText(
                                assert,
                                @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnEdge)
                            ) +
                            @" // #" + site.Id
                        );
                        // Corner - set
                        strings.Add(
                            GetAssertNotNullText(
                                assert,
                                @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnCorner)
                            ) + 
                            @" // #" + site.Id
                        );
                        Point point = onEdges[0].FromPoint == onEdges[1].FromPoint || onEdges[0].FromPoint == onEdges[1].ToPoint ? onEdges[0].FromPoint : onEdges[0].ToPoint;
                        strings.Add(
                            GetAssertEqualsText(
                                assert,
                                @"FindPoint(edges, " + point.X + @", " + point.Y + @")",
                                @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnCorner)
                            ) +
                            @" // #" + site.Id + @" on " + (char)point.Id
                        );
                        break;

                    case > 3:
                        throw new InvalidOperationException();
                }
            }
        }
        else
        {
            if (assert)
            {
                strings.Add("// There are no sites, so nothing to check");
                strings.Add("Assert.Pass();");
            }
        }

        return strings;


        static bool IsSiteOnEdge(Site site, Edge edge)
        {
            return ArePointsColinear(
                site.X, site.Y,
                edge.FromPoint.X, edge.FromPoint.Y,
                edge.ToPoint.X, edge.ToPoint.Y
            );
        }

        static bool ArePointsColinear(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return (x2 - x1) * (y3 - y1) == (x3 - x1) * (y2 - y1);
        }
    }

    private List<string> BuildPointBorderLocationAssertions(Test test, List<Edge> edges, TestBorderLogic borderLogic, bool assert)
    {
        List<string> strings = [ ];

        List<Point> points = edges
                             .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                             .SelectMany(e => e.Points())
                             .Distinct() // edges connect at points, so there's repeats
                             .OrderBy(p => p.Id + (p.Corner ? 10 : 0)) // corner after regular
                             .ToList();

        if (points.Count > 0)
        {
            foreach (Point point in points)
            {
                strings.Add(
                    GetAssertEqualsText(
                        assert,
                        nameof(PointBorderLocation) + @"." + PointLocationToExpectedBorderLocation(test, point),
                        @"FindPoint(edges, " + point.X + @", " + point.Y + @")." + nameof(VoronoiPoint.BorderLocation)
                    ) +
                    @"// " + (char)point.Id
                );
            }

        }
        else
        {
            if (assert)
            {
                strings.Add("// There are no points, so nothing to check");
                strings.Add("Assert.Pass();");
            }
        }

        return strings;
    }

    private PointBorderLocation PointLocationToExpectedBorderLocation(Test test, Point point)
    {
        if (point.X == test.MinX)
        {
            if (point.Y == test.MinY)
                return PointBorderLocation.BottomLeft;
            else if (point.Y == test.MaxY)
                return PointBorderLocation.TopLeft;
            else
                return PointBorderLocation.Left;
        }
        else if (point.X == test.MaxX)
        {
            if (point.Y == test.MinY)
                return PointBorderLocation.BottomRight;
            else if (point.Y == test.MaxY)
                return PointBorderLocation.TopRight;
            else
                return PointBorderLocation.Right;
        }
        else
        {
            if (point.Y == test.MinY)
                return PointBorderLocation.Bottom;
            if (point.Y == test.MaxY)
                return PointBorderLocation.Top;
            else
                return PointBorderLocation.NotOnBorder;
        }
    }

    private List<string> BuildSiteEdgeAssertions(List<Edge> edges, List<Site> allSites, TestBorderLogic borderLogic, bool clockwise, bool assert)
    {
        List<string> strings = [ ];

        List<Site> sites = edges.SelectMany(e => e.EdgeSites).Distinct().OrderBy(s => s.Id).ToList();

        if (sites.Count > 0)
        {
            foreach (Site site in sites)
            {
                List<Edge> siteEdges = edges
                                       .Where(e => EdgeMatchesBorderLogic(e, borderLogic))
                                       .Where(e => e.EdgeSites.Contains(site))
                                       .ToList();

                string listName = clockwise ? nameof(VoronoiSite.ClockwiseCell) : nameof(VoronoiSite.Cell);

                strings.Add(
                    GetAssertNotNullText(
                        assert,
                        @"sites[" + allSites.IndexOf(site) + @"]" + @"." + listName
                    )
                );

                strings.Add(
                    GetAssertEqualsText(
                        assert,
                        siteEdges.Count,
                        @"sites[" + allSites.IndexOf(site) + @"]" + @"." + listName + @".Count()"
                    ) +
                    @" // #" + site.Id
                );

                foreach (Edge siteEdge in siteEdges)
                {
                    strings.Add(
                        GetAssertTrueText(
                            assert,
                            @"HasEdge(sites[" + allSites.IndexOf(site) + @"]." + listName + @", " + siteEdge.FromPoint.X + @", " + siteEdge.FromPoint.Y + @", " + siteEdge.ToPoint.X + @", " + siteEdge.ToPoint.Y + @")"
                        ) + 
                        @" // #" + site.Id + @" has " + (char)siteEdge.FromPoint.Id + @"-" + (char)siteEdge.ToPoint.Id
                    );
                }

                if (clockwise)
                {
                    if (siteEdges.Count > 0)
                    {
                        List<Edge> orderedEdges = siteEdges.OrderBy(e => GetEdgeSoftIndex(e, site.Points)).ToList();

                        if (!site.UndefinedPointOrder)
                        {
                            for (int i = 0; i < orderedEdges.Count; i++)
                            {
                                Edge edge = orderedEdges[i];

                                strings.Add(
                                    GetAssertTrueText(
                                        assert,
                                        @"EdgeIs(sites[" + allSites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.ClockwiseCell) + @".ElementAt(" + i + @"), " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")"
                                    ) +
                                    @" // #" + site.Id + @" " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id
                                );
                            }
                        }
                        else
                        {
                            strings.Add("// Exact starting edge is undefined, so we only check that edges are sequential");

                            for (int i = 0; i < orderedEdges.Count; i++)
                            {
                                Edge edge1 = orderedEdges[i];
                                Edge edge2 = orderedEdges[i == orderedEdges.Count - 1 ? 0 : i + 1];

                                strings.Add(
                                    GetAssertTrueText(
                                        assert,
                                        @"EdgesAreSequential(sites[" + allSites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.ClockwiseCell) + @", " + edge1.FromPoint.X + @", " + edge1.FromPoint.Y + @", " + edge1.ToPoint.X + @", " + edge1.ToPoint.Y + @", " + edge2.FromPoint.X + @", " + edge2.FromPoint.Y + @", " + edge2.ToPoint.X + @", " + edge2.ToPoint.Y + @")"
                                    ) +
                                    @" // #" + site.Id + @" " + (char)edge1.FromPoint.Id + @"-" + (char)edge1.ToPoint.Id + @" > " + (char)edge2.FromPoint.Id + @"-" + (char)edge2.ToPoint.Id
                                );
                            }
                        }
                    }
                }
            }
        }
        else
        {
            if (assert)
            {
                strings.Add("// There are no sites, so nothing to check");
                strings.Add("Assert.Pass();");
            }
        }

        return strings;
    }

    private int GetEdgeSoftIndex(Edge edge, List<Point>[] sitePoints)
    {
        List<Point> flatPoints = sitePoints.SelectMany(sp => sp).Reverse().ToList();

        int fromIndex = flatPoints.IndexOf(edge.FromPoint);
        int toIndex = flatPoints.IndexOf(edge.ToPoint);

        // Points are sequential
        if (Math.Abs(toIndex - fromIndex) == 1)
            return Math.Min(fromIndex, toIndex); // select previous index (going to next)

        // Points wrap around
        if (Math.Abs(toIndex - fromIndex) == flatPoints.Count - 1)
            return Math.Max(fromIndex, toIndex); // select last index (going to first)

        throw new InvalidOperationException(
            "Points " +
            string.Join(",", flatPoints.Select(p => (char)p.Id).ToArray()) +
            " not in order for edge " + (char)edge.FromPoint.Id + " " + (char)edge.ToPoint.Id);
    }

    private List<string> BuildVisualLayout(Test test, TestBorderLogic borderLogic)
    {
        int horPreviewSteps = test.Width / _horPreviewStepSize + 1;
        int verPreviewSteps = test.Height / _verPreviewStepSize + 1;

        // Shift back element indices to origin (because offsetting tests means we cannot cleanly assume 0..width/step)
        int indexShiftX = -test.MinX / _horPreviewStepSize;
        int indexShiftY = -test.MinY / _verPreviewStepSize;

        List<Edge>?[,] edgeLines = new List<Edge>[horPreviewSteps, verPreviewSteps];

        foreach (Edge edge in test.Edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)))
            PlaceEdgeOnGrid(ref edgeLines, edge, indexShiftX, indexShiftY);

        List<string> lines = [ ];

        for (int y = verPreviewSteps - 1; y >= 0; y--)
        {
            string str = "// ";

            int verValue = y * _verPreviewStepSize - indexShiftY * _verPreviewStepSize;

            if (verValue % 100 == 0)
                str += $"{verValue,4}";
            else
                str += @"    ";

            str += @" ";

            for (int x = 0; x < horPreviewSteps; x++)
            {
                int horValue = x * _horPreviewStepSize - indexShiftX * _horPreviewStepSize;

                Site? site = test.Sites.FirstOrDefault(s => s.X == horValue && s.Y == verValue);

                if (site != null)
                {
                    str += site.Id;
                }
                else
                {
                    Point? point = test.Points.Where(e => PointMatchesBorderLogic(e, borderLogic)).FirstOrDefault(p => p.X == horValue && p.Y == verValue);

                    if (point != null)
                    {
                        str += (char)point.Id;
                    }
                    else
                    {
                        List<Edge>? edges = edgeLines[x, y];

                        if (edges != null &&
                            edges.Count > 0)
                        {
                            if (edges.Count > 1)
                                str += "#";
                            else
                                str += MakeEdgeLineSymbol(edges[0], horValue, verValue);
                        }
                        else
                        {
                            if (x == 0) // left border
                            {
                                if (y == 0)
                                    str += @"└";
                                else if (y == verPreviewSteps - 1)
                                    str += @"↑";
                                else
                                    str += @"|";
                            }
                            else if (y == 0) // bottom border
                            {
                                if (x == horPreviewSteps - 1)
                                    str += "→";
                                else
                                    str += "-";
                            }
                            else if (horValue == 0 && verValue == 0) // origin
                            {
                                str += "●";
                            }
                            else
                            {
                                str += " ";
                            }
                        }
                    }
                }
            }

            lines.Add(str);
        }

        string fs = "//    ";

        for (int x = 0; x < horPreviewSteps; x++)
        {
            int horValue = x * _horPreviewStepSize - indexShiftX * _horPreviewStepSize;

            if (horValue % 100 == 0)
                fs += $"{horValue,4} ";
        }

        lines.Add(fs);

        return lines;
    }

    private char MakeEdgeLineSymbol(Edge edge, int valueX, int valueY)
    {
        if (edge.ToPoint.X == edge.FromPoint.X)
            return '|';

        if (edge.ToPoint.Y == edge.FromPoint.Y)
            return '-';

        // How many cells does this line/site pass through?

        int xSteps = Math.Abs((edge.ToPoint.X - edge.FromPoint.X) / _horPreviewStepSize);
        int ySteps = Math.Abs((edge.ToPoint.Y - edge.FromPoint.Y) / _verPreviewStepSize);
        int totalSteps = Math.Max(xSteps, ySteps);

        // Find the closest point to the given cell's center

        double closestDistToValue = -1;
        //double closestXToValue = -1; - not using X atm
        double closestYToValue = -1;

        for (int i = 0; i <= totalSteps; i++)
        {
            double frac = (double)i / totalSteps;

            double actualX = edge.FromPoint.X + (edge.ToPoint.X - edge.FromPoint.X) * frac;
            double actualY = edge.FromPoint.Y + (edge.ToPoint.Y - edge.FromPoint.Y) * frac;

            double distX = (valueX - actualX);
            double distY = (valueY - actualY) * _horPreviewStepSize / _verPreviewStepSize; // because text isn't "square"
            double distToValue = distX * distX + distY * distY;

            if (closestDistToValue < 0 ||
                distToValue < closestDistToValue)
            {
                closestDistToValue = distToValue;
                //closestXToValue = actualX; - not using X atm
                closestYToValue = actualY;
            }
        }

        // Calculate the difference between cell center and where the line passes through the cell

        //double diffX = (valueX - closestXToValue) / _horPreviewStepSize; - not using X atm
        double diffY = (valueY - closestYToValue) / _verPreviewStepSize;

        // Choose a symbol that best "describes" this position

        char symbol = diffY switch
        {
            < -0.1 => '\'',
            > 0.1  => ',',
            _      => '·'
        };

        //Console.WriteLine(symbol + " for value " + valueX + ", " + valueY + " -> closest actual " + closestXToValue + ", " + closestYToValue + " dif " + diffX + ", " + diffY);

        return symbol;
    }

    private void PlaceEdgeOnGrid(ref List<Edge>?[,] edgeLines, Edge edge, int indexShiftX, int indexShiftY)
    {
        int x = edge.FromPoint.X / _horPreviewStepSize;
        int y = edge.FromPoint.Y / _verPreviewStepSize;
        int x2 = edge.ToPoint.X / _horPreviewStepSize;
        int y2 = edge.ToPoint.Y / _verPreviewStepSize;

        // This is Bresenham's Line Algorithm verbatim from:
        // https://stackoverflow.com/a/11683720

        int w = x2 - x;
        int h = y2 - y;
        int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
        if (w < 0) dx1 = -1;
        else if (w > 0) dx1 = 1;
        if (h < 0) dy1 = -1;
        else if (h > 0) dy1 = 1;
        if (w < 0) dx2 = -1;
        else if (w > 0) dx2 = 1;
        int longest = Math.Abs(w);
        int shortest = Math.Abs(h);
        if (!(longest > shortest))
        {
            longest = Math.Abs(h);
            shortest = Math.Abs(w);
            if (h < 0) dy2 = -1;
            else if (h > 0) dy2 = 1;
            dx2 = 0;
        }

        int numerator = longest >> 1;
        for (int i = 0; i <= longest; i++)
        {
            // Our code
            int sx = x + indexShiftX;
            int sy = y + indexShiftY;
            if (edgeLines[sx, sy] == null)
                edgeLines[sx, sy] = [ ];
            edgeLines[sx, sy]!.Add(edge);
            // End of our code
            numerator += shortest;
            if (!(numerator < longest))
            {
                numerator -= longest;
                x += dx1;
                y += dy1;
            }
            else
            {
                x += dx2;
                y += dy2;
            }
        }
    }


    private class Test
    {
        public int MinX { get; }
        public int MinY { get; }
        public int MaxX { get; }
        public int MaxY { get; }
        public int Width { get; }
        public int Height { get; }
        public List<Site> Sites { get; }
        public List<Point> Points { get; }
        public List<Edge> Edges { get; }
        public string Name { get; }
        
        public LayoutTransform? Transformed { get; }
        public LayoutOffset? Offset { get; }
        public string? OriginalName { get; }


        public Test(int minX, int minY, int maxX, int maxY, string name,
                    List<Site> sites, List<Point> points, List<Edge> edges,
                    LayoutTransform? transformed, LayoutOffset? offset, string? originalName)
        {
            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
            Sites = sites;
            Points = points;
            Edges = edges;
            Transformed = transformed;
            OriginalName = originalName;
            Name = name;
            Transformed = transformed;
            OriginalName = originalName;
            Offset = offset;

            Width = maxX - minX;
            Height = maxY - minY;
        }


        public Test Transform(LayoutTransform transform)
        {
            if (Transformed != null) throw new InvalidOperationException();
            
            
            List<Site> newSites = [ ];
            List<Point> newPoints = [ ];
            List<Edge> newEdges = [ ];

            foreach (Site site in Sites)
            {
                (int x, int y) = TransformCoord(site.X, site.Y, transform, MinX, MinY, MaxX, MaxY);
                Site newSite = new Site(x, y, site.Id);
                newSites.Add(newSite);
            }

            foreach (Point point in Points)
            {
                (int x, int y) = TransformCoord(point.X, point.Y, transform, MinX, MinY, MaxX, MaxY);
                newPoints.Add(new Point(x, y, point.Id, point.Corner));
            }

            foreach (Edge edge in Edges)
            {
                Point fromPoint = newPoints[Points.IndexOf(edge.FromPoint)];
                Point toPoint = newPoints[Points.IndexOf(edge.ToPoint)];
                List<Site> sites = [ ];
                foreach (Site site in edge.EdgeSites)
                    sites.Add(newSites[Sites.IndexOf(site)]);
                newEdges.Add(new Edge(fromPoint, toPoint, sites, edge.Border));
            }

            for (int s = 0; s < newSites.Count; s++)
            {
                Site ourSite = newSites[s];
                Site givenSite = Sites[s];

                ourSite.UndefinedPointOrder = givenSite.UndefinedPointOrder;
                if (ourSite.UndefinedPointOrder)
                    ourSite.Points = [ [ ] ];
                else
                    ourSite.Points = [ [ ], [ ], [ ], [ ], [ ], [ ], [ ], [ ] ];

                for (int sourceQuadrant = 0; sourceQuadrant < givenSite.Points.Length; sourceQuadrant++)
                {
                    int targetQuadrant;
                    if (givenSite.UndefinedPointOrder)
                        targetQuadrant = sourceQuadrant; // 0, basically
                    else
                        targetQuadrant = TransformQuadrantIndex(sourceQuadrant, transform);

                    for (int p = 0; p < givenSite.Points[sourceQuadrant].Count; p++)
                    {
                        Point givenPoint = givenSite.Points[sourceQuadrant][p];
                        Point ourPoint = newPoints[Points.IndexOf(givenPoint)];
                        ourSite.Points[targetQuadrant].Add(ourPoint);
                    }

                    if (DoesTransformMirror(transform))
                        ourSite.Points[targetQuadrant].Reverse();
                }
            }

            string name = TransformName(Name, transform);

            return new Test(
                MinX, MinY, MaxX, MaxY,
                name,
                newSites, newPoints, newEdges,
                transform, Offset, Name
            );
            
            
            static int TransformQuadrantIndex(int quadrant, LayoutTransform transform)
            {
                if (DoesTransformMirror(transform))
                    quadrant = MirrorAcrossY(quadrant);

                switch (transform)
                {
                    case LayoutTransform.Rotate90:           quadrant -= 2; break;
                    case LayoutTransform.Rotate180:          quadrant -= 4; break;
                    case LayoutTransform.Rotate270:          quadrant -= 6; break;
                    case LayoutTransform.Mirror:             break;
                    case LayoutTransform.MirrorAndRotate90:  quadrant -= 2; break;
                    case LayoutTransform.MirrorAndRotate180: quadrant -= 4; break;
                    case LayoutTransform.MirrorAndRotate270: quadrant -= 6; break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(transform), transform, null);
                }

                if (quadrant < 0)
                    quadrant += 8;

                if (quadrant >= 8)
                    quadrant -= 8;

                return quadrant;
            }

            static int MirrorAcrossY(int quadrant)
            {
                //            ^
                //            |
                //         3  2  1
                //      3     |     1
                //     3      |      1
                // ---4-------+-------0-->
                //     5      |      7
                //      5     |     7
                //         5  6  7
                //            |
                // mirrors to
                //            ^
                //            |
                //         1  2  3
                //      1     |     3
                //     1      |      3
                // ---0-------+-------4-->
                //     7      |      5
                //      7     |     5
                //         7  6  5
                //            |

                return quadrant switch
                {
                    0 => 4,
                    1 => 3,
                    2 => 2,
                    3 => 1,
                    4 => 0,
                    5 => 7,
                    6 => 6,
                    7 => 5,
                    _ => throw new InvalidOperationException()
                };
            }

            static (int x, int y) TransformCoord(int siteX, int siteY, LayoutTransform transform, int minX, int minY, int maxX, int maxY)
            {
                int x0 = minX;
                int y0 = minY;
                int x1 = maxX;
                int y1 = maxY;
                int xc = siteX;
                int yc = siteY;

                if (DoesTransformMirror(transform))
                {
                    xc = x1 - xc + x0;
                    //yc = y1 - yc + y0; -- we only mirror horizontally
                }

                switch (transform)
                {
                    case LayoutTransform.Mirror:
                        return (xc, yc); // no change except what mirror already applied

                    case LayoutTransform.Rotate90:
                    case LayoutTransform.MirrorAndRotate90:
                        return (x0 + yc, y1 - xc);

                    case LayoutTransform.Rotate180:
                    case LayoutTransform.MirrorAndRotate180:
                        return (x1 - xc, y1 - yc);

                    case LayoutTransform.Rotate270:
                    case LayoutTransform.MirrorAndRotate270:
                        return (x1 - yc, y0 + xc);

                    default:
                        throw new ArgumentOutOfRangeException(nameof(transform), transform, null);
                }
            }

            static bool DoesTransformMirror(LayoutTransform transform)
            {
                switch (transform)
                {
                    case LayoutTransform.Rotate90:
                    case LayoutTransform.Rotate180:
                    case LayoutTransform.Rotate270:
                        return false;

                    case LayoutTransform.Mirror:
                    case LayoutTransform.MirrorAndRotate90:
                    case LayoutTransform.MirrorAndRotate180:
                    case LayoutTransform.MirrorAndRotate270:
                        return true;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(transform), transform, null);
                }
            }

            static string TransformName(string givenName, LayoutTransform transform)
            {
                if (transform == LayoutTransform.Rotate90)
                    if (givenName.Contains("Horizontal"))
                        return givenName.Replace("Horizontal", "Vertical");

                if (transform == LayoutTransform.Rotate90)
                    if (givenName.Contains("Vertical"))
                        return givenName.Replace("Vertical", "Horizontal");

                return givenName + "_" + TransformToNameSuffix(transform);
            }

            static string TransformToNameSuffix(LayoutTransform transform)
            {
                return transform switch
                {
                    LayoutTransform.Rotate90           => "Rotated90",
                    LayoutTransform.Rotate180          => "Rotated180",
                    LayoutTransform.Rotate270          => "Rotated270",
                    LayoutTransform.Mirror             => "Mirrored",
                    LayoutTransform.MirrorAndRotate90  => "MirroredAndRotated90",
                    LayoutTransform.MirrorAndRotate180 => "MirroredAndRotated180",
                    LayoutTransform.MirrorAndRotate270 => "MirroredAndRotated270",

                    _ => throw new ArgumentOutOfRangeException(nameof(transform), transform, null)
                };
            }
        }

        public Test Shift(LayoutOffset offset)
        {
            if (Offset != null) throw new InvalidOperationException();
            
            
            List<Site> newSites = [ ];
            List<Point> newPoints = [ ];
            List<Edge> newEdges = [ ];

            foreach (Point point in Points)
            {
                (int x, int y) = TransformCoord(point.X, point.Y, offset, MinX, MinY, MaxX, MaxY);
                newPoints.Add(new Point(x, y, point.Id, point.Corner));
            }

            foreach (Site site in Sites)
            {
                (int x, int y) = TransformCoord(site.X, site.Y, offset, MinX, MinY, MaxX, MaxY);
                Site newSite = new Site(x, y, site.Id);
                List<Point>[] newSitePoints = new List<Point>[site.Points.Length];
                for (int i = 0; i < site.Points.Length; i++)
                {
                    newSitePoints[i] = [ ];
                    foreach (Point point in site.Points[i])
                    {
                        Point newPoint = newPoints[Points.IndexOf(point)];
                        newSitePoints[i].Add(newPoint);
                    }
                }
                newSite.Points = newSitePoints;
                newSite.UndefinedPointOrder = site.UndefinedPointOrder;
                newSites.Add(newSite);
            }

            foreach (Edge edge in Edges)
            {
                Point fromPoint = newPoints[Points.IndexOf(edge.FromPoint)];
                Point toPoint = newPoints[Points.IndexOf(edge.ToPoint)];
                List<Site> sites = [ ];
                foreach (Site site in edge.EdgeSites)
                    sites.Add(newSites[Sites.IndexOf(site)]);
                newEdges.Add(new Edge(fromPoint, toPoint, sites, edge.Border));
            }
            
            string name = OffsetName(Name, offset);
            
            (int minX, int minY) = TransformCoord(MinX, MinY, offset, MinX, MinY, MaxX, MaxY);
            (int maxX, int maxY) = TransformCoord(MaxX, MaxY, offset, MinX, MinY, MaxX, MaxY);
            
            return new Test(
                minX, minY, maxX, maxY,
                name,
                newSites, newPoints, newEdges,
                Transformed, offset, Name
            );
            
            static (int x, int y) TransformCoord(int siteX, int siteY, LayoutOffset offset, int minX, int minY, int maxX, int maxY)
            {
                switch (offset)
                {
                    case LayoutOffset.CenteredAtOrigin:
                        // Center of the layout becomes 0,0
                        int centerX = (minX + maxX) / 2;
                        int centerY = (minY + maxY) / 2;
                        return (siteX - centerX, siteY - centerY);

                    case LayoutOffset.ShiftedTowardsOrigin:
                        // Layout is shifted by quarter towards 0,0, so it gets into negatives but doesn't center on origin
                        const int shiftX = -200;
                        const int shiftY = -200;
                        return (siteX + shiftX, siteY + shiftY);
                    
                    case LayoutOffset.ShiftwedAwayFromOrigin:
                        // Layout is shifted by quarter away from 0,0, so it gets further into positives
                        const int shiftX2 = 200;
                        const int shiftY2 = 200;
                        return (siteX + shiftX2, siteY + shiftY2);
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(offset), offset, null);
                }
            }

            static string OffsetName(string givenName, LayoutOffset offset)
            {
                return givenName + "_" + OffsetToNameSuffix(offset);
            }

            static string OffsetToNameSuffix(LayoutOffset offset)
            {
                return offset switch
                {
                    LayoutOffset.CenteredAtOrigin => "CenteredAtOrigin",
                    LayoutOffset.ShiftedTowardsOrigin => "ShiftedTowardsOrigin",
                    LayoutOffset.ShiftwedAwayFromOrigin => "ShiftedAwayFromOrigin",

                    _ => throw new ArgumentOutOfRangeException(nameof(offset), offset, null)
                };
            }
        }
    }

    private class Site
    {
        public int X { get; }
        public int Y { get; }
        public int Id { get; }
        public List<Point>[] Points { get; set; } = null!;
        public bool UndefinedPointOrder { get; set; }


        public Site(int x, int y, int id)
        {
            X = x;
            Y = y;
            Id = id;
        }


        public override string ToString()
        {
            return "#" + Id + "(" + X + ", " + Y + ")";
        }
    }

    private class Point
    {
        public int X { get; }
        public int Y { get; }
        public int Id { get; }
        public bool Corner { get; }


        public Point(int x, int y, int id, bool corner)
        {
            X = x;
            Y = y;
            Id = id;
            Corner = corner;
        }


        public override string ToString()
        {
            return (char)Id + "(" + X + ", " + Y + ")";
        }
    }

    private class Edge
    {
        public Point FromPoint { get; }
        public Point ToPoint { get; }
        public List<Site> EdgeSites { get; }
        public bool Border { get; }


        public Edge(Point fromPoint, Point toPoint, List<Site> edgeSites, bool border)
        {
            FromPoint = fromPoint;
            ToPoint = toPoint;
            EdgeSites = edgeSites;
            Border = border;
        }


        public IEnumerable<Point> Points()
        {
            yield return FromPoint;
            yield return ToPoint;
        }


        public override string ToString()
        {
            return FromPoint + "-" + ToPoint;
        }
    }
}