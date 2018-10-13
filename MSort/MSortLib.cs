using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSort
{
    /// <summary>
    /// This class for sorting array at merge sorting algorithm
    /// </summary>
    public static class MSortLib
    {
        private static int[] _incommArr;
        /// <summary>
        /// This method take incomming array. Transfer control to the
        /// recursive private method RecursiveCall for sorting.
        /// </summary>
        /// <param name="incomming">incomming array should be contains integer elements.
        /// It shouldn't have empty(null reference) array </param>
        public static void MergeSort(int[] incomming)
        {
            if (incomming == null)
            {
                throw new ArgumentNullException("Array is empty");
            }
            _incommArr = incomming;
            int firstPtr = 0;
            int lastPtr = _incommArr.Length-1;
            RecursiveCall(_incommArr, firstPtr, lastPtr);
        }

        private static void RecursiveCall(int[] incomming, int firstPtr, int lastPtr)
        {
            if (firstPtr < lastPtr)//если номер первого меньше последнего элемента
            {
                RecursiveCall(incomming, firstPtr, (firstPtr + lastPtr) / 2);//сортировка левой части
                RecursiveCall(incomming, (firstPtr + lastPtr) / 2 + 1, lastPtr);//сортировка правой части
                Merge(incomming, firstPtr, lastPtr);//слияние
            }
        }

        private static void Merge(int[] incomming, int firstPtr, int lastPtr)
        {
            //start, final – номера первых элементов левой и правой частей
            //intermed – массив, middle - хранит номер среднего элемента
            int middle = (firstPtr + lastPtr) / 2;//вычисление среднего элемента
            int start = firstPtr;//начало левой части
            int final = middle + 1;//начало правой части
            int[] intermed = new int[incomming.Length];
            for (int i = firstPtr; i <= lastPtr; i++)
            {
                if ((start <= middle) && ((final > lastPtr) || (incomming[start] < incomming[final])))
                {
                    intermed[i] = incomming[start];
                    start++;
                }
                else
                {
                    intermed[i] = incomming[final];
                    final++;
                }
            }
            for (int i = firstPtr; i <= lastPtr; i++)//возвращение результата в список
            {
                incomming[i] = intermed[i];
            }
        }
    }
}
