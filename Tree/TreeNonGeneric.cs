using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TreeNonGeneric
    {
        public string Data;
        public List<TreeNonGeneric> Children;

        public TreeNonGeneric(string data)
        {
            Data = data;
            Children = new List<TreeNonGeneric>();
        }

        public void Addchild(TreeNonGeneric child)
        {
            Children.Add(child);
        }

    }

    public class TreeNon
    {
        public TreeNonGeneric Root;
        public TreeNon(string root)
        {
            Root =new TreeNonGeneric (root);
        }

        public void PrintTree(TreeNonGeneric node, string? indent = "")
        {
            if (node == null)
                return;
            Console.WriteLine(indent + node.Data);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "  ");
            }
        }
    }
}
