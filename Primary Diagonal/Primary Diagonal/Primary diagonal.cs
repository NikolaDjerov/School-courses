using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int input = int.Parse(Console.ReadLine());
                int sum = 0;
                int[,] matrix = new int[input, input];
                for (int i = 0; i < input; i++)
                {
                    int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < input; j++)
                    {
                        matrix[i, j] = row[j];
                    }
                }
                for (int pos = 0; pos < input; pos++)
                {
                    sum += matrix[pos, pos];
                }
                Console.WriteLine(sum);
        }
    }
}
