namespace SharpVoronoiLib
{
    internal class FortuneCircleEvent : FortuneEvent
    {
        internal VoronoiPoint Lowest { get; }
        internal double YCenter { get; }
        internal RBTreeNode<BeachSection> ToDelete { get; }

        public int DuplicateCounter { get; set; }

        public double X => Lowest.X;
        public double Y => Lowest.Y;

        
        internal FortuneCircleEvent(VoronoiPoint lowest, double yCenter, RBTreeNode<BeachSection> toDelete)
        {
            Lowest = lowest;
            YCenter = yCenter;
            ToDelete = toDelete;
        }


        public override string ToString()
        {
            return "Circle @" + X.ToString("F3") + "," + Y.ToString("F3");
        }
    }
}
