﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashion_boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            Stack<int> stack = new Stack<int>(clothes);
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int numberOfRacks = 1;
            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= capacity)
                {
                    stack.Pop();
                }
                else
                {
                    numberOfRacks++;
                    sum = 0;
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
