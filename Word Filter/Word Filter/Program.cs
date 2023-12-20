using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .OrderByDescending(n => n)
            .ToArray();
            int count = number.Length >= 3 ? 3 : number.Length;
            for (int i = 0; i < count; i++)
            Console.Write($"{number[i]} ");
        }
    }
}
