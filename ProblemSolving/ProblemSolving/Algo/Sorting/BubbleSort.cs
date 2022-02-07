using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Sorting
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5,4,3,2,1};

            var sortedArray = Bubble(arr);

            Console.WriteLine(String.Join(',', sortedArray));
        }

        static int[] Bubble(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                bool isSwapped = false;

                // for each step max item will come at the last respective index
                for (int j = 1; j < arr.Length - i; j++)
                {
                    // swap if item is smaller than the previous item
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        isSwapped = true;
                    }
                }

                if (!isSwapped)  // if no swapped , means array is already sorted. Hence break.
                {
                    break;
                }
            }

            return arr;
        }
    }
}
