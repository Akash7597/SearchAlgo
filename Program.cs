using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    internal class Program
    {
        class Node
        {
            public Node Left {get;set;}
            public Node Right {get;set;}
            public int Data {get;set;}
        }
        class BinarySearchTree
        {
            public static Boolean Contains(Node root,int item)
            {
                if(root==null)
                {
                    return false;
                }
                else if(item < root.Data)
                {
                    return Contains(root.Left,item);
                }
                else if(item>root.Data)
                {
                    return Contains(root.Right,item);
                }
                else
                {
                    return true;
                }
            }
            public static Node Insert(Node root, int item)
            {
                if (root==null)
                {
                    root=new Node();
                    root.Data= item;
                }
                else if(item<root.Data)
                {
                    root.Left=Insert(root.Left,item);
                }
                else if (item>root.Data)
                {
                    root.Right = Insert(root.Right,item);
                }
                return root;
            }
        }
        static void Main(string[] args)
        {

            Node rootNode = new Node();
            rootNode.Data = 4;
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 4));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 3));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 6));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 7));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 2));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 0));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, -3));
            Console.WriteLine(BinarySearchTree.Contains(null, 4));

        }
    }
}
