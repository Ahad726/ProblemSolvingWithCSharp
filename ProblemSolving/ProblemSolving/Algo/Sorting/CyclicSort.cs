using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Sorting
{
    internal class CyclicSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };

            var sortedArray = Sort(arr);

            Console.WriteLine(String.Join(',', sortedArray));
        }

        static int[] Sort(int[] arr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                int correctIndex = arr[i] -1;
                if (arr[i] != arr[correctIndex])
                {
                    Swap(arr, i, correctIndex);

                }else
                {
                    i++;
                }
            }

            return arr;
        }

        private static void Swap(int[] arr, int first, int second)
        {
            int temp = arr[second];
            arr[second] = arr[first];
            arr[first] = temp;
        }
    }
}
