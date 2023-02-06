using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {

        }

        public static int FindMin(int[] nums)
        {
            int lastIndex = nums.Length - 1;
            int firstIndex = 0;


            if (nums[firstIndex] > nums[lastIndex])
            {
                for (int i = lastIndex; i > 0; i--)
                {
                    if (nums[i-1] > nums[i])
                    {
                        return nums[i];
                    }
                }
            }
            else
            {

            }
        }
    }
}
