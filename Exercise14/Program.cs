//Create a function that takes the width, height and character and returns a picture frame as an array of strings (string[]).

//get_frame(4, 5, "#") ➞ [
//  "####",
//  "#  #",
//  "#  #",
//  "#  #",
//  "####"
//]
// Frame is 4 characters wide and 5 characters tall.


//get_frame(10, 3, "*") ➞ [
//  "**********",
//  "*        *",
//  "**********"
//]
// Frame is 10 characters and wide and 3 characters tall.


//get_frame(2, 5, "0") ➞ "invalid"
// Frame"s width is less than 3.

using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            var frame = GetFrame(10, 3, '*');

            for (int i = 0; i < frame.Length; i++)
            {
                Console.WriteLine(frame[i]);
            }

            Console.ReadLine();
        }

        public static string[] GetFrame(int width, int height, char character)
        {
            string[] frame = new string[height];

            if (width < 3 | height < 3)
            {
                frame = new string[1] { "Invalid" };
                return frame;
            }

            for (int i = 0; i < height; i++)
            {
                if (i == 0 | i == height - 1)
                {
                    string characterLine = "";

                    for (int j = 0; j < width; j++)
                    {
                        characterLine += character;
                    }

                    frame[i] = characterLine;
                }
                else
                {
                    string characterLine = "" + character;

                    for (int k = 1; k < width - 1; k++)
                    {
                        characterLine += " ";
                    }

                    characterLine += character;

                    frame[i] = characterLine; 
                }
            }

            return frame;
        }
    }
}
