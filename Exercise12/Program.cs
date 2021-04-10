//Write a function that returns the longest common ending between two strings.

//LongestCommonEnding("multiplication", "ration") ➞ "ation"
//LongestCommonEnding("potent", "tent") ➞ "tent"
//LongestCommonEnding("skyscraper", "carnivore") ➞ ""

using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            var commonEnding = LongestCommonEnding("potent", "tent");
            Console.WriteLine(commonEnding);
            Console.ReadLine();
        }

        public static string LongestCommonEnding(string str1, string str2)
        {
            var commonEndingLength = 0;
            var shortestStringLength = 0;
            var commonEnding = "";

            if (str1.Length - str2.Length >= 0)
            {
                shortestStringLength = str2.Length;
            }
            else
            {
                shortestStringLength = str1.Length;
            }

            for (var i = 0; i < shortestStringLength; i++)
            {
                if (str1[str1.Length - i - 1] == str2[str2.Length - i - 1])
                {
                    commonEndingLength++;
                }
                else
                {
                    break;
                }
            }

            if (commonEndingLength == 0)
            {
                commonEnding = "\"\"";
            }
            else
            {
                commonEnding = str1.Substring(str1.Length - commonEndingLength);
            }

            return commonEnding;
        }
    }
}
