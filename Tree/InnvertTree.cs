using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class InnvertTree
    {

        public BNode InvertTree(BNode root)
        {
            if (root == null)
            {
                return null;
            }
            BNode rl = root.Left;
            root.Left = root.Right;
            root.Right = rl;

             InvertTree(root.Left);
             InvertTree(root.Right);
            return root;
        }   
    }
}
