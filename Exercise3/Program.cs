//Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

//Input: nums1 = [1,3], nums2 = [2]
//Output: 2.00000
//Explanation: merged array = [1, 2, 3] and median is 2.

using System;

namespace Exercise3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = {  };
            int[] nums2 = { 0, 0 };
            var median = FindMedianInSortedArrays(nums1, nums2);
            Console.WriteLine(median);
            Console.ReadLine();
        }

        public static double FindMedianInSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combinedArray = MergeTwoSortedArrays(nums1, nums2);
            double median = 0;

            var firstIndex = Convert.ToDouble((combinedArray[(combinedArray.Length / 2)]));
            var secondIndex = Convert.ToDouble(combinedArray[(combinedArray.Length / 2 + 1)]);

            if (combinedArray.Length % 2 == 0)
            {
                median = (firstIndex + secondIndex) / 2;
            }
            else
            {
                median = firstIndex; 
            }

            return median;
        }

        public static int[] MergeTwoSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combinedArray = new int[nums1.Length + nums2.Length];
            var nums2Index = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                combinedArray[i] = nums1[i];
            }

            for (int i = nums1.Length; i < combinedArray.Length; i++)
            {
                combinedArray[i] = nums2[nums2Index];
                nums2Index++;
            }

            var sortedArray = SortArray(combinedArray);
            return sortedArray;
        }

        public static int[] SortArray(int [] unsortedArray)
        {
            int[] sortedArray = unsortedArray;

            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = 0; j < sortedArray.Length - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        var lowerValue = sortedArray[j + 1];
                        sortedArray[j + 1] = sortedArray[j];
                        sortedArray[j] = lowerValue;
                    }
                }
            }

            return sortedArray;
        }
    }
}
