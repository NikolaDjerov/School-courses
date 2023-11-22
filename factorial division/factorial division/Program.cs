using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            double num1 = Factoriel(n1);
            double num2 = Factoriel2(n2);
            double fullnum = num1 / num2;
            Console.WriteLine($"{fullnum:F2}");
        }

        static int Factoriel(int n1)
        {
            int factoriel = 1;
            for (int i = 1; i <= n1; i++)
            {
                factoriel = factoriel * i;
            }
            int factoriel1 = factoriel;
            return factoriel1;
        }
        static int Factoriel2(int n2)
        {
            int factoriel = 1;

            for (int i = 1; i <= n2; i++)
            {
                factoriel = factoriel * i;
            }

            int factoriel2 = factoriel;

            return factoriel2;
        }
    }
}
