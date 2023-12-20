using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drum_set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> price = new List<int>();
            price.AddRange(drums);

            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "Hit it again, Gabsy!") break;
                int hit = int.Parse(command);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= hit;
                    if (drums[i] <= 0)
                    {
                        if (money - (price[i] * 3) >= 0)
                        {
                            money = money - (price[i] * 3);
                            drums[i] = price[i];
                        }
                    }
                }
                for (int i = 0; i < drums.Count; i++)
                {
                    if (drums[i] <= 0)
                    {
                        drums.Remove(drums[i]);
                        price.Remove(price[i]);
                    }
                }
            }
            foreach (var drum in drums)
            {
                Console.Write(drum + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}