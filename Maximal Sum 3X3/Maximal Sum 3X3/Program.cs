using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_Sum_3X3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for(int row = 0 ;row < size[0]; row++)
            {
                int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for(int col = 0; col < size[1]; col++)
                {
                    matrix[row,col] = elements[col];
                }
            }
            int topG = 0;
            int topRow = 0;
            int topCol= 0;
            for(int row = 0; row < size[0] - 2; row++)
            {
                for(int col = 0; col < size[1] - 2; col++)
                {
                    int g = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] +
                    matrix[row, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 2] + matrix[row +2,col + 1] + matrix[row +1, col + 2];
                    if(g > topG)
                    {
                        topG = g;
                        topRow = row;
                        topCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {topG}");
            Console.WriteLine($"{matrix[topRow, topCol]}{matrix[]}");
            Console.WriteLine($"");
        }
    }
}