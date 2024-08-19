using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SharpVoronoiLib.UnitTestGenerator
{
    public static class UnitTestGenerator
    {
        public static void Main()
        {
            TestGenerator testGenerator = new TestGenerator(
                50, 100,
                20, 50
            );

            testGenerator.AddTest("NoPoints", @"
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

            testGenerator.AddTest("OnePointInMiddle", @"
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

            testGenerator.AddTest("OnePointOffsetFromMiddle", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("OnePointArbitrary", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("OnePointOnBorderCentered", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("OnePointOnBorderOffset", @"
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
            ", Repeat.RotateAndMirrorAll);

            testGenerator.AddTest("OnePointInCorner", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("TwoPointsVerticalAroundMiddle", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("TwoPointsVerticalOffsetFromMiddle", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("ThreeConcentricPointsVerticalAroundMiddle", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("FourConcentricPointsVerticalAroundMiddle", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("TwoDiagonalPointsAroundMiddle", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("TwoDiagonalPointsOffsetFromMiddle", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("TwoPointsAgainstCorner", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("TwoPointsAgainstCornerSlanted", @"
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
            ", Repeat.RotateAndMirrorAll);

            testGenerator.AddTest("ThreeConcentricPointsDiagonalAroundMiddle", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("ThreeConcentricPointsDiagonalOffsetFromMiddle", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("FourConcentricPointsDiagonalAroundMiddle", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("ThreePointsInAWedgeTowardsCorner", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsInAWedgeTowardsCornerOffset", @"
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
            ", Repeat.RotateAndMirrorAll);

            // todo: offset to side a bit, then mirror too

            testGenerator.AddTest("ThreePointsInAWedgeTowardsSideAroundMiddle", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsInAWedgeTowardsSideOffsetFromMiddle", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsInAWedgeTowardsSideOffsetIntoMiddle", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("FourPointsSurroundingAPointInMiddle", @"
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

            testGenerator.AddTest("FourPointsSurroundingAPointOffsetFromMiddle", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("FourEquidistantPointsInASquareAroundMiddle", @"
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

            testGenerator.AddTest("FourEquidistantPointsInARectangleAroundMiddle", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("FourEquidistantPointsInAKiteAroundMiddle", @"
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

            testGenerator.AddTest("FourEquidistantPointsInARotatedSquareOffset", @"
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
            ", Repeat.RotateAndMirrorAll);

            testGenerator.AddTest("FivePointsInAForkedTallCross", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("FivePointsInAForkedStubbyCross", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("SixPointsInADoubleCross", @"
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
            ", Repeat.Rotate90);

            testGenerator.AddTest("FivePointsInABorderTouchingKite", @"
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

            testGenerator.AddTest("ThreePointsMeetingAtBorderPerpendicularly", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsMeetingPastBorderPerpendicularly", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsMeetingSharplyAtBorderPerpendicularly", @"
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
            ", Repeat.RotateAll);

            testGenerator.AddTest("ThreePointsMeetingSharplyPastBorderPerpendicularly", @"
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
            ", Repeat.RotateAll);
            
            testGenerator.AddTest("ThreePointsMeetingSharplyTowardsCorner", @"
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
            ", Repeat.RotateAll);
            
            testGenerator.AddTest("ThreePointsMeetingAtCorner", @"
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
            ", Repeat.RotateAll);
            
            testGenerator.AddTest("ThreePointsMeetingAtBorderAngled", @"
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
            ", Repeat.RotateAndMirrorAll);
            
            testGenerator.AddTest("ThreePointsMeetingPastCorner", @"
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
            ", Repeat.RotateAll);
            
            testGenerator.AddTest("FourPointsMeetingAtCorner", @"
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
            ", Repeat.RotateAll);

            List<(string, TestPurpose)> variants = new List<(string, TestPurpose)>()
            {
                ("GeneratedTest_Edges", TestPurpose.AssertEdges),
                ("GeneratedTest_SiteEdges", TestPurpose.AssertSiteEdges),
                ("GeneratedTest_SiteEdgesClockwise", TestPurpose.AssertSiteEdgesClockwise),
                ("GeneratedTest_EdgeSites", TestPurpose.AssertEdgeSites),
                ("GeneratedTest_EdgeNeighbours", TestPurpose.AssertEdgeNeighbours),
                ("GeneratedTest_SiteNeighbours", TestPurpose.AssertSiteNeighbours),
                ("GeneratedTest_SitePoints", TestPurpose.AssertSitePoints),
                ("GeneratedTest_SitePointsClockwise", TestPurpose.AssertSitePointsClockwise),
                ("GeneratedTest_PointBorderLocation", TestPurpose.AssertPointBorderLocation),
                ("GeneratedTest_LiesOnEdgeOrCorner", TestPurpose.AssertLiesOnEdgeOrCorner),
                ("GeneratedTest_SiteCentroids", TestPurpose.AssertSiteCentroids)
            };

            // todo: edge length

            for (int i = 0; i < 2; i++)
            {
                TestBorderLogic borderLogic = i == 0 ? TestBorderLogic.UnclosedBorders : TestBorderLogic.ClosedBorders;

                foreach ((string testName, TestPurpose testPurpose) in variants)
                {
                    string fullTestName = testName + "_" + (borderLogic == TestBorderLogic.UnclosedBorders ? "OpenBorders" : "ClosedBorders");

                    Console.WriteLine("Outputting test " + fullTestName + "...");

                    string output = testGenerator.GenerateCode(fullTestName, testPurpose, borderLogic);

                    File.WriteAllText("../../../../UnitTests/Fortune/AutoGenerated/" + fullTestName + ".cs", output);

                    //Console.OutputEncoding = Encoding.UTF8;
                    //Console.WriteLine(output);
                }
            }

            Console.WriteLine("Done.");
        }


        private class TestGenerator
        {
            private readonly int _horStepSize;
            private readonly int _verStepSize;
            private readonly int _horPreviewStepSize;
            private readonly int _verPreviewStepSize;


            private readonly List<Test> _tests = new List<Test>();


            public TestGenerator(int horStepSize, int verStepSize, int horPreviewStepSize, int verPreviewStepSize)
            {
                _horStepSize = horStepSize;
                _verStepSize = verStepSize;
                _horPreviewStepSize = horPreviewStepSize;
                _verPreviewStepSize = verPreviewStepSize;
            }


            public void AddTest(string name, string layout, Repeat? repeat = null)
            {
                if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException();
                if (string.IsNullOrWhiteSpace(layout)) throw new ArgumentException();
                if (_tests.Any(t => t.Name == name)) throw new ArgumentException();


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

                List<Site> sites = new List<Site>();
                List<Point> points = new List<Point>();

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

                            case ' ' or 'x':
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

                List<Edge> edges = new List<Edge>();

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

                        List<Site> edgeSites = new List<Site>();

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
                            site.Points = new[] { new List<Point>() };
                        else
                            site.Points = new[] { new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>() };

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

                Test newTest = new Test(
                    minX, minY, maxX, maxY, name,
                    sites, points, edges
                );

                _tests.Add(newTest);

                if (repeat != null)
                {
                    switch (repeat.Value)
                    {
                        case Repeat.Rotate90:
                            if (width != height) throw new InvalidOperationException();
                            _tests.Add(new RepeatedTest(newTest, Repeat.Rotate90, minX, minY, maxX, maxY));
                            break;

                        case Repeat.Mirror:
                            if (width != height) throw new InvalidOperationException();
                            _tests.Add(new RepeatedTest(newTest, Repeat.Mirror, minX, minY, maxX, maxY));
                            break;

                        case Repeat.RotateAll:
                            if (width != height) throw new InvalidOperationException();
                            _tests.Add(new RepeatedTest(newTest, Repeat.Rotate90, minX, minY, maxX, maxY));
                            _tests.Add(new RepeatedTest(newTest, Repeat.Rotate180, minX, minY, maxX, maxY));
                            _tests.Add(new RepeatedTest(newTest, Repeat.Rotate270, minX, minY, maxX, maxY));
                            break;

                        case Repeat.RotateAndMirrorAll:
                            if (width != height) throw new InvalidOperationException();
                            _tests.Add(new RepeatedTest(newTest, Repeat.Rotate90, minX, minY, maxX, maxY));
                            _tests.Add(new RepeatedTest(newTest, Repeat.Rotate180, minX, minY, maxX, maxY));
                            _tests.Add(new RepeatedTest(newTest, Repeat.Rotate270, minX, minY, maxX, maxY));
                            _tests.Add(new RepeatedTest(newTest, Repeat.Mirror, minX, minY, maxX, maxY));
                            _tests.Add(new RepeatedTest(newTest, Repeat.MirrorAndRotate90, minX, minY, maxX, maxY));
                            _tests.Add(new RepeatedTest(newTest, Repeat.MirrorAndRotate180, minX, minY, maxX, maxY));
                            _tests.Add(new RepeatedTest(newTest, Repeat.MirrorAndRotate270, minX, minY, maxX, maxY));
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            public string GenerateCode(string className, TestPurpose purpose, TestBorderLogic borderLogic)
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine(@"using NUnit.Framework;");
                stringBuilder.AppendLine(@"using NUnit.Framework.Legacy;");
                stringBuilder.AppendLine(@"using System.Collections.Generic;");
                stringBuilder.AppendLine(@"using System.Linq;");
                stringBuilder.AppendLine(@"using static SharpVoronoiLib.UnitTests.CommonTestUtilities;");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine(@"#pragma warning disable");
                stringBuilder.AppendLine(@"// ReSharper disable All");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine(@"namespace SharpVoronoiLib.UnitTests");
                stringBuilder.AppendLine(@"{");
                List<string> classSummary = BuildClassSummary(purpose, borderLogic);
                foreach (string summaryLine in classSummary)
                    stringBuilder.AppendPaddedLine(1, summaryLine);
                stringBuilder.AppendPaddedLine(1, @"[Parallelizable(ParallelScope.All)]");
                stringBuilder.AppendPaddedLine(1, @"[TestFixture]");
                stringBuilder.AppendPaddedLine(1, @"public class " + className);
                stringBuilder.AppendPaddedLine(1, @"{");

                foreach (Test test in _tests)
                {
                    // Header

                    if (test is RepeatedTest repeatedTest)
                    {
                        List<string> summary = BuildSummary(repeatedTest.Repeated, repeatedTest.OriginalName);
                        foreach (string summaryLine in summary)
                            stringBuilder.AppendPaddedLine(2, summaryLine);
                    }

                    stringBuilder.AppendPaddedLine(2, @"[Test]");
                    stringBuilder.AppendPaddedLine(2, @"public void " + test.Name + @"()");
                    stringBuilder.AppendPaddedLine(2, @"{");

                    // Arrange

                    stringBuilder.AppendPaddedLine(3, @"// Arrange", true);

                    stringBuilder.AppendPaddedLine(3, @"List<VoronoiSite> sites = new List<VoronoiSite>");
                    stringBuilder.AppendPaddedLine(3, @"{");
                    List<string> siteDefinitions = BuildSiteDefinitions(test.Sites);
                    foreach (string siteDefinition in siteDefinitions)
                        stringBuilder.AppendPaddedLine(4, siteDefinition);
                    stringBuilder.AppendPaddedLine(3, @"};");
                    stringBuilder.AppendLine();

                    List<string> visualLayout = BuildVisualLayout(test, borderLogic);
                    foreach (string visualLayoutString in visualLayout)
                        stringBuilder.AppendPaddedLine(3, visualLayoutString);
                    stringBuilder.AppendLine();

                    // Act

                    stringBuilder.AppendPaddedLine(3, @"// Act", true);

                    stringBuilder.AppendPaddedLine(3, @"List<VoronoiEdge> edges = VoronoiPlane.TessellateOnce(sites, " + test.MinX + @", " + test.MinY + @", " + test.MaxX + @", " + test.MaxY + BorderLogicToRealEnumParam(borderLogic) + @");");
                    stringBuilder.AppendLine();

                    // Assume + Assert

                    switch (purpose)
                    {
                        case TestPurpose.AssertEdges:
                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, true));
                            break;

                        case TestPurpose.AssertSitePoints:
                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, true));
                            break;

                        case TestPurpose.AssertEdgeSites:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildEdgeSiteAssertions(test.Edges, borderLogic, true));
                            break;

                        case TestPurpose.AssertEdgeNeighbours:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildEdgeNeighboursAssertions(test.Edges, borderLogic, true));
                            break;

                        case TestPurpose.AssertSiteEdges:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildSiteEdgeAssertions(test.Edges, test.Sites, borderLogic, false, true));
                            break;

                        case TestPurpose.AssertSiteCentroids:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildSiteCentroidsAssertions(test.Sites, borderLogic, true));
                            break;

                        case TestPurpose.AssertSiteEdgesClockwise:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                            stringBuilder.AppendLine();
                            AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildSiteEdgeAssertions(test.Edges, test.Sites, borderLogic, true, true));
                            break;

                        case TestPurpose.AssertSiteNeighbours:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildSiteNeighboursAssertions(test.Sites, test.Edges, borderLogic, true));
                            break;

                        case TestPurpose.AssertSitePointsClockwise:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, true, true));
                            break;

                        case TestPurpose.AssertPointBorderLocation:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                            stringBuilder.AppendLine();
                            AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildPointBorderLocationAssertions(test, test.Edges, borderLogic, true));
                            break;

                        case TestPurpose.AssertLiesOnEdgeOrCorner:
                            stringBuilder.AppendPaddedLine(3, @"// Assume", true);
                            AppendAssertions(BuildEdgeAssertions(test.Edges, borderLogic, false));
                            stringBuilder.AppendLine();
                            AppendAssertions(BuildSitePointsAssertions(test.Edges, test.Sites, borderLogic, false, false));
                            stringBuilder.AppendLine();

                            stringBuilder.AppendPaddedLine(3, @"// Assert", true);
                            AppendAssertions(BuildLiesOnEdgeOrCornerAssertions(test.Edges, test.Sites, borderLogic, true));
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(purpose), purpose, null);
                    }

                    void AppendAssertions(IEnumerable<string> assertions)
                    {
                        foreach (string assertion in assertions)
                            stringBuilder.AppendPaddedLine(3, assertion);
                    }

                    // Footer

                    stringBuilder.AppendPaddedLine(2, @"}", true);
                }

                stringBuilder.AppendPaddedLine(1, @"}");
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
                List<string> strings = new List<string>();

                strings.Add(@"/// <summary>");

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

            private List<string> BuildSummary(Repeat repeated, string originalName)
            {
                List<string> strings = new List<string>();

                strings.Add(@"/// <summary>");
                strings.Add(@"/// This test basically repeats <see cref=""" + originalName + @"""/> above,");
                strings.Add(@"/// but all coordinates are " + RepeatToExplanation(repeated) + ".");
                strings.Add(@"/// </summary>");

                return strings;
            }

            private string RepeatToExplanation(Repeat repeat)
            {
                switch (repeat)
                {
                    case Repeat.Rotate90:           return "rotated 90° around the center of the boundary";
                    case Repeat.Rotate180:          return "rotated 180° around the center of the boundary";
                    case Repeat.Rotate270:          return "rotated 270° around the center of the boundary";
                    case Repeat.Mirror:             return "mirrored horizontally";
                    case Repeat.MirrorAndRotate90:  return "mirrored horizontally and then rotated 90° around the center of the boundary";
                    case Repeat.MirrorAndRotate180: return "mirrored horizontally and then rotated 180° around the center of the boundary";
                    case Repeat.MirrorAndRotate270: return "mirrored horizontally and then rotated 270° around the center of the boundary";

                    case Repeat.RotateAll:
                    case Repeat.RotateAndMirrorAll:
                        throw new InvalidOperationException();
                    default:
                        throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
                }
            }

            private List<string> BuildSiteDefinitions(List<Site> sites)
            {
                List<string> strings = new List<string>();

                foreach (Site site in sites)
                {
                    strings.Add(@"new VoronoiSite(" + site.X + @", " + site.Y + @"), // #" + site.Id);
                }

                return strings;
            }

            private List<string> BuildEdgeAssertions(List<Edge> edges, TestBorderLogic borderLogic, bool assert)
            {
                List<string> strings = new List<string>();

                int expectedCount = CountExpectedRelevantEdges(edges, borderLogic);
                strings.Add(GetAssertEqualMethodStart(assert) + expectedCount + GetAssertEqualMethodSeparator(assert) + @"edges.Count, ""Expected: edge count " + expectedCount + @""");");

                strings.Add(GetAssertNotNullMethodStart(assert) + @"edges);");

                foreach (Edge edge in edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)))
                {
                    string comment = (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id;
                    strings.Add(GetAssertTrueMethodStart(assert) + @"HasEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @"), ""Expected: has edge " + comment + @"""); // " + comment);
                }

                return strings;
            }

            private string GetAssertEqualMethodStart(bool assert)
            {
                return assert ? @"ClassicAssert.AreEqual(" : @"Assume.That(() => ";
            }

            private string GetAssertNotNullMethodStart(bool assert)
            {
                return assert ? @"ClassicAssert.NotNull(" : @"Assume.That(() => null != ";
            }

            private string GetAssertNullMethodStart(bool assert)
            {
                return assert ? @"ClassicAssert.Null(" : @"Assume.That(() => null == ";
            }

            private string GetAssertEqualMethodSeparator(bool assert)
            {
                return assert ? @", " : @" == ";
            }

            private string GetAssertTrueMethodStart(bool assert)
            {
                return assert ? @"ClassicAssert.IsTrue(" : @"Assume.That(() => ";
            }

            private List<string> BuildEdgeSiteAssertions(List<Edge> edges, TestBorderLogic borderLogic, bool assert)
            {
                List<string> strings = new List<string>();

                List<Edge> matchingEdges = edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)).ToList();

                if (matchingEdges.Count > 0)
                {
                    foreach (Edge edge in matchingEdges)
                    {
                        foreach (Site site in edge.EdgeSites)
                        {
                            strings.Add(GetAssertTrueMethodStart(assert) + @"EdgeHasSite(FindEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @"), " + site.X + @", " + site.Y + @")); // " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id + " has #" + site.Id + @"");
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
                List<string> strings = new List<string>();

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

                        strings.Add(GetAssertNotNullMethodStart(assert) + @"edge" + @"." + nameof(VoronoiEdge.Neighbours) + @");");

                        //if (assert)
                        //    strings.Add(@"Assert.Multiple(() => { // if the count is wrong, we want to know which edge is possibly missing");

                        strings.Add(GetAssertEqualMethodStart(assert) + neighbours.Count + GetAssertEqualMethodSeparator(assert) + @"edge" + @"." + nameof(VoronoiEdge.Neighbours) + @".Count(), ""Expected: edge neighbour count " + neighbours.Count + @""");");

                        foreach (Edge neighbour in neighbours)
                        {
                            string comment = (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id + " neighbours " + (char)neighbour.FromPoint.Id + @"-" + (char)neighbour.ToPoint.Id;

                            strings.Add(GetAssertTrueMethodStart(assert) + @"edge." + nameof(VoronoiEdge.Neighbours) + @".Contains(FindEdge(edges, " + neighbour.FromPoint.X + @", " + neighbour.FromPoint.Y + @", " + neighbour.ToPoint.X + @", " + neighbour.ToPoint.Y + @")), ""Expected: edge " + comment + @"""); // " + comment);
                        }

                        //if (assert)
                        //    strings.Add(@"});");
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
                List<string> strings = new List<string>();

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

                        strings.Add(GetAssertNotNullMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.Neighbours) + @");");

                        strings.Add(GetAssertEqualMethodStart(assert) + neighbours.Count + GetAssertEqualMethodSeparator(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiEdge.Neighbours) + @".Count());");

                        foreach (Site neighbour in neighbours)
                        {
                            strings.Add(GetAssertTrueMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]." + nameof(VoronoiSite.Neighbours) + @".Contains(sites[" + sites.IndexOf(neighbour) + @"])); // " + site.Id + @" neighbours " + neighbour.Id);
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
                List<string> strings = new List<string>();

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

                        strings.Add(GetAssertNotNullMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + listName + @");");

                        strings.Add(GetAssertEqualMethodStart(assert) + points.Count + GetAssertEqualMethodSeparator(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + listName + @".Count(), ""Expected: site #" + site.Id + @" point count " + points.Count + @"""); // #" + site.Id);

                        foreach (Point point in points)
                        {
                            string comment = @"#" + site.Id + " has " + (char)point.Id;
                            strings.Add(GetAssertTrueMethodStart(assert) + @"HasPoint(sites[" + sites.IndexOf(site) + @"]." + listName + @", " + point.X + @", " + point.Y + @"), ""Expected: site " + comment + @"""); // " + comment);
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
                                            strings.Add(GetAssertTrueMethodStart(assert) + @"PointIs(sites[" + sites.IndexOf(site) + @"]" + @"." + listName + @".ElementAt(" + index + @"), " + point.X + @", " + point.Y + @")); // #" + site.Id + @" " + (char)point.Id);

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

                                            strings.Add(GetAssertTrueMethodStart(assert) + @"PointsAreSequential(sites[" + sites.IndexOf(site) + @"]" + @"." + listName + @", " + point1.X + @", " + point1.Y + @", " + point2.X + @", " + point2.Y + @")); // #" + site.Id + @" " + (char)point1.Id + " > " + (char)point2.Id);
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
                List<string> strings = new List<string>();

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
                        strings.Add(GetAssertEqualMethodStart(assert) + centroidX.ToString("F2") + GetAssertEqualMethodSeparator(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.Centroid) + @"." + nameof(VoronoiPoint.X) + @", 0.01);");
                        strings.Add(GetAssertEqualMethodStart(assert) + centroidY.ToString("F2") + GetAssertEqualMethodSeparator(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.Centroid) + @"." + nameof(VoronoiPoint.Y) + @", 0.01);");
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
                            (c1!.Y + c2!.Y) / 2.0
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
                List<string> strings = new List<string>();

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
                                strings.Add(GetAssertNullMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnEdge) + @"); // #" + site.Id);
                                // Corner - null
                                strings.Add(GetAssertNullMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnCorner) + @"); // #" + site.Id);
                                break;

                            case 1:
                                // Edge - set
                                Edge edge = onEdges[0];
                                strings.Add(GetAssertNotNullMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnEdge) + @"); // #" + site.Id);
                                strings.Add(GetAssertEqualMethodStart(assert) + @"FindEdge(edges, " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")" + GetAssertEqualMethodSeparator(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnEdge) + @"); // #" + site.Id + @" on " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id);
                                // Corner - null
                                strings.Add(GetAssertNullMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnCorner) + @"); // #" + site.Id);
                                break;

                            case 2:
                                // Edge - null
                                strings.Add(GetAssertNullMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnEdge) + @"); // #" + site.Id);
                                // Corner - set
                                strings.Add(GetAssertNotNullMethodStart(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnCorner) + @"); // #" + site.Id);
                                Point point = onEdges[0].FromPoint == onEdges[1].FromPoint || onEdges[0].FromPoint == onEdges[1].ToPoint ? onEdges[0].FromPoint : onEdges[0].ToPoint;
                                strings.Add(GetAssertEqualMethodStart(assert) + @"FindPoint(edges, " + point.X + @", " + point.Y + @")" + GetAssertEqualMethodSeparator(assert) + @"sites[" + sites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.LiesOnCorner) + @"); // #" + site.Id + @" on " + (char)point.Id);
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
                List<string> strings = new List<string>();

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
                        strings.Add(GetAssertEqualMethodStart(assert) + nameof(PointBorderLocation) + @"." + PointLocationToExpectedBorderLocation(test, point) + GetAssertEqualMethodSeparator(assert) + @"FindPoint(edges, " + point.X + @", " + point.Y + @")." + nameof(VoronoiPoint.BorderLocation) + @"); // " + (char)point.Id);
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
                List<string> strings = new List<string>();

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

                        strings.Add(GetAssertNotNullMethodStart(assert) + @"sites[" + allSites.IndexOf(site) + @"]" + @"." + listName + @");");

                        strings.Add(GetAssertEqualMethodStart(assert) + siteEdges.Count + GetAssertEqualMethodSeparator(assert) + @"sites[" + allSites.IndexOf(site) + @"]" + @"." + listName + @".Count()); // #" + site.Id);

                        foreach (Edge siteEdge in siteEdges)
                        {
                            strings.Add(GetAssertTrueMethodStart(assert) + @"HasEdge(sites[" + allSites.IndexOf(site) + @"]." + listName + @", " + siteEdge.FromPoint.X + @", " + siteEdge.FromPoint.Y + @", " + siteEdge.ToPoint.X + @", " + siteEdge.ToPoint.Y + @")); // #" + site.Id + @" has " + (char)siteEdge.FromPoint.Id + @"-" + (char)siteEdge.ToPoint.Id);
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

                                        strings.Add(GetAssertTrueMethodStart(assert) + @"EdgeIs(sites[" + allSites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.ClockwiseCell) + @".ElementAt(" + i + @"), " + edge.FromPoint.X + @", " + edge.FromPoint.Y + @", " + edge.ToPoint.X + @", " + edge.ToPoint.Y + @")); // #" + site.Id + @" " + (char)edge.FromPoint.Id + @"-" + (char)edge.ToPoint.Id);
                                    }
                                }
                                else
                                {
                                    strings.Add("// Exact starting edge is undefined, so we only check that edges are sequential");

                                    for (int i = 0; i < orderedEdges.Count; i++)
                                    {
                                        Edge edge1 = orderedEdges[i];
                                        Edge edge2 = orderedEdges[i == orderedEdges.Count - 1 ? 0 : i + 1];

                                        strings.Add(GetAssertTrueMethodStart(assert) + @"EdgesAreSequential(sites[" + allSites.IndexOf(site) + @"]" + @"." + nameof(VoronoiSite.ClockwiseCell) + @", " + edge1.FromPoint.X + @", " + edge1.FromPoint.Y + @", " + edge1.ToPoint.X + @", " + edge1.ToPoint.Y + @", " + edge2.FromPoint.X + @", " + edge2.FromPoint.Y + @", " + edge2.ToPoint.X + @", " + edge2.ToPoint.Y + @")); // #" + site.Id + @" " + (char)edge1.FromPoint.Id + @"-" + (char)edge1.ToPoint.Id + @" > " + (char)edge2.FromPoint.Id + @"-" + (char)edge2.ToPoint.Id);
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

                List<Edge>?[,] edgeLines = new List<Edge>[horPreviewSteps, verPreviewSteps];

                foreach (Edge edge in test.Edges.Where(e => EdgeMatchesBorderLogic(e, borderLogic)))
                    PlaceEdgeOnGrid(ref edgeLines, edge);

                List<string> lines = new List<string>();

                for (int y = verPreviewSteps - 1; y >= 0; y--)
                {
                    string str = "// ";

                    int verValue = y * _verPreviewStepSize;

                    if (verValue % 100 == 0)
                        str += $"{verValue,4}";
                    else
                        str += @"    ";

                    str += @" ";

                    for (int x = 0; x < horPreviewSteps; x++)
                    {
                        int horValue = x * _horPreviewStepSize;

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
                                    if (x == 0)
                                    {
                                        if (y == 0)
                                            str += @"└";
                                        else if (y == verPreviewSteps - 1)
                                            str += @"↑";
                                        else
                                            str += @"|";
                                    }
                                    else if (y == 0)
                                    {
                                        if (x == horPreviewSteps - 1)
                                            str += "→";
                                        else
                                            str += "-";
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
                    int horValue = x * _horPreviewStepSize;

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

            private void PlaceEdgeOnGrid(ref List<Edge>?[,] edgeLines, Edge edge)
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
                    if (edgeLines[x, y] == null)
                        edgeLines[x, y] = new List<Edge>();
                    edgeLines[x, y]!.Add(edge);
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
                public int MinX { get; protected init; }
                public int MinY { get; protected init; }
                public int MaxX { get; protected init; }
                public int MaxY { get; protected init; }
                public int Width { get; protected init; }
                public int Height { get; protected init; }
                public List<Site> Sites { get; protected init; } = null!;
                public List<Point> Points { get; protected init; } = null!;
                public List<Edge> Edges { get; protected init; } = null!;
                public string Name { get; protected init; } = null!;


                public Test(int minX, int minY, int maxX, int maxY, string name, List<Site> sites, List<Point> points, List<Edge> edges)
                {
                    MinX = minX;
                    MinY = minY;
                    MaxX = maxX;
                    MaxY = maxY;
                    Sites = sites;
                    Points = points;
                    Edges = edges;
                    Name = name;

                    Width = maxX - minX;
                    Height = maxY - minY;
                }

                protected Test()
                {
                }
            }

            private class RepeatedTest : Test
            {
                public Repeat Repeated { get; }
                public string OriginalName { get; }


                public RepeatedTest(Test givenTest, Repeat repeat, int minX, int minY, int maxX, int maxY)
                {
                    Repeated = repeat;
                    OriginalName = givenTest.Name;

                    MinX = givenTest.MinX;
                    MinY = givenTest.MinY;
                    MaxX = givenTest.MaxX;
                    MaxY = givenTest.MaxY;
                    Width = givenTest.Width;
                    Height = givenTest.Height;

                    Sites = new List<Site>();
                    Points = new List<Point>();
                    Edges = new List<Edge>();

                    foreach (Site site in givenTest.Sites)
                    {
                        (int x, int y) = TransformCoord(site.X, site.Y, repeat, minX, minY, maxX, maxY);
                        Site newSite = new Site(x, y, site.Id);
                        Sites.Add(newSite);
                    }

                    foreach (Point point in givenTest.Points)
                    {
                        (int x, int y) = TransformCoord(point.X, point.Y, repeat, minX, minY, maxX, maxY);
                        Points.Add(new Point(x, y, point.Id, point.Corner));
                    }

                    foreach (Edge edge in givenTest.Edges)
                    {
                        Point fromPoint = Points[givenTest.Points.IndexOf(edge.FromPoint)];
                        Point toPoint = Points[givenTest.Points.IndexOf(edge.ToPoint)];
                        List<Site> sites = new List<Site>();
                        foreach (Site site in edge.EdgeSites)
                            sites.Add(Sites[givenTest.Sites.IndexOf(site)]);
                        Edges.Add(new Edge(fromPoint, toPoint, sites, edge.Border));
                    }

                    for (int s = 0; s < Sites.Count; s++)
                    {
                        Site ourSite = Sites[s];
                        Site givenSite = givenTest.Sites[s];

                        ourSite.UndefinedPointOrder = givenSite.UndefinedPointOrder;
                        if (ourSite.UndefinedPointOrder)
                            ourSite.Points = new[] { new List<Point>() };
                        else
                            ourSite.Points = new[] { new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>(), new List<Point>() };

                        for (int sourceQuadrant = 0; sourceQuadrant < givenSite.Points.Length; sourceQuadrant++)
                        {
                            int targetQuadrant;
                            if (givenSite.UndefinedPointOrder)
                                targetQuadrant = sourceQuadrant; // 0, basically
                            else
                                targetQuadrant = TransformQuadrantIndex(sourceQuadrant, repeat);

                            for (int p = 0; p < givenSite.Points[sourceQuadrant].Count; p++)
                            {
                                Point givenPoint = givenSite.Points[sourceQuadrant][p];
                                Point ourPoint = Points[givenTest.Points.IndexOf(givenPoint)];
                                ourSite.Points[targetQuadrant].Add(ourPoint);
                            }

                            if (DoesRepeatMirror(repeat))
                                ourSite.Points[targetQuadrant].Reverse();
                        }
                    }

                    Name = TransformName(givenTest.Name, repeat);
                }


                private static int TransformQuadrantIndex(int quadrant, Repeat repeat)
                {
                    if (DoesRepeatMirror(repeat))
                        quadrant = MirrorAcrossY(quadrant);

                    switch (repeat)
                    {
                        case Repeat.Rotate90:           quadrant -= 2; break;
                        case Repeat.Rotate180:          quadrant -= 4; break;
                        case Repeat.Rotate270:          quadrant -= 6; break;
                        case Repeat.Mirror:                            break;
                        case Repeat.MirrorAndRotate90:  quadrant -= 2; break;
                        case Repeat.MirrorAndRotate180: quadrant -= 4; break;
                        case Repeat.MirrorAndRotate270: quadrant -= 6; break;

                        case Repeat.RotateAll:
                        case Repeat.RotateAndMirrorAll:
                            throw new InvalidOperationException();

                        default:
                            throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
                    }

                    if (quadrant < 0)
                        quadrant += 8;

                    if (quadrant >= 8)
                        quadrant -= 8;

                    return quadrant;
                }

                private static int MirrorAcrossY(int quadrant)
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

                private static (int x, int y) TransformCoord(int siteX, int siteY, Repeat repeat, int minX, int minY, int maxX, int maxY)
                {
                    int x0 = minX;
                    int y0 = minY;
                    int x1 = maxX;
                    int y1 = maxY;
                    int xc = siteX;
                    int yc = siteY;

                    if (DoesRepeatMirror(repeat))
                    {
                        xc = x1 - xc + x0;
                        //yc = y1 - yc + y0; -- we only mirror horizontally
                    }

                    switch (repeat)
                    {
                        case Repeat.Mirror:
                            return (xc, yc); // no change except what mirror already applied

                        case Repeat.Rotate90:
                        case Repeat.MirrorAndRotate90:
                            return (x0 + yc, y1 - xc);

                        case Repeat.Rotate180:
                        case Repeat.MirrorAndRotate180:
                            return (x1 - xc, y1 - yc);

                        case Repeat.Rotate270:
                        case Repeat.MirrorAndRotate270:
                            return (x1 - yc, y0 + xc);

                        case Repeat.RotateAll:
                        case Repeat.RotateAndMirrorAll:
                            throw new InvalidOperationException();

                        default:
                            throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
                    }
                }

                private static bool DoesRepeatMirror(Repeat repeat)
                {
                    switch (repeat)
                    {
                        case Repeat.Rotate90:
                        case Repeat.Rotate180:
                        case Repeat.Rotate270:
                            return false;

                        case Repeat.Mirror:
                        case Repeat.MirrorAndRotate90:
                        case Repeat.MirrorAndRotate180:
                        case Repeat.MirrorAndRotate270:
                            return true;

                        case Repeat.RotateAndMirrorAll:
                        case Repeat.RotateAll:
                            throw new InvalidOperationException();

                        default:
                            throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
                    }
                }

                private string TransformName(string givenName, Repeat repeat)
                {
                    if (repeat == Repeat.Rotate90)
                        if (givenName.Contains("Horizontal"))
                            return givenName.Replace("Horizontal", "Vertical");

                    if (repeat == Repeat.Rotate90)
                        if (givenName.Contains("Vertical"))
                            return givenName.Replace("Vertical", "Horizontal");

                    return givenName + "_" + RepeatToNameSuffix(repeat);
                }

                private static string RepeatToNameSuffix(Repeat repeat)
                {
                    switch (repeat)
                    {
                        case Repeat.Rotate90:           return "Rotated90";
                        case Repeat.Rotate180:          return "Rotated180";
                        case Repeat.Rotate270:          return "Rotated270";
                        case Repeat.Mirror:             return "Mirrored";
                        case Repeat.MirrorAndRotate90:  return "MirroredAndRotated90";
                        case Repeat.MirrorAndRotate180: return "MirroredAndRotated180";
                        case Repeat.MirrorAndRotate270: return "MirroredAndRotated270";

                        case Repeat.RotateAll:
                        case Repeat.RotateAndMirrorAll:
                            throw new InvalidOperationException();

                        default:
                            throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null);
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

        private enum Repeat
        {
            Rotate90,
            Rotate180,
            Rotate270,
            RotateAll,
            Mirror,
            MirrorAndRotate90,
            MirrorAndRotate180,
            MirrorAndRotate270,
            RotateAndMirrorAll
        }

        private enum TestPurpose
        {
            AssertEdges,
            AssertSiteEdges,
            AssertEdgeSites,
            AssertSitePoints,
            AssertPointBorderLocation,
            AssertEdgeNeighbours,
            AssertSiteNeighbours,
            AssertSiteEdgesClockwise,
            AssertSitePointsClockwise,
            AssertLiesOnEdgeOrCorner,
            AssertSiteCentroids
        }

        private enum TestBorderLogic
        {
            UnclosedBorders,
            ClosedBorders
        }
    }


    internal static class StringBuilderExtensions
    {
        public static void AppendPaddedLine(this StringBuilder stringBuilder, int padding, string text, bool addExtraNewLine = false)
        {
            stringBuilder.Append(' ', padding * 4);
            stringBuilder.AppendLine(text);
            if (addExtraNewLine)
                stringBuilder.AppendLine();
        }
    }
}