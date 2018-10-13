using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QSort
{   /// <summary>
    /// QSortLib class for sorting array at quick sorting algorithm.
    /// </summary>
    public static class QSortLib
    {
        private static int[] _incommArr;
        private static Random rnd;
        /// <summary>
        /// "QuickSort" method  take incomming array. Transfer control to the
        /// recursive private method "DivArr for" sorting.
        /// </summary>
        /// <param name="incomm"> Is incomming array should be contains integer elements.
        /// It shouldn't have empty(null reference) array </param>
        public static void QuickSort(int[] incomm)
        {            
            if (incomm == null)
            {
                throw new ArgumentNullException("Array is empty");
            }
            _incommArr = incomm;
            int firstPtr = 0;
            int lastPtr = _incommArr.Length - 1;
            rnd = new Random();
            DivArr(firstPtr, lastPtr);
        }
        private static void DivArr(int firstPtr, int lastPtr)
        {
            var f = firstPtr;
            var l = lastPtr;
            int temp;            
            int _support = _incommArr[rnd.Next(f, l)];
            do
            {
                while (_incommArr[f] < _support)
                    f++;
                while (_incommArr[l] >_support)
                    l--;
                if (f <= l)
                {
                    temp = _incommArr[f];
                    _incommArr[f] = _incommArr[l];
                    _incommArr[l] = temp;
                    f++;
                    l--;
                }
            } while (f < l);
            if (firstPtr < l)
                DivArr(firstPtr, l);
            if (f < lastPtr)
                DivArr(f, lastPtr);

        }
    }
}
