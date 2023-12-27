using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class TestObject
    {
        public class TestBubble
        {
            public static void RunTestForSortAlgorithm(Action<int[]> sort, int[][] jagged)
            {
                foreach (var item in jagged)
                {
                    sort(item);
                    item.OrderBy(p => p);
                    Console.WriteLine(string.Join(" ", item));

                }

            }


        }
        public class TestSelection
        {
            public static void RunTestForSortAlgorithm(Action<int[]> sort, int[][] jagged)
            {
                foreach (var item in jagged)
                {
                    sort(item);
                    item.OrderBy(p => p);
                    Console.WriteLine(string.Join(" ", item));

                }

            }
        }
        public class TestInsertion
        {
            public static void RunTestForSortAlgorithm(Action<int[]> sort, int[][] jagged)
            {
                foreach (var item in jagged)
                {
                    sort(item);
                    item.OrderBy(p => p);
                    Console.WriteLine(string.Join(" ", item));

                }

            }
        }
        public class TestShellSort
        {
            public static void RunTestForSortAlgorithm(Action<int[]> sort, int[][] jagged)
            {
                foreach (var item in jagged)
                {
                    if (item != null)
                    {
                        sort(item);
                        item.OrderBy(p => p);
                        Console.WriteLine(string.Join(" ", item));

                    }


                }

            }
        }
        public class TestMergeSort
        {
            public static void RunTestForSortAlgorithm(Action<int[]> sort, int[][] jagged)
            {
                foreach (var item in jagged)
                {
                    if (item != null)
                    {
                        sort(item);
                        item.OrderBy(p => p);
                        Console.WriteLine(string.Join(" ", item));

                    }


                }

            }
            public static void RunTestForSortAlgorithm(Action<int[]> sort, int[]item)
            {
              
                    if (item != null)
                    {
                        sort(item);
                        item.OrderBy(p => p);
                        Console.WriteLine(string.Join(" ", item));

                    }


                

            }
        }
        public class TestQuickSort
        {
            public static void RunTestForSortAlgorithm(Action<int[]> sort, int[][] jagged)
            {
                foreach (var item in jagged)
                {
                    if (item != null)
                    {
                        sort(item);
                        item.OrderBy(p => p);
                        Console.WriteLine(string.Join(" ", item));

                    }


                }

            }
        }

        public class TestBuiltInList
        {

            private LinkedListBlock.SinglyLinkedList<int> _linkedListBlock = new LinkedListBlock.SinglyLinkedList<int>();
            public   void RunTestForSortAlgorithm(Action<int[]> sort, int[][] jagged)
            {
                _linkedListBlock.AddFirst(2);

            }
        }


        public class Heaptest
        {
            public static void TestMAxHeap()
            {
                var heap = new Heaping.MaxHeap<int>();
                heap.Insert(24);
                heap.Insert(37);
                heap.Insert(17);
                heap.Insert(28);
                heap.Insert(31);
                foreach (var item in heap.Values())
                {
                    Console.Write($"{item} ");
                }
                 
            }
        }







    }
}
