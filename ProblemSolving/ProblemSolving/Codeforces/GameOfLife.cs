using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class GameOfLife
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());          

            for (int k = 0; k < n; k++)
            {
                var line = Console.ReadLine().Split(' ');
                var arraySize = Convert.ToInt32(line[0]);
                var iteration = Convert.ToInt64(line[1]);

                var InitialArray = Console.ReadLine().ToCharArray();

                var resultArray = new char[arraySize];


                for (int j = 0; j < iteration; j++)
                {
                    resultArray = new char[arraySize];

                    for (int i = 0; i < InitialArray.Length; i++)
                    {
                        if (i == 0 && InitialArray[i + 1] == '1')
                        {
                            resultArray[i] = '1';
                        }
                        else if (InitialArray[i] == '0' && i-1 >= 0 && i < arraySize-1)
                        {
                            if (InitialArray[i - 1] ==  InitialArray[i + 1] )
                            {
                                resultArray[i] = '0';
                            }
                            else
                            {
                                resultArray[i] = '1';
                            }

                        }
                        else
                        {
                            resultArray[i] = InitialArray[i];
                        }
                    }

                    if (InitialArray[arraySize - 1] == '0')
                    {
                        if (InitialArray[arraySize - 2] == '1')
                        {
                            resultArray[arraySize - 1] = '1';
                        }
                        else
                        {
                            resultArray[arraySize - 1] = '0';
                        }
                    }

                    string initialArrayString = new string(InitialArray);
                    string resultArrayString = new string(resultArray);

                    if (initialArrayString == resultArrayString)
                    {
                        break;
                    }

                    InitialArray = resultArray;
                }


                Console.WriteLine(resultArray);
            }

        }
    }
}
