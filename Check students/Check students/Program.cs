using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string>name = Console.ReadLine()
            .Split(',')
            .ToList();
            for (int i = 0; i < n; i++)
            {
                string[] student = Console.ReadLine()
                .Split(',')
                .ToList();
                if (student[2] == "not")
                {
                    if (student.Contains(student[0])) 
                    {
                        Console.Write(student[0]);
                        Console.WriteLine($"{student} is already in the list!");
                    }
                }
                if (student[2] == " is not")
                {
                    if (student.Contains(student[0]))
                    {
                        Console.Write(student[0]);
                        Console.WriteLine($"{student} is not in the list!");
                    }
                }
            }
        }
    }
}
