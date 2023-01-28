using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class TwoPointer
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(IsPalindrome("0P"));


            //Console.WriteLine(MaxArea(new int[] { 2, 3, 4, 5, 18, 17, 6 }));

            var nmbr = TwoSum(new int[] { -1, -1, 1, 1, 1, 1 }, -2);
        }


        public static int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                int midVal = numbers[mid];

                if (midVal > target && start != mid)
                {
                    end = mid;
                }
                else
                {
                    break;
                }
            }

            int firstIndex = 0;
            int secondIndex = 0;

            var nmbrDic = new Dictionary<int, int>();

            for (int i = start; i <= end; i++)
            {
                nmbrDic[numbers[i]] = i;
            }

            for (int i = start; i < end; i++)
            {
                int rem = target - numbers[i];
                firstIndex = i;
                if (nmbrDic.ContainsKey(rem))
                {
                    secondIndex = nmbrDic[rem];
                    break;
                }
            }


            return new int[] {firstIndex+1,secondIndex+1};
        }


        public static int MaxArea(int[] height)
        {

            int maxArea = 0;

            var left = 0;
            var right = height.Length - 1;

            while (left < right)
            {
                var minHeight = height[left] < height[right] ? height[left] : height[right];
                var tempArea = minHeight * (right - left);

                maxArea = tempArea < maxArea ? maxArea : tempArea;

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
        public static bool IsPalindrome(string s)
        {

            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {


                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                    continue;
                }
                else if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return true;

        }
    }
}
