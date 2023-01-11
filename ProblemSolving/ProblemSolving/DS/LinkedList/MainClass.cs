using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.DS.LinkedList
{
    internal class MainClass
    {
        static void Main(string[] args)
        {

            var linkedList = new LL();

            linkedList.InsertAtLast(1);
            linkedList.InsertAtFirst(3);
            linkedList.InsertAtFirst(2);
            linkedList.InsertAtFirst(5);
            linkedList.InsertAtFirst(9);
            linkedList.InsertAtIndex(100, 3);
            linkedList.Display();
            Console.WriteLine( linkedList.Find(5).value);
            linkedList.Display();

        }
    }
}
