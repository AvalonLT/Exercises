//Create a function that takes an array of numbers and return "Boom!" if the number 7 appears in the array. 
//Otherwise, return "there is no 7 in the array".

//sevenBoom([1, 2, 3, 4, 5, 6, 7]) ➞ "Boom!"
// 7 contains the number seven.

//sevenBoom([8, 6, 33, 100]) ➞ "there is no 7 in the array"
// None of the items contain 7 within them.

//sevenBoom([2, 55, 60, 97, 86]) ➞ "Boom!"
// 97 contains the number seven.

using System;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 2, 49, 60, 97, 86 };
            var answer = SevenBoom(items);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        public static string SevenBoom(int[] items)
        {
            var sevenExists = false;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == 7)
                    sevenExists = true;

                if (items[i] > 9)
                {
                    for (int j = 0; j < items[i].ToString().Length; j++)
                    {
                        var b = items[i].ToString().Length;
                        var a = items[i].ToString();
                        char c = a[1];
                        if (items[i].ToString()[j] == '7')
                            sevenExists = true;
                    }
                }

            }

            if (sevenExists)
                return "Boom!";

            return "There is no 7 in the array";
        }
    }
}
