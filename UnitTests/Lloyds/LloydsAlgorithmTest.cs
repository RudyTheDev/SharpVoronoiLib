using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class LloydsAlgorithmTest
    {
        [Test]
        public void TestRelax()
        {
            // Arrange
            
            List<VoronoiSite> originalSites = new List<VoronoiSite>
            {
                new VoronoiSite(-100, 300),
                new VoronoiSite(300, -100),
                new VoronoiSite(800, 300),
                new VoronoiSite(300, 800)
            };

            List<VoronoiSite> sites = new List<VoronoiSite>(originalSites); // copy so any changes to list don't affect the source list 

            VoronoiPlane plane = new VoronoiPlane(0, 0, 600, 600);

            plane.SetSites(sites);

            plane.Tessellate();
            
            // Act

            List<VoronoiEdge> edges = plane.Relax();

            // Assert

            Assert.That(edges, Is.Not.Null);
            Assert.That(edges, Is.Not.Empty);
            Assert.That(sites, Has.Count.EqualTo(originalSites.Count));
            // todo: check movement
        }
    }
}