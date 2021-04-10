//Create a function that takes a string as an argument and returns the Morse code equivalent.

//EncodeMorse("EDABBIT CHALLENGE") ➞ ". -.. .- -... -... .. -   -.-. .... .- .-.. .-.. . -. --. ."
//EncodeMorse("HELP ME") ➞ ".... . .-.. .--.   -- .   -.-.--"

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            var morseCodeString = EncodeMorse("EDABBIT CHALLENGE");
            Console.WriteLine(morseCodeString);
            Console.ReadLine();
        }

        public static string EncodeMorse(string str)
        {
            var morseDictonary = InitializeMorseCodeDictionary();
            var morseCodedStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                var morseCodeString = morseDictonary[str[i]];
                morseCodedStr += morseCodeString + " ";
            }

            return morseCodedStr;
        }

        private static Dictionary<char, string> InitializeMorseCodeDictionary()
        {
            var morseAlphabetDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'A', ".-"},
                                       {'B', "-..."},
                                       {'C', "-.-."},
                                       {'D', "-.."},
                                       {'E', "."},
                                       {'F', "..-."},
                                       {'G', "--."},
                                       {'H', "...."},
                                       {'I', ".."},
                                       {'J', ".---"},
                                       {'K', "-.-"},
                                       {'L', ".-.."},
                                       {'M', "--"},
                                       {'N', "-."},
                                       {'O', "---"},
                                       {'P', ".--."},
                                       {'Q', "--.-"},
                                       {'R', ".-."},
                                       {'S', "..."},
                                       {'T', "-"},
                                       {'U', "..-"},
                                       {'V', "...-"},
                                       {'W', ".--"},
                                       {'X', "-..-"},
                                       {'Y', "-.--"},
                                       {'Z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."},
                                       {' ', " " }
                                   };

            return morseAlphabetDictionary;
        }
    }
}
