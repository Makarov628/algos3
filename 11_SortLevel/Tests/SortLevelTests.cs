using NUnit.Framework;
using SortSpace;

namespace Tests
{
    [TestFixture]
    public class SortLevelTests
    {
        [Test]
        public void BinarySearch_found()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var binarySearch = new BinarySearch(array);
            binarySearch.Step(1);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(0));
            Assert.That(binarySearch.Right, Is.EqualTo(8));

            binarySearch.Step(1);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(0));
            Assert.That(binarySearch.Right, Is.EqualTo(3));

            binarySearch.Step(1);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(1));
            Assert.That(binarySearch.Left, Is.EqualTo(0));
            Assert.That(binarySearch.Right, Is.EqualTo(0));

            binarySearch.Step(1);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(1));
            Assert.That(binarySearch.Left, Is.EqualTo(0));
            Assert.That(binarySearch.Right, Is.EqualTo(0));

        }

        [Test]
        public void BinarySearch_not_found()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var binarySearch = new BinarySearch(array);
            binarySearch.Step(21);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(10));
            Assert.That(binarySearch.Right, Is.EqualTo(19));

            binarySearch.Step(21);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(15));
            Assert.That(binarySearch.Right, Is.EqualTo(19));

            binarySearch.Step(21);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(-1));
            Assert.That(binarySearch.Left, Is.EqualTo(18));
            Assert.That(binarySearch.Right, Is.EqualTo(19));

            binarySearch.Step(21);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(-1));
            Assert.That(binarySearch.Left, Is.EqualTo(18));
            Assert.That(binarySearch.Right, Is.EqualTo(19));

        }
    }
}
