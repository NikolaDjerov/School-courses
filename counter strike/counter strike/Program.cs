using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter_strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string enemyDistance = string.Empty;
            int counter = 0;
            while ((enemyDistance = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(enemyDistance);
                if (n < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {n} energy");
                    return;
                }
                counter++;
                n -= distance;
                if (counter % 3 == 0)
                {
                    n += counter;
                }
            }
            Console.WriteLine($"Won battles: {counter}. Energy left: {n}");
        }
    }
}
