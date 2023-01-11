using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    public class Leetcode
    {
        static void Main(string[] args)
        {
            // LeetCode1863
                int[]  nums = { 5,1,6 };
                //Console.WriteLine(SubsetXORSum(nums));

            Subset(nums);
        }


        public static int SubsetXORSum(int[] nums)
        {
            int size = nums.Length;
            int total = 0;

            for (int mask = 0; mask < (1<<size); mask++)  // loop from 0th mask  to  (2^n - 1)th mask.
                                                          // each mask indicates one subset
            {
                // now for each mask, bitwise and (&) with the all elements of the array.
                // if result 1 then the number presents in the subset.
                
                int curTotal = 0;
                for (int j = 0; j < size; j++)
                {
                    if ((mask & (1<<j))> 0)  // 1 << j shows the 2^j index of the numbers of array
                    {
                        curTotal ^= nums[j];
                    }
                }
                total += curTotal;
            }

            return total;
        }

        /// <summary>
        /// Subset using bit mask
        /// </summary>
        /// <param name="nums"></param>
        static void Subset(int[] nums)
        {
            int size = nums.Length;

            var outerList = new List<List<int>>();

            for (int mask = 0; mask < (1<<size); mask++)
            {
                var internalList = new List<int>();
                for (int j = 0; j < size; j++)
                {
                    if ((mask & (1<<j))>0)
                    {
                        internalList.Add(nums[j]);
                    }
                }
                outerList.Add(internalList);
            }

            PrintListofList(outerList);
        }

        static void PrintListofList(List<List<int>> lists)
        {
            foreach (var list in lists)
            {
                var output = String.Join(',', list);
                Console.WriteLine(output);
            }
        }
    }
}
