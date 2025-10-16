#nullable disable // This code hasn't been converted to nullable yet

namespace SharpVoronoiLib;

internal class FortuneCircleEvent : FortuneEvent
{
    internal VoronoiPoint Lowest { get; }
    internal double YCenter { get; }
    internal RBTreeNode<BeachSection> ToDelete { get; }
    internal bool Discarded { get; set; }

    public double X => Lowest.X;
    public double Y => Lowest.Y;

        
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
        
        
    public override string ToString()
    {
        return "Circle @" + X.ToString("F3") + "," + Y.ToString("F3");
    }
}