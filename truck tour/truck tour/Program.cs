using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truck_tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < petrolPumps; i++)
            {
                int[] n = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray(); 
                int petrol = n[0];
                int distance = n[1];
                pumps.Enqueue(n);
            }
            int bestRoute = 0;
            while (true)
            {
                int totalPetrol = 0;
                foreach (int[] pump in pumps)
                {
                    totalPetrol += pump[0]; //1
                    int currentDistance = pump[1]; //5
                    if (totalPetrol - currentDistance < 0)
                    {
                        totalPetrol = 0;
                        break;
                    }
                    else
                    {
                        totalPetrol -= currentDistance;
                    }
                }
                if (totalPetrol > 0)
                {
                    break;
                }
                bestRoute++;
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(bestRoute);
        }
    }
}
