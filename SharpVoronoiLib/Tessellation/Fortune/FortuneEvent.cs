namespace SharpVoronoiLib
{
    internal interface FortuneEvent
    {
        double X { get; }
        double Y { get; }
        int DuplicateCounter { get; set; }
    }
}
