using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintInWords(grade);
        }
        static void PrintInWords(double grade)
        {
            string gradeInWords = string.Empty;
            if(grade >= 2 && grade <= 2.99)
            {
                gradeInWords = "Fail";
            }
            if(grade >= 3 && grade <= 3.49)
            {
                gradeInWords = "Poor";
            }
            if(grade >= 3.50 && grade <= 4.49)
            {
                gradeInWords = "Good";
            }
            if(grade >= 4.50 && grade <= 5.49)
            {
                gradeInWords = "Very good";
            }
            if(grade >= 5.50 && grade <= 6)
            {
                gradeInWords = "Excellent";
            }

            Console.WriteLine(gradeInWords);
        }
    }
}
