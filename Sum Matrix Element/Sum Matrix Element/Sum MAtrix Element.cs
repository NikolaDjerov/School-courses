using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Matrix_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int matrixRow = size[0];
            int matrixColumn = size[1];
            int[,] matrix = new int[matrixRow, matrixColumn];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[matrixRow, col] = elements[col];
                    sum+= elements[col];
                }
            }
            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);
        }
    }
}
