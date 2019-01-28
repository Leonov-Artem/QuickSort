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
             * Swap()
             * RecursiveQuickSort()
             * Partition()
        */
        private T[] array;

        public QuickSort(T[] array) => this.array = array;

        private void Swap(int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
