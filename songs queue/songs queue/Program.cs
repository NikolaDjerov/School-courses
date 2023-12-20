using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songs_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
            .Split(',');
            Queue<string> song = new Queue<string>(input);
            while (true)
            {
                string[] command = Console.ReadLine() 
                    .Split();
                if (command[0] == "Play")
                {
                    if (song.Any())
                    {
                        song.Dequeue();
                    }
                    if (song.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (command[0] == "Add")
                {
                    string name = string.Join(" ", command.Skip(1));

                    if (song.Contains(name))
                    {
                        Console.WriteLine($"{name} is already contained!");
                    }
                    else
                    {
                        song.Enqueue(name);
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", song));
                }
            }
        }
    }
}
