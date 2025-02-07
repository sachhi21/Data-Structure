using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TNode<T>
    {
        public T Value;
        public List<TNode<T>> Children;
        public TNode(T value)
        {
            Value = value;
            Children = new List<TNode<T>>();
        }

        public void insert(TNode<T> child)
        {
            Children.Add(child);
        }

        public void delete(TNode<T> child)
        {
            Children.Remove(child);
        }

        public void delete(int index)
        {
            Children.RemoveAt(index);
        }

    }

    public class Tree<T>
    {
        public TNode<T> Root;
        public Tree(T root)
        {
            Root = new TNode<T>(root);
        }
    }

}

