using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class BinarSearching
    {
        public static int RecursiveBinaySearch(int[] array, int value)
        {
            return InternalRecursiveBinarySearch(0, array.Length);
            int InternalRecursiveBinarySearch(int low, int high)
            {
                if (low >= high)
                    return -1;

                int mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;
                if (array[mid] < value)
                    return InternalRecursiveBinarySearch(mid + 1, high);
                return InternalRecursiveBinarySearch(low, mid);
            }
        }
        public static int BinarySearch(int[] array, int value)
        {
            if (array.Length == 1)
                return value;

            int low = 0;
            int high = array.Length;
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;
                if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid;
            }
            return -1;
        }

        public static int BSearch(int[] array, int value)
        {
            int length = array.Length;
            MergeSorting.MergeSort(array);
          
            int mid = length / 2;
            if (array[mid] < value)
            {
                for (int i = mid+1; i < length; i++)
                {
                    if (array[i] == value)
                        return 1;

                }
            }
            else
            {
                for (int i =0; i < mid; i++)
                {
                    if (array[i] == value)
                        return 1;

                }

            }
            return -1;
        }

    }
}
