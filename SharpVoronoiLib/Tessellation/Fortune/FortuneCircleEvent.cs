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
            int c = Y.ApproxCompareTo(other.Y);
            return c == 0 ? X.ApproxCompareTo(other.X) : c;
        }

        public double X => Lowest.X;
        public double Y => Lowest.Y;


        public override string ToString()
        {
            return "Circle @" + X.ToString("F3") + "," + Y.ToString("F3");
        }
    }
}
