using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_transformations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] n = input.Split(',');
            int[] numbers = Array.ConvertAll(n, int.Parse);
            var increase = numbers.Where(num => num % 2 == 0).Select(num => num + 1).OrderBy(num => num);
            Console.Write("Enter integers separated by ',': ");
            foreach (int number in increase)
            {
                Console.Write(number + " ");
            }
        }
    }
    }

