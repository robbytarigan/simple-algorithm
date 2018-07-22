/**
 * Implement function CountNumbers that accepts a sorted array of integers and counts the number of array elements that are less than the parameter lessThan.
 * For example, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 because there are two array elements less than 4.
 */

using System;

namespace SimpleAlgorithm
{
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            if (sortedArray == null)
            {
                return 0;
            }

            int index = Array.BinarySearch(sortedArray, lessThan);

            if (index >= 0)
            {
                return index;
            }
            else
            {
                return ~index;
            }
        }

        
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
        //}
    }
}
