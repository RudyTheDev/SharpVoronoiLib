namespace SharpVoronoiLib
{
    internal class FortuneSiteEvent : FortuneEvent
    {
        public double X => Site.X;
        public double Y => Site.Y;
        internal VoronoiSite Site { get; }

        internal FortuneSiteEvent(VoronoiSite site)
        {
            Site = site;
        }


        public override string ToString()
        {
            return "Site @" + X.ToString("F3") + "," + Y.ToString("F3");
        }
    }
}