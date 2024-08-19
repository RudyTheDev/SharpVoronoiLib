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

        public int CompareTo(FortuneEvent other)
        {
            int c = Y.CompareTo(other.Y);
            return c == 0 ? X.CompareTo(other.X) : c;
        }


        public override string ToString()
        {
            return "Site @" + X.ToString("F3") + "," + Y.ToString("F3");
        }
    }
}