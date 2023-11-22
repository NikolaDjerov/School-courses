using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace password_validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
        }
        static void Characters(string pass)
        {
            bool chars = false;    
            if(pass.Length > 5 && pass.Length < 11)
            {
                chars = true;
            }
        }
        static void LettersAndDigits(string pass)
        { 
            bool chars = false;
            if (pass.Contains("@") || pass.Contains("-") || pass.Contains("%") || pass.Contains("*") || pass.Contains("+") || pass.Contains(">") || pass.Contains("<") || pass.Contains("#") || pass.Contains("&") || pass.Contains("$"))
            {
                chars = false;
            }
            else
            {
                chars = true;
            }
        }
        static bool DoubleDigits(string pass)
        {
            bool numbers = false;
            int digitCount = pass.Count(char.IsDigit);
            if (digitCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                numbers = true;
            }
            return numbers;
        }
        static void Password(string pass)
        {

        }

    }
}
