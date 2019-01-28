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
             * RecursiveQuickSort()
        */
        private T[] array;

        public QuickSort(T[] array) => this.array = array;

        private T GetPivot(int left, int right)
        {
            // опорный элемент определяется как медиана по трем точкам
            int mid = (left + right) / 2;

            if (array[left].CompareTo(array[mid]) > 0)      Swap(left, mid);
            if (array[left].CompareTo(array[right]) > 0)    Swap(left, right);
            if (array[mid].CompareTo(array[right]) > 0)     Swap(mid, right);

            Swap(mid, right - 1);       // размещаем медиану на правом краю (чтобы ее не проверять в Partition)
            return array[right - 1];    // возвращаем медиану
        }
        private int Partition(int left, int right, int pivot)
        {
            int left_pointer = left;
            int right_pointer = right - 1;

            while (true)
            {
                // так как опорный элемент определялся как медиана по трем точкам,
                // то нет необходимости добавлять доп. проверки выхода за границы для left_pointer и right_pointer,
                // так как left и right заведомо стоят на верный позициях

                // ищем максимальный элемент
                while (array[++left_pointer].CompareTo(pivot) < 0) ;
                // ищем минимальный элемент 
                while (array[--right_pointer].CompareTo(pivot) > 0) ;

                if (left_pointer >= right_pointer) break;
                else Swap(left_pointer, right_pointer);
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
