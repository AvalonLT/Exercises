//In this challenge, you must verify the equality of two different values given the parameters a and b.
//Both the value and type of the parameters need to be equal. The possible types of the given parameters are:
//Numbers, Strings, Booleans.


using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var isEqual = CheckEquality(1, 1);
            Console.WriteLine(isEqual);
            Console.ReadLine();
        }
        public static bool CheckEquality(object a, object b)
        {
            if (a.Equals(b))
            {
                return true;
            }

            return false;
        }
    }

}
