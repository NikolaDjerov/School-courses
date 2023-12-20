using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        }
        bool isOdd(int x) => x % 2 != 0;
    }
}
