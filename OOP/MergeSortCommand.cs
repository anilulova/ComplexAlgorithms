using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexSortingAlgorithm
{
    public class MergeSortCommand
    {
        public int[] Sort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }
        private void Merge(int[] array, int leftIndex, int midIndex, int rightIndex)
        {
            int[] leftArray = new int[midIndex - leftIndex + 1];
            int[] rightArray = new int[rightIndex - midIndex];

            Array.Copy(array, leftIndex, leftArray, 0, midIndex - leftIndex + 1);
            Array.Copy(array, midIndex + 1, rightArray, 0, rightIndex - midIndex);

            int i = 0;
            int j = 0;

            for (int k = leftIndex; k < rightIndex + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    array[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
            }
        }

        private int[] MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
            return array;
        }
    }

}