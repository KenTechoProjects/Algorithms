using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class ShellSorting
    {
        public static void ShellSortV2(int[] array)
        {
            int arrayLength = array.Length;
            int halfCountindex = arrayLength / 2;
            int count = 1;
            for (int startIndex = 0; startIndex < arrayLength; startIndex++)
            {
                halfCountindex = arrayLength / (count * 2);
                int nextIndex = halfCountindex;
                if (halfCountindex > 2)
                {
                    for (int i = 0; i < arrayLength; i++)
                    {
                        if (array[nextIndex - 1] < array[i])
                        {
                            SwapObject.Swap(array, i, nextIndex - 1);
                            nextIndex++;
                        }


                    }
                }
                else
                {
                    if (halfCountindex != 0)
                        Insertion.InsertionSort(array);
                }
                count++;
            }
        }

        public static void ShellSort(int[] array)
        {
            if (array != null)
            {


                int gap = 1;
                while (gap < array.Length / 3)
                {
                    gap = 3 * gap + 1;
                }
                while (gap >= 1)
                {
                    for (int i = gap; i < array.Length; i++)
                    {
                        for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                        {
                            SwapObject.Swap(array, j, j - gap);
                        }
                    }

                    gap /= 3;
                }
            }
        }
    }
}
