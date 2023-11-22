using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
           .Split(',')
           .Select(int.Parse)
           .ToList();
            num.RemoveAll(x => x < 0);
            if(num.Count == 0) 
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", num));
            }
        }
    }
}
