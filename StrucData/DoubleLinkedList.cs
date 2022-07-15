using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrucData
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        public DoubleNode<T> head;
        public DoubleNode<T> tail;
        public int Count { get; private set; }

        public void Add(T item)
        {
            DoubleNode<T> node = new DoubleNode<T>(item);
            if (head==null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            Count++;
        }

        public bool Remove(T item)
        {
            DoubleNode<T> node = new DoubleNode<T>(item);
            var current = head;
            while (current != null)
            {
                if(current.Data.Equals(node.Data))
                {
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    Count--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }






        public IEnumerator<T> GetEnumerator()
        {
            DoubleNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
