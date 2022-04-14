using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Sorting
{
    internal class MergeSort
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 8, 3, 4, 12, 5, 6 };
            int[] arr = { 8, 3, 4 ,12,5,6,7};
            var sortedArray = Sort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(',', sortedArray));

        }
        static int[] Sort(int[] arr, int l, int r)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int mid = l + (r - l) / 2;

            int leftSize = mid - l + 1;
            int rightSize = arr.Length - leftSize;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            Array.Copy(arr, 0, leftArray, 0, leftSize);
            Array.Copy(arr, mid + 1, rightArray, 0, rightSize);

            leftArray = Sort(leftArray, 0, leftArray.Length - 1);
            rightArray = Sort(rightArray, 0, rightArray.Length - 1);

            return Merge(leftArray, rightArray);
        }

        private static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int[] mixArray = new int[leftArray.Length + rightArray.Length];

            int i = 0;      // index marking for left array
            int j = 0;      // index marking for right array
            int k = 0;      // index marking for mix array

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] < rightArray[j])
                {
                    mixArray[k] = leftArray[i];
                    i++;
                }
                else
                {
                    mixArray[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            // it is possible that one of the array has more element . hence it has not been completed traversing

            // if left array is not complete
            if (i < leftArray.Length)
            {
                while (i < leftArray.Length)
                {
                    mixArray[k] = leftArray[i];
                    i++;
                    k++;
                }
            }

            // if right array is not complete
            if (j < rightArray.Length)
            {
                while (j < rightArray.Length)
                {
                    mixArray[k] = rightArray[j];
                    j++;
                    k++;
                }
            }

            return mixArray;
        }
    }
}
