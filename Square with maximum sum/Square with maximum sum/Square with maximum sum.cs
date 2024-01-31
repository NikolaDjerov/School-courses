using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_with_maximum_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] element = new int[size[0], size[1]];
            for (int row = 0; row < size[0]; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    element[row, col] = input[col];
                }
            }
            int max = 0;
            int elementRow = 0;
            int elementCol = 0;
            for (int row = 0; row < size[0] - 1; row++)
            {
                for (int col = 0; col < size[1] - 1; col++)
                {
                    int sum =
                        element[row, col] +
                        element[row + 1, col] +
                        element[row, col + 1] +
                        element[row + 1, col + 1];

                    if (max < sum)
                    {
                        max = sum;
                        elementRow = row;
                        elementCol = col;
                    }
                }
            }
            Console.WriteLine(@$"{element[elementRow, elementCol]} {element[elementRow, elementCol + 1]}
{element[elementRow + 1, elementCol]} {element[elementRow + 1, elementCol + 1]} {max}");
        }
    }
}
