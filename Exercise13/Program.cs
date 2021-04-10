//Create a function that takes a string and replaces each letter with its appropriate position in the alphabet.
//"a" is 1, "b" is 2, "c" is 3, etc, etc. If any character in the string isn't a letter, ignore it.

//AlphabetIndex("Wow, does that work?")
//➞ "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11"
//AlphabetIndex("The river stole the gods.")
//➞ "20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19"
//AlphabetIndex("We have a lot of rain in June.")
//➞ "23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5"

using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = AlphabetIndex("Wow, does that work?");
            Console.WriteLine(str);
            Console.ReadLine();
        }
        public static string AlphabetIndex(string str)
        {
            var alphabetIndexString = "";

            for (int i = 0; i < str.Length; i++)
            {
                var symbolInt = Convert.ToInt32(str[i]);

                if (symbolInt > 64 &  symbolInt < 91)
                {
                    var alphabeticIndex = (symbolInt - 64).ToString() + " ";
                    alphabetIndexString += alphabeticIndex;
                }
                else if (symbolInt > 96 & symbolInt < 123)
                {
                    var alphabeticIndex = (symbolInt - 96).ToString() + " ";
                    alphabetIndexString += alphabeticIndex;
                }
            }

            return alphabetIndexString;
        }
    }

}
