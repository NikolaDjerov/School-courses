using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_of_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        static void Matrix(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    Console.Write(n+ " ");
                }
                Console.WriteLine(n);
            }
        }
    }
}
