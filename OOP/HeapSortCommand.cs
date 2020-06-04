using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexSortingAlgorithm
{
    public class HeapSortCommand
    {
        public int[] SortArray(int[] arrayToSort)
        {
            return Sort(arrayToSort);
        }
        private int[] Sort (int[] array)
        {
            var lenght = array.Length;

            for(int i = lenght / 2 - 1; i >= 0; i--)
            {
                Heapify(array, lenght, i);
            }
            for(int i = lenght - 1; i >= 0; i--)
            {
                Swap(array, 0, i);
                Heapify(array, i, 0);
            }
            return array;
        }

        private void Heapify(int[] array, int lenght, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if(left < lenght && array[left] > array[largest])
            {
                largest = left;
            }
            if(right < lenght && array[right] > array[largest])
            {
                largest = right;
            }
            if(largest != i)
            {
                Swap(array, i, largest);
                Heapify(array, lenght, largest);
            }
        }

        private void Swap(int[] array, int indexOne, int indexTwo)
        {
            var temp = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = temp;
        }
    }
}
