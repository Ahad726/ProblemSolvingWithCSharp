using ProblemSolving.DS.LinkedList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http.Headers;
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

        public ListNode Remove(int val)
        {
            var node = head;

            while (node != null)
            {
                if (head != null && head.val == val)
                {
                    head = head.next;
                }
                else if (node.next != null && node.next.val == val)
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


        // https://leetcode.com/problems/middle-of-the-linked-list/
        public ListNode ReturnMid()
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }

        public ListNode ReverseList()
        {
            var curr = head;
            ListNode pre = null;

            while (curr != null)
            {
                var nxt = curr.next;
                curr.next = pre;
                pre = curr;
                curr = nxt;
            }

            head = pre;
            return pre;
        }

        public void RecursiveReverseList(ListNode node)
        {
            if (node == tail)
            {
                head = tail;
                return;
            }

            RecursiveReverseList(node.next);
            tail.next = node;
            tail = node;
            tail.next = null;

        }


        public ListNode Merge(LinkedList l1, LinkedList l2)
        {
            var mergedList = MergeTwoLists(l1.head, l2.head);
            return mergedList;
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var newNode = new ListNode();

            var tempNode = newNode;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    tempNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tempNode.next = list2;
                    list2 = list2.next;
                }
                tempNode = tempNode.next;
            }

            if (list1 != null)
            {
                tempNode.next = list1;
            }
            else if (list2 != null)
            {
                tempNode.next = list2;
            }


            return newNode.next;
        }

        public void Reorder(LinkedList ll)
        {
            ReorderList(ll.head);
        }

        public void ReorderList(ListNode head)
        {
            var slow = head;
            var fast = head.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            var midNode = slow;
            ListNode pre = null;
            var curr = slow.next;

            while (curr != null)
            {
                var next = curr.next;
                curr.next = pre;
                pre = curr;
                curr = next;
            }

            // rearrange
            var hf = head;
            var hs = pre;

            while (hf != null && hs != null)
            {
                var temp = hf.next;
                hf.next = hs;
                hf = temp;
                temp = hs.next;
                hs.next = hf;
                hs = temp;
            }

            // set lastnode.next to null
            if (hf != null)
            {
                hf.next = null;
            }


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



