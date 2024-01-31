using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plunderDays = int.Parse(Console.ReadLine());
            int plunderForDay = int.Parse(Console.ReadLine());
            double goalPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;
            for (int i = 1; i <= plunderDays; i++)
            {
                totalPlunder += (double)plunderForDay;

                if (i % 3 == 0)
                {
                    totalPlunder += plunderForDay * 0.5;
                }
                else if (i % 5 == 0)
                {
                    totalPlunder *= 0.7;
                }
            }
            if (goalPlunder <= totalPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {totalPlunder / goalPlunder * 100:f2}% of the plunder.");
            }
        }
    }
}
