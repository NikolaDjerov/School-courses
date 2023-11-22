using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            Char(first, second);
        }
        static void Char(char first, char second)
        {
            char startChar;
            char endChar;

            if(first < second)
            {
                startChar = first;
                endChar = second;
            }
            else
            {
                endChar = first;
                startChar = second;
            }
            for(char i = ++startChar; i < endChar; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
