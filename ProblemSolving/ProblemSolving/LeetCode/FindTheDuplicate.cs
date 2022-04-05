using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    //  https://leetcode.com/problems/find-the-duplicate-number/
    internal class FindTheDuplicate
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 1,3,4,2,2 };

            var duplicateNum = FindDuplicate(arr);

            Console.WriteLine(duplicateNum);
        }

        static int FindDuplicate(int[] arr)
        {
            int i = 0;
            int n = arr.Length-1;
            while (i <= n)
            {
                int correctIndex = arr[i] - 1;

                if (arr[i] != arr[correctIndex])
                {
                    Swap(arr, i, correctIndex);
                }
                else
                {
                    i++;
                }
            }

            return arr[n];

        }

        private static void Swap(int[] arr, int i, int correctIndex)
        {
            int temp = arr[i];
            arr[i] = arr[correctIndex];
            arr[correctIndex] = temp;
        }
    }
}
