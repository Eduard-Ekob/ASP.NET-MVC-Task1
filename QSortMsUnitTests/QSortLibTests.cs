using Microsoft.VisualStudio.TestTools.UnitTesting;
using QSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QSort;

namespace QSort.Tests
{
    [TestClass]
    public class QSortLibTests
    {
        /// <summary>
        /// Test quick sorting by MS Test
        /// </summary>
        [TestMethod]
        public void QuickSortTest()
        {
            //Arrange                                    
            int sizeArr = 100000;
            int[] arr = new int[sizeArr];
            FeelArray(arr, sizeArr);
            
            //Act
            ArrayCustomSort.QuickSort(arr);
            
            //Assert
            Assert.IsTrue(VerifiArrayIsSorted(arr));

        }

        private void FeelArray(int[] arr, int sizeArr)
        {            
            Random rnd = new Random();
            for (int i = 0; i < sizeArr; i++)
            {
                arr[i] = rnd.Next(-1060, 10180);
            }            
        }

        private static bool VerifiArrayIsSorted(int[] arr)
        {
            bool expected = true;
            int sizeArr = arr.Length;
            for (int i = 0; i < sizeArr - 1; i++)
            {
                expected = (arr[i] <= arr[i + 1]);
                if (!expected) break;
            }
            return expected;
        }
    }
}