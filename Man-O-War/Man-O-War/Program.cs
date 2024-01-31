using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirate = Console.ReadLine()
            .Split(">")
            .Select(int.Parse)
            .ToList();
            List<int> war = Console.ReadLine()
            .Split(">")
            .Select(int.Parse)
            .ToList();
            int health = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] a = command.Split(' ').ToArray();
                if (a[0] == "Fire")
                {
                    int n = int.Parse(a[1]);
                    int fire = int.Parse(a[2]);
                    if (n >= 0 && n < war.Count)
                    {
                        war[n] -= fire;
                        if (war[n] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                if (a[0] == "Defend")
                {
                    int firstIndex = int.Parse(a[1]);
                    int lastIndex = int.Parse(a[2]);
                    int dmg = int.Parse(a[3]);
                    if (firstIndex >= 0 && firstIndex < pirate.Count && lastIndex >= 0 && lastIndex < pirate.Count && dmg >= 0)
                    {
                        for (int i = firstIndex; i <= lastIndex; i++)
                        {
                            int index = i;
                            pirate[index] -= dmg;
                            if (pirate[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                if (a[0] == "Repair")
                {
                    int healIndex = int.Parse(a[1]);
                    int heal = int.Parse(a[2]);
                    if (healIndex >= 0 && healIndex < pirate.Count && heal >= 0)
                    {
                        pirate[healIndex] += heal;
                        if (pirate[healIndex] > health)
                        {
                            pirate[healIndex] = health;
                        }
                    }
                }
                if (a[0] == "Status")
                {
                    int broken = 0;
                    double lowH = health - (health * 0.8);
                    for (int i = 0; i < pirate.Count; i++)
                    {
                        if (lowH > pirate[i])
                        {
                            broken++;
                        }
                    }
                    Console.WriteLine($"{broken} sections need repair.");
                }
            }
            int pirateResult = 0;
            int warResult = 0;
            for (int i = 0; i < pirate.Count; i++)
            {
                pirateResult += pirate[i];
            }
            Console.WriteLine($"Pirate ship status: {pirateResult}");
            for (int i = 0; i < war.Count; i++)
            {
                warResult += war[i];
            }
            Console.WriteLine($"Warship status: {warResult}");
        }
    }
}
