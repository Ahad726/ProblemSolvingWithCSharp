using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codeforces
{
    class LongComparison
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var firstLine = Console.ReadLine().Split(' ');
                var numb1Str = firstLine[0];
                var num1Appnd = Convert.ToInt32(firstLine[1]);
                var secondLine = Console.ReadLine().Split(' ');
                var numb2Str = secondLine[0];
                var num2Appnd = Convert.ToInt32(secondLine[1]);

                var num1Length = numb1Str.Length + num1Appnd;
                var num2Length = numb2Str.Length + num2Appnd;



                if (num1Length == num2Length)
                {
                    var numbr1 = Convert.ToInt32(numb1Str);
                    var numbr2 = Convert.ToInt32(numb2Str);

                    if (numb1Str.Length > numb2Str.Length)
                    {
                        var multiple = 1;
                        for (int j = 0; j < numb1Str.Length - numb2Str.Length; j++)
                        {
                            multiple *= 10;
                        }
                        numbr2 *= multiple;
                    }
                    else
                    {
                        var multiple = 1;
                        for (int j = 0; j < numb2Str.Length - numb1Str.Length; j++)
                        {
                            multiple *= 10;
                        }
                        numbr1 *= multiple;
                    }

                    if (numbr1 < numbr2)
                    {
                        Console.WriteLine("<");
                    }
                    else if (numbr1 > numbr2)
                    {
                        Console.WriteLine(">");
                    }
                    else
                    {
                        Console.WriteLine("=");
                    }

                }
                else if (num1Length < num2Length)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    Console.WriteLine(">");
                }

            }
        }
    }
}
