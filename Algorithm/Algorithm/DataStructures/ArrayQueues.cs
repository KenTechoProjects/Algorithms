using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class ArrayQueues<T> : IEnumerable<T>
    {
        private T[] _queque;
        private int _head;
        private int _tail;
        public ArrayQueues()
        {
            const int defaultCapacity = 4;
            _queque = new T[defaultCapacity];
        }
        public ArrayQueues(int capacity)
        {

            _queque = new T[capacity];
        }
        public void Enqueue(T item)
        {
            if (_queque.Length == _tail)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_queque, largerArray, Count);
                _queque = largerArray;
            }
            _queque[_tail++] = item;
        }
        public void Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            _queque[_head++] = default(T);

            if (IsEmpty)
                _head = _tail = 0;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return _queque[_head];
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _head; i < _tail; i++)
            {
                yield return _queque[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public int Count => _tail - _head;
        public bool IsEmpty => Count == 0;
        public int Capacity { get; set; }
    }
}
