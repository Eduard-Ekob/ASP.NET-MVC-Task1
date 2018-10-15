using System;
using NUnit.Framework;
using QSort;

//using QSort;

namespace QSortNUnitTests
{
    /// <summary>
    /// Test quick sorting by NUnit
    /// </summary>
    [TestFixture]
    public class QSortLibTests
    {
        const int SizeArr = 100000;
        [Test]
        public void QuickSortTest()
        {            
            int[] arr = new int[SizeArr];
            FeelArr(arr);
            ArrayCustomSort.QuickSort(arr);
            Assert.IsTrue(IsSorted(arr));
        }


        private void FeelArr(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < SizeArr; i++)
            {
                arr[i] = rnd.Next(-1060, 10180);
            }
        }

        private bool IsSorted(int[] arr)
        {
            bool expected=true;
            for (int i = 0; i < SizeArr - 1; i++)
            {
                expected = (arr[i] <= arr[i + 1]);
                if (!expected) break;
            }
            return expected;
        }
        


    }
}
