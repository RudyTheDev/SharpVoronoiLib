using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class MinHeapTest
    {
        [Test]
        public void Sort5Test()
        {
            MinHeap<int> heap = new MinHeap<int>(5);
            heap.Insert(5);
            heap.Insert(4);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);
            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(3, heap.Pop());
            Assert.AreEqual(4, heap.Pop());
            Assert.AreEqual(5, heap.Pop());
        }

        [Test]
        public void DeleteTest()
        {
            MinHeap<int> heap = new MinHeap<int>(5);
            for (int i = 1; i <= 5; i++)
            {
                //insert 5 through 1
                for (int j = 5; j >= 1; j--)
                {
                    heap.Insert(j);
                }
                //remove i
                heap.Remove(i);
                //the order of pops should be sorted without i
                for (int j = 1; j <= 5; j++)
                {
                    if (j != i)
                        Assert.AreEqual(j, heap.Pop());
                }
            }
        }

        [Test]
        public void SortRandom()
        {
            List<double> numbers = new List<double>();
            Random random = new Random();
            const int size = 10000;
            MinHeap<double> heap = new MinHeap<double>(size);
            for (int i = 0; i < size; i++)
            {
                double number = 100*random.NextDouble();
                numbers.Add(number);
                heap.Insert(number);
            }
            numbers.Sort();
            foreach (double number in numbers)
            {
                Assert.AreEqual(heap.Pop(), number);
            }
        }

        [Test]
        public void PopEmpty()
        {
            MinHeap<int> heap = new MinHeap<int>(10);
            Assert.That(() => heap.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void PeekEmpty()
        {
            MinHeap<int> heap = new MinHeap<int>(10);
            Assert.That(() => heap.Peek(), Throws.InvalidOperationException);
        }
        
        // todo: peek non-empty
    }
}
