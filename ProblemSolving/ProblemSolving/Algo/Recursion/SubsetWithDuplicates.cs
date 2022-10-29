using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class SubsetWithDuplicates
    {
        static void Main(string[] args)     
        {
            int[] arr = { 1, 2, 2 };
            var list = SubsetDuplicate(arr);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(String.Join(',', list[i]));
            }

        }

        static List<List<int>> SubsetDuplicate(int[] arr)
        {
            Array.Sort(arr);
            List<List<int>> outerList = new List<List<int>>();

            outerList.Add(new List<int>());

            int start = 0;
            int end = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                start = 0;

                // if current element and previous element is same the s = e+1;
                if (i > 0 && arr[i] == arr[i - 1])
                {
                    start = end + 1;
                }
                end = outerList.Count - 1;


                // number of internal list is equal to the outerList size
                int n = outerList.Count;

                for (int j = start; j < n; j++)
                {
                    var internalList = new List<int>(outerList[j]); // copy ith outerlist member to this internal list
                    internalList.Add(arr[i]);
                    outerList.Add(internalList);
                }
            }
            return outerList;
        }
    }
}
