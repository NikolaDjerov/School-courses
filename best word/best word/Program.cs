using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace best_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string first = "";
            string last = "";
            Console.Write("Enter words separated by space: ");
            foreach (string word in words)
            {
                if (word.Contains("est"))
                {
                    string upperCaseWord = word.ToUpper();
                    if (word.Contains("B"))
                    {
                        if (first == "")
                        {
                            first = upperCaseWord;
                        }
                        last = upperCaseWord;
                    }
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(last);
        }
    }
    }

