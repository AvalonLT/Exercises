//Write a function to find the longest common prefix string amongst an array of strings.
//If there is no common prefix, return an empty string "".

//Input: ["flower","flow","flight"]
//Output: "fl"

using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "car", "cuddle", "flower", "flow", "flight" };
            var prefix = LongestCommonPrefix(words);
            Console.WriteLine(prefix);
            Console.ReadLine();
        }

        public static string LongestCommonPrefix(string[] words)
        {
            var prefix = "";
            var newWords = words;
            var firsLettersListCount = 3;

            while(firsLettersListCount > 2)
            {
                var firstLettersList = FirstLettersList(newWords);
                var mostCommonLetter = MostCommonLetter(firstLettersList);
                prefix += mostCommonLetter;
                newWords = DeleteUnnecesaryWordsWithoutMostCommonLetter(newWords, mostCommonLetter);
                firsLettersListCount = firstLettersList.Count;
            }

            return prefix;        }

        public static List<char> FirstLettersList(string[] words)
        {
            var firstLetters = new List<char>();

            for (int i = 0; i < words.Length; i++)
            {
                firstLetters.Add(words[i][0]);
            }

            return firstLetters;
        }

        public static char MostCommonLetter(List<char> letters)
        {
            var newArray = new int[255];
            var largestNumberinNewArray = 0;
            var mostCommonLetter = '\0';

            for (int i = 0; i < letters.Count; i++)
            {
                var a = Convert.ToInt32(letters[i]);
                newArray[a]++;
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] > largestNumberinNewArray)
                {
                    largestNumberinNewArray = newArray[i];
                    mostCommonLetter = Convert.ToChar(i);
                }
            }

            return Convert.ToChar(mostCommonLetter);
        }
        
        public static string[] DeleteUnnecesaryWordsWithoutMostCommonLetter(string[] words, char mostCommonLetter)
        {
            var newList = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][0] == mostCommonLetter)
                {
                    newList.Add(words[i].Substring(1));
                }
            }

            var newArray = new string[newList.Count];

            for (int i = 0; i < newList.Count; i++)
            {
                newArray[i] = newList[i];
            }
            return newArray;

        }
    }

}
