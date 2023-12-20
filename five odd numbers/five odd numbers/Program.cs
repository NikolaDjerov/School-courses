using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');
            int[] numbers = Array.ConvertAll(inputs, int.Parse);
            int[] oddNumbers = numbers.Where(num => num % 2 != 0).OrderByDescending(num => num).Take(5).ToArray();
            Console.Write("Enter integers separated by ',': ");
            foreach (int number in oddNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
