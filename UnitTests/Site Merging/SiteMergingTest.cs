using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using NUnit.Framework;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SiteMergingTest
    {
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
        }
        
        [TestCase(new[] { 0,1 }, new[] { 1,2 })]
        [TestCase(new[] { 1,0 }, new[] { 0,2 })]
        [TestCase(new[] { 1,2 }, new[] { 0,2 })]
        [TestCase(new[] { 2,1 }, new[] { 0,1 })]
        [TestCase(new[] { 1,0, 2,0 }, new[] { 0 })]
        [TestCase(new[] { 0,1, 2,1 }, new[] { 1 })]
        [TestCase(new[] { 0,2, 1,2 }, new[] { 2 })]
        public void ThreeSitesInARow(int[] mergeDecisions, int[] expectedRemainingSites)
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
        }
        
        [TestCase(new[] { 0,1 }, new[] { 1,2 })]
        [TestCase(new[] { 1,0 }, new[] { 0,2 })]
        [TestCase(new[] { 0,2 }, new[] { 1,2 })]
        [TestCase(new[] { 2,0 }, new[] { 0,1 })]
        [TestCase(new[] { 1,2 }, new[] { 0,2 })]
        [TestCase(new[] { 2,1 }, new[] { 0,1 })]
        [TestCase(new[] { 1,0, 2,0 }, new[] { 0 })]
        [TestCase(new[] { 0,1, 2,1 }, new[] { 1 })]
        [TestCase(new[] { 0,2, 1,2 }, new[] { 2 })]
        public void ThreeSitesTouching(int[] mergeDecisions, int[] expectedRemainingSites)
        {
            // Arrange
            
            List<VoronoiSite> originalSites = new List<VoronoiSite>
            {
                new VoronoiSite(100, 400),
                new VoronoiSite(300, 200),
                new VoronoiSite(500, 400)
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
    }
}