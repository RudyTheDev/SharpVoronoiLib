using NUnit.Framework;
using System.Collections.Generic;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class BugReproTests
    {
        /// <summary>
        /// Issue #2
        /// </summary>
        [Test]
        public void IncorrectNeighours()
        {
            // Arrange

            VoronoiSite site0 = new VoronoiSite(309.2762, 29.37344);
            VoronoiSite site1 = new VoronoiSite(498.7968, 410.0901);
            VoronoiSite site2 = new VoronoiSite(328.3032, 284.3138);
            VoronoiSite site3 = new VoronoiSite(25.5397, 184.688);
            VoronoiSite site4 = new VoronoiSite(373.5264, 73.77794);

            List<VoronoiSite> sites = new List<VoronoiSite>
            {
                site0,
                site1,
                site2,
                site3,
                site4
            };

            // Act

            VoronoiPlane.TessellateOnce(
                sites,
                0, 0, 500, 500
            );

            // Assert

            CollectionAssert.AreEquivalent(new[] { site2, site3, site4 }, site0.Neighbours);
            CollectionAssert.AreEquivalent(new[] { site2 }, site1.Neighbours);
            CollectionAssert.AreEquivalent(new[] { site0, site1, site3, site4 }, site2.Neighbours);
            CollectionAssert.AreEquivalent(new[] { site0, site2 }, site3.Neighbours);
            CollectionAssert.AreEquivalent(new[] { site0, site2 }, site4.Neighbours);
        }
    }
}