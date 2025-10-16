namespace SharpVoronoiLib;

/// <summary>
/// A linked list that caches the node reference in the item, allowing O(1) lookup/removal.
/// Otherwise, functions like a standard linked list (except for all the unimplemented features).
/// </summary>
internal class CachedLinkedList<T> where T : class, CachedLinkedList<T>.ICachedLinkedListItem
{
    private LinkedNode? _head;

    private int _count;


    internal void AddFirst(T item)
    {
        if (item.CachedLinkedListNode != null)
            throw new ArgumentException();
        
        LinkedNode newNode = new LinkedNode(item);

        if (_head != null)
        {
            newNode.next = _head;
            _head.prev = newNode;
        }
        
        _head = newNode;
        
        _count++;

        item.CachedLinkedListNode = newNode;
    }

    internal void Remove(T item)
    {
        if (item.CachedLinkedListNode == null)
            throw new ArgumentException();
        
        LinkedNode node = item.CachedLinkedListNode!;
        
        if (node.prev != null)
            node.prev.next = node.next;
        else
            _head = node.next;
        
        if (node.next != null)
            node.next.prev = node.prev;
        
        item.CachedLinkedListNode = null!;
        
        _count--;
    }

    internal List<T> ToList(bool clearNodeBackReferences = true)
    {
        List<T> list = new List<T>(_count);

        LinkedNode? current = _head;

        while (current != null)
        {
            if (clearNodeBackReferences)
                current.item.CachedLinkedListNode = null;
            
            list.Add(current.item);
            current = current.next;
        }

        return list;
    }
    
    
    internal class LinkedNode
    {
        internal readonly T item;
        internal LinkedNode? next;
        internal LinkedNode? prev;
        
        
        internal LinkedNode(T item)
        {
            this.item = item;
        }
    }

    
    internal interface ICachedLinkedListItem
    {
        internal LinkedNode? CachedLinkedListNode { get; set; }
    }
}