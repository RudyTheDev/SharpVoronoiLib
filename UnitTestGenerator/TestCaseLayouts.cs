namespace SharpVoronoiLib.UnitTestGenerator;

/// <summary>
/// A collection of predefined test case layouts.
/// This is where we manually in a more or less readable format add them to be parsed.
/// </summary>
public static class TestCaseLayouts
{
    public static void AddLayouts(TestLayoutParser testLayoutParser)
    {
        testLayoutParser.AddTest("NoPoints", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                X-Y
                Y-W
                W-Z
                Z-X
            ");

        testLayoutParser.AddTest("OnePointInMiddle", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · 1 · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                X-Y: 1
                Y-W: 1
                W-Z: 1
                Z-X: 1
                1: ZXYW
            ");

        testLayoutParser.AddTest("OnePointOffsetFromMiddle", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · 1 · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                X-Y: 1
                Y-W: 1
                W-Z: 1
                Z-X: 1
                1: ZXYW
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("OnePointArbitrary", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · 1 · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                X-Y: 1
                Y-W: 1
                W-Z: 1
                Z-X: 1
                1: ZXYW
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("OnePointOnBorderCentered", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                1 · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                X-Y: 1
                Y-W: 1
                W-Z: 1
                Z-X: 1
                1: YWZX !
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("OnePointOnBorderOffset", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                1 · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                X-Y: 1
                Y-W: 1
                W-Z: 1
                Z-X: 1
                1: YWZX !
            ", LayoutRepeat.RotateAndMirrorAll);

        testLayoutParser.AddTest("OnePointInCorner", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · · · · · · · 7
                · · · · · · · · · · · 6
                · · · · · · · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                1Y· · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                X-Y: 1
                Y-W: 1
                W-Z: 1
                Z-X: 1
                1: YWZX !
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("TwoPointsVerticalAroundMiddle", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · · · · · · · 8
                · · · · · 1 · · · · · 7
                · · · · · · · · · · · 6
                A x x x x x x x x x B 5
                · · · · · · · · · · · 4
                · · · · · 2 · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                X-A: 1
                A-Y: 2
                Y-W: 2
                W-B: 2
                B-Z: 1
                Z-X: 1
                1: ZXAB
                2: BAYW
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("TwoPointsVerticalOffsetFromMiddle", @"
                10
                X · · · · · · · · · Z 10
                · · · · · 1 · · · · · 9
                · · · · · · · · · · · 8
                A x x x x x x x x x B 7
                · · · · · · · · · · · 6
                · · · · · 2 · · · · · 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                X-A: 1
                A-Y: 2
                Y-W: 2
                W-B: 2
                B-Z: 1
                Z-X: 1
                1: ZXAB
                2: BAYW
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("ThreeConcentricPointsVerticalAroundMiddle", @"
                10
                X · · · · · · · · · Z 10
                · · · · · 1 · · · · · 9
                · · · · · · · · · · · 8
                A x x x x x x x x x B 7
                · · · · · · · · · · · 6
                · · · · · 2 · · · · · 5
                · · · · · · · · · · · 4
                C x x x x x x x x x D 3
                · · · · · · · · · · · 2
                · · · · · 3 · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                C-D: 2,3
                X-A: 1
                A-C: 2
                C-Y: 3
                Y-W: 3
                W-D: 3
                D-B: 2
                B-Z: 1
                Z-X: 1
                1: ZXAB
                2: BACD
                3: DCYW
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("FourConcentricPointsVerticalAroundMiddle", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · · · · 1 · · · · · 8
                A x x x x x x x x x B 7
                · · · · · 2 · · · · · 6
                C x x x x x x x x x D 5
                · · · · · 3 · · · · · 4
                E x x x x x x x x x F 3
                · · · · · 4 · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                C-D: 2,3
                E-F: 3,4
                X-A: 1
                A-C: 2
                C-E: 3
                E-Y: 4
                Y-W: 4
                W-F: 4
                F-D: 3
                D-B: 2
                B-Z: 1
                Z-X: 1
                1: ZXAB
                2: BACD
                3: DCEF
                4: FEYW
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("TwoDiagonalPointsAroundMiddle", @"
                10
                X · · · · · · · · · B 10
                · · · · · · · · · x · 9
                · · · · · · · · x · · 8
                · · · 1 · · · x · · · 7
                · · · · · · x · · · · 6
                · · · · · x · · · · · 5
                · · · · x · · · · · · 4
                · · · x · · · 2 · · · 3
                · · x · · · · · · · · 2
                · x · · · · · · · · · 1
                A · · · · · · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                X-A: 1
                A-Y: 2
                Y-B: 2
                B-X: 1
                1: BXA
                2: BAY
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("TwoDiagonalPointsOffsetFromMiddle", @"
                10
                X · · · · · · · B · Z 10
                · · · · · · · x · · · 9
                · · 1 · · · x · · · · 8
                · · · · · x · · · · · 7
                · · · · x · · · · · · 6
                · · · x · · · · · · · 5
                · · x · · · 2 · · · · 4
                · x · · · · · · · · · 3
                A · · · · · · · · · · 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                X-A: 1
                A-Y: 2
                Y-W: 2
                W-Z: 2
                Z-B: 2
                B-X: 1
                1: BXA
                2: ZBAYW
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("TwoPointsAgainstCorner", @"
                10
                A · · · · · · · · · Y 10
                · x · · · · · · · · · 9
                · · x · · · 2 · · · · 8
                · · · x · · · · · · · 7
                · · · · x · · · · · · 6
                · · · · · x · · · · · 5
                · · 1 · · · x · · · · 4
                · · · · · · · x · · · 3
                · · · · · · · · x · · 2
                · · · · · · · · · x · 1
                X · · · · · · · · · B 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-X: 1
                X-B: 1
                B-Y: 2
                Y-A: 2
                1: AXB
                2: YAB
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("TwoPointsAgainstCornerSlanted", @"
                10
                A · · · · · · · · · Z 10
                · · x · · · · 2 · · · 9
                · · · · x · · · · · · 8
                · · · · · · x · · · · 7
                · · · · · · · · x · · 6
                · · · · · 1 · · · · B 5
                · · · · · · · · · · · 4
                · · · · · · · · · · · 3
                · · · · · · · · · · · 2
                · · · · · · · · · · · 1
                X · · · · · · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-X: 1
                X-Y: 1
                Y-B: 1
                B-Z: 2
                Z-A: 2
                1: BAXY
                2: ZAB
            ", LayoutRepeat.RotateAndMirrorAll);

        testLayoutParser.AddTest("ThreeConcentricPointsDiagonalAroundMiddle", @"
                10
                X · · · · · · D · · Z 10
                · · · · · · x · · · · 9
                · · 1 · · x · · · · · 8
                · · · · x · · · · · C 7
                · · · x · · · · · x · 6
                · · x · · 2 · · x · · 5
                · x · · · · · x · · · 4
                A · · · · · x · · · · 3
                · · · · · x · · 3 · · 2
                · · · · x · · · · · · 1
                Y · · B · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-D: 1,2
                B-C: 2,3
                X-A: 1
                A-Y: 2
                Y-B: 2
                B-W: 3
                W-C: 3
                C-Z: 2
                Z-D: 2
                D-X: 1
                1: DXA
                2: CZDAYB
                3: CBW
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("ThreeConcentricPointsDiagonalOffsetFromMiddle", @"
                10
                X · · · · · D · · · C 10
                · · · · · x · · · x · 9
                · · 1 · x · · · x · · 8
                · · · x · · · x · · · 7
                · · x · 2 · x · · · · 6
                · x · · · x · · · · · 5
                A · · · x · 3 · · · · 4
                · · · x · · · · · · · 3
                · · x · · · · · · · · 2
                · x · · · · · · · · · 1
                B · · · · · · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-D: 1,2
                B-C: 2,3
                X-A: 1
                A-B: 2
                B-Y: 3
                Y-C: 3
                C-D: 2
                D-X: 1
                1: DXA
                2: CDAB
                3: CBY
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("FourConcentricPointsDiagonalAroundMiddle", @"
                10
                X · · · · · F · · · E 10
                · · · · · x · · · x · 9
                · · 1 · x · · · x · · 8
                · · · x · · · x · · · 7
                · · x · 2 · x · · · D 6
                · x · · · x · · · x · 5
                A · · · x · 3 · x · · 4
                · · · x · · · x · · · 3
                · · x · · · x · 4 · · 2
                · x · · · x · · · · · 1
                B · · · C · · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-F: 1,2
                B-E: 2,3
                C-D: 3,4
                X-A: 1
                A-B: 2
                B-C: 3
                C-Y: 4
                Y-D: 4
                D-E: 3
                E-F: 2
                F-X: 1
                1: FXA
                2: EFAB
                3: DEBC
                4: DCY
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("ThreePointsInAWedgeTowardsCorner", @"
                10
                X · · · · · · · · · D 10
                · · · · · · · · · x · 9
                · · · · · · · · x · · 8
                · · · · · · · x · · · 7
                · · · · · · x · · · · 6
                · · · 1 · x · · · · · 5
                B x x x A · · · · · · 4
                · · · 2 x 3 · · · · · 3
                · · · · x · · · · · · 2
                · · · · x · · · · · · 1
                Y · · · C · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-C: 2,3
                A-D: 1,3
                X-B: 1
                B-Y: 2
                Y-C: 2
                C-W: 3
                W-D: 3
                D-X: 1
                1: DXBA
                2: ABYC
                3: DACW
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("ThreePointsInAWedgeTowardsCornerOffset", @"
                10
                X · · · · · · D · · Z 10
                · · · · · · x · · · · 9
                · 1 · · · x · · · · · 8
                · · · · x · · · · · · 7
                B x x A · · · · · · · 6
                · · · x · · · · · · · 5
                · 2 · x · 3 · · · · · 4
                · · · x · · · · · · · 3
                · · · x · · · · · · · 2
                · · · x · · · · · · · 1
                Y · · C · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-C: 2,3
                A-D: 1,3
                X-B: 1
                B-Y: 2
                Y-C: 2
                C-W: 3
                W-Z: 3
                Z-D: 3
                D-X: 1
                1: DXBA
                2: ABYC
                3: ZDACW
            ", LayoutRepeat.RotateAndMirrorAll);

        // todo: offset to side a bit, then mirror too

        testLayoutParser.AddTest("ThreePointsInAWedgeTowardsSideAroundMiddle", @"
                10
                X · · · · D · · · · Y 10
                · · · · · x · · · · · 9
                · · · · · x · · · · · 8
                · · · · · x · · · · · 7
                · · · · · x · · · · · 6
                · · · 3 · A · 2 · · · 5
                · · · · x · x · · · · 4
                · · · x · 1 · x · · · 3
                · · x · · · · · x · · 2
                · x · · · · · · · x · 1
                B · · · · · · · · · C 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,3
                A-C: 1,2
                A-D: 2,3
                X-B: 3 
                B-C: 1 
                C-Y: 2 
                Y-D: 2 
                D-X: 3
                1: ABC
                2: YDAC
                3: ADXB
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("ThreePointsInAWedgeTowardsSideOffsetFromMiddle", @"
                10
                X · · · · D · · · · Z 10
                · · · · · x · · · · · 9
                · · · · · x · · · · · 8
                · · · · · x · · · · · 7
                · · · · · x · · · · · 6
                · · · · · x · · · · · 5
                · · · · · x · · · · · 4
                · · · 3 · A · 2 · · · 3
                · · · · x · x · · · · 2
                · · · x · 1 · x · · · 1
                Y · B · · · · · C · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,3
                A-C: 1,2
                A-D: 2,3
                X-Y: 3 
                Y-B: 3 
                B-C: 1 
                C-W: 2 
                W-Z: 2 
                Z-D: 2 
                D-X: 3 
                1: ABC
                2: ZDACW
                3: ADXYB
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("ThreePointsInAWedgeTowardsSideOffsetIntoMiddle", @"
                10
                X · · · · D · · · · Z 10
                · · · · · x · · · · · 9
                · · · · · x · · · · · 8
                · · · 3 · A · 2 · · · 7
                · · · · x · x · · · · 6
                · · · x · 1 · x · · · 5
                · · x · · · · · x · · 4
                · x · · · · · · · x · 3
                B · · · · · · · · · C 2
                · · · · · · · · · · · 1
                Y · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,3
                A-C: 1,2
                A-D: 2,3
                X-B: 3 
                B-Y: 1 
                Y-W: 1 
                W-C: 1
                C-Z: 2
                Z-D: 2
                D-X: 3
                1: ABYWC
                2: ZDAC
                3: ADXB
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("FourPointsSurroundingAPointInMiddle", @"
                10
                E · · · · · · · · · H 10
                · x · · · · · · · x · 9
                · · x · · · · · x · · 8
                · · · x · 5 · x · · · 7
                · · · · A x D · · · · 6
                · · · 2 x 1 x 4 · · · 5
                · · · · B x C · · · · 4
                · · · x · 3 · x · · · 3
                · · x · · · · · x · · 2
                · x · · · · · · · x · 1
                F · · · · · · · · · G 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                B-C: 1,3
                C-D: 1,4
                D-A: 1,5
                A-E: 2,5
                B-F: 2,3
                C-G: 3,4
                D-H: 4,5
                E-F: 2
                F-G: 3
                G-H: 4
                H-E: 5
                1: DABC
                2: AEFB
                3: CBFG
                4: HDCG
                5: HEAD
            ");

        testLayoutParser.AddTest("FourPointsSurroundingAPointOffsetFromMiddle", @"
                10
                X · · · · · · · · · Z 10
                · · · · · · · · · · · 9
                E · · · · · · · · · H 8
                · x · · · · · · · x · 7
                · · x · · · · · x · · 6
                · · · x · 5 · x · · · 5
                · · · · A x D · · · · 4
                · · · 2 x 1 x 4 · · · 3
                · · · · B x C · · · · 2
                · · · x · 3 · x · · · 1
                Y · F · · · · · G · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                B-C: 1,3
                C-D: 1,4
                D-A: 1,5
                A-E: 2,5
                B-F: 2,3
                C-G: 3,4
                D-H: 4,5
                X-E: 5
                E-Y: 2
                Y-F: 2
                F-G: 3
                G-W: 4
                W-H: 4
                H-Z: 5
                Z-X: 5
                1: DABC
                2: AEYFB
                3: CBFG
                4: HDCGW
                5: HZXEAD
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("FourEquidistantPointsInASquareAroundMiddle", @"
                10
                X · · · · B · · · · Z 10
                · · · · · x · · · · · 9
                · · · · · x · · · · · 8
                · · · 1 · x · 4 · · · 7
                · · · · · x · · · · · 6
                C x x x x A x x x x E 5
                · · · · · x · · · · · 4
                · · · 2 · x · 3 · · · 3
                · · · · · x · · · · · 2
                · · · · · x · · · · · 1
                Y · · · · D · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,4
                A-C: 1,2
                A-D: 2,3
                A-E: 3,4
                X-C: 1
                C-Y: 2
                Y-D: 2
                D-W: 3
                W-E: 3
                E-Z: 4
                Z-B: 4
                B-X: 1
                1: BXCA
                2: ACYD
                3: EADW
                4: ZBAE
            ");

        testLayoutParser.AddTest("FourEquidistantPointsInARectangleAroundMiddle", @"
                10
                X · · · · B · · · · Z 10
                · · · · · x · · · · · 9
                · · · · 1 x 4 · · · · 8
                · · · · · x · · · · · 7
                · · · · · x · · · · · 6
                C x x x x A x x x x E 5
                · · · · · x · · · · · 4
                · · · · · x · · · · · 3
                · · · · 2 x 3 · · · · 2
                · · · · · x · · · · · 1
                Y · · · · D · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,4
                A-C: 1,2
                A-D: 2,3
                A-E: 3,4
                X-C: 1
                C-Y: 2
                Y-D: 2
                D-W: 3
                W-E: 3
                E-Z: 4
                Z-B: 4
                B-X: 1
                1: BXCA
                2: ACYD
                3: EADW
                4: ZBAE
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("FourEquidistantPointsInAKiteAroundMiddle", @"
                10
                B · · · · · · · · · E 10
                · x · · · · · · · x · 9
                · · x · · · · · x · · 8
                · · · x · 1 · x · · · 7
                · · · · x · x · · · · 6
                · · · 4 · A · 2 · · · 5
                · · · · x · x · · · · 4
                · · · x · 3 · x · · · 3
                · · x · · · · · x · · 2
                · x · · · · · · · x · 1
                C · · · · · · · · · D 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,4
                A-C: 3,4
                A-D: 2,3
                A-E: 1,2
                B-C: 4
                C-D: 3
                D-E: 2
                E-B: 1
                1: EBA
                2: EAD
                3: ACD
                4: ABC
            ");

        testLayoutParser.AddTest("FourEquidistantPointsInARotatedSquareOffset", @"
                10
                X B · · · · · · · · Z 10
                · · · · · · · · · · · 9
                · · x · · · · · · · · 8
                · · · · · 4 · · · · E 7
                · · · x · · · · x · · 6
                · 1 · · · · x · · · · 5
                · · · · A · · · · · · 4
                · · x · · · · 3 · · · 3
                C · · · · x · · · · · 2
                · · · 2 · · · · · · · 1
                Y · · · · · D · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,4
                A-C: 1,2
                A-D: 2,3
                A-E: 3,4
                X-C: 1 
                C-Y: 2 
                Y-D: 2 
                D-W: 3 
                W-E: 3 
                E-Z: 4 
                Z-B: 4 
                B-X: 1 
                1: BXCA
                2: ACYD
                3: EADW
                4: EZBA
            ", LayoutRepeat.RotateAndMirrorAll);

        testLayoutParser.AddTest("FivePointsInAForkedTallCross", @"
                10
                W · C · · · · · D · Z 10
                · · · x · 1 · x · · · 9
                · · · · x · x · · · · 8
                · · · 2 · B · 5 · · · 7
                · · · · · x · · · · · 6
                · · · · · x · · · · · 5
                E x x x x A x x x x F 4
                · · · · · x · · · · · 3
                · · · · · x · · · · · 2
                · · · 3 · x · 4 · · · 1
                X · · · · G · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 2,5
                B-C: 1,2
                B-D: 1,5
                A-E: 2,3
                A-F: 4,5
                A-G: 3,4
                C-W: 2
                W-E: 2
                E-X: 3 
                X-G: 3 
                G-Y: 4 
                Y-F: 4 
                F-Z: 5
                Z-D: 5
                D-C: 1
                1: DCB
                2: BCWEA
                3: AEXG
                4: FAGY
                5: ZDBAF
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("FivePointsInAForkedStubbyCross", @"
                10
                C · · · · · · · · · D 10
                · x · · · · · · · x · 9
                · · x · · · · · x · · 8
                · · · x · 1 · x · · · 7
                · · · · x · x · · · · 6
                · · · 2 · B · 5 · · · 5
                · · · · · x · · · · · 4
                E x x x x A x x x x F 3
                · · · · · x · · · · · 2
                · · · 3 · x · 4 · · · 1
                X · · · · G · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 2,5
                B-C: 1,2
                B-D: 1,5
                A-E: 2,3
                A-F: 4,5
                A-G: 3,4
                C-E: 2
                E-X: 3 
                X-G: 3 
                G-Y: 4 
                Y-F: 4 
                F-D: 5 
                D-C: 1
                1: DCB
                2: BCEA
                3: AEXG
                4: FAGY
                5: DBAF
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("SixPointsInADoubleCross", @"
                10
                W · · · · H · · · · Z 10
                · · · 1 · x · 2 · · · 9
                · · · · · x · · · · · 8
                C x x x x B x x x x G 7
                · · · · · x · · · · · 6
                · · · 3 · x · 4 · · · 5
                · · · · · x · · · · · 4
                D x x x x A x x x x F 3
                · · · · · x · · · · · 2
                · · · 5 · x · 6 · · · 1
                X · · · · E · · · · Y 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 3,4
                B-C: 1,3
                B-G: 2,4
                A-D: 3,5
                A-F: 4,6
                A-E: 5,6
                B-H: 1,2
                W-C: 1 
                C-D: 3
                D-X: 5
                X-E: 5
                E-Y: 6
                Y-F: 6
                F-G: 4
                G-Z: 2
                Z-H: 2 
                H-W: 1
                1: HWCB
                2: ZHBG
                3: BCDA
                4: GBAF
                5: ADXE
                6: FAEY
            ", LayoutRepeat.Rotate90);

        testLayoutParser.AddTest("FivePointsInARegularKite", @"
                10
                X · · · · A · · · · Z 10
                · · · · · x · · · · · 9
                · · 1 · · E · · 4 · · 8
                · · · · x · x · · · · 7
                · · · x · · · x · · · 6
                B x F · · 5 · · H x D 5
                · · · x · · · x · · · 4
                · · · · x · x · · · · 3
                · · 2 · · G · · 3 · · 2
                · · · · · x · · · · · 1
                Y · · · · C · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-E: 1,4
                D-H: 4,3
                C-G: 3,2
                B-F: 2,1
                E-H: 4,5
                H-G: 3,5
                G-F: 2,5
                F-E: 1,5
                X-A: 1
                A-Z: 4
                Z-D: 4
                D-W: 3
                W-C: 3
                C-Y: 2
                Y-B: 2
                B-X: 1
                1: EAXBF
                2: GFBYC
                3: DHGCW
                4: ZAEHD
                5: HEFG
            ");

        testLayoutParser.AddTest("FivePointsInABorderTouchingRegularKite", @"
                10
                1X· · · · A · · · · 4Z10
                · · · · x · x · · · · 9
                · · · x · · · x · · · 8
                · · x · · · · · x · · 7
                · x · · · · · · · x · 6
                B · · · · 5 · · · · D 5
                · x · · · · · · · x · 4
                · · x · · · · · x · · 3
                · · · x · · · x · · · 2
                · · · · x · x · · · · 1
                2Y· · · · C · · · · 3W0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,5
                B-C: 2,5
                C-D: 3,5
                D-A: 4,5
                X-B: 1
                B-Y: 2
                Y-C: 2
                C-W: 3
                W-D: 3
                D-Z: 4
                Z-A: 4
                A-X: 1
                1: XBA !
                2: YCB !
                3: WDC !
                4: ZAD !
                5: DABC 
            ");

        testLayoutParser.AddTest("FivePointsInASkewedKite", @"
                8
                X · · · A · · · Z 8
                · · · · x · · · · 7
                · · 1 · x · 4 · · 6
                · · · · E x · · · 5
                B x x F · · x H D 4
                · · · ·x· 5 x · · 3
                · · 2 ·x· x 3 · · 2
                · · · · G · · · · 1
                Y · · · C · · · W 0
                0 1 2 3 4 5 6 7 8
                A-E: 1,4
                D-H: 4,3
                C-G: 3,2
                B-F: 2,1
                E-H: 4,5
                H-G: 3,5
                G-F: 2,5
                F-E: 1,5
                X-A: 1
                A-Z: 4
                Z-D: 4
                D-W: 3
                W-C: 3
                C-Y: 2
                Y-B: 2
                B-X: 1
                1: AXBFE
                2: FBYCG
                3: DHGCW
                4: ZAEHD
                5: HEFG
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("ThreePointsMeetingAtBorderPerpendicularly", @"
                10
                X · · · · · · · · · B 10
                · · · 1 · · · · x · · 9
                · · · · · · x · · · · 8
                · · · · x · · · · · · 7
                · · x · · · · · · · · 6
                A · · · · 3 · · · · · 5
                · · x · · · · · · · · 4
                · · · · x · · · · · · 3
                · · · · · · x · · · · 2
                · · · 2 · · · · x · · 1
                Y · · · · · · · · · C 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,3
                A-C: 2,3
                X-A: 1
                A-Y: 2
                Y-C: 2
                C-B: 3
                B-X: 1
                1: BXA
                2: AYC 
                3: BAC
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("ThreePointsMeetingPastBorderPerpendicularly", @"
                10
                X · · · · · · · B · W 10
                · 1 · · · · x · · · · 9
                · · · · x · · · · · · 8
                · · x · · · · · · · · 7
                A · · · · · · · · · · 6
                · · · 3 · · · · · · · 5
                D · · · · · · · · · · 4
                · · x · · · · · · · · 3
                · · · · x · · · · · · 2
                · 2 · · · · x · · · · 1
                Y · · · · · · · C · Z 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,3
                D-C: 2,3
                B-X: 1
                X-A: 1
                A-D: 3
                D-Y: 2
                Y-C: 2
                C-Z: 3
                Z-W: 3
                W-B: 3
                1: BXA
                2: DYC 
                3: WBADCZ
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("ThreePointsMeetingSharplyAtBorderPerpendicularly", @"
                12
                X · · · · · · · · · · · Z 12
                · · · · · · · · · · · · · 11
                · · · · · · · · · · · ·xC 10
                · · · · 2 · · · ·xxx· · · 9
                · · · · · ·xxx· · · · · · 8
                · · ·xxx· · · · · · · · · 7
                Ax· · · · 1 · · · · · · · 6
                · · ·xxx· · · · · · · · · 5
                · · · · · ·xxx· · · · · · 4
                · · · · 3 · · · ·xxx· · · 3
                · · · · · · · · · · · ·xB 2
                · · · · · · · · · · · · · 1
                Y · · · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 0 1 2
                A-C: 1,2
                A-B: 1,3
                X-A: 2
                A-Y: 3
                Y-W: 3
                W-B: 3
                B-C: 1
                C-Z: 2
                Z-X: 2
                1: CAB
                2: CZXA
                3: AYWB
            ", LayoutRepeat.RotateAll);

        testLayoutParser.AddTest("ThreePointsMeetingSharplyPastBorderPerpendicularly", @"
                12
                X · · · · · · · · · · · Z 12
                · · · · · · · · · · · ·xB 11
                · · · · · · · · ·xxx· · · 10
                · 2 · · · ·xxx· · · · · · 9
                · · ·xxx· · · · · · · · · 8
                Ax· · · · · · · · · · · · 7
                · · 1 · · · · · · · · · · 6
                Dx· · · · · · · · · · · · 5
                · · ·xxx· · · · · · · · · 4
                · 3 · · · ·xxx· · · · · · 3
                · · · · · · · · ·xxx· · · 2
                · · · · · · · · · · · ·xC 1
                Y · · · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 0 1 2
                A-B: 1,2
                C-D: 1,3
                C-B: 1
                B-Z: 2
                Z-X: 2
                X-A: 2
                A-D: 1
                D-Y: 3
                Y-W: 3
                W-C: 3
                1: BADC
                2: BZXA
                3: DYWC
            ", LayoutRepeat.RotateAll);
            
        testLayoutParser.AddTest("ThreePointsMeetingSharplyTowardsCorner", @"
                10
                X · · · · · B · · · Z 10
                · · · 1 · · · · · · · 9
                · · · · · x · · · · · 8
                · · · · · · · 2 · · · 7
                · · · · x · · · · · C 6
                · · · · · · · · x · · 5
                · · · x · · x · · · · 4
                · · · · x · · · · 3 · 3
                · · A · · · · · · · · 2
                · x · · · · · · · · · 1
                D · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-C: 2,3
                A-D: 1,3
                B-X: 1
                X-D: 1
                D-W: 3
                W-C: 3
                C-Z: 2
                Z-B: 2
                1: BXDA
                2: ZBAC
                3: CADW
            ", LayoutRepeat.RotateAll);
            
        testLayoutParser.AddTest("ThreePointsMeetingAtCorner", @"
                10
                X · · · · B · · · · Z 10
                · · · · · · · · · · · 9
                · · · · x · · · · · · 8
                · 1 · · · · · · · · · 7
                · · · x · · · · · · · 6
                · · · · · 2 · · · · C 5
                · · x · · · · · x · · 4
                · · · · · · x · · · · 3
                · x · · x · · · · · · 2
                · · x · · · · 3 · · · 1
                A · · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-C: 2,3
                B-X: 1
                X-A: 1
                A-W: 3
                W-C: 3
                C-Z: 2
                Z-B: 2
                1: BXA
                2: CZBA
                3: CAW
            ", LayoutRepeat.RotateAll);
            
        testLayoutParser.AddTest("ThreePointsMeetingAtBorderAngled", @"
                10
                X · · · · · · B · · Z 10
                · · · · · · · · · · · 9
                · · · · · · x · · · · 8
                · · · 1 · · · · · · · 7
                · · · · · x · · · · · 6
                · · · · · · · 2 · · · 5
                · · · · x · · · · · C 4
                · · · · · · · · x · · 3
                · · · x · · x · · · · 2
                · · · · x · · · · 3 · 1
                Y · A · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 10
                A-B: 1,2
                A-C: 2,3
                B-X: 1
                X-Y: 1
                Y-A: 1
                A-W: 3
                W-C: 3
                C-Z: 2
                Z-B: 2
                1: BXYA
                2: ZBAC
                3: CAW
            ", LayoutRepeat.RotateAndMirrorAll);
            
        testLayoutParser.AddTest("ThreePointsMeetingPastCorner", @"
                12
                X · · · · · C · · · · · Z 12
                · 1 · · · · · · · · · · · 11
                · · · · · · · · · · · · · 10
                · · · · x · · · · · · · · 9
                · · · · · · · · · · · · · 8
                · · · · · · · 2 · · · · · 7
                · · x · · · · · · · · · D 6
                · · · · · · · · · · · · · 5
                · · · · · · · · · x · · · 4
                A · · · · · · · · · · · · 3
                · · · · · · x · · · · · · 2
                · · · · · · · · · · · 3 · 1
                Y · · B · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9 0 1 12
                A-C: 1,2
                B-D: 2,3
                X-A: 1
                A-Y: 2
                Y-B: 2
                B-W: 3
                W-D: 3
                D-Z: 2
                Z-C: 2
                C-X: 1
                1: CXA
                2: ZCAYBD
                3: DBW
            ", LayoutRepeat.RotateAll);
            
        testLayoutParser.AddTest("FourPointsMeetingAtCorner", @"
                9
                X · · C · · · · · B 9
                · 1 · · · · · · x · 8
                · · · · 2 · · x · · 7
                · · x · · · x · · · 6
                · · · · · x · · · · 5
                · · · · x · · 3 · · 4
                · x · x · · · · · D 3
                · · x · · · x · · · 2
                · x · x · · · · 4 · 1
                A · · · · · · · · W 0
                0 1 2 3 4 5 6 7 8 9
                A-B: 2,3
                A-C: 1,2
                A-D: 3,4
                A-W: 4
                W-D: 4
                D-B: 3
                B-C: 2
                C-X: 1
                X-A: 1
                1: CXA
                2: BCA 
                3: BAD
                4: DAW
            ", LayoutRepeat.RotateAll);
    }
}