using Algorithm.DataStructures;
using Algorithm.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.DataStructures;
using static Algorithm.DataStructures.LinkedListBlock;
using static Algorithm.DataStructures.StackeADT;
using static Algorithm.DataStructures.BinarySearchTrees;
using   Algorithm.DataStructures.MineThought;
using static Algorithm.DataStructures.GraphWeightedUndirectedGraph;
using static Algorithm.DataStructures.Graph_PathWithSmallestProductOfEdgeWithWeightGreaterThanOne.Pair;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Fizzbuzz.PrintP(65);
            //Fizzbuzz.FizzBuzzPrint(1, 100);
            //Fibonacci.PrintFibonacci(40);
            //ReverseType.ReverseV2("12345");
            //ReverseType.ReverseV3("12345");
            // StringReverse.Reverse("12345");.
            //  Palindromes.IsPalindrome("AnnA");
            //Palindromes.IsPalindromeV2("radda");

            // ReverseType.ReverseInt.Reverse(1234557);
            //Arrays.MultiDimentionalArrayV2();
            //Arrays.JaggedArray();
            // Arrays.MemoryAlocationIterateOver(new int[] { 1,2,3});

            //TestObject.TestBubble.RunTestForSortAlgorithm(BubbleSortIng.BubbleSort, SampleObjects.Samples());
            //TestObject.TestSelection.RunTestForSortAlgorithm(SelectionSorting.SelectionSort, SampleObjects.Samples());
            // TestObject.TestInsertion.RunTestForSortAlgorithm(Insertion.InsertionSort, SampleObjects.Samples());
            //Insertion.RecursiveFactorial(10);
            // TestObject.TestMergeSort.RunTestForSortAlgorithm(MergeSorting.MergeSort, SampleObjects.Samples());
            //TestObject.TestMergeSort.RunTestForSortAlgorithm(MergeSorting.MergeSort, SampleObjects.Sample()[2]);
            // TestObject.TestQuickSort.RunTestForSortAlgorithm(QuickSorting.QuickSort, SampleObjects.Samples());
            // BuiltDemo.BuiltInList.BIL();
            //NodeImplementation.Implement();
            //ArrayQueues<int> stk = new ArrayQueues<int>();
            //stk.Enqueue(1);
            //stk.Enqueue(2);
            //stk.Enqueue(3);
            //stk.Enqueue(4);
            //stk.Enqueue(5);
            //stk.Enqueue(6);
            //Console.WriteLine($"Should print out 6 {stk.Peek()}");
            //stk.Dequeue();
            //Console.WriteLine($"Should print out 5 {stk.Peek()}");

            //foreach(var st in stk)
            //{
            //    Console.WriteLine($"{st}");
            //}

            //var bst = new BinarySearchTree<int>(12);
            //bst.Insert(37);
            //bst.Insert(40);
            //bst.Insert(24); 
            //bst.Insert(47);
            //bst.Insert(17);
            //bst.Insert(28);
            //bst.Insert(31);
            //bst.Insert(29);
            //bst.Insert(15);
            //bst.Insert(12);
            //bst.Insert(20);


            //foreach (var item in bst.TraverseInOrder())
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //bst.PrintLeftView();
            //Console.WriteLine();
            //Console.WriteLine("Min {0}",bst.Min());
            //Console.WriteLine($"Max {bst.MAx()}");
            //Console.WriteLine($"Value at 20 {bst.Get(20).Value}");


            //int value=   AmazonQuestions.FindTheMissingNumberInArrayOfTenNumber(new[] { 3, 7, 1, 2, 8, 4, 5 });
            // int value=   AmazonQuestions.FindTheMissingNumberInArrayOfTenNumber(new[] { 30,15,25,10,40,35 });
            //bool value = AmazonQuestions.DetermineIfSumOfTwoNumberInAnArrayIsEqualToTheGivenNumber(new[] {9, 3, 7, 1, 2, 8, 4, 5 ,10}, 19);
            // double value = AmazonQuestions.LargestSumOfContiguousSubArray(new[] {-2,-3,4,-1,-2,1,5,-3});



            //int value=  BinarSearching.BSearch(SampleObjects.Sample()[2], 431);
            //LinkedListsDTS.SinglyLinkedList<int> all = new LinkedListsDTS.SinglyLinkedList<int>();
            //LinkedListsDTS.SinglyLinkedList<int> allz = new LinkedListsDTS.SinglyLinkedList<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //   all.AddFirst(i * i+i);
            //}
            //allz.AddLast(-2);
            //allz.AddLast(1);
            //allz.AddLast(10);
            //foreach (var item in allz)
            //{
            //    Console.Write($"{item} ");

            //}
            //var arr = new[] { 30, 15, 25, 10, 40, 35 };
            //QuickSorting.QuickSort(arr);
            //Console.Write(string.Join(" ", arr));
            // GraphDTS.Graph.TestGraphP();
            // Graph g = new Graph(9);
            //g.AddEdge(0, 1, 4);
            //g.AddEdge(0, 7, 8);
            //g.AddEdge(1, 2, 8);
            //g.AddEdge(1, 7, 11);
            //g.AddEdge(2, 3, 7);
            //g.AddEdge(2, 8, 2);
            //g.AddEdge(2, 5, 4);
            //g.AddEdge(3, 4, 9);
            //g.AddEdge(3, 5, 14);
            //g.AddEdge(4, 5, 10);
            //g.AddEdge(5, 6, 2);
            //g.AddEdge(6, 7, 1);

            //g.AddEdge(6, 8, 6);
            //g.AddEdge(7, 8, 7);


            //Console.WriteLine(g.FindMinimumCycle());
            //Console.WriteLine();
            // Console.WriteLine(value);

            // TestGFG.GetPathWithTheSmallestProductOfEdge();

            //int trips= AmazonQuestions.TripCountForSameTwoOrThreePackWeight(new int[] {2,4,6,6,4,2,4});

            //Console.WriteLine("Number of Trips for the packs are {0}", trips);


            TestObject.Heaptest.TestMAxHeap();


            Console.ReadLine();
        }
    }
}