using System;

namespace SharpVoronoiLib
{
    internal interface FortuneEvent : IComparable<FortuneEvent>
    {
        double X { get; }
        double Y { get; }
        int DuplicateCounter { get; set; }
    }
}
