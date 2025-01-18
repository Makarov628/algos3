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
        public void SelectionSort()
        {
            var array = new int[] { 4, 3, 1, 2 };
            SortLevel.SelectionSortStep(array, 0);
            CollectionAssert.AreEqual(new int[] { 1, 3, 4, 2 }, array);

            SortLevel.SelectionSortStep(array, 1);
            CollectionAssert.AreEqual(new int[] { 1, 2, 4, 3 }, array);

            SortLevel.SelectionSortStep(array, 2);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, array);
        }

        [Test]
        public void BubbleSort()
        {
            var array = new int[] { 4, 3, 1, 2 };
            Assert.IsFalse(SortLevel.BubbleSortStep(array));
            CollectionAssert.AreEqual(new int[] { 3, 1, 2, 4 }, array);

            Assert.IsFalse(SortLevel.BubbleSortStep(array));
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, array);

            Assert.IsTrue(SortLevel.BubbleSortStep(array));
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, array);
        }

    }
}
