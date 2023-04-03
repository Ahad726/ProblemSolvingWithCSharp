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
            var root = bst.Insert(null, 3);
            bst.Insert(root, 1);
            bst.Insert(root,2);
            bst.Insert(root,4);
            

            var result = bst.KthSmallest(root, 4);
            //var list = bst.LevelOrder(root);


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
