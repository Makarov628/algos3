using NUnit.Framework;
using SortSpace;

namespace Tests
{
    [TestFixture]
    public class SortLevelTests
    {
        [Test]
        public void BinarySearch()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var binarySearch = new BinarySearch(array);
            binarySearch.Step(1);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));

            binarySearch.Step(1);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));

            binarySearch.Step(1);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(1));

        }
    }
}
