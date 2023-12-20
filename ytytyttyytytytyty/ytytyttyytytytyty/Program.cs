using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ytytyttyytytytyty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Square(number));

            int[] num1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(n => n > 0)  
                .ToArray();
        }
        static int Square(int x) => x * x;
    }
}
