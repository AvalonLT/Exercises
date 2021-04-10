//A smooth sentence is one where the last letter of each word is identical to the first letter the following word.
//The following would be a smooth sentence: "Carlos swam masterfully." 
//Since "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
//Create a function that determines whether the input sentence is a smooth sentence, 
//returning a boolean value true if it is, false if it is not.

//IsSmooth("Marta appreciated deep perpendicular right trapezoids") ➞ true
//IsSmooth("Someone is outside the doorway") ➞ false
//IsSmooth("She eats super righteously") ➞ true

using System;
using System.Collections.Generic;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var isSmooth = IsSmooth("She eats super righteously");
            Console.WriteLine(isSmooth.ToString());
            Console.ReadLine();

        }

        public static bool IsSmooth(string sentence)
        {
            //var words = new List<string>(sentence.Split(" "));

            for (var i = 1; i < sentence.Length - 1; i++)
            {
                if (sentence[i] == ' ' & sentence[i - 1] != sentence[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
