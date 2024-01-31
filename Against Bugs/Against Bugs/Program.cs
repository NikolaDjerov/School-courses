using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Against_Bugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] days = new int[plants.Length];
            Stack<int> stack = new Stack<int>();
            stack.Push(0); 
            for(int i = 1; i <= plants.Length; i++)
            {
                int maxDays = 0;
                while(stack.Count > 0 && plants[stack.Peek()] >= plants[1])
                {
                    maxDays = Math.Max(maxDays, days[stack.Pop()]);
                }
                if(stack.Count > 0)
                {
                    days[i] = maxDays + 1;
                }
                stack.Push(i);
            }
            Console.WriteLine(days.Max());
        }
    }
}
