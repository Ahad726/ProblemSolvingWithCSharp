using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class BeautifulYear
    {
        // seperate every digit and add in a list if the digit already not exist. Then if the year string length and list count match
        // we find the year and break the loop.
        static void Main(string[] args)
        {
            var year = Convert.ToInt32(Console.ReadLine())+1;

           
            string yearString;
            int tempYear;
            while (year <= 10000)
            {
                var digitList = new List<int>();
                tempYear = year;
                yearString = year.ToString();
                while (tempYear > 0)
                {
                    int digit = tempYear % 10;
                    tempYear /= 10;

                    if (!digitList.Contains(digit))
                    {
                        digitList.Add(digit);
                    }
                }

                if (yearString.Length == digitList.Count)
                {
                    Console.WriteLine(yearString);
                    break;
                }
                year++;
            }
          

        }
    }
}
