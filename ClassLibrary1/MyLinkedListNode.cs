using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyLinkedListNode<T>
    {
        public T Value { get; set; }
        public MyLinkedListNode<T> Next { get; set; }
        public MyLinkedListNode<T> Prev { get; set; }
        public MyLinkedListNode(T value, MyLinkedListNode<T> next = null, MyLinkedListNode<T> prev = null)
        {
            Value = value;
            Next = next;
            Prev = prev;
        }
    }
}
