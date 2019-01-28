using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class QuickSort<T> where T : IComparable
    {
        /*
             * InsertionSort()
             * RecursiveQuickSort()
             * Partition()
        */
        private T[] array;

        public QuickSort(T[] array) => this.array = array;

        private void InsertionSort(int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                T temp = array[i];
                int inner = i;

                while (inner > left && array[inner-1].CompareTo(temp) >= 0)
                {
                    array[inner] = array[inner - 1];
                    inner--;
                }
                array[inner] = temp;
            }
        }
        private void Swap(int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
