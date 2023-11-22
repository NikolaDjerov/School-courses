using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = GetIntList();
            int capacity = int.Parse(Console.ReadLine());
            string[] command = GetStringArr();
            while (command[0]?.ToLower() != "end")
            {
                switch(command[0]?.ToLower())
                {
                    case "add":
                        train.Add(int.Parse(command[1]));
                        break;
                    default:
                        AddNumberToListElement(train, capacity, command[0]);
                        break;
                }
                command= GetStringArr();
            }
            Console.WriteLine(String.Join(" ", train));
        }
        static List<int>GetIntList()
        {
            return Console.ReadLine()
            .Split(',')
            .Select(int.Parse)
            .ToList();
        }
        static string[] GetStringArr()
        {
            return Console.ReadLine()
            .Split(',')
            .ToArray();
        }
        static List<int> AddNumberToListElement(List<int> list, int capacity, string num)
        {
            int convertedNumber = int.Parse(num);
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] + convertedNumber <= capacity)
                {
                    list[i] += capacity;
                }
            }
            return list;
        }
    }
}
