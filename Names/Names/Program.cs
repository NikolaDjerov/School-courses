using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> name= new List<string>();

            for (int i = 0; i < n; i++)
            {
                name.Add(Console.ReadLine());
            }
            name.Sort();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{name[i]}");
            }
        }
    }
}
