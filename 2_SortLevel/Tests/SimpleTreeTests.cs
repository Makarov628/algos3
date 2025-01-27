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
        public void InsertionSortStep()
        {
            var array = new int[] { 7, 6, 5, 4, 3, 2, 1 };
            SortLevel.InsertionSortStep(array, 3, 0);
            CollectionAssert.AreEqual(new int[] { 1, 6, 5, 4, 3, 2, 7 }, array);

            SortLevel.InsertionSortStep(array, 3, 1);
            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 4, 6, 2, 7 }, array);

            SortLevel.InsertionSortStep(array, 3, 2);
            CollectionAssert.AreEqual(new int[] { 1, 3, 2, 4, 6, 5, 7 }, array);

            SortLevel.InsertionSortStep(array, 3, 3);
            CollectionAssert.AreEqual(new int[] { 1, 3, 2, 4, 6, 5, 7 }, array);
        }
    }
}
