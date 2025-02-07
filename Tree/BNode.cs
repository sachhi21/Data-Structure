using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public  class BNode
    {
       public int Data;
        public BNode Left, Right ;

        public BNode(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}
