using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class Subsets
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            var list = DoSubset(arr);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(String.Join(',', list[i]));
            }


        }

        static List<List<int>> DoSubset(int[] arr)
        {
            List<List<int>> outerList = new List<List<int>>();

            outerList.Add(new List<int>());


            foreach (var num in arr)
            {
                // number of internal list is equal to the outerList size
                int n = outerList.Count;
                for (int i = 0; i < n; i++)
                {
                    var internalList = new List<int>(outerList[i]); // copy ith outerlist member to this internal list
                    internalList.Add(num);
                    outerList.Add(internalList);
                }
            }


            return outerList;
        }
    }
}
