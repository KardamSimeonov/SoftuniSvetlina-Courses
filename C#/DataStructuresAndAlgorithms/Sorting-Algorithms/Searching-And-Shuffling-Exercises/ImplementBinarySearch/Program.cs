﻿using System;
using System.Linq;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch.IndexOf(arr, target));
        }
    }
    public class BinarySearch
    {
        // BinarySearch searches for the index of an element,
        // in an ascending sorted collection
        //
        // The algorithm find the midIndex and depending on 
        // if the element is smaller than midIndex,
        // midIndex is incremented or decremented
        public static int IndexOf(int[] arr, int key)
        {
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;

                if (key < arr[midIndex])
                    rightIndex = midIndex - 1;

                else if (key > arr[midIndex])
                    leftIndex = midIndex + 1;

                else
                    return midIndex;
            }

            return -1;
        }
    }
}
