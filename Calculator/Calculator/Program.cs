using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            Stack<string>stack = new Stack<string>(values.Reverse());
            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string opera = stack.Pop();
                int second = int.Parse(stack.Pop());
                switch (opera)
                 { 
                    case "+":
                    stack.Push((first + second).ToString());
                    break;
                    case "-":
                    stack.Push((first - second).ToString());
                    break;
                 }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
