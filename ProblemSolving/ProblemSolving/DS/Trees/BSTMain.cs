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

            var root = bst.Insert(null, 20);
            bst.Insert(root,30);
            bst.Insert(root,15);
            bst.Insert(root,16);
            bst.Insert(root,17);
           

            var res = bst.MaxDepth(root);
        }
    }
}
