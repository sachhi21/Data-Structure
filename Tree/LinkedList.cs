using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class LinkedList
    {

        private Node head;

        public void add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;

                }
                current.Next = node;
            }
        }
            
        
        public void display()
            {
            Node current = head;

            while (current == null) { Console.WriteLine("Empty"); return; }

            while (current != null)
            {
                Console.WriteLine(current.Value.ToString());
                current = current.Next;
            }
            Console.WriteLine("null");

        }

        public void addatnode(int data , int position)
        {
            Node node = new Node(data);

            if(position == 1)
            {
                node.Next = head;
                head = node;
                return;
            }
            Node current = head;
            int currentPosition = 1;

            while(current.Next != null && currentPosition < position - 1)
            {
                current = current.Next;
                currentPosition++;
            }
            if(current == null)
            {
                return;
            }

            node.Next = current.Next;
            current.Next = node;
            
        }


        

    }
}
