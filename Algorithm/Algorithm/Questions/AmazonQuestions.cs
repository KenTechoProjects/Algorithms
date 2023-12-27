using Algorithm.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithm.Questions
{
    public class AmazonQuestions
    {
        private static void MergeSort(int[] array)
        {
            int[] aux = new int[array.Length];
            Sort(0, array.Length - 1);
            void Sort(int low, int high)
            {
                if (high <= low) return;
                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }
            void Merge(int low, int mid, int high)
            {
                if (array[mid] < array[mid + 1]) { return; }
                int i = low;
                int j = mid + 1;
                Array.Copy(array, low, aux, low, high - low + 1);
                for (int k = low; k <= high; k++)
                {
                    if (i > mid) { array[k] = aux[j++]; }
                    else if (j > high) { array[k] = aux[i++]; }
                    else if (aux[j] < aux[i]) { array[k] = aux[j++]; }
                    else { array[k] = aux[i++]; }
                }
            }
        }
        public static int FindTheMissingNumberInArrayOfTenNumber(int[] array)
        {
            MergeSort(array);
            Console.Write(string.Join(" ", array));
            int sequence = array[1] - array[0];
            for (int i = 1; i < array.Length; i++)
            {

                if (i != array.Length - 1)
                {
                    if (array[i] + sequence != array[i + 1])
                    {
                        return array[i] + sequence;
                    }
                }

            }
            return -1;
        }

        public static bool DetermineIfSumOfTwoNumberInAnArrayIsEqualToTheGivenNumber(int[] array, int target)
        {

            if (array.Length <= 0)
                return false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target) return true;
                }

            }

            return false;
        }
        public static bool DetermineIfSumOfTwoNumberInAnArrayIsEqualToTheGivenNumberV2(int[] array, int target)
        {
            if (array.Length <= 0)
                return false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Contains(target - array[i])) return true;

            }

            return false;
        }




        public static double LargestSumOfContiguousSubArray(int[] array)
        {
            double sum = 0;
            var lastNoneNegative = Array.FindLastIndex(array, p => p > 0);
            var firstNoneNegative = Array.FindIndex(array, p => p > 0);
            int count = 0;
            for (int i = firstNoneNegative; i <= lastNoneNegative; i++)
            {
                count = i + 1;
                if (count == 1)
                {
                    sum += array[i] + array[count];
                }
                else
                {
                    if ((count + 1) <= lastNoneNegative)
                    {
                        sum += array[count] + array[count + 1];
                    }

                }


            }
            return sum;
        }

        public static int TripCountForSameTwoOrThreePackWeight(int[] packs)
        {
            int count = 0;
            int length = packs.Length;
            if (length > 0)
            {

                if (length == 1)
                {
                    return 1;
                }

                var lst = QuickSorting<int>.GenericQuickSort(packs);
                var hsSet = new HashSet<int>();
                for (int i = 0; i < length; i++)
                {
                    if (i <= length - 3)
                    {

                        if (!hsSet.Contains(i))
                        {
                            if (lst[i].CompareTo(lst[i + 1]) == lst[i + 1].CompareTo(lst[i + 2]) == true)
                            {
                                hsSet.Add(i);
                                hsSet.Add(i + 1);
                                hsSet.Add(i + 2);

                                count++;
                            }
                            else if (lst[i].CompareTo(lst[i + 1]) == 0)
                            {
                                hsSet.Add(i);
                                hsSet.Add(i + 1);
                                count++;
                            }
                        }


                    }
                    else
                    {
                        if (!hsSet.Contains(i))
                        {
                            if (i <= length - 1)
                            {
                                if (i <= length - 2 && lst[i].CompareTo(lst[i + 1]) == 0)
                                {
                                    hsSet.Add(i);
                                    hsSet.Add(i + 1);
                                    count++;
                                }
                                else
                                {
                                    hsSet.Add(i);
                                    return -1;
                                }
                            }


                        }


                    }

                }


            }
            return count;

        }

        public static int GetMinimumClick(string text)
        {

            int textCount = text.Length;
            if (textCount == 0)
                return 0;
            if (textCount == 1)
            {
                return 1;
            }

            int totalButton = 9;
            int maxLetter = 3;

            int maxClick = 9 * 3;

            var sortedText = QuickSorting<char>.GenericQuickSort(text.ToArray());
            HashSet<char> setStoreage = new HashSet<char>();

            foreach (var item in sortedText)
            {
                if (!setStoreage.Contains(item))
                {


                }
            }

            return -1;
        }
    }
}
