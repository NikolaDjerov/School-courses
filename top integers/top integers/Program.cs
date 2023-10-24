using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =Console.ReadLine()
               .Split(',')
               .Select(int.Parse)
               .ToArray();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < arr.Length; i++)
            {
               
            }
        }
    }
}
