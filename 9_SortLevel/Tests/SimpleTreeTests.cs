using System;
using System.Collections.Generic;
using SortSpace;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SortLevelTests
    {
        [Test]
        public void HeapSort()
        {
            var array = new int[] { 1, 6, 2, 5, 4, 3, 7 };
            var heapSort = new HeapSort(array);

            Assert.That(heapSort.GetNextMax(), Is.EqualTo(7));
            Assert.That(heapSort.GetNextMax(), Is.EqualTo(6));
            Assert.That(heapSort.GetNextMax(), Is.EqualTo(5));
            Assert.That(heapSort.GetNextMax(), Is.EqualTo(4));
            Assert.That(heapSort.GetNextMax(), Is.EqualTo(3));
            Assert.That(heapSort.GetNextMax(), Is.EqualTo(2));
            Assert.That(heapSort.GetNextMax(), Is.EqualTo(1));
            Assert.That(heapSort.GetNextMax(), Is.EqualTo(-1));
        }
    }
}
