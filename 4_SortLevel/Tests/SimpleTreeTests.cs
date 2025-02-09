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
        public void ArrayChunk()
        {
            var array = new int[] { 7, 5, 6, 4, 3, 1, 2 };
            Assert.That(SortLevel.ArrayChunk(array), Is.EqualTo(3));
            CollectionAssert.AreEqual(new int[] { 2, 1, 3, 4, 6, 5, 7 }, array);
        }
    }
}
