using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProblemSolving.DS.Trees
{
    public class BST
    {
        // DFS
        public void Inorder(TreeNode root) // left root right
        {
            if (root == null)
            {
                return;
            }

            Inorder(root.left);
            Console.WriteLine(root.val);
            Inorder(root.right);
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
