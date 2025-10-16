namespace SharpVoronoiLib;

internal class FortunesTessellation : ITessellationAlgorithm
{
    public List<VoronoiEdge> Run(List<VoronoiSite> sites, double minX, double minY, double maxX, double maxY, out int duplicateCount)
    {
        MinHeap<FortuneEvent> eventQueue = new MinHeap<FortuneEvent>(5 * sites.Count);

        HashSet<VoronoiSite> siteCache = new HashSet<VoronoiSite>(VoronoiSiteComparer.Instance);
        
        duplicateCount = 0;
            
        foreach (VoronoiSite site in sites)
        {
            // If the site has already been marked as a duplicate before (such as prior to relaxing), count and skip it
            if (site.SkippedAsDuplicate)
            {
                duplicateCount++;
                continue;
            }
            
            if (!siteCache.Add(site))
            {
                site.MarkSkippedAsDuplicate();
                duplicateCount++;
                continue;
            }

            FortuneSiteEvent siteEvent = new FortuneSiteEvent(site);

            eventQueue.Insert(siteEvent);
                
            site.Tessellated();
        }
            
        //init tree
        BeachLine beachLine = new BeachLine();
        LinkedList<VoronoiEdge> edges = new LinkedList<VoronoiEdge>();
        HashSet<FortuneCircleEvent> deleted = new HashSet<FortuneCircleEvent>();

        //init edge list
        while (eventQueue.Count != 0)
        {
            FortuneEvent nextEvent = eventQueue.Pop();

            switch (nextEvent)
            {
                case FortuneSiteEvent siteEvent:
                    beachLine.AddBeachSection(siteEvent, eventQueue, deleted, edges);
                    break;
                
                case FortuneCircleEvent circleEvent:
                    if (deleted.Contains(circleEvent))
                        deleted.Remove(circleEvent);
                    else
                        beachLine.RemoveBeachSection(circleEvent, eventQueue, deleted, edges);
                    break;
            }
        }

        return edges.ToList(); 
        // Note: I attempted to make an optimized linked list with item caching, but this didn't gain any performance until 100K sites.
        // I suspect the small number of edge removals and the overhead of the linked list management just doesn't beat a single .ToList() here.
    }
}