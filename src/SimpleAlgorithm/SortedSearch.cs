/**
 * Implement function CountNumbers that accepts a sorted array of integers and counts the number of array elements that are less than the parameter lessThan.
 * For example, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 because there are two array elements less than 4.
 */

using System.Linq;

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

            return sortedArray.Count(m => m < lessThan);
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
        //}
    }
}
