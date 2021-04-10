//Write a function that finds the sum of an array. Make your function recursive.

//sum([1, 2, 3, 4]) ➞ 10

//sum([1, 2]) ➞ 3

//sum([1]) ➞ 1

//sum([]) ➞ 0

using System;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5 };
            var sum = Sum(arr);
            Console.WriteLine();
            Console.ReadLine();
        }

        public static int Sum(int[] arr)
        {
            if (arr.Length == 1)
                return arr[0];

            if (arr.Length > 1)
            {
                arr[1] = arr[0] + arr[1];
                int[] newArr = new int[arr.Length - 1];
                Array.Copy(arr, 1, newArr, 0, arr.Length - 1);
                Sum(newArr);
            }

            return 0;
        }
    }
}
