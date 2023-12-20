using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_3_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .OrderByDescending(n => n)
            .ToArray();
            int count = num.Length >= 3 ? 3 : num.Length;
            for (int i = 0; i < count; i++)
                Console.Write($"{num[i]} ");
        }
    }
}
