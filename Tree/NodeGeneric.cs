using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class NodeGeneric<T>
    {
        public T Data;
        public NodeGeneric<T> Next;

        public NodeGeneric(T data)
        {
            Data = data;
            Next = null;
        }

    }
}
