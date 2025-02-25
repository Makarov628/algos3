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
        public void MergeSort()
        {
            var array = new List<int> { 3, 5, 2, 4, 1 };
            var sortedArray = SortLevel.MergeSort(array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, sortedArray);
        }
    }
}
