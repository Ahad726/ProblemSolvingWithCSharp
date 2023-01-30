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

            //var result = ThreeSum(new int[] { 0,0,0,0 });

            
        }

       


        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            var tripletList = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                var fnmbr = nums[i];

                var left = i + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    var sum = fnmbr + nums[left] + nums[right];
                    if(fnmbr == left || sum < 0)
                    {
                        left++;
                        continue;
                    }
                    else if(sum > 0)
                    {
                        right--;
                    }
                    else
                    {
                        tripletList.Add(new List<int> { fnmbr, nums[left], nums[right] });
                        left++;

                        while (nums[left] == nums[left-1] && left < right)
                        {
                            left++;
                        }
                        
                    }
                }
            }

            return tripletList;
        }

        public static int[] TwoSum(int[] numbers, int target)
        {

            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                var sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    break;
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }

            }

            return new int[] { left + 1, right + 1 };


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
