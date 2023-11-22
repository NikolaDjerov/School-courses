using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printing_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        void PrintLine(int start, int end)
        {
            for(int i = start; i <= end; i++) 
            {
                Console.WriteLine(i + "");
            }
            Console.WriteLine();
        }
        void Triangle(int start, int end, int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }

        
    }
}
