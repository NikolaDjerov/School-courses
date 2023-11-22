using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Cafeteria(product, count);
        }
        static void Cafeteria(string product, int count)
        {
            
            double price = 1;
            if(product == "water")
            {
                price = price * 1.00;
            }
           if(product == "coke")
            {
                price = price * 1.40;
            }
           if(product == "coffee")
            {
                price = price * 1.50;
            }
           if(product == "snacks")
            {
                price = price * 2.00;
            }
            price = price * count;
           Console.WriteLine($"{price:F2}");
        }
    }
}
