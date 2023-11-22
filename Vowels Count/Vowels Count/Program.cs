using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Vowels(word, count);
        }
        static void Vowels(string word, int count)
        {
            word = word.ToLower();
            if(word == "a")
            {
                count++;
            }
            if (word == "e")
            {
                count++;
            }
            if (word == "i")
            {
                count++;
            }
            if (word == "o")
            {
                count++;
            }
            if (word == "u")
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
