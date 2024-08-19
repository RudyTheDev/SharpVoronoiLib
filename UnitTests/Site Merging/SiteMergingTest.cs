using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using NUnit.Framework;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Ignore("WIP")]
    [Parallelizable(ParallelScope.All)]
    public class SiteMergingTest
    {
        private Random _random = new Random();
            
        
        [TestCase(VoronoiSiteMergeDecision.MergeIntoSite1, 0)]
        [TestCase(VoronoiSiteMergeDecision.MergeIntoSite2, 1)]
        public void TwoSites(VoronoiSiteMergeDecision mergeDecision, int expectedRemainingSite)
        {
            // Arrange
            
            List<VoronoiSite> originalSites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 300),
                new VoronoiSite(500, 300)
            };

            List<VoronoiSite> sites = new List<VoronoiSite>(originalSites); // copy so any changes to list don't affect the source list 

            VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

            plane.SetSites(sites);

            plane.Tessellate();
            
            VoronoiSiteMergeDecision MergeQuery(VoronoiSite site1, VoronoiSite site2)
            {
                return mergeDecision;
            }
            
            // Act

            List<VoronoiSite> newSites = plane.MergeSites(MergeQuery);

            // Assert
            
            Assert.NotNull(newSites);
            Assert.IsNotEmpty(newSites);
            Assert.AreEqual(1, newSites.Count);
            Assert.AreSame(originalSites[expectedRemainingSite], newSites[0]);
            Assert.AreEqual(6, newSites[0].Points.Count());
            Assert.AreEqual(6, newSites[0].Cell.Count());
        }
        
        [TestCase(new[] { 0,1 }, new[] { 1, 2 }, new[] { 6, 4 }, new[] { 6, 4 })]
        [TestCase(new[] { 1,0 }, new[] { 0, 2 }, new[] { 6, 4 }, new[] { 6, 4 })]
        [TestCase(new[] { 1,2 }, new[] { 0, 2 }, new[] { 4, 6 }, new[] { 4, 6 })]
        [TestCase(new[] { 2,1 }, new[] { 0, 1 }, new[] { 4, 6 }, new[] { 4, 6 })]
        [TestCase(new[] { 1,0, 2,0 }, new[] { 0 }, new[] { 8 }, new[] { 8 })]
        [TestCase(new[] { 0,1, 2,1 }, new[] { 1 }, new[] { 8 }, new[] { 8 })]
        [TestCase(new[] { 0,2, 1,2 }, new[] { 2 }, new[] { 8 }, new[] { 8 })]
        public void ThreeSitesInARow(int[] mergeDecisions, int[] expectedRemainingSites, int[] expectedRemainingPoints, int[] expectedRemainingEdges)
        {
            // Arrange
            
            List<VoronoiSite> originalSites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 300),
                new VoronoiSite(300, 300),
                new VoronoiSite(500, 300)
            };

            List<VoronoiSite> sites = new List<VoronoiSite>(originalSites); // copy so any changes to list don't affect the source list 

            VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

            plane.SetSites(sites);

            plane.Tessellate();
            
            // Act

            List<VoronoiSite> newSites = plane.MergeSites(
                (site, site2) => GenericMergeQuery(site, site2, mergeDecisions, originalSites)
            );
            
            // Assert
            
            Assert.NotNull(newSites);
            Assert.IsNotEmpty(newSites);
            Assert.AreEqual(expectedRemainingSites.Length, newSites.Count);
            foreach (int expectedRemainingSite in expectedRemainingSites)
                Assert.IsTrue(newSites.Contains(originalSites[expectedRemainingSite]));
            for (int i = 0; i < expectedRemainingPoints.Length; i++)
                Assert.AreEqual(expectedRemainingPoints[i], originalSites[expectedRemainingSites[i]].Points.Count());
            for (int i = 0; i < expectedRemainingEdges.Length; i++)
                Assert.AreEqual(expectedRemainingEdges[i], originalSites[expectedRemainingSites[i]].Cell.Count());
        }
        
        [TestCase(new[] { 0,1 }, new[] { 1, 2 }, new[] { 6, 4 }, new[] { 6, 4 })]
        [TestCase(new[] { 1,0 }, new[] { 0, 2 }, new[] { 6, 4 }, new[] { 6, 4 })]
        [TestCase(new[] { 0,2 }, new[] { 1, 2 }, new[] { 4, 6 }, new[] { 4, 6 })]
        [TestCase(new[] { 2,0 }, new[] { 0, 1 }, new[] { 6, 4 }, new[] { 6, 4 })]
        [TestCase(new[] { 1,2 }, new[] { 0, 2 }, new[] { 4, 6 }, new[] { 4, 6 })]
        [TestCase(new[] { 2,1 }, new[] { 0, 1 }, new[] { 4, 6 }, new[] { 4, 6 })]
        [TestCase(new[] { 1,0, 2,0 }, new[] { 0 }, new[] { 6 }, new[] { 6 })]
        [TestCase(new[] { 0,1, 2,1 }, new[] { 1 }, new[] { 6 }, new[] { 6 })]
        [TestCase(new[] { 0,2, 1,2 }, new[] { 2 }, new[] { 6 }, new[] { 6 })]
        public void ThreeSitesTouching(int[] mergeDecisions, int[] expectedRemainingSites, int[] expectedRemainingPoints, int[] expectedRemainingEdges)
        {
            // Arrange
            
            // 1000 Y-------------------B-----------------------------X
            //      |                   |                             |
            //  900 |                   |                             |
            //      |                   |                             |
            //  800 |                   |                             |
            //      |                   |                             |
            //  700 |              1    |    0                        |
            //      |                   |                             |
            //  600 C-------------------A,                            |
            //      |                     ',                          |
            //  500 |              2        '·,                       |
            //      |                          ',                     |
            //  400 |                            '·,                  |
            //      |                               ',                |
            //  300 |                                 '·,             |
            //      |                                    ',           |
            //  200 |                                      '·,        |
            //      |                                         ',      |
            //  100 |                                           '·,   |
            //      |                                              ', |
            //    0 W------------------------------------------------#D
            //       0  100  200  300  400  500  600  700  800  900 1000 
            
            List<VoronoiSite> originalSites = new List<VoronoiSite>
            {
                new VoronoiSite(500, 700), // #0
                new VoronoiSite(300, 700), // #1
                new VoronoiSite(300, 500), // #2
            };

            List<VoronoiSite> sites = new List<VoronoiSite>(originalSites); // copy so any changes to list don't affect the source list 

            VoronoiPlane plane = new VoronoiPlane(0, 0, 1000, 1000);

            plane.SetSites(sites);

            plane.Tessellate();
            
            // Act

            List<VoronoiSite> newSites = plane.MergeSites(
                (site, site2) => GenericMergeQuery(site, site2, mergeDecisions, originalSites)
            );

            // Assert
            
            Assert.NotNull(newSites);
            Assert.IsNotEmpty(newSites);
            Assert.AreEqual(expectedRemainingSites.Length, newSites.Count);
            foreach (int expectedRemainingSite in expectedRemainingSites)
                Assert.IsTrue(newSites.Contains(originalSites[expectedRemainingSite]));
            for (int i = 0; i < expectedRemainingPoints.Length; i++)
                Assert.AreEqual(expectedRemainingPoints[i], originalSites[expectedRemainingSites[i]].Points.Count());
            for (int i = 0; i < expectedRemainingEdges.Length; i++)
                Assert.AreEqual(expectedRemainingEdges[i], originalSites[expectedRemainingSites[i]].Cell.Count());
        }


        [Pure]
        private static VoronoiSiteMergeDecision GenericMergeQuery(VoronoiSite site1, VoronoiSite site2, int[] mergeDecisions, List<VoronoiSite> originalSites)
        {
            for (int i = 0; i < mergeDecisions.Length - 1; i += 2)
            {
                int i1 = mergeDecisions[i];
                int i2 = mergeDecisions[i + 1];
                    
                if (mergeDecisions.Any(md => originalSites[i1] == site1 && originalSites[i2] == site2))
                    return VoronoiSiteMergeDecision.MergeIntoSite2;
                
                if (mergeDecisions.Any(md => originalSites[i2] == site1 && originalSites[i1] == site2))
                    return VoronoiSiteMergeDecision.MergeIntoSite1;
            }

            return VoronoiSiteMergeDecision.DontMerge;
        }
        
        [Test]
        [Timeout(100)] // todo: temp - it gets stuck
        [Repeat(1)]
        public void RandomSites()
        {
            // Arrange

            VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

            int expectedSiteCount = 1000; 

            plane.GenerateRandomSites(expectedSiteCount);

            plane.Tessellate();
            
            // Act

            List<VoronoiSite> sites = plane.MergeSites(
                (_, _) => RandomMergeDecision(ref expectedSiteCount)
            );

            // Assert
            
            Assert.AreEqual(expectedSiteCount, sites.Count);
        }

        private VoronoiSiteMergeDecision RandomMergeDecision(ref int expectedSiteCount)
        {
            float r = _random.NextSingle();

            if (r > 0.9f)
            {
                expectedSiteCount--;
                return VoronoiSiteMergeDecision.MergeIntoSite1;
            }

            if (r < 0.1f)
            {
                expectedSiteCount--;
                return VoronoiSiteMergeDecision.MergeIntoSite2;
            }

            return VoronoiSiteMergeDecision.DontMerge;
        }
    }
}