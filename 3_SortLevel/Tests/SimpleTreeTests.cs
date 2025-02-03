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

        [Test]
        public void KnuthSequence()
        {
            CollectionAssert.AreEqual(new List<int> { 1 }, SortLevel.KnuthSequence(1));
            CollectionAssert.AreEqual(new List<int> { 1 }, SortLevel.KnuthSequence(2));
            CollectionAssert.AreEqual(new List<int> { 1 }, SortLevel.KnuthSequence(3));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(4));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(5));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(6));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(7));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(8));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(9));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(10));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(11));
            CollectionAssert.AreEqual(new List<int> { 4, 1 }, SortLevel.KnuthSequence(12));
            CollectionAssert.AreEqual(new List<int> { 13, 4, 1 }, SortLevel.KnuthSequence(13));
            CollectionAssert.AreEqual(new List<int> { 13, 4, 1 }, SortLevel.KnuthSequence(14));
            CollectionAssert.AreEqual(new List<int> { 13, 4, 1 }, SortLevel.KnuthSequence(15));
            CollectionAssert.AreEqual(new List<int> { 13, 4, 1 }, SortLevel.KnuthSequence(16));
            CollectionAssert.AreEqual(new List<int> { 13, 4, 1 }, SortLevel.KnuthSequence(17));
            CollectionAssert.AreEqual(new List<int> { 13, 4, 1 }, SortLevel.KnuthSequence(18));
        }
    }
}
