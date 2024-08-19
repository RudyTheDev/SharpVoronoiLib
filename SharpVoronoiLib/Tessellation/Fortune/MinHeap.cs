using System;
using System.Runtime.CompilerServices;

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

        public bool Insert(T obj)
        {
            if (Count == Capacity)
                return false; // todo: should this not be exception? this fails silently because nothing ever uses the result
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

        //TODO: stop using the remove on the heap as it goes o(N^2)

        public bool Remove(T item)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                return false; // todo: should this not be exception? this fails silently because nothing ever uses the result. and we don't expect to call it for elements we don't have

            Count--;
            Swap(index, Count);
            if (Compare(index, (index - 1) / 2) == Result.LeftLessThanRight)
                PercolateUp(index);
            else
                PercolateDown(index);
            return true;
        }

        private void PercolateDown(int index)
        {
            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int largest = index;

                if (left < Count && Compare(left, largest) == Result.LeftLessThanRight)
                    largest = left;
                if (right < Count && Compare(right, largest) == Result.LeftLessThanRight)
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

                if (Compare(parent, index) == Result.LeftLessThanRight)
                    return;

                Swap(index, parent);
                index = parent;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private Result Compare(int left, int right)
        {
            int compare = items[left].CompareTo(items[right]);
            return compare < 0 ? Result.LeftLessThanRight : compare > 0 ? Result.RightLessThanLeft : Result.Equal;
        }

        private void Swap(int left, int right)
        {
            (items[left], items[right]) = (items[right], items[left]);
        }

        private enum Result
        {
            LeftLessThanRight,
            RightLessThanLeft,
            Equal
        }
    }
}
