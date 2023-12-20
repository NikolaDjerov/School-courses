using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            int count = 0;
            string command = Console.ReadLine();
            while (command != "END")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (q.Count == 0)
                        {
                            break;
                        }
                        count++;
                        Console.WriteLine($"{q.Dequeue()} passed!");
                    }
                }
                else
                {
                    q.Enqueue(count);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
        }
    }
