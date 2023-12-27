﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class SampleObjects
    {
        public static int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new int[] { 1 };
            samples[1] = new int[] { 2, 1 };
            samples[2] = new int[] { 2, 1, 3 };
            samples[3] = new int[] { 1, 1, 1 };
            samples[4] = new int[] { 2, -1, 3, 3 };
            samples[5] = new int[] { 4, -5, 3, 3 };
            samples[6] = new int[] { 0, -5, 3, 3 };
            samples[7] = new int[] { 0, -5, 3, 0 };
            samples[8] = new int[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return samples;
        }
        public static int[][] Sample()
        {
            int[][] arr = new int[9][];
            arr[0] = new int[] { 37, 42, 39, 58, 89, 56, 60, 40, 83, 32, 51, 67, 86, 62, 59, 54, 9, 58, 86, 75 };
            arr[1] = new int[] { 71, 37, 47, 5, 92, 87, 42, -3, 22, 11, 15, 43, 10, 87, 36, 18, 38, 9, 15, 99, 6, 84, 50, 8, 62, 93, 37, -9, 6, -1, 33, 88, 36, 35, 33, 91, 97, 52, 66, 57, 19, 13, 7, 8, 57, 97, 40, 16, 50, 64, 65, 96, 73, -2, 8, 23, 92, 32, 49, 21, 49, 52, 26, 73, 39, 31, 56, 52, 19, 66, 47, 3, 75, 39, 36, 15, 70, 43, -3, 71, -5, 65, 28, 81, 37, 4, -1, 60, 64, 61, 37, 27, 25, 67, 66, 88, 25, 33, 86, 2 };
            arr[2] = new int[] { 89, 36, 50, 26, 23, 89, 65, 8, 79, 67, 10, 66, 7, 48, 99, 49, 56, 74, 72, 40, 2, 21, 41, -5, 9, -4, 68, 80, 57, 46, 84, 8, 85, 85, 94, 24, 47, 58, 43, 4, 23, 62, 61, 66, 27, -2, 14, 43, 31, 77 };


            return arr;


        }


        public static List<int> SampleIntList()
        {
            return new List<int>
            {
                71, 37, 47, 5, 92, 87, 42, -3, 22, 11, 15, 43, 10, 87, 36, 18, 38, 9, 15, 99, 6, 84, 50, 8, 62, 93, 37, -9, 6, -1, 33, 88, 36, 35, 33, 91, 97, 52, 66, 57, 19, 13, 7, 8, 57, 97, 40, 16, 50, 64, 65, 96, 73, -2, 8, 23, 92, 32, 49, 21, 49, 52, 26, 73, 39, 31, 56, 52, 19, 66, 47, 3, 75, 39, 36, 15, 70, 43, -3, 71, -5, 65, 28, 81, 37, 4, -1, 60, 64, 61, 37, 27, 25, 67, 66, 88, 25, 33, 86, 2
            };
        }
        public static List<string> SampStringleList()
        {


            var data = "71, 37, 47, 5, 92, 87, 42, -3, 22, 11, 15, 43, 10, 87, 36, 18, 38, 9, 15, 99, 6, 84, 50, 8, 62, 93, 37, -9, 6, -1, 33, 88, 36, 35, 33, 91, 97, 52, 66, 57, 19, 13, 7, 8, 57, 97, 40, 16, 50, 64, 65, 96, 73, -2, 8, 23, 92, 32, 49, 21, 49, 52, 26, 73, 39, 31, 56, 52, 19, 66, 47, 3, 75, 39, 36, 15, 70, 43, -3, 71, -5, 65, 28, 81, 37, 4, -1, 60, 64, 61, 37, 27, 25, 67, 66, 88, 25, 33, 86, 2".Split(',').ToList();
            return data;
        }
    }
}
