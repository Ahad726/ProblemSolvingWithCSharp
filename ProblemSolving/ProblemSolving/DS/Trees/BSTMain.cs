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
            //bst.Insert(root,3);
            bst.Insert(root,6);
            //bst.Insert(root, 25);
            //bst.Insert(root, 40);

            var bst2 = new BST();
            var root2 = bst2.Insert(null, 4);
            //bst2.Insert(root2, 3);
            bst2.Insert(root2, 5);


            Console.WriteLine(bst.IsSameTree(root, root2));
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
