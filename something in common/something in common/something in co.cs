using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something_in_common
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[]array2= Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            
            foreach(string item1 in array1) 
            {
                foreach(string item2 in array2)
                {
                    if (item1 == item2)
                    {
                        
                        Console.WriteLine($"{array1} {array2}");
                    }
                }
            }
        }
    }
}
