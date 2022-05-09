using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassLibrary1
{
    public class CustomLinkedList<T> : IEnumerable<T>
    {       
        
        private MyLinkedListNode<T> head = null;
        private MyLinkedListNode<T> tail = null;
        private int count = 0;
        public void AddFirst(T elem)
        {
            MyLinkedListNode<T> newNode = new MyLinkedListNode<T>(elem,head,null);
            if (head == null)
            {                
                tail = newNode;
            }
            else 
            {
                head.Prev = newNode;                
            }
            head = newNode;
            count++;
        }
        public void AddLast(T elem)
        {
            MyLinkedListNode<T> newNode = new MyLinkedListNode<T>(elem, null, tail);
            if (tail == null)
            {                
                head = newNode;
            }
            else
            {
                tail.Next = newNode;                
            }
            tail = newNode;
            count++;
        }
        public IEnumerator<T> GetEnumerator()
        {
            MyLinkedListNode<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
