//Create a function that takes an array as an argument and returns a new jagged array for each element in the original array.
//The jagged array must be filled with the corresponding element(string or number) 
//in the original array and each nested array has the same amount of elements as the original array.

//|Multiply([12, 13, "TT"]) ➞ [[12, 12, 12], [13, 13, 13], ["TT", "TT", "TT"]]
//Multiply([12, 17, "DX"]) ➞ [[12, 12, 12], [17, 17, 17], ["DX", "DX", "DX"]]
//Multiply([4, 5]) ➞ [[4, 4], [5, 5]]
//Multiply(["T", "E", "S", "H", "A"]) ➞ [["T", "T", "T", "T", "T"], ["E", "E", "E", "E", "E"], ["S", "S", "S", "S", "S"], ["H", "H", "H", "H", "H"], ["A", "A", "A", "A", "A"]]

using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] items = { 12, 13, "TT" };
            object[][] multipliedArray = Multiply(items);
            var a = PrintOut(multipliedArray);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        public static object[][] Multiply(object[] items)
        {
            object[][] newArray = new object[items.Length][];
            var newArrayTemp = new List<object>();

            for (int j = 0; j < items.Length; j++)
            {
                var item = items[j];
                    
                for (int k = 0; k < items.Length; k++)
                {
                    newArrayTemp.Add(item);
                }

                newArray[j] = newArrayTemp.ToArray();
                newArrayTemp.Clear();
            }

            return newArray;
        }

        public static string PrintOut(object[][] array)
        {
            string arrayContentToString = "";
            arrayContentToString += "[";

            for (int i = 0; i < array.Length; i++)
            {
                arrayContentToString += i == 0 ? "[" : ", [";

                for (int j = 0; j < array.Length; j++)
                {
                    arrayContentToString += array[i][j] is string ? "\"" + array[i][j] + "\"" : array[i][j];
                    arrayContentToString += j < array.Length - 1 ? ", " : "";
                }

                arrayContentToString += "]";
            }

            arrayContentToString += "]";

            return arrayContentToString;
        }
    }
}
