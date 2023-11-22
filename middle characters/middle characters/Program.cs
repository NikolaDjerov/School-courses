using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace middle_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Check(name);
        }
        static void Check(string name)
        {
            int length = name.Length;
            if(name.Length % 2 == 0)
            {
                int even = (int)Math.Ceiling((double)(length / 2))-1;
                int even1 = (int)Math.Ceiling((double)(length / 2));
                Console.WriteLine($"{name[even]}{name[even1]}");
            }
            else
            {
                int odd = (int)Math.Ceiling((double)(length / 2));
                Console.WriteLine(name[odd]);
            }
        }
    }
}
