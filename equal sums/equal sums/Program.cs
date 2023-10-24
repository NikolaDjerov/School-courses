using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equal_sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToArray();


        }
    }
}
