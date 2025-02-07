using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{

    public class InOrderTraversal
    {

        public IList<int> inorder = new List<int>();

        public IList<int> InOrderTraversals(BNode root)
        {


            OnOrder(root);
            return inorder;
        }


        private void OnOrder(BNode node)
        {
            if (node == null)
            {
                return;
            }
            OnOrder(node.Left);
            inorder.Add(node.Data);
            OnOrder(node.Right);


        }

    }
}
