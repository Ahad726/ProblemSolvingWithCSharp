using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProblemSolving.DS.Trees
{
    public class BST
    {

        public void BFS(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                if (curr == null) continue;
                queue.Enqueue(curr.left);
                queue.Enqueue(curr.right);
                Console.WriteLine(curr.val);
            }

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
