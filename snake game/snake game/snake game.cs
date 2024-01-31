using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int N = int.Parse(dimensions[0]);
            int M = int.Parse(dimensions[1]);
            string snake = Console.ReadLine();
            int snake0 = 0;
            char[,] matrix = new char[N, M];
            for (int row = 0; row < N; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < M; col++)
                    {
                        matrix[row, col] = snake[snake0 % snake.Length];
                        snake0++;
                    }
                }
                else
                {
                    for (int col = M - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[snake0 % snake.Length];
                        snake0++;
                    }
                }
            }
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
