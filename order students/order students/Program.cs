using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            List<int> r = Groups(n);
            Result(r);
        }
        static List<int> Groups(string n)
        {
            string[] group = n.Split('|');
            List<int> r = new List<int>();
            for (int i = group.Length - 1; i >= 0; i--)
            {
                int[] nums = GetNum(group[i]);
                r.AddRange(nums);
            }
            return r;
        }
        static int[] GetNum(string group)
        {
            return group
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        static void Result(List<int> r)
        {
            Console.WriteLine(string.Join(" ", r));
        }
    }
    }

