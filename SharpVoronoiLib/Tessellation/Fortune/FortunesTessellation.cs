﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVoronoiLib
{
    internal class FortunesTessellation : ITessellationAlgorithm
    {
        public List<VoronoiEdge> Run(List<VoronoiSite> sites, double minX, double minY, double maxX, double maxY)
        {
            MinHeap<FortuneEvent> eventQueue = new MinHeap<FortuneEvent>(5 * sites.Count);

            for (int i = 0; i < sites.Count; i++)
            {
                VoronoiSite site = sites[i];
                
                if (site == null) throw new ArgumentNullException(nameof(sites));

                FortuneSiteEvent siteEvent = new FortuneSiteEvent(site);

                if (eventQueue.Insert(siteEvent))
                {
                    site.Tessellating();
                }
                else
                {
                    // todo: I am not sure if this is the right approach or not
                    //sites.RemoveAt(i);
                    //i--;
                }
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
    }
}