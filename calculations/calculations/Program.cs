﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            switch(action)
            {
                case "add":
                    Add(first, second);
                break;
                case "multiply":
                    Multiply(first, second);
                break;
                case "subtract":
                    Subtract(first, second);
                break;
                case "divide":
                    Divide(first, second);
                break;
            }
        }
        static void Add(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        static void Multiply(int first, int second)
        {
            Console.WriteLine(first * second);
        }
        static void Subtract(int first, int second)
        {
            Console.WriteLine(first - second);
        }
        static void Divide(int first, int second)
        {
            Console.WriteLine(first / second);
        }

    }
}
