using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexSortingAlgorithm
{
    public class QuickSortCommand
    {
        public int[] Sort(int[] collectionToSort)
        {
           return QuickSort(collectionToSort, 0, collectionToSort.Length - 1);
        }


        private int Partition(int[] collection, int startIndex, int lastIndex)
        {
            int nextSmallestItemIndex = startIndex;
            var pivot = collection[lastIndex];

            for(int currentIndex = startIndex; currentIndex < lastIndex; currentIndex++)
            {
                if(collection[currentIndex] < pivot)
                {
                    Swap(collection, nextSmallestItemIndex, currentIndex);
                    nextSmallestItemIndex++;
                }
            }
            Swap(collection, nextSmallestItemIndex, lastIndex);
            return nextSmallestItemIndex;
        }

        private int[] QuickSort(int[] collectionToSort, int startIndex, int lastIndex)
        {
            var pivotIndex = Partition(collectionToSort, startIndex, lastIndex);

            if (startIndex != pivotIndex)
                QuickSort(collectionToSort, startIndex, pivotIndex - 1);

            if (lastIndex != pivotIndex)
                QuickSort(collectionToSort, pivotIndex + 1, lastIndex);

            return collectionToSort;
        }

        private void Swap(int[] array, int indexOne, int indexTwo)
        {
            var temp = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = temp;
        }
    }
}
