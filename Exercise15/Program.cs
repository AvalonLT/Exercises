//Create a function that takes in a sentence and returns the average length of each word in that sentence. 
//Round your result to two decimal places.

//AverageWordLength("A B C.") ➞ 1.00
//AverageWordLength("What a gorgeous day.") ➞ 4.00
//AverageWordLength("Dude, this is so awesome!") ➞ 3.80

using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            var average = AverageWordLength("Dude, this is so awesome!");
            Console.WriteLine(average.ToString("F2"));
            Console.ReadLine();
        }

        public static double AverageWordLength(string sentence)
        {
            string[] wordsWithExclamtions = sentence.Split();
            string[] words = new string[wordsWithExclamtions.Length];

            for (int i = 0; i < words.Length; i++)
            {
                var fullWord = "";

                for (int j = 0; j < wordsWithExclamtions[i].Length; j++)
                {
                    int letterInt = Convert.ToInt32(wordsWithExclamtions[i][j]);

                    if (letterInt > 64 & letterInt < 91 | letterInt > 96 & letterInt < 123)
                    {
                        fullWord += Convert.ToChar(letterInt);
                    }
                }

                words[i] = fullWord;
            }

            var average = Average(words);

            return average;
        }

        private static double Average(string[] words)
        {
            var totalLetterCount = 0;

            for (int i = 0; i < words.Length; i++)
            {
                totalLetterCount += words[i].Length;
            }

            var average = (double)totalLetterCount / words.Length;

            return average;
        }
    }
}
