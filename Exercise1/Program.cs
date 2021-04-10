//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example:
//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Because nums[0] + nums[1] == 9, we return [0, 1].

using System;

namespace Exercise1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] numbersIndices = TwoSum(nums, 9);

            Console.WriteLine("[" + numbersIndices[0] + ", " + numbersIndices[1] + "]");
            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var sumOfTwoNumbers = 0;
            var firstNumberIndex = 0;
            var secondNumberIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        sumOfTwoNumbers = nums[i] + nums[j];
                        firstNumberIndex = i;
                        secondNumberIndex = j;
                    }

                    if(sumOfTwoNumbers == target)
                    {
                        goto End;
                    }
                }
            }
        End:

            int[] numbersIndices = { firstNumberIndex, secondNumberIndex };

            return numbersIndices;
        }
    }
}
