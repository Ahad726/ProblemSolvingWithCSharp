using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Bitwise_Operator
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsOdd(13));

            //int[] arr = { 2, 3, 4, 1, 2, 1, 3, 6, 4 };
            //Console.WriteLine(FindUnique(arr));

            //FindIthBit(20,3);

            //SetBit(20, 4);
            //ResetBit(20, 3);

            //FindRightSetBit(32);

            //MagicNumber(5, 5);

            //SumOfrow(6);

            // Console.WriteLine(IsPowerOf2(30));
            //Setbits(20);

            //var ans = XOR(9);
            //Console.WriteLine(ans);

            //var ans = RangeXOR(3, 9);
            //Console.WriteLine(ans);

            int[] arr = { 2, 2, 2, 3, 7, 7, 8, 7, 8, 8 };
            FindNumberAppearingOne(arr, 3);
        }

        // Every number is appearing Odd times (n times), only one number is appearing 1 time. Find the number
        static void FindNumberAppearingOne(int[] arr, int n)
        {
            var setBitArray = new int[16];

            for (int i = 0; i < arr.Length; i++)
            {
                var bitArray = Convert.ToString(arr[i], 2).ToCharArray();
                Array.Reverse(bitArray);


                for (int j = 0; j < bitArray.Length; j++)
                {
                    if (bitArray[j] == '1')
                    {
                        setBitArray[j]++;
                    }
                }
            }

            var remainderBitString = string.Empty;

            for (int i = 0; i < setBitArray.Length; i++)
            {
                remainderBitString += setBitArray[i] % n;
            }

            int extraNum = BinaryStringToInt(remainderBitString);

            Console.WriteLine(extraNum);
        }

        /// <summary>
        /// Convert a Binary String To Int value
        /// </summary>
        /// <param name="str">binary string</param>
        /// <returns>int value equivalent to binary</returns>
        static int BinaryStringToInt(string str)
        {
            int b = 1; // base
            int ans = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    ans += b;
                }
                b *= 2;
            }

            return ans;
        }
       
        // Find XOR in Range a to b
        static int RangeXOR(int a, int b)
        {
            var xor0toa = XOR(a - 1);
            var xor1tob = XOR(b);

            return xor0toa ^ xor1tob;
        }

        // Find XOR of number 0 to a
        static int XOR(int a)
        {
            if (a % 4 == 0)
            {
                return a;
            }
            else if (a % 4 == 1)
            {
                return 1;
            }
            else if (a % 4 == 2)
            {
                return a + 1;
            }
            return 0;
        }

        //Find the number of set bits
        static void Setbits(int n)
        {
            Console.WriteLine($"{n} in Binary : " + Convert.ToString(n, 2));
            int count = 0;
            while (n > 0)
            {
                n = n & (n - 1);
                count++;
            }
            Console.WriteLine("Set bits = " + count);
        }

        // Find if a number is power of 2
        static bool IsPowerOf2(int n)
        {
            // 10000 = 1111 + 1 
            return (n & (n - 1)) == 0;
        }

        // Pascals triangle sum of the nth row
        //1
        //1 1
        //1 2 1
        //1 3 3 1
        //1 4 6 4 1
        //1 5 10 10 5 1

        static void SumOfrow(int n)
        {
            Console.WriteLine(1 << (n - 1));
        }

        //Find the kth magic number
        static void MagicNumber(int n, int b)
        {
            int ans = 0;
            int startb = b;
            while (n > 0)
            {
                int lastdigit = n & 1;
                ans += lastdigit * b;
                n = n >> 1;
                b = b * startb;
            }

            Console.WriteLine(ans);
        }


        // Find the position of the right most set bit
        static void FindRightSetBit(int n)
        {
            Console.WriteLine($"{n} in Binary : " + Convert.ToString(n, 2));

            var val = n & (-n);

            int position = 1;

            while (val > 0)
            {

                if (val == 1)
                {
                    break;
                }
                val = val >> 1;
                position++;


            }

            Console.WriteLine(position);

        }

        // Reset kth bit
        static void ResetBit(int n, int k)
        {
            Console.WriteLine($"{n} in Binary : " + Convert.ToString(n, 2));

            var mask = 1 << (k - 1);
            var CompMask = ~mask;

            var restedBit = n & CompMask;
            Console.WriteLine("Reset bits : " + Convert.ToString(restedBit, 2));

            Console.WriteLine();
        }

        // Set kth bit
        static void SetBit(int n, int k)
        {
            Console.WriteLine($"{n} in Binary : " + Convert.ToString(n, 2));

            var mask = 1 << (k - 1);

            var numWithSetBit = n | mask;
            Console.WriteLine("Set bits : " + Convert.ToString(numWithSetBit, 2));
        }

        // Find ith bit of a number
        static void FindIthBit(int n, int i)
        {
            Console.WriteLine($"{n} in Binary : " + Convert.ToString(n, 2));

            var mask = 1 << (i - 1);
            var ithBit = n & mask;

            Console.WriteLine(i + "th Bit : " + (ithBit >> (i - 1)));
        }


        // Find if a number is even or odd
        static bool IsOdd(int n)
        {
            return (n & 1) == 1;
        }


        // Find the number appearing only once
        static int FindUnique(int[] vs)
        {
            int unique = 0;
            foreach (var digt in vs)
            {
                unique ^= digt;
            }
            return unique;
        }


    }
}
