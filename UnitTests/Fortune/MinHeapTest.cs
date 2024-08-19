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
            Assert.That(heap.Pop(), Is.EqualTo(1));
            Assert.That(heap.Pop(), Is.EqualTo(2));
            Assert.That(heap.Pop(), Is.EqualTo(3));
            Assert.That(heap.Pop(), Is.EqualTo(4));
            Assert.That(heap.Pop(), Is.EqualTo(5));
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
                        Assert.That(heap.Pop(), Is.EqualTo(j));
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
                Assert.That(number, Is.EqualTo(heap.Pop()));
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
        
        [Test]
        public void Insert()
        {
            MinHeap<int> heap = new MinHeap<int>(1);
            
            bool result = heap.Insert(1);
            
            Assert.That(result, Is.True);
        }
        
        [Test]
        public void Duplicate([Values(1,2,3,4,5)] int d)
        {
            MinHeap<int> heap = new MinHeap<int>(6);
            heap.Insert(1);
            heap.Insert(2);
            heap.Insert(3);
            heap.Insert(4);
            heap.Insert(5);
            
            bool result = heap.Insert(d);
            
            Assert.That(result, Is.False);
        }
    }
}
