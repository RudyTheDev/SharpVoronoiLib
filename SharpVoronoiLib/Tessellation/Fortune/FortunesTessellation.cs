using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVoronoiLib
{
    internal class FortunesTessellation : ITessellationAlgorithm
    {
        public List<VoronoiEdge> Run(List<VoronoiSite> sites, double minX, double minY, double maxX, double maxY)
        {
            MinHeap<FortuneEvent> eventQueue = new MinHeap<FortuneEvent>(5 * sites.Count);

            HashSet<VoronoiSite> siteCache = new HashSet<VoronoiSite>(VoronoiSiteComparer.Instance);
            
            foreach (VoronoiSite site in sites)
            {
                if (!siteCache.Add(site))
                    continue;

                if (site == null) throw new ArgumentNullException(nameof(sites));

                FortuneSiteEvent siteEvent = new FortuneSiteEvent(site);

                eventQueue.Insert(siteEvent);
                
                site.Tessellating();
            }
            
            //init tree
            BeachLine beachLine = new BeachLine();
            LinkedList<VoronoiEdge> edges = new LinkedList<VoronoiEdge>();
            HashSet<FortuneCircleEvent> deleted = new HashSet<FortuneCircleEvent>();

            //init edge list
            while (eventQueue.Count != 0)
            {
                FortuneEvent fEvent = eventQueue.Pop();
                
                if (fEvent is FortuneSiteEvent)
                    beachLine.AddBeachSection((FortuneSiteEvent)fEvent, eventQueue, deleted, edges);
                else
                {
                    if (deleted.Contains((FortuneCircleEvent)fEvent))
                    {
                        deleted.Remove((FortuneCircleEvent)fEvent);
                    }
                    else
                    {
                        beachLine.RemoveBeachSection((FortuneCircleEvent)fEvent, eventQueue, deleted, edges);
                    }
                }
            }

            return edges.ToList(); 
            // TODO: Build the list directly
        }

        
        internal class VoronoiSiteComparer : IEqualityComparer<VoronoiSite>
        {
            public static VoronoiSiteComparer Instance { get; } = new VoronoiSiteComparer();
            private VoronoiSiteComparer() { }


            public bool Equals(VoronoiSite a, VoronoiSite b)
            {
                return a.X.ApproxEqual(b.X) && a.Y.ApproxEqual(b.Y);
            }

            public int GetHashCode(VoronoiSite obj)
            {
                unchecked
                {
                    return (obj.X.GetHashCode() * 397) ^ obj.Y.GetHashCode();
                }
            }
        }
    }
}