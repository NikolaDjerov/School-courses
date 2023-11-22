using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Palindrom()
        {
            while (true)
            {
                string num = Console.ReadLine();
                if (num == "END")
                {
                    break;
                }
                char[] chars = num.ToCharArray();
                string reverse = String.Empty;
                for (int i = chars.Length - 1; i > -1; i--)
                {
                    reverse += chars[i];
                }
                if (reverse == num)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
