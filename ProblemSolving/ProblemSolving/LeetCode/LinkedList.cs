using ProblemSolving.DS.LinkedList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProblemSolving.LeetCode
{
    public class LinkedList
    {
        private ListNode head;
        private ListNode tail;
        private int size;

        public class ListNode
        {
            internal int val;
            internal ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public void InsertAtFirst(int val)
        {
            var node = new ListNode(val);
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

            var node = new ListNode(val);
            tail.next = node;
            tail = node;
            size++;
        }

        public ListNode DeleteDuplicates()
        {
            var node = head;
            while (node.next != null)
            {
                if (node.val == node.next.val)
                {
                    node.next = node.next.next;
                }
                else
                {

                    node = node.next;
                }
            }
            return node;
        }


        public ListNode MergeList(LinkedList list1, LinkedList list2)
        {
            var result = Merge(list1.head, list2.head);
            return result;
        }

        public ListNode Merge(ListNode first, ListNode second)
        {

            var ansLL = new LinkedList();

            while (first != null && second != null)
            {
                if (first.val < second.val)
                {
                    ansLL.InsertAtLast(first.val);
                    first = first.next;
                }
                else
                {
                    ansLL.InsertAtLast(second.val);
                    second = second.next;
                }
            }


            while (second != null)
            {
                ansLL.InsertAtLast(second.val);
                second = second.next;
            }


            while (first != null)
            {
                ansLL.InsertAtLast(first.val);
                first = first.next;
            }


            return ansLL.head;
        }



        /// <summary>
        /// https://leetcode.com/problems/linked-list-cycle/
        /// </summary>
        public bool HasCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    return true;
                }
            }
            return false;
        }

        public int LengthOfCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    var count = 0;

                    do
                    {
                        slow = slow.next;
                        count++;
                    } while (fast != slow);

                    return count;
                }
            }
            return 0;
        }


        /// <summary>
        /// https://leetcode.com/problems/linked-list-cycle-ii/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DetectCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            bool HasCycle = false;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    HasCycle = true;
                    break;
                }
            }

            if (!HasCycle)
            {
                return null;
            }

            fast = head;

            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;

            }

            return fast;
        }


        // https://leetcode.com/problems/happy-number/description/
        public bool IsHappy(int n)
        {
            var fast = n;
            var slow = n;

            do
            {
                slow = FindSquare(slow);
                fast = FindSquare(FindSquare(fast));
            } while (slow != fast);

            if (slow == 1)
            {
                return true;
            }

            return false;
        }


        private static int FindSquare(int num)
        {
            var ans = 0;

            while (num > 0)
            {
                var rem = num % 10;

                ans += rem * rem;
                num /= 10;
            }

            return ans;
        }


        //https://leetcode.com/problems/remove-linked-list-elements/description/

        public ListNode Remove( int val)
        {
            var node = head;

            while (node != null)
            {
                if (head != null && head.val == val)
                {
                    head = head.next;
                }
                else if(node.next != null && node.next.val == val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }

            }

            return head;
        }

        public void Display()
        {
            ListNode tempNode = head;

            while (tempNode != null)
            {
                Console.Write(tempNode.val + " -> ");
                tempNode = tempNode.next;
            }
            Console.Write("END");
            Console.WriteLine();
        }

    }


}



