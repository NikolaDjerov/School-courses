using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace everything_in_common
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool same = false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    sum = i;
                    Console.WriteLine("Arrays are not identical.");
                    Console.WriteLine($"Found difference at {sum} index");
                    break;
                }
                sum = array1[i];
                if (i == array1.Length - 1 && i == array2.Length - 1)
                {
                    same = true;
                }
                if (same == true)
                {
                    int lastNum = array1[i] % 10;
                    sum += lastNum;
                    Console.WriteLine("Arrays are identical.");
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
            }
        }
    }
}
