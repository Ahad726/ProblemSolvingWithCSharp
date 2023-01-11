using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.DS.LinkedList
{
    public class Node
    {
        internal int value;
        internal Node next;

        public Node(int value)
        {
            this.value = value;
        }

        public Node(int value, Node next)
        {
            this.value = value;
            this.next = next;
        }
    }
}
