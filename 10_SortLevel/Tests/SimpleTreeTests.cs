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
        public void KSortIndex()
        {
            var ksort = new KSort();
            Assert.That(ksort.Index("a00"), Is.EqualTo(0));
            Assert.That(ksort.Index("a01"), Is.EqualTo(1));
            Assert.That(ksort.Index("a99"), Is.EqualTo(99));
            Assert.That(ksort.Index("b00"), Is.EqualTo(100));
            Assert.That(ksort.Index("b01"), Is.EqualTo(101));
            Assert.That(ksort.Index("b99"), Is.EqualTo(199));
            Assert.That(ksort.Index("h00"), Is.EqualTo(700));
            Assert.That(ksort.Index("h01"), Is.EqualTo(701));
            Assert.That(ksort.Index("h99"), Is.EqualTo(799));
            Assert.That(ksort.Index("i00"), Is.EqualTo(-1));
            Assert.That(ksort.Index("a0000") , Is.EqualTo(-1));
        }
    }
}
