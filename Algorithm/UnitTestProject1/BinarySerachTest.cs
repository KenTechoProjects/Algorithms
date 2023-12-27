using Algorithm.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureUnitTest
{
    [TestClass]
   public class BinarySerachTest
    {
        [TestMethod]
        public void BinarySearch_SortedInput_RetursCorrectIntdex()
        {
            int[] input = new int[] { 0, 3, 4, 7, 34,45, 56, 67,68, 79 };
            Assert.AreEqual(2, BinarSearching.BinarySearch(input, 4));

        }
    }
}
