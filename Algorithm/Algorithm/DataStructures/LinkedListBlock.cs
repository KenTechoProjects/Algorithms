using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class LinkedListBlock
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
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
        public class NodeImplementation
        {
            public static void Implement()
            {
                Node first = new Node() { Value = 5 };
                Node Second = new Node() { Value = 1 };
                first.Next = Second;
                Node third = new Node() { Value = 3 };
                Second.Next = third;
                PrintOutLinkedNode(first);
            }
            private static void PrintOutLinkedNode(Node node)
            {
                while (node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                }
            }


        }
        public class SinglyLinkedList<T>:IEnumerable<T>
        {
            public Node<T> Head { get; private set; }
            public Node<T> Tail { get; private set; }
            public int Count { get; private set; }
            public void AddFirst(T value)
            {
                AddFirst(new Node<T>(value));

            }
            public void AddFirst(Node<T> node)
            {//save off current head
                Node<T> temp = Head;
                Head = node;
                //shifting the former head
                Head.Next = temp;

                Count++;

                if (Count == 1)
                {
                    Tail = Head;
                }
                Console.WriteLine($"Head:{Head.Value}, Next:{Tail.Next}");
            }
            public void AddLast(T value)
            {
                AddFirst(new Node<T>(value));
            }

            private void AddLast(Node<T> node)
            {
                if (ISEmpty)
                Head = node; 
                else
                Tail.Next = node; 

                Tail = node;
                Count++;

            }
            public   bool ISEmpty => Count == 0;

            public   void RemoveFirst()
            {
                if (ISEmpty) throw new InvalidOperationException();

                Head = Head.Next;
                if (Count == 1)
                    Tail = null;

                Count--;
            }
            public void RemoveLast()
            {
                if (ISEmpty) throw new InvalidOperationException();

                if(Count==1)
                Head = Tail=null;
                else 
                { 
                    //find penultimate node
                    var current = Head;
                    while(current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }           

                Count--;
            }

            public IEnumerator<T> GetEnumerator()
            {
                Node<T> currrent = Head;
                while(currrent != null)
                {
                    yield return currrent.Value;
                    currrent = currrent.Next;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
