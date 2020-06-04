using System;
using System.Collections.Generic;

namespace ComplexSortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 20, 15, 101, -8, 0, 12, 7 };

            var mergeSort = new MergeSortCommand();
            var arrayToSort = mergeSort.Sort(array);

            foreach (var item in arrayToSort)
            {
                Console.Write(item + " "); //-8 0 7 12 15 20 101
            }

            Console.WriteLine();


            List<int> unsortedList = new List<int>{12,15,0,-8,154,5 };

            unsortedList.Sort();

            foreach (var item in unsortedList)
            {
                Console.Write(item + " "); //-8 0 5 12 15 154
            }

            Console.WriteLine();

            int[] arr = { 8, 6, 0, 4, 10, 1 };

            var heapSort = new HeapSortCommand();
            var arrToSort = heapSort.SortArray(arr);

            foreach(var item in arrToSort)
            {
                Console.Write(item + " "); //0 1 4 6 8 10
            }
        }
    }
}
