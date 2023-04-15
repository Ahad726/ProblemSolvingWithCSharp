using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Text;

namespace ProblemSolving.DS.Trees
{
    public class BST
    {

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTreeHelper(0, 0, preorder.Length - 1, preorder, inorder);
        }

        private TreeNode BuildTreeHelper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 && inorder.Length == 0)
            {
                return null;
            }

            if (preStart > preorder.Length - 1 || inStart > inEnd)
            {
                return null;
            }

            var rootNode = new TreeNode(preorder[preStart]);
            var mid = Array.IndexOf(inorder, preorder[preStart]);

            rootNode.left = BuildTreeHelper(preStart + 1, inStart, mid - 1, preorder, inorder);
            rootNode.right = BuildTreeHelper(preStart + mid - inStart + 1, mid + 1, inEnd, preorder, inorder);
            return rootNode;
        }

        public int KthSmallest(TreeNode root, int k)
        {
            var n = 0;
            var cur = root;
            var stack = new Stack<TreeNode>();
            stack.Push(cur);

            while ( stack.Count > 0)
            {
                while (cur != null)
                {
                    cur = cur.left;
                    if (cur != null)
                        stack.Push(cur);
                }

                cur = stack.Pop();
                n++;

                if (n == k)
                {
                    break;
                }

                cur = cur.right;
                if (cur != null)
                {

                    stack.Push(cur);
                }


            }

            return cur.val;
        }

        public bool IsValidBST(TreeNode root)
        {

            if (root.left == null && root.right == null) return true;
            if (root.left == null || root.right == null)
            {
                if ((root.right?.val > root.val) || (root.left?.val < root.val))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            IsValidBST(root.left);
            IsValidBST(root.right);

            return IsValidBST(root.left) && IsValidBST(root.right) && (root.val > root.left.val && root.val < root.right.val);
        }

        public bool IsBST(int left, int right)
        {

            if (left > right) return true;
            else return false;
        }
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null)
                return root == subRoot;
            if (root.val == subRoot?.val && SameTree(root, subRoot))
                return true;

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        private bool SameTree(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null) return true;
            if (root != null && subRoot != null && root.val == subRoot.val)
            {
                return SameTree(root.left, subRoot.left) && SameTree(root.right, subRoot.right);
            }

            return false;
        }

        public void BFS(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                if (curr.left != null)
                    queue.Enqueue(curr.left);
                if (curr.right != null)
                    queue.Enqueue(curr.right);
                Console.WriteLine(curr.val);
            }

        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            var queue = new Queue<TreeNode>();
            var rootList = new List<IList<int>>();
            if (root == null) return rootList;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var currLevelCout = queue.Count;
                var currList = new List<int>();

                while (currLevelCout > 0)
                {
                    var curr = queue.Dequeue();
                    currList.Add(curr.val);
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                    currLevelCout--;
                }
                rootList.Add(currList);
            }
            return rootList;
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            if (p.val != q.val)
            {
                return false;
            }



            return (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));


        }


        /// <summary>
        ///Print -> left root right
        /// </summary>
        /// <param name="root"></param>
        // DFS
        public void Inorder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Inorder(root.left);
            Console.WriteLine(root.val);
            Inorder(root.right);
        }

        /// <summary>
        /// Root Left Right
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(TreeNode root)
        {
            if (root == null) { return; }

            Console.WriteLine(root.val);
            PreOrder(root.left);
            PreOrder(root.right);
        }

        /// <summary>
        /// Left Right Root
        /// </summary>
        /// <param name="root"></param>
        public void PostOrder(TreeNode root)
        {
            if (root == null)
                return;
            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine(root.val);
        }



        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) { return null; }

            var temp = root.left;
            root.left = root.right;
            root.right = temp;
            InvertTree(root.left);
            InvertTree(root.right);


            return root;
        }


        public int MaxDepth(TreeNode root)
        {
            return root == null ? 0 : 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }


        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var curr = root;
            while (curr != null)
            {
                if (p.val > curr.val && q.val > curr.val)
                {
                    curr = curr.right;
                }
                else if (p.val < curr.val && q.val < curr.val)
                {
                    curr = curr.left;
                }
                else
                {
                    break;
                }
            }

            return curr;
        }

        public TreeNode FindMinNode(TreeNode root)
        {
            var curr = root;

            while (curr != null && curr.left != null)
            {
                curr = curr.left;
            }

            return curr;
        }

        public TreeNode Remove(TreeNode root, int target)
        {
            if (root == null)
                return null;

            if (target > root.val)
                root.right = Remove(root.right, target);
            else if (target < root.val)
                root.left = Remove(root.left, target);
            else
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;
                else
                {
                    var minNode = FindMinNode(root.right);
                    root.val = minNode.val;
                    root.right = Remove(root.right, minNode.val);
                }
            }

            return root;

        }

        public TreeNode Insert(TreeNode root, int val)
        {
            if (root == null)
            {
                root = new TreeNode(val);
                return root;
            }

            if (val > root.val)
                root.right = Insert(root.right, val);
            else if (val < root.val)
                root.left = Insert(root.left, val);
            return root;

        }

        public bool Search(TreeNode root, int target)
        {
            if (root == null)
            {
                return false;
            }

            if (target > root.val)
            {
                return Search(root.right, target);
            }
            else if (target < root.val)
            {
                return Search(root.left, target);
            }
            else
            {
                return true;
            }
        }
    }
}
