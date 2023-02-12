using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.DS.Trees
{
    public class BSTMain
    {
        static void Main(string[] args)
        {
            var bst = new BST();

            var root = bst.Insert(null, 6);
            bst.Insert(root,2);
            bst.Insert(root,8);
            bst.Insert(root,0);
            bst.Insert(root,4);
            bst.Insert(root,7);
            bst.Insert(root,9);
            bst.Insert(root,3);
            bst.Insert(root,5);

            root = bst.LowestCommonAncestor(root, new TreeNode(3),new TreeNode(5));
        }
    }
}
