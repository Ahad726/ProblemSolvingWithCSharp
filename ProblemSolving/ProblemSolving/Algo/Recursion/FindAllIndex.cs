using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class FindAllIndex
    {
       
        static void Main(string[] args)
        {
            int[] arr = { 1, 4,  5 };
            int target = 4;

            var resultList = FindAll(arr, target, 0);

            Console.WriteLine(string.Join(',',resultList));
        }


        static IList<int> FindAll(int[] arr, int target, int index)
        {
            IList<int> list = new List<int>();

            if (index == arr.Length)
            {
                return list;
            }

            if (arr[index] == target)
            {
                list.Add(index);
            }
            var listBelow = FindAll(arr, target, index + 1);

            return list;
        }
    }
}
