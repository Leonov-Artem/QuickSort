using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArray();
            Print(array);

            QuickSorting<int> sorting = new QuickSorting<int>(array);
            sorting.QuickSort();
            Print(array);

            Console.ReadKey();
        }
        static int[] GetArray()
        {
            Random random = new Random();
            int size = random.Next(10, 20);

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(-30, 30);

            return array;
        }
        static void Print(int[] array)
        {
            foreach (int num in array)
                Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}
