using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Arrays
    {
        public static void TestArray()
        {
            Array arr = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            // Array arr =new  int[4];
            for (int i = 1; i < 4; i++)
            {
                arr.SetValue(i + 1, i);
                Console.WriteLine($"{arr.GetValue(i)}");
            }
        }
        public static void MultiDimentionalArray()
        {
            int[,] arr2 = new int[4, 3] { { 16, 28, 39 }, { 24, 520, 6 }, { 72, 81, 90 }, { 908, 114, 124 } };

            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < arr2.GetLength(0); ++i)
            {
                for (int j = 0; j < arr2.GetLength(1); ++j)
                {
                    if (arr2[i, j] % 3 == 0 && arr2[i, j] % 2 == 0)
                        hs.Add(arr2[i, j]);

                }
            }
            var lst = hs.OrderBy(h => h).ToList();

            Console.WriteLine(string.Join(" ", lst));
        }
        public static void MultiDimentionalArrayV2()
        {
            int[,] arr2 = new int[2, 3] { { 16, 28, 39 }, { 24, 520, 6 } };

            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < arr2.GetLength(0); ++i)
            {
                for (int j = 0; j < arr2.GetLength(1); ++j)
                {

                    hs.Add(arr2[i, j]);

                }
            }
            var lst = hs.OrderBy(h => h).ToList();

            Console.WriteLine(string.Join(" ", lst));
        }

        public static void JaggedArray()
        {
            int[][] arr3 = new int[4][];
            arr3[0] = new int[1];
            arr3[1] = new int[3];
            arr3[2] = new int[2];
            arr3[3] = new int[4];
            Console.WriteLine("Enter the number for a jagged array");
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    string st = Console.ReadLine();

                    arr3[i][j] = int.Parse(st);

                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("Print Jagged Array ");
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.Write(arr3[i][j]);
                    Console.Write("\0");
                }
                Console.WriteLine("");
            }

        }

        public static unsafe void MemoryAlocationIterateOver(int[] array)
        {
            fixed (int* b = array)
            {
                int* p = b;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(*p);
                    p++;
                }
            }
        }
        public static void TimeComplecity(object[] array)
        {
            //Example of Running Time Complexity
            int length = array.Length;
            //accessed by index O(1)
            Console.WriteLine(array[0]);

            //search for an element O(N)
            object elemtnToFinf = new object();
            for (int i = 0; i < length; i++)
            {
                if (array[i] == elemtnToFinf)
                {
                    Console.WriteLine("Exists/Find");
                }
            }
            //add to a full array
            var bigArray = new int[length * 2];
            Array.Copy(array,0, bigArray,0, length); //Or  Array.Copy(array, bigArray, length)
            bigArray[length + 1] = 10;

            //add to the end when there is some space O(1)
            array[length - 1] = 10;

            //Remove elemt of known index O(1)
            array[6]=null;
        }

        public static void RemoveAt(object [] array ,int index)
        {
            int length = array.Length;
            var newArray = new object[length-1];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index+1, newArray, index,length-1- index);
        }
    }
}
