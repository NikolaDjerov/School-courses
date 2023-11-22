using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sign_of_integer_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Number(number);
        }
        static void Number(int number)
        {
            if(number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            if(number == 0) 
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            if(number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
