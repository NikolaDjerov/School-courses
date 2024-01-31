using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> item = Console.ReadLine().Split(", ").ToList();
            string[] command = Console.ReadLine().Split(" - ").ToArray();
            string[] items = new string[2];
            while (command[0] != "Craft!")
            {
                switch (command[0])
                {
                    case "Collect":
                        if (!item.Contains(command[1]))
                        {
                            item.Add(command[1]);
                        }
                        break;
                    case "Drop":
                        item.Remove(command[1]);
                        break;
                    case "Combine Items":
                        item = command[1].Split(":");
                        if (item.Contains(item[0]))
                        {
                            item.Insert(item.FindIndex(x => x == item[0]) + 1, item[1]);
                        }
                        break;
                    case "Renew":
                        if (item.Contains(command[1]))
                        {
                            item.Remove(command[1]);
                            item.Add(command[1]);
                        }
                        break;
                }
                command = Console.ReadLine().Split(" - ").ToArray();
            }
            Console.WriteLine(string.Join(", ", item));
        }
    }
}
