using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    public class LeetcodeSubset
    {
        static void Main(string[] args)
        {
            var arr = Subsets(new int[] { 1, 2, 3 });

            foreach (var item in arr)
            {
                Console.WriteLine("[" +string.Join(',', item) + "]");
                Console.WriteLine();
            }
        }

        public static IList<IList<int>> Subsets(int[] nums)
        {
            var outerList = new List<IList<int>>();
            outerList.Add(new List<int>());

            foreach (var num in nums)
            {
                var n = outerList.Count;
                for (int i = 0; i < n; i++)
                {
                    var innerList = new List<int>(outerList[i]);
                    innerList.Add(num);
                    outerList.Add(innerList);
                }
            }
            return outerList;
        }
    }
}
