using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProblemSolving.DS.LinkedList
{
    public class LL
    {
        private Node head;
        private Node tail;
        private int size;
        public LL()
        {
            this.size = 0;
        }

        public void InsertAtFirst(int val)
        {
            var node = new Node(val);
            node.next = head;
            head = node;
            if (tail == null)
            {
                tail = head;
            }

            size += 1;
        }

        public void InsertAtLast(int val)
        {
            if (tail == null)
            {
                InsertAtFirst(val);
                return;
            }

            var node = new Node(val);
            tail.next = node;
            tail = node;
            size++;
        }

        public void InsertAtIndex(int val, int index)
        {
            if (index == 0)
            {
                InsertAtFirst(val);
            }
            else if (index == size)
            {
                InsertAtLast(val);
            }
            else
            {
                var temp = head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.next;
                }
                var node = new Node(val, temp.next);
                temp.next = node;
                size++;
            }
        }

        /// <summary>
        /// Delete the first item
        /// </summary>
        /// <returns>Returns the deleted item</returns>
        public int DeleteFirst()
        {
            var val = head.value;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            size--;
            return val;
        }

        public int DeleteLast()
        {
            if (size <= 1)
            {
                DeleteFirst();
            }

            var secondLast = Get(size - 2);
            tail = secondLast;
            tail.next = null;
            return tail.value;
        }

        public int Delete(int index)
        {
            if (index == 0)
            {
                DeleteFirst();
            }
            if (index == size - 1)
            {
                DeleteLast();
            }

            var pre = Get(index - 1);
            var val = pre.next.value;
            
            pre.next = pre.next.next;

            return val;

        }

        public Node Find(int value)
        {
            var node = head;
            while (node != null)
            {
                if (node.value == value)
                {
                    return node;
                }
                node = node.next;
            }
            return null;
        }

        private Node Get(int index)
        {
            var node = head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }



        public void Display()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.Write(tempNode.value + " -> ");
                tempNode = tempNode.next;
            }
            Console.Write("END");
            Console.WriteLine();
        }
    }
}
