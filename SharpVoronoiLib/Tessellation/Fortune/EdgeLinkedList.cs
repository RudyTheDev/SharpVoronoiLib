namespace SharpVoronoiLib;

internal class EdgeLinkedList<T> where T : VoronoiEdge
{
    private readonly LinkedList<T> _list = [ ];


    public void Remove(T edge)
    {
        _list.Remove(edge);
    }

    public void AddFirst(T edge)
    {
        _list.AddFirst(edge);
    }

    public List<T> ToList()
    {
        return _list.ToList();
    }
}