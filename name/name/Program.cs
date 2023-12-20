using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enteredName = Console.ReadLine();

            bool isValid = enteredName.Length >= 3 && char.IsUpper(enteredName[0]);
            if (isValid)
            {
                Console.WriteLine($"Hello, {enteredName}!");
                Console.WriteLine("ASCII values increased by 10:");
                foreach (char c in enteredName)
                {
                    int asciiValue = c + 10;
                    Console.WriteLine(asciiValue);
                }
            }
            else
            {
                Console.WriteLine("Invalid name. Please enter a name that is at least 3 characters long, starts with a capital letter, and contains no digits.");
            }
            Console.Write($"Enter a name:{enteredName} ");
        }
    }
}
