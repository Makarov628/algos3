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

        [Test]
        public void BinarySearch_found_in_large_array()
        {
            var array = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                array[i] = i + 1;
            }

            var binarySearch = new BinarySearch(array);
            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(500));
            Assert.That(binarySearch.Right, Is.EqualTo(999));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(750));
            Assert.That(binarySearch.Right, Is.EqualTo(999));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(875));
            Assert.That(binarySearch.Right, Is.EqualTo(999));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(938));
            Assert.That(binarySearch.Right, Is.EqualTo(999));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(969));
            Assert.That(binarySearch.Right, Is.EqualTo(999));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(985));
            Assert.That(binarySearch.Right, Is.EqualTo(999));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(993));
            Assert.That(binarySearch.Right, Is.EqualTo(999));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(0));
            Assert.That(binarySearch.Left, Is.EqualTo(993));
            Assert.That(binarySearch.Right, Is.EqualTo(995));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(1));
            Assert.That(binarySearch.Left, Is.EqualTo(993));
            Assert.That(binarySearch.Right, Is.EqualTo(995));

            binarySearch.Step(995);
            Assert.That(binarySearch.GetResult(), Is.EqualTo(1));
            Assert.That(binarySearch.Left, Is.EqualTo(993));
            Assert.That(binarySearch.Right, Is.EqualTo(995));
        }

        [Test]
        public void GallopingSearch_found_in_large_array()
        {
            var array = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                array[i] = i + 1;
            }

            Assert.That(BinarySearch.GallopingSearch(array, 1), Is.True);
            Assert.That(BinarySearch.GallopingSearch(array, 995), Is.True);
        }

        [Test]
        public void GallopingSearch_not_found_in_large_array()
        {
            var array = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                array[i] = i + 1;
            }

            Assert.That(BinarySearch.GallopingSearch(array, 0), Is.False);
            Assert.That(BinarySearch.GallopingSearch(array, 1001), Is.False);
        }
    }
}
