using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class IsSameTrees
    {
        bool result = true;
        public bool IsSameTree(BNode p, BNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            if (p.Data != q.Data)
            {
                return false;
            }

           return  IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);




        }
    }
}
