using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSort;

namespace MSort.Tests
{
    [TestClass()]
    public class MSortLibTests
    {
        const int SizeArr = 10000;
        [TestMethod()]
        public void MergeSortTest()
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
            MSortLib.MergeSort(arr);
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