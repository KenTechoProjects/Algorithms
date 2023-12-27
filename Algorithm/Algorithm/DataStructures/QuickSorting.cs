using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
   public class QuickSorting<T>
    {
        public static T[] GenericQuickSort(T[] array)
        {
            Sort(0, array.Length - 1,array as int[]);
            return array;
        }
        public static void QuickSort(int[] array)
        {
            Sort(0, array.Length - 1,array);
        }
        private static void Sort(int low, int high,int[] array)
        {
            if (high <= low) return;
            int j = Partition(low, high,array);
            Sort(low, j - 1,array);
            Sort(j+1, high,array);
        }
        private static int Partition(int low, int high, int [] array)
        {
            int i = low;
            int j = high + 1;

            int pivot = array[low];
            while (true)
            {
                while (array[++i] < pivot)
                {
                    if (i == high) break;
                }
                while (pivot < array[--j])
                {
                    if (j == low) break;
                }
                if (i >= j) { break; }

                SwapObject.Swap(array, i, j);

            }
            SwapObject.Swap(array, low, j);
            return j;
        }
    }
}
