using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>time = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
            double left = 0;
            double right = 0;
            for(int i = 0; i < time.Count/2; i++)
            {
                left += time[i];
                if (time[i] == 0)
                {
                    left *= 0.8;
                }
            }
            for(int i = time.Count - 1; i > time.Count/2; i--)
            {
                right += time[i];
                if (time[i] == 0)
                {
                    right *= 0.8;
                }
            }
            if(left > right)
            {
                Console.WriteLine($"The wiiner is right with total time: {right}");
            }
            else
            {
                Console.WriteLine($"The wiiner is left with total time: {left}");
            }
        }
    }
}
