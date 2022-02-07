using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Sorting
{
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };

            var sortedArray = Selection(arr);

            Console.WriteLine(String.Join(',', sortedArray));
        }

        static int[] Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int last = arr.Length - i - 1;
                int maxIndex = FindMax(arr, start: 0, last);
                Swap(arr, maxIndex, last);

            }
            return arr;
        }

        private static void Swap(int[] arr, int fisrt, int second)
        {
            int temp = arr[second];
            arr[second] = arr[fisrt];
            arr[fisrt] = temp;
        }

        private static int FindMax(int[] arr, int start, int end)
        {
            int max = start;
            for (int i = 0; i <= end; i++)
            {

                if (arr[i] > arr[max])
                {
                    max = i;
                }
            }

            return max;
        }
    }
}
