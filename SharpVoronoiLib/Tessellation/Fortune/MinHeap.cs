namespace SharpVoronoiLib;

public class MinHeap<T> where T : IComparable<T>
{
    public int Count { get; private set; }

    
    private T[] _items;
    
    
    public MinHeap(int capacity)
    {
        if (capacity < 2)
            capacity = 2;

        _items = new T[capacity];
        Count = 0;
    }

    public void Insert(T item)
    {
        if (Count == _items.Length)
            Array.Resize(ref _items, _items.Length * 2);

        _items[Count] = item;
        Count++;
        PercolateUp(Count - 1);
    }

    public T Pop()
    {
        if (Count == 0) throw new InvalidOperationException("Min heap is empty");
        
        
        if (Count == 1)
        {
            Count--;
            return _items[Count];
        }

        T min = _items[0];
        _items[0] = _items[Count - 1];
        Count--;
        PercolateDown(0);
        
        return min;
    }

    public T Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Min heap is empty");
        
        
        return _items[0];
    }

    private void PercolateDown(int index)
    {
        while (true)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int smallest = index;

            if (left < Count && _items[left].CompareTo(_items[smallest]) <= 0)
                smallest = left;
            
            if (right < Count && _items[right].CompareTo(_items[smallest]) <= 0)
                smallest = right;
            
            if (smallest == index)
                return;
            
            Swap(index, smallest);
            
            index = smallest;
        }
    }

    private void PercolateUp(int index)
    {
        while (true)
        {
            if (index >= Count || index <= 0)
                return;
            
            int parent = (index - 1) / 2;

            if (_items[parent].CompareTo(_items[index]) < 0)
                return;

            Swap(index, parent);
            
            index = parent;
        }
    }

    private void Swap(int left, int right)
    {
        (_items[left], _items[right]) = (_items[right], _items[left]);
    }
}