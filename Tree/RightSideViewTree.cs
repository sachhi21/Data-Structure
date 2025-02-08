using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class RightSideViewTree
    {


        public IList<int> RightSideView(BNode root)
        {
            List<int> result = new List<int>();
            RightSideViewHelper(root, 0, result);
            return result;
        }

        private void RightSideViewHelper(BNode node, int level, List<int> result)
        {
            if (node == null)
            {
                return;
            }


            if (level == result.Count)
            {
                result.Add(node.Data);
            }

            RightSideViewHelper(node.Right, level + 1, result);
            RightSideViewHelper(node.Left, level + 1, result);
        }
    }
}
