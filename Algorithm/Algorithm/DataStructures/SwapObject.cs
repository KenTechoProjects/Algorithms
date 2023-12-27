using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
   public class SwapObject
    {
        public static void Swap(int[] array, int i, int j)
        {
            if (i == j||i==-1||j==-1) { return; }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
