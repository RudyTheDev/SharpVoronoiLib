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
            int c = Y.ApproxCompareTo(other.Y);
            return c == 0 ? X.ApproxCompareTo(other.X) : c;
        }


        public override string ToString()
        {
            return "Site @" + X.ToString("F3") + "," + Y.ToString("F3");
        }
    }
}