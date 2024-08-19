namespace SharpVoronoiLib
{
    internal class FortuneCircleEvent : FortuneEvent
    {
        internal VoronoiPoint Lowest { get; }
        internal double YCenter { get; }
        internal RBTreeNode<BeachSection> ToDelete { get; }

        internal FortuneCircleEvent(VoronoiPoint lowest, double yCenter, RBTreeNode<BeachSection> toDelete)
        {
            Lowest = lowest;
            YCenter = yCenter;
            ToDelete = toDelete;
        }

        public int CompareTo(FortuneEvent other)
        {
            int c = Y.CompareTo(other.Y);
            return c == 0 ? X.CompareTo(other.X) : c;
        }

        public double X => Lowest.X;
        public double Y => Lowest.Y;


        public override string ToString()
        {
            return "Circle @" + X.ToString("F3") + "," + Y.ToString("F3");
        }
    }
}
