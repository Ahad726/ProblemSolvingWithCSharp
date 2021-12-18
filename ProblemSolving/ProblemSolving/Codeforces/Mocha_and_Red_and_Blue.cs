using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class Mocha_and_Red_and_Blue
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var size = Convert.ToInt32(Console.ReadLine());

                var squareArray = Console.ReadLine().ToCharArray();

                var emptyCount = 0;

                char nonEmptyValue = char.MinValue;
                for (int i = 0; i < size; i++)
                {
                    if (squareArray[i] == 'B' || squareArray[i] == 'R')
                    {
                        nonEmptyValue = squareArray[i];
                        break;
                    }
                    else
                    {
                        emptyCount++;
                    }
                }

                char foundChar;
                char otherChar;

                if (nonEmptyValue == 'B')
                {
                    foundChar = 'B';
                    otherChar = 'R';
                }
                else
                {
                    foundChar = 'R';
                    otherChar = 'B';

                }


                if (squareArray[0] == '?')
                {
                    squareArray[0] = emptyCount % 2 == 0 ? foundChar : otherChar;
                }
               
                for (int i = 1; i < size; i++)
                {
                    if (squareArray[i] == '?' && squareArray[i - 1] == foundChar)
                    {

                        squareArray[i] = otherChar;
                    }
                    else if (squareArray[i] == '?' && squareArray[i - 1] == otherChar)
                    {

                        squareArray[i] = foundChar;
                    }
                }
                

                var strResult = new String(squareArray);
                Console.WriteLine(strResult);


            }
        }
    }
}
