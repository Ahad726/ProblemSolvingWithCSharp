using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class ScenesFromMemory
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {

                var size = Convert.ToInt32(Console.ReadLine());
                var nmbr = Console.ReadLine();

                if (nmbr.Contains('1'))
                {
                    Console.WriteLine(1);
                    Console.WriteLine(1);
                    continue;
                }

                var isFound = false;

                for (int i = 0; i < size; i++)
                {
                    var digit = Convert.ToInt32(nmbr[i].ToString());
                    if (IsComposite(digit))
                    {
                        Console.WriteLine(1);
                        Console.WriteLine(digit);
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    for (int i = 0; i < size-1; i++)
                    {
                        for (int j = i+1; j < size; j++)
                        {

                            var digit = Convert.ToInt32(nmbr[i].ToString() + nmbr[j].ToString());
                            if (IsComposite(digit))
                            {
                                Console.WriteLine(2);
                                Console.WriteLine(digit);
                                isFound = true;
                                break;
                            }
                        }
                        if (isFound)
                        {
                            break;
                        }
                    }
                }
            }
        }

        static bool IsComposite(int n)
        {
            for (int i = 2; i*i <= n; i++)
            {
                if (n % i == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
