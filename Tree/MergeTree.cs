using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class MergeTree
    {
        public BNode MergeTrees(BNode root1, BNode root2)
        {
            // Base cases
            if (root1 == null) return root2; // If root1 is null, use root2
            if (root2 == null) return root1; // If root2 is null, use root1

            // Merge the current nodes
            root1.Data += root2.Data;

            // Recursively merge left and right subtrees
            root1.Left = MergeTrees(root1.Left, root2.Left);
            root1.Right = MergeTrees(root1.Right, root2.Right);

            return root1; // Return the merged tree
        }
    }
}
