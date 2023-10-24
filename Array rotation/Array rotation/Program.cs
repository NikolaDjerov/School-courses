using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for (int j = arr.Length; j>=0; j--)
                {
                    int tamp = arr[arr.Length-1];
                    arr[arr.Length- 1] = arr[j];
                    arr[j] = tamp;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
