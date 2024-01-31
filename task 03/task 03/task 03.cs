using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerX, playerY;
            int playerHealth = 0;
            int enemyCount = 0;
            int size = int.Parse(Console.ReadLine());
            int[,] battlefield = new int[size, size];
            for(int i = 0; i < size; i++)
            {
                string colEl = Console.ReadLine();
                for(int j = 0; j < size; j++)
                {
                    battlefield[i, j] = colEl[i];
                    if (colEl[j] == 'P')
                    {
                        playerX= i;
                        playerY = j;
                    }
                    else if (colEl[j] == 'E')
                    {
                        enemyCount++;
                    }
                }
            }
            while (true)
            {
                string move = Console.ReadLine();
                switch(move.ToLower())
                {
                    case "up":
                        if (battlefield[playerX + 1, playerY] == 'G')
                        {
                            playerHealth--;
                        }
                        break;
                    case "down":
                        if (battlefield[playerX + 1, playerY] == 'G')
                        {
                            playerHealth--;
                        }
                        break;
                    case "left":
                        if (battlefield[playerX + 1, playerY] == 'G')
                        {
                            playerHealth--;
                        }
                        break;
                    case "right":
                        if (battlefield[playerX + 1, playerY] == 'G')
                        {
                            playerHealth--;
                        }
                        break;

                }
            }
        }
    }
}
