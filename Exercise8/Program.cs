//Create a function that takes an array of non-negative integers and strings and return a new array without the strings.
//Zero is a non-negative integer.
//The given array only has integers and strings.
//Numbers in the array should not repeat.

//FilterArray([1, 2, "a", "b"]) ➞ [1, 2]
//FilterArray([1, "a", "b", 0, 15]) ➞ [1, 0, 15]
//FilterArray([1, 2, "aasf", "1", "123", 123]) ➞ [1, 2, 123]

using System;
using System.Collections.Generic;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] stringsAndIntegers = new object[] { 1, 2, "aasf", "1", "123", 123 };
            int[] integerElements = ReturnIntegers(stringsAndIntegers);
            PrintOutArray(integerElements);

        }

        public static void PrintOutArray(int[] integerElements)
        {
            Console.Write("[");

            for (var i = 0; i < integerElements.Length; i++)
            {
                if (i < integerElements.Length - 1)
                {
                    Console.Write(integerElements[i] + ", ");
                }
                else
                {
                    Console.Write(integerElements[i]);
                }
            }

            Console.Write("]");

            Console.ReadLine();
        }

        public static int[] ReturnIntegers(object[] array)
        {
            var integersList = new List<int>();

            foreach (var element in array)
            {
                if (element is int)
                {
                    integersList.Add(Convert.ToInt32(element));
                }
            }

            int[] integersArray = integersList.ToArray();
            return integersArray;
        }
    }

}
