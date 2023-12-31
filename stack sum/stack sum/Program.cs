﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(input);
            while (true)
            {
                string[] command = Console.ReadLine().ToLower().Split();
                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    var countOfRemovedNums = int.Parse(command[1]);
                    if (stack.Count >= countOfRemovedNums)
                    {
                        for (int i = 0; i < countOfRemovedNums; i++)
                        {
                            if (stack.Any())
                            {
                                stack.Pop();
                            }
                        }
                    }
                }
                else if (command[0] == "end")
                {
                    break;
                }
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
    }

