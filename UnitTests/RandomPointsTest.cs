using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class RandomPointsTest
    {
        [Test]
        public void TestUniform()
        {
            // Arrange

            const int size = 600;
            
            VoronoiPlane plane = new VoronoiPlane(0, 0, size, size);

            // Act

            const int amount = 1000000;
            List<VoronoiSite> sites = plane.GenerateRandomSites(amount, PointGenerationMethod.Uniform);

            // Assert
            
            Assert.That(sites, Is.Not.Null);
            Assert.That(sites, Has.Count.EqualTo(amount));
            
            foreach (VoronoiSite site in sites)
            {
                Assert.That(site.X, Is.LessThan(size));
                Assert.That(site.X, Is.GreaterThan(0.0));
                Assert.That(site.Y, Is.LessThan(size));
                Assert.That(site.Y, Is.GreaterThan(0.0));
            }

            // Split the range into bands/slices and see how many points are within that slice
            
            const int bands = 10;
            
            int[] countsX = new int[bands];
            int[] countsY = new int[bands];
            
            foreach (VoronoiSite site in sites)
            {
                countsX[(int)Math.Floor(site.X / size * bands)]++;
                countsY[(int)Math.Floor(site.Y / size * bands)]++;
            }

            const double tolerance = 0.1;

            for (int i = 0; i < bands; i++)
            {
                Assert.That(countsX[i], Is.EqualTo((double)amount / bands).Within((double)amount / bands * tolerance));
                Assert.That(countsY[i], Is.EqualTo((double)amount / bands).Within((double)amount / bands * tolerance));
            }
        }
        
        [Test]
        public void TestGaussian()
        {
            // Arrange

            const int size = 600;
            
            VoronoiPlane plane = new VoronoiPlane(0, 0, size, size);

            // Act

            const int amount = 1000000;
            List<VoronoiSite> sites = plane.GenerateRandomSites(amount, PointGenerationMethod.Gaussian);

            // Assert
            
            Assert.That(sites, Is.Not.Null);
            Assert.That(sites, Has.Count.EqualTo(amount));
            
            foreach (VoronoiSite site in sites)
            {
                Assert.That(site.X, Is.LessThan(size));
                Assert.That(site.X, Is.GreaterThan(0.0));
                Assert.That(site.Y, Is.LessThan(size));
                Assert.That(site.Y, Is.GreaterThan(0.0));
            }

            // Split the range into bands/slices and see how many points are within that slice

            const int bands = 7;
            
            int[] countsX = new int[bands];
            int[] countsY = new int[bands];
            
            foreach (VoronoiSite site in sites)
            {
                countsX[(int)Math.Floor(site.X / size * bands)]++;
                countsY[(int)Math.Floor(site.Y / size * bands)]++;
            }

            const double tolerance = 0.1;

            for (int i = 0; i < bands; i++)
            {
                // Hard-coded normal distribution for 7 bands/segments:
                // Value     Norm     Total    Frac
                // -1.000    0.001    
                // -0.714    0.016    1.47%    0.0147
                // -0.429    0.099    8.32%    0.0832
                // -0.143    0.334    23.48%   0.2348
                // 0.143     0.666    33.18%   0.3318
                // 0.429     0.901    23.48%   0.2348
                // 0.714     0.984    8.32%    0.0832
                // 1.000     0.999    1.47%    0.0147
                
                double distr =
                    i == 0 ? 0.0147 :
                    i == 1 ? 0.0832 :
                    i == 2 ? 0.2348 :
                    i == 3 ? 0.3318 :
                    i == 4 ? 0.2348 :
                    i == 5 ? 0.0832 :
                             0.0147; 

                double expected = amount * distr;
                
                Assert.That(countsX[i], Is.EqualTo(expected).Within(expected * tolerance));
                Assert.That(countsY[i], Is.EqualTo(expected).Within(expected * tolerance));
            }
        }
    }
}