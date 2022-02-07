using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Sorting
{
    internal class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };

            var sortedArray = Insertion(arr);

            Console.WriteLine(String.Join(',', sortedArray));

        }

        static int[] Insertion(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1 ; i++)
            {
                for (int j = i+1; j > 0; j--)
                {
                    if (arr[j] < arr[j-1])
                    {
                        Swap(arr, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr;
        }

        static void Swap(int[] arr, int first, int second)
        {
            int temp = arr[second];
            arr[second] = arr[first];
            arr[first] = temp;
        }
    }
}
