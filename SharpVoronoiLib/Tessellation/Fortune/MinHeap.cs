using System;
using System.Diagnostics;

namespace SharpVoronoiLib
{
    public class MinHeap<T> where T : IComparable<T>
    {
        private readonly T[] items;
        public int Capacity { get; }
        public int Count { get; private set; }

        public MinHeap(int capacity)
        {
            if (capacity < 2)
            {
                capacity = 2;
            }

            Capacity = capacity;
            items = new T[Capacity];
            Count = 0;
        }

        public bool Insert(T obj, bool checkForDuplicates, Stopwatch? __stopwatch = null)
        {
            if (Count == Capacity)
                return false; // todo: should this not be exception? this fails silently because nothing ever uses the result
            
            if (checkForDuplicates)
            {
                __stopwatch?.Start();

                bool contains = Contains(obj);

                __stopwatch?.Stop();

                if (contains)
                    return false;
            }

            items[Count] = obj;
            Count++;
            PercolateUp(Count - 1);
            
            return true;
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Min heap is empty");
            if (Count == 1)
            {
                Count--;
                return items[Count];
            }

            T min = items[0];
            items[0] = items[Count - 1];
            Count--;
            PercolateDown(0);
            return min;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Min heap is empty");
            return items[0];
        }

        private void PercolateDown(int index)
        {
            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int largest = index;

                if (left < Count && items[left].CompareTo(items[largest]) == -1)
                    largest = left;
                if (right < Count && items[right].CompareTo(items[largest]) == -1)
                    largest = right;
                if (largest == index)
                    return;
                Swap(index, largest);
                index = largest;
            }
        }

        private void PercolateUp(int index)
        {
            while (true)
            {
                if (index >= Count || index <= 0)
                    return;
                int parent = (index - 1) / 2;

                if (items[parent].CompareTo(items[index]) == -1)
                    return;

                Swap(index, parent);
                index = parent;
            }
        }

        private void Swap(int left, int right)
        {
            (items[left], items[right]) = (items[right], items[left]);
        }

        private bool Contains(T obj)
        {
            // Unfortuantely, min heap isn't guaranteed any sort of sorting for leaves, so the value could be anywhere
            
            for (int i = 0; i < Count; i++)
                if (items[i].CompareTo(obj) == 0)
                    return true;

            return false;        
        }
    }
}
