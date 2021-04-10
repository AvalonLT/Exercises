//Given a string s, find the length of the longest substring without repeating characters.

//Input: s = "abcabcbb"
//Output: 3
//Explanation: The answer is "abc", with the length of 3.

using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = LenghtOfTheLongestSubstring("acdefghia");
            Console.WriteLine(a);
            Console.ReadLine();
        }

        public static int LenghtOfTheLongestSubstring(string s)
        {
            var substringLenght = 1;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j)
                    {
                        if (s[i] != s[j])
                        {
                            substringLenght++;
                        }
                        else
                        {
                            goto End;
                        }
                    }
                }
            }
        End:

            return substringLenght;
        }
    }
}
