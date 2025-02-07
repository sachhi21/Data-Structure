using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class CountNodesTree
    {
        int count = 0;
        public int CountNodes(BNode root)
        {
            CountNode(root);
            return count;
        }

        private void CountNode(BNode root)
        {
            if (root == null)
            {
                return;
            }
            CountNode(root.Left);
            CountNode(root.Right);
            count += 1;

        }
    }
}
