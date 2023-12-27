using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithm.DataStructures.StackeADT;

namespace DataStructureUnitTest
{
    [TestClass]
  public  class StackArrayTest
    {
        [TestMethod]
        public void IsEmpty_EmptyStack_ReturnTrue()
        {
            var stack = new ArrayStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

  [TestMethod]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new ArrayStack<int>();
           
            stack.Push(1);         
            Assert.AreEqual(1,stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

    }
}
