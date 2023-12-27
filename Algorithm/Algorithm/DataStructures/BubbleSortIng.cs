using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    //In-place algorithm: it does not depend on the input size
    public class BubbleSortIng
    {


        public static void BubbleSort(int[] array)
        {
            int length = array.Length;
            for (int pathIndex = length - 1; pathIndex >0; pathIndex--)
            {
                for (int i = 0; i < pathIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        SwapObject.Swap(array, i, i + 1);
                    }
                }
            }
        }
        


      
       
    }
}
