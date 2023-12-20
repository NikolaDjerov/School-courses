using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traffic_jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string>queue = new Queue<string>();
            int count = 0;
            string command = Console.ReadLine();
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for(int i = 0; i < n; i++)
                    {
                        if(queue.Count == 0)
                        { 
                            break;
                        }
                        count++;
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
