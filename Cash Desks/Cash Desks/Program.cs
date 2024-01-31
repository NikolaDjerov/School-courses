using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Desks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transactionCount = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int clients = int.Parse(Console.ReadLine());
            int transaction = transactionCount[0] + transactionCount[1] + transactionCount[2];
            int time = 0;
            while (true)
            {
                if (clients <= 0)
                {
                    break;
                }
                clients -= time;
                time++;
                if (time % 4 == 0)
                {
                    time++;
                }
               
            }
            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
