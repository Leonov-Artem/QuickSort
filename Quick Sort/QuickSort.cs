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
             * Median() 
             * RecursiveQuickSort()
             * Partition()
        */
        private T[] array;

        public QuickSort(T[] array) => this.array = array;

        private int Partition(int left, int right, int pivot)
        {
            int left_pointer = left;
            int right_poinert = right - 1;

            while (true)
            {
                // ищем максимальный элемент
                while (array[++left_pointer].CompareTo(pivot) < 0) ;
                // ищем минимальный элемент 
                while (array[--right_poinert].CompareTo(pivot) > 0) ;

                if (left_pointer >= right) break;
                else Swap(left_pointer, right_poinert);
            }

            Swap(left_pointer, right - 1);      // ставим опорный элемент на исходную позицию 
            return left_pointer;                // возврат позиции опорного элемента
        }
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
