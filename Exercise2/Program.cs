//Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

using System;

namespace Exercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalimdrome(-121));
            Console.ReadLine();
        }

        public static bool IsPalimdrome(int number)
        {
            var numberAsString = number.ToString();
            var newNumber = "";
            //var isSameNumber = false;

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                newNumber += numberAsString[i];
            }

            try
            {
                if (number == Int32.Parse(newNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
