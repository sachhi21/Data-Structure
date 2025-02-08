using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class CountMinimumNodeLeaf
    {
        public int CountNodes(BNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.Left == null)
            {
                return 1 + CountNodes(root.Right);
            }


            if (root.Right == null)
            {
                return 1 + CountNodes(root.Left);
            }

            return 1 + Math.Min(CountNodes(root.Left), CountNodes(root.Right));

        }
    }
}
