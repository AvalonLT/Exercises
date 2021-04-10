//Create a function that takes a string and returns the number of alphanumeric characters that occur more than once.

//DuplicateCount("abcde") ➞ 0
//DuplicateCount("aabbcde") ➞ 2
//DuplicateCount("Indivisibilities") ➞ 2
//DuplicateCount("Aa") ➞ 0
// Case sensitive

using System;
using System.Collections.Generic;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var occourances = AlphanumericCharacters("Indivisibilities");
            Console.WriteLine(occourances);
            Console.ReadLine();

        }

        public static int AlphanumericCharacters(string s)
        {
            var sameCharactersCount = 0;
            var foundCharacters = new List<char>();
            foundCharacters.Add('\0');

            for (var i = 0; i < s.Length - 1; i++)
            {
                foreach (var character in foundCharacters)
                {
                    if (character == s[i])
                    {
                        i++;
                    }
                }
                for (var j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j] & i != j)
                    {
                        sameCharactersCount++;
                        foundCharacters.Add(s[i]);
                        break;
                    }
                }
            }

            return sameCharactersCount;
        }
    }
}
