using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memory_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
            string input  = Console.ReadLine();
            while(true)
            {
                input.Split(' ').Select(int.Parse).ToList();
                if (num[input[0]] == num[input[1]] )
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {input[0]}");
                    num.RemoveAt([input[0]);
                    num.RemoveAt([input[1]);
                }
                if(input == "end" && num.Count > 0)
                {
                    Console.WriteLine("Sorry you lose :(");
                    Console.WriteLine($"{string.Join(" ", num)}");
                }
                if (input[0] == input[1])
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
