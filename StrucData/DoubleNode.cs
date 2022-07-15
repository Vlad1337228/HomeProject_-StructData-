using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrucData
{
    public class DoubleNode<T>
    {
        public DoubleNode(T data)
        {
            Data = data;
        }
        public T Data { get;   set; }
        public DoubleNode<T> Next { get; set; }
        public DoubleNode<T> Previous { get; set; }

    }
}
