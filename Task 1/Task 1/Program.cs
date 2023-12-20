using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
            List<int> s = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
            Stack<int> x = new Stack<int>(s);
            int index = n[1];
            for (int i = 0; i < index; i++)
            {
                x.Pop();
            }
            for (int i = 0; i < index; i++)
            {
                x.Push();         
                if (index == n[2])
                {
                    x.Pop();
                    Console.WriteLine("found");
                }
                else
                {
                    Console.WriteLine("nothing found");
                }
            }
        }
    }
}
