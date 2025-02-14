﻿using System;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(String.Join(" ", QuickSort.Sort(arr)));
        }
    }

    public class QuickSort
    {
        public static int[] Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);

            return arr;
        }

        private static void Sort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
                return;

            int pivot = AlternatePartition(arr, leftIndex, rightIndex);
            Sort(arr, leftIndex, pivot - 1);
            Sort(arr, pivot + 1, rightIndex);
        }

        private static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
                return leftIndex;

            int i = leftIndex;
            int j = rightIndex + 1;

            while (true)
            {
                while (arr[++i] < arr[leftIndex])
                    if (i == rightIndex)
                        break;

                while (arr[leftIndex] < arr[--j])
                    if (j == leftIndex)
                        break;

                if (i >= j)
                    break;

                Swap(ref arr, i, j);
            }

            Swap(ref arr, leftIndex, j);

            return j;
        }
       
        private static int AlternatePartition(int[] arr, int leftIndex, int rightIndex)
        {
            // The AlternatePartition scans the elements infront of the pivot,
            // swapping positions with the storeIndex if the element if it's smaller
            // than the storeIndex
            //
            // In the end the numbers from the pivot to the storeIndex are smaller than the pivot,
            // thus the pivot is swapped with the storeIndex - 1

            if (leftIndex >= rightIndex)
                return leftIndex;

            int storeIndex = leftIndex + 1;

            for (int i = leftIndex + 1; i <= rightIndex; i++)
            {
                if (arr[i] < arr[leftIndex])
                {
                    Swap(ref arr, i, storeIndex);
                    ++storeIndex;
                }
            }

            Swap(ref arr, leftIndex, storeIndex - 1);

            return storeIndex - 1;
        }

        static void Swap(ref int[] arr, int toSwap, int swapWith)
        {
            int temp = arr[toSwap];
            arr[toSwap] = arr[swapWith];
            arr[swapWith] = temp;
        }
    }
}
