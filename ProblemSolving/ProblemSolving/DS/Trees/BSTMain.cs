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
            var root = bst.Insert(null, 4);
            bst.Insert(root, 3);
            bst.Insert(root,10);
            bst.Insert(root, 2);
            bst.Insert(root, 5);
            bst.Insert(root, 12);

            bst.BFS(root);


            //var res = bst.MaxDepth(root);
            //bst.Inorder(root);

            //bst.InvertTree(root);

            //Console.WriteLine();
            //bst.PreOrder(root);

            //Console.WriteLine();
            //bst.PostOrder(root);

        }
    }
}
