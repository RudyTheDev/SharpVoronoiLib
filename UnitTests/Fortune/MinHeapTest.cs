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
        public void Duplicate(
            [Values(new[] {1,2,3,4,5}, new[] {5,4,3,2,1}, new[] {3,4,1,5,2})] int[] input,
            [Values(1,2,3,4,5)] int d)
        {
            MinHeap<int> heap = new MinHeap<int>(6);
            for (int i = 0; i < 5; i++)
                heap.Insert(input[i]);
            
            bool result = heap.Insert(d);
            
            Assert.That(result, Is.False);
            for (int i = 0; i < 5; i++)
                Assert.That(heap.Pop(), Is.EqualTo(i + 1));
        }
    }
}
