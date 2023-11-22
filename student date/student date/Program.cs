using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());
            GetStudentData(name, grade);
        }
        static void GetStudentData(string name, int grade)
        {
            Console.WriteLine($"{name} is studying in {grade} grade.");
        }
    }
}
