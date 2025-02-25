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
        public void KthOrderStatisticsStep()
        {
            var array = new int[] { 3, 5, 2, 4, 1 };
            var stat = SortLevel.KthOrderStatisticsStep(array, 0, 4, 0);
            CollectionAssert.AreEqual(new int[] { 0, 3 }, stat);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, array);
        }
    }
}
