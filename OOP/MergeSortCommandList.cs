using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexSortingAlgorithm
{
    public class MergeSortCommandList
    {
        public List<int> Sort(List<int> unsortedList)
        {
            return MergeSort(unsortedList);
        }
        private List<int> Merge(List<int> leftList, List<int> rightList)
        {
            List<int> resultList = new List<int>();

            while(leftList.Count > 0 || rightList.Count > 0)
            {
                if(leftList.Count > 0 && rightList.Count > 0)
                {
                    if(leftList.First() <= rightList.First()) 
                    {
                        resultList.Add(leftList.First());
                        leftList.Remove(leftList.First());
                    }
                    else
                    {
                        resultList.Add(rightList.First());
                        rightList.Remove(rightList.First());
                    }
                }
                else if(leftList.Count > 0)
                {
                    resultList.Add(leftList.First());
                    leftList.Remove(leftList.First());
                }
                else if(rightList.Count > 0)
                {
                    rightList.Add(rightList.First());
                    rightList.Remove(rightList.First());
                }
            }
            return resultList;
        }
       

        private List<int> MergeSort(List<int> unsortedList)
        {
            if(unsortedList.Count <= 1)
            {
                return unsortedList;
            }

            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            int midPoint = unsortedList.Count / 2;

            for(int i = 0; i < midPoint; i++)
            {
                leftList.Add(unsortedList[i]);
            }

            for(int i = midPoint; i < unsortedList.Count; i++)
            {
                rightList.Add(unsortedList[i]);
            }

            leftList = MergeSort(leftList);
            rightList = MergeSort(rightList);

            return Merge(leftList, rightList);
        }
    }
}
