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
        const int SizeArr = 100000;
        [TestMethod]
        public void QuickSortTest()
        {
            //Arrange                        
            int[] arr = new int[SizeArr];
            Random rnd = new Random();
            for (int i = 0; i < SizeArr; i++)
            {
                arr[i] = rnd.Next(-1060, 10180);
            }
            bool expected = true;

            //Act
            QSortLib.QuickSort(arr);
            for (int i = 0; i < SizeArr - 1; i++)
            {
                expected = (arr[i] <= arr[i + 1]);
                if (!expected) break;
            }

            //Assert
            Assert.IsTrue(expected);
        }
    }
}