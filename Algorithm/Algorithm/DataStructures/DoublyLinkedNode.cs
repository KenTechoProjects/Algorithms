using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
   public class DoublyLinkedNode<T>
    {
        public DoublyLinkedNode<T> Next { get; internal set; }
        public DoublyLinkedNode<T> Previous { get; internal set; }
        public T Value { get; set; }
        public DoublyLinkedNode(T value)
        {
            Value = value;
        }
    }
   public class DoubleLinkedList<T>
    {
        public DoublyLinkedNode<T> Head { get; private set; }
        public DoublyLinkedNode<T> Tail { get; private set; }
        public T Value { get; set; }
        public DoubleLinkedList(T value)
        {
            Value = value;
        }
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

       public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedNode<T>(value));
        }

        private void AddFirst(DoublyLinkedNode<T> node)
        {
            //save off the Head
            DoublyLinkedNode<T> tmp = Head;
            //Point Head to node
            Head = node;
            //Insert the rest of the list after the Head
            Head.Next = tmp;
            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                // before :1(head)<--->5<->7 -> null
                //after : 3(head) <----->1 <->5 <-> 7 ->null
                tmp.Previous = Head;
            }
            Count++;

        }
        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedNode<T>(value));

        }

        private  void AddLast(DoublyLinkedNode<T> node)
        {

            if (IsEmpty)
                Head = node;           
            else
            {
                Tail.Next = node;
                node.Previous = Tail;               
            }
            Tail = node;
            Count++;
        }
        public void RemoveFirst()
        {
            if (IsEmpty)
                new InvalidOperationException();
            //shift Head
            Head = Head.Next;
            Count--;

            if (IsEmpty)
                Tail = null;
            else
                Head.Previous = null;

        }
        public void RemoveLast()
        { if (IsEmpty)
                new InvalidOperationException();
            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;//null the last node
                Tail = Tail.Previous;//Shift the Tail (Now it is the oenultimate node)
            }
            Count--;
        }

        #region Mine Testing
        public void AddF(T value)
        {
            AddF(new DoublyLinkedNode<T>(value));
            
        }

        private void AddF(DoublyLinkedNode<T> node)
        {
            DoublyLinkedNode<T> tmp = Head;
            Head = node; 
            Head.Next = tmp;
            if (IsEmpty)
                Tail = Head;
            else
                tmp.Previous = Head;

            Count++;
            
        }
        public void AddL(T value)
        {
            AddL(new DoublyLinkedNode<T>(value));
        }

        private void AddL(DoublyLinkedNode<T> node)
        {
            if (IsEmpty)
            {
                Head = node;                
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
            Tail = node;
            Count++;

        }

        #endregion Mine Testing
    }
}
