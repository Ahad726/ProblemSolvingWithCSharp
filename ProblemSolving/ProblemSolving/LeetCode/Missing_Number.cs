using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class Missing_Number
    {
        // https://leetcode.com/problems/missing-number/
        static void Main(string[] args)
        {
            int[] arr = {0, 1 };

            var missingNumber = MissingNumber(arr);

            Console.WriteLine(missingNumber);
        }

        static int MissingNumber(int[] arr)
        {
            int n = arr.Length;
            int i = 0;

            while (i < n)
            {
                int correctIndex = arr[i];
                if (correctIndex == n)
                {
                    i++;
                }
                else if(arr[i] != arr[correctIndex])
                {

                    Swap(arr, i, correctIndex);
                }
                else
                {
                    i++;
                }
            }

            for (int j = 0; j < n; j++)
            {
                if( j != arr[j])
                {
                    return j;
                }
            }
            return n;
        }

        private static void Swap(int[] arr, int i, int correctIndex)
        {
            int temp = arr[i];
            arr[i] = arr[correctIndex];
            arr[correctIndex] = temp;
        }
    }
}
