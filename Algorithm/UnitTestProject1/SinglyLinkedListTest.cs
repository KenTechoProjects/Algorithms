using System;
using Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Algorithm.DataStructures.LinkedListBlock;

namespace DataStructureUnitTest
{
    [TestClass]
    public class SinglyLinkedListTest
    {


        [TestMethod]
        public void CreateEmptyList_CorrectState()
        {
            var list = new SinglyLinkedList<int>();
            Assert.IsTrue(list.ISEmpty);
            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);

        }

        [TestMethod]
        public void AddFirst_and_AddLast_OneItem_CorrectState()
        {
            var list = new SinglyLinkedList<int>();
            list.AddFirst(1);
            CheckStateWithSingleNode(list);
            list.RemoveFirst();
            list.AddLast(1);

        }   [TestMethod]
        public void AddRemoveToGetToStartWithSigleNode_CorrectState()
        {
            var list = new SinglyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            //list.AddFirst(3);
            //list.AddFirst(4);
            list.RemoveFirst();
            CheckStateWithSingleNode(list);
            // list.AddFirst(5);
            list.AddFirst(2);
            list.RemoveLast();
            CheckStateWithSingleNode(list);
        }
        [TestMethod]
        public void RemoveFirst_ThrowException_CorrectState()
        {
            var list = new SinglyLinkedList<int>();
           // Assert.ThrowsException(() => list.RemoveFirst());
        }
        [TestMethod]
        public void RemoveLast_ThrowException_CorrectState()
        {
            var list = new SinglyLinkedList<int>();
             
        }
        private void CheckStateWithSingleNode(SinglyLinkedList<int> list)
        {
            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.ISEmpty);
            Assert.AreSame(list.Head, list.Tail);

        }
    }
}
