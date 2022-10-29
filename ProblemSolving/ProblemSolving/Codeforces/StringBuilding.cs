using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codeforces
{
    internal class StringBuilding
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string str = Console.ReadLine();

                string ans = "NO";

                for (int j = 0; j < str.Length - 1; j++)
                {
                    if (j == 0 && str[j] != str[j+1])
                    {
                        break;
                    }
                    else if(j + 1 == str.Length -1 && str[j] != str[j + 1])
                    {
                        ans = "NO";
                        break;
                    }
                    else if ( j > 0 && str[j - 1] != str[j] && str[j] != str[j + 1])
                    {
                        ans = "NO";
                        break;
                    }
                    else
                    {
                        ans = "YES";
                    }

                }

                Console.WriteLine(ans);
            }
        }


    }
}
