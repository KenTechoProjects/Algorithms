using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Heaping
    {
        public class MaxHeap<T> where T : IComparable<T>
        {
            private const int DefaultCapacity = 4;
            private T[] _heap;

            public int Count { get; private set; }

            public bool IsFull => Count == _heap.Length;
            public bool IsEmpty => Count == 0;
            public MaxHeap() : this(DefaultCapacity) { }
            public MaxHeap(int capacity)
            {
                _heap = new T[capacity];
            }
            public void Insert(T value)
            {
                if (IsFull)
                {
                    var newHeap = new T[_heap.Length * 2];
                    Array.Copy(_heap, 0, newHeap, 0, _heap.Length);
                    _heap = newHeap;
                }
                _heap[Count] = value;
                Swim(Count);
                Count++;
            }

            public T Peek()
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return _heap[0];
            }
            public T Remove()
            {
                return Remove(0);
            }

            private T Remove(int index)
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
            }

            private void Swim(int indexOfSwimmingItem)
            {
                T newValue = _heap[indexOfSwimmingItem];
                while (indexOfSwimmingItem > 0 && IsParentLess(indexOfSwimmingItem, newValue))
                {
                    _heap[indexOfSwimmingItem] = GetParent(indexOfSwimmingItem);
                    indexOfSwimmingItem = ParentIndex(indexOfSwimmingItem);
                }
                _heap[indexOfSwimmingItem] = newValue;
            }

            public IEnumerable<T> Values()
            {
                for (int i = 0; i < Count; i++)
                {
                    T item = _heap[i];
                    yield return item;
                }
            }
            private bool IsParentLess(int indexOfSwimmingItem, T newvalue)
            {
                return newvalue.CompareTo(GetParent(indexOfSwimmingItem)) > 0;
            }

            private T GetParent(int indexOfSwimmingItem)
            {
                return _heap[ParentIndex(indexOfSwimmingItem)];


            }

            private int ParentIndex(int index)
            {
                return (index - 1) / 2;
            }
            private int LeftChild(int index)
            {
                return (index * 2) + 1;
            }
            private int RightChild(int index)
            {
                return (index * 2) + 2;
            }
        }
    }
}
