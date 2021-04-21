using System;

namespace ProblemSolving
{
    class BoyOrGirl
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string distinctInput = string.Empty;            

            foreach (var item in input)
            {
                if (!distinctInput.Contains(item))
                {
                    distinctInput += item;
                }
            }

            int count = distinctInput.Length;

            if(count % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
}
