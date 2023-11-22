using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>num = Console.ReadLine()
            .Split(',')
            .Select(int.Parse)
            .ToList();
            List<string>word = Console.ReadLine()
            .Split(',')
            .ToList();
            int sum = num.Sum();
            while(word.Count < sum)
            {
                word.AddRange(word);
            }
        }
    }
}
