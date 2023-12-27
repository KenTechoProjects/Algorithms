using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class SelectionSorting
    {
        public static void SelectionSort(int[] array)
        {
            int length = array.Length;
            for (int pathIndex = length - 1; pathIndex > 0; pathIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= pathIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                SwapObject.Swap(array, largestAt, pathIndex);
            }
        }


    }
}
