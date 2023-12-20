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
            int numStudents = int.Parse(Console.ReadLine());
            int totalLectures = int.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());
            string maxStudent = "";
            double maxBonus = 0;
            for (int i = 0; i < numStudents; i++)
            {
                int studentAttendance = int.Parse(Console.ReadLine());
                double bonus = (studentAttendance / (double)totalLectures) * (5 + additionalBonus);
                if (bonus > maxBonus)
                {
                    maxBonus = bonus;
                    maxStudent = $"The student has attended {studentAttendance} lectures";
                }
            }
            maxBonus = Math.Ceiling(maxBonus);

            Console.WriteLine($"Max Bonus: {maxBonus}. {maxStudent}");
        }
    }
}
