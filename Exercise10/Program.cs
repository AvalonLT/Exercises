//ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
//Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.

//ValidatePIN("1234") ➞ true
//ValidatePIN("12345") ➞ false
//ValidatePIN("a234") ➞ false
//ValidatePIN("") ➞ false

using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var isPinCodeValid = IsPinCodeValid("a234");
            Console.WriteLine(isPinCodeValid);
            Console.ReadLine();
        }

        public static bool IsPinCodeValid(string pinCode)
        {
            var isValid = false;

            var IsPinCodeHave4Or6Digit = IsPinCodeHave4Or6Digits(pinCode);

            if (IsPinCodeHave4Or6Digit)
            {
                isValid = IsPinCodeContainsOnlyDigits(pinCode);
            }

            return isValid;
        }

        public static bool IsPinCodeHave4Or6Digits(string pinCode)
        {
            if (pinCode.Length == 4 || pinCode.Length == 6)
            {
                return true;
            }

            return false;
        }

        public static bool IsPinCodeContainsOnlyDigits(string pinCode)
        {
            int integer;

            for (var i = 0; i < pinCode.Length; i++)
            {
                var digit = pinCode[i].ToString();

                if (Int32.TryParse(digit, out integer))
                {
                }
                else
                {
                    return false;
                }
                
            }

            return true;
        }
        
    }
}
