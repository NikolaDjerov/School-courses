using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Calculator(n1, n2, n3);
        }
        static void Calculator(int n1, int n2, int n3)
        {
            int fullprice = (n1 + n2) - n3;
            Console.WriteLine($"{fullprice:F2}");
        }
    }
}
