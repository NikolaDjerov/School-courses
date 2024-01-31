﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasure_hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> steal = new List<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Yohoho!")
                {
                    break;
                }
                string[] token = command.Split();
                string word = token[0];
                if (word == "Loot")
                {
                    for (int i = 1; i < token.Length; i++)
                    {
                        if (!treasure.Contains(token[i]))
                        {
                            treasure.Insert(0, token[i]);
                        }
                    }
                }
                else if (word == "Drop")
                {
                    int index = int.Parse(token[1]);
                    if (index >= 0 && index < treasure.Count)
                    {
                        string removedItem = treasure[index];
                        treasure.RemoveAt(index);
                        treasure.Add(removedItem);
                    }
                }
                else if (word == "Steal")
                {
                    int count = int.Parse(token[1]);
                    if (count < treasure.Count)
                    {
                        for (int i = treasure.Count - count; i < treasure.Count; i++)
                        {
                            steal.Add(treasure[i]);
                        }
                        Console.WriteLine(string.Join(", ", steal));
                        steal.Clear();
                        treasure.RemoveRange(treasure.Count - count, count);
                    }
                    else
                    {
                        for (int i = 0; i < treasure.Count; i++)
                        {
                            steal.Add(treasure[i]);
                        }
                        Console.WriteLine(string.Join(", ", steal));

                        steal.Clear(); 

                        treasure.RemoveRange(0, treasure.Count);
                    }
                }
            }
            double sum = 0;
            double avarage = 0;
            foreach (var item in treasure)
            {
                sum = sum + item.Length;
            }
            if (treasure.Count != 0)
            {
                avarage = sum / treasure.Count;

                Console.WriteLine($"Average treasure gain: {avarage:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
