using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double max = double.MaxValue;
            int Maxattendances = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                int Minattendances = int.Parse(Console.ReadLine());
                double currentBonus = (Minattendances / (double)numberOfLectures) * (5 + additionalBonus);
                if (currentBonus > max)
                {
                    max = currentBonus;
                    Maxattendances = Minattendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(max)}.");
            Console.WriteLine($"The student has attended {Maxattendances} lectures.");
        }
    }
}
