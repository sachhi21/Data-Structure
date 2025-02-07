using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class LowestCommonAncestors
    {
        public BNode LowestCommonAncestor(BNode root, BNode p, BNode q)
        {
            while (root != null)
            {
                // If both p and q are smaller than root, LCA is in the left subtree
                if (p.Data < root.Data && q.Data < root.Data)
                {
                    root = root.Left;
                }
                // If both p and q are larger than root, LCA is in the right subtree
                else if (p.Data > root.Data && q.Data > root.Data)
                {
                    root = root.Right;
                }
                // If one is on the left and the other is on the right, root is the LCA
                else
                {
                    return root;
                }
            }
            return null; // Should never be reached if p and q are guaranteed to exist in the tree
        }
    }
}
