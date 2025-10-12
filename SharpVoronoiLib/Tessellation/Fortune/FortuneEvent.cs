namespace SharpVoronoiLib;

internal interface FortuneEvent : IComparable<FortuneEvent>
{
    double X { get; }
    double Y { get; }
}