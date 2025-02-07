using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class LinkedListGeneric<T>
    {
        private NodeGeneric<T> head;

        public void Add(T data)
        {
            NodeGeneric<T> nodeGeneric = new Tree.NodeGeneric<T>(data);

            if (head == null)
            {
                head = nodeGeneric;
            }
            else
            {
                NodeGeneric<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                    
                }

                current.Next = nodeGeneric;
            }
           
         }

        public void display()
        {
            NodeGeneric<T> current = head;
          if(current == null)
            {
                Console.WriteLine("Empty ");

            }
          while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void AddAtPosition(T data,int position)
        {
            NodeGeneric<T> curr = head;
            NodeGeneric<T> node = new NodeGeneric<T> (data);
            if(position == 1)
            {
                curr = node;
                curr.Next = null;
                head = curr;
            }
            int currentposition = 1;


            while (curr.Next != null && currentposition < position - 1)
            {
                curr = curr.Next;
                currentposition++;
            }

            node.Next = curr.Next;
            curr.Next = node;

        }

        public void Search(T data)
        {
             NodeGeneric<T> curr  = head;

            if(curr == null)
            {
                Console.WriteLine("The LinkedList is Empty");
                return;
            }
            while(curr != null)
            {
                if (curr.Data.Equals(data))
                {
                    Console.WriteLine("Found" + data);
                    return;
                }
                curr = curr.Next;   
            }
        }

        public int LengthofLinkedList()
        {
            NodeGeneric<T> curr = head;
            int length = 0;

            if(curr == null)
            {
                return 0;
            }
            while (curr.Next != null)
            {

                length++;
                curr = curr.Next;
            }

            return length;




        }

        //public void Sort()
        //{
        //    head = MergeSort(head);
        //}

        //private NodeGeneric<T> MergeSort(NodeGeneric<T> node)
        //{
        //    // Base case: if the list is empty or has one element, it is already sorted
        //    if (node == null || node.Next == null)
        //    {
        //        return node;
        //    }

        //    // Step 1: Split the list into two halves
        //    NodeGeneric<T> middle = GetMiddle(node);
        //    NodeGeneric<T> nextToMiddle = middle.Next;

        //    // Break the list into two parts
        //    middle.Next = null;

        //    // Step 2: Recursively sort both halves
        //    NodeGeneric<T> left = MergeSort(node);
        //    NodeGeneric<T> right = MergeSort(nextToMiddle);

        //    // Step 3: Merge the sorted halves
        //    //return Merge(left, right);
        //}

        //private NodeGeneric<T> GetMiddle(NodeGeneric<T> node)
        //{
        //    if (node == null)
        //    {
        //        return node;
        //    }

        //    NodeGeneric<T> slow = node;
        //    NodeGeneric<T> fast = node;

        //    // Use the slow and fast pointer approach to find the middle
        //    while (fast.Next != null && fast.Next.Next != null)
        //    {
        //        slow = slow.Next;
        //        fast = fast.Next.Next;
        //    }

        //    return slow;
        //}

        //private NodeGeneric<T> Merge<T>(NodeGeneric<T> left, NodeGeneric<T> right) where T : IComparable<T>
        //{
        //    // Base cases for merging
        //    if (left == null)
        //        return right;
        //    if (right == null)
        //        return left;

        //    NodeGeneric<T> result;

        //    // Compare and merge nodes
        //    if (left.Data.CompareTo(right.Data) <= 0)
        //    {
        //        result = left;
        //        result.Next = Merge(left.Next, right);
        //    }
        //    else
        //    {
        //        result = right;
        //        result.Next = Merge(left, right.Next);
        //    }

        //    return result;
        //}


    }
}
