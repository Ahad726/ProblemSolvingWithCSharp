using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class AB_Balance
    {
        static void Main(string[] args)
        {
            var testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {

                var str = Console.ReadLine().ToCharArray();

                int abCount = 0;
                int baCount = 0;

                for (int j = 0; j < str.Length - 1; j++)
                {
                    string subStr = $"{str[j]}{str[j + 1]}";

                    if (subStr == "ab")
                    {
                        abCount++;
                    }
                    else if (subStr == "ba")
                    {
                        baCount++;
                    }
                }



                if (abCount != baCount)
                {
                    var dif = abCount > baCount ? abCount - baCount : baCount - abCount;

                    for (int j = 0; j < dif; j++)
                    {
                        if (abCount > baCount)
                        {
                            if (str[j] == 'a')
                            {
                                str[j] = 'b';
                            }
                        }
                        else
                        {
                            if (str[j] == 'b')
                            {
                                str[j] = 'a';
                            }
                        }

                    }
                }

                Console.WriteLine(new String(str));
            }
        }
    }
}
