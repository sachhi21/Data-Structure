using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    

    public class PreOrderTraversal
    {
        public IList<int> PreorderTraversalOutput = new List<int>();



        public IList<int> PreorderTraversal(BNode root)
        {
            Preorder(root);
            return PreorderTraversalOutput;


        }

        private void Preorder(BNode root) {

            if (root == null)
            {
                return;
            }
            PreorderTraversalOutput.Add(root.Data);
            Preorder(root.Left);
            Preorder(root.Right);

        

        }
    }
}
