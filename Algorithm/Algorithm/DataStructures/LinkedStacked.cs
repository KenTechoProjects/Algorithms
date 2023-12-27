using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithm.DataStructures.LinkedListBlock;

namespace Algorithm.DataStructures
{
    public class LinkedStacked<T> 
    {

        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();



        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return _list.Head.Value;

        }
        public void Push(T item)
        {
            _list.AddFirst(item);
        }
        public void Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            _list.RemoveFirst();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
         
        public int Count => _list.Count;
        public bool IsEmpty => Count == 0;
    }
}
