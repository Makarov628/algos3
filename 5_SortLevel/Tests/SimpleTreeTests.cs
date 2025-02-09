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
        public void QuickSort()
        {
            var array = new int[] { 1, 6, 2, 5, 4, 3, 7 };
            SortLevel.QuickSort(array, 1, 5);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7 }, array);
        }
    }
}
