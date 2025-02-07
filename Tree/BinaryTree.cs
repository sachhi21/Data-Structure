using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinaryTree
    {
        public BNode Root;

        public BinaryTree() {

            Root = null;
        }

        public BNode Insert(BNode root, int value)
        {

            if (root == null)
            {
                root = new BNode(value);
                return root;
            }
            else if (value < root.Data)
            {
                root.Left = Insert(root.Left, value);
            }
            else 
            {
                root.Right = Insert(root.Right, value);
            }
            return root;



        }

        public void InorderTraversal(BNode root, int space)
        {
            if(root == null)
            {
                return ;
            }
            space += 5;
            InorderTraversal(root.Left, space);
            //for (int i =5; i< space; i++)          
            //    Console.WriteLine(" ");
            Console.WriteLine(root.Data );
            InorderTraversal(root.Right, space);

        }

        public void PreOrderTraversal(BNode root, int space)
        {
            if (root == null)
            {
                return;
            }
            space += 5;
            Console.WriteLine(root.Data + " ");

            PreOrderTraversal(root.Left, space);
            //for (int i =5; i< space; i++)          
            //    Console.WriteLine(" ");
            PreOrderTraversal(root.Right, space);

        }


        public void PostTraversal(BNode root, int space)
        {
            if (root == null)
            {
                return;
            }
            space += 5;

            PostTraversal(root.Left, space);
            //for (int i =5; i< space; i++)          
            //    Console.WriteLine(" ");
            PostTraversal(root.Right, space);
            Console.WriteLine(root.Data + " ");


        }

        public void LevelOrderTransveral (BNode node)
        {
            if(node == null)
            {
                return;
            }

            Queue<BNode> queuebfs = new Queue<BNode>();
            queuebfs.Enqueue(node);

            BNode current = null;

            while (queuebfs.Any())
            {
                current = queuebfs.Peek();
                Console.WriteLine(current.Data);
                if (current.Left != null)
                    queuebfs.Enqueue(current.Left);
                if (current.Right != null)
                    queuebfs.Enqueue(current.Right);

                queuebfs.Dequeue();
            }
        }








    }
}
