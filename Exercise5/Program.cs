//Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
//Notice that the solution set must not contain duplicate triplets.

//Input: nums = [-1,0,1,2,-1,-4]
//Output: [[-1,-1,2],[-1,0,1]]

using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            var uniqueTriplets = ThreeSum(nums);
            PrintOutTriplets(uniqueTriplets);
        }

        

        public static List<List<int>> ThreeSum(int[] nums)
        {
            var uniqueTriplets = new List<List<int>>();

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    //for (int k = 0; k < nums.Length; k++)
                    //{
                        if (i != j & j > i)
                        {
                            if (nums[0] + nums[i] + nums[j] == 0)
                            {
                                var uniqueTriplet = new List<int>();
                                uniqueTriplet.Add(nums[0]);
                                uniqueTriplet.Add(nums[i]);
                                uniqueTriplet.Add(nums[j]);
                                uniqueTriplets.Add(uniqueTriplet);
                            }
                        }
                    //}
                }
            }

            return uniqueTriplets;
        }

        public static void PrintOutTriplets(List<List<int>> uniqueTriplets)
        {
            Console.Write("[");

            foreach (var uniqueTriplet in uniqueTriplets)
            {
                Console.Write("[");

                for (int i = 0; i < uniqueTriplet.Count; i++)
                {
                    Console.Write(i == uniqueTriplet.Count - 1 ? uniqueTriplet[i].ToString() : uniqueTriplet[i] + ",");
                }

                Console.Write("]");
            }

            Console.WriteLine("]");
            Console.ReadLine();
        }

    }
}
