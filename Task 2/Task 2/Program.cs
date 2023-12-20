using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            List<int> order = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
            int quanity = int.Parse(Console.ReadLine());
            Queue<int> order1 = new Queue<int>(order);
            int order2 = order.Max();
            while (order1.Count > 0)
            {
                int currentOrder = order1.Dequeue();
                if (quanity >= currentOrder)
                {
                    quanity -= currentOrder;
                }
                else
                {
                    order1.Enqueue(currentOrder);
                    break;
                }
            }
            if (order1.Count == 0)
            {
                Console.WriteLine(order2);
                Console.WriteLine("All orders are completed");
            }
            else
            {
                string orderN = string.Join(" ", order1);
                Console.WriteLine(order2);
                Console.WriteLine($"Orders left: {orderN}");
            }
        }
    }
}

