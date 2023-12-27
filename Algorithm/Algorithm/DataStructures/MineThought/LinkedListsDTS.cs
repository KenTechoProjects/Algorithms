using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures.MineThought
{
    public class LinkedListsDTS
    {
        public class SinglyLinkedList<T> : IEnumerable<T>
        {
            public Node<T> Head { get; private set; }
            public Node<T> Tail { get; private set; }
            public int Count { get; set; }
            public bool IsEmpty => Count == 0;

            public void AddFirst(T value)
            {
                AddFirst(new Node<T>(value));
            }

            public IEnumerator<T> GetEnumerator()
            {
                Node<T> current = Head;
                while (current != null)
                {
                    yield return current.Value;
                    current = current.Next;
                }

            }

            private void AddFirst(Node<T> node)
            {
                Node<T> temp = Head;
                Head = node;
                Head.Next = temp;

                Count++;
                if (Count == 1)
                {
                    Tail = Head;
                }

            }
            public void AddLast(T value)
            {
                AddLast(new Node<T>(value));
            }
            private void AddLast(Node<T> node)
            {

                if (IsEmpty)
                    Head = node;
                else
                    Tail.Next = node;

                Tail = node;
                Count++;





            }
            IEnumerator IEnumerable.GetEnumerator()
            {

                return GetEnumerator();
            }

            public void RemoveFirst()
            {
                if (IsEmpty)
                    throw new InvalidOperationException();

                Head = Head.Next;
                if (Count == 1)
                {
                    Tail = null;
                }
                Count--;
            }

            public void RemoveLast()
            {
                if (IsEmpty)
                    throw new InvalidOperationException();


                if (Count == 1)
                {
                    Head = Tail = null;
                }
                var current = Head;
                Node<T> penultimate;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                penultimate = current;
                current.Next = null;

                Tail = penultimate;

                Count--;

            }

        }
    }
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            Value = value;
        }
    }
}
