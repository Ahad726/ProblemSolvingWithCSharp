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

            var root = bst.Insert(null, 1);
            bst.Insert(root,2);
            //bst.Insert(root,15);
            //bst.Insert(root, 25);
            //bst.Insert(root, 40);


            //var res = bst.MaxDepth(root);
            bst.Inorder(root);

            bst.InvertTree(root);

            Console.WriteLine();
            bst.Inorder(root);
        }
    }
}
