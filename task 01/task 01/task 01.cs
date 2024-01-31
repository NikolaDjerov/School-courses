using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItem = Console.ReadLine();
            int rightCheap = 0;
            int leftCheap = 0;
            int rightExp = 0;
            int leftExp = 0;
            int number = priceRatings[entryPoint];
            for (int i = 0; i < priceRatings.Length; i++)
            {
                if (typeOfItem == "expensive")
                {
                    if (priceRatings[i] >= number)
                    {
                        if (i > entryPoint)
                            rightExp = rightExp + priceRatings[i];
                        if (i < entryPoint)
                            leftExp = leftExp + priceRatings[i];
                    }
                }
                if (typeOfItem == "cheap")
                {
                    if (priceRatings[i] < number)
                    {
                        if (i > entryPoint)
                            rightCheap = rightCheap + priceRatings[i];
                        if (i < entryPoint)
                            leftCheap = leftCheap + priceRatings[i];
                    }
                }

            }
            if (typeOfItem == "expensive")
            {
                if (leftExp >= rightExp)
                {
                    Console.WriteLine($"Left - {leftExp}");
                }
                else
                {
                    Console.WriteLine($"Right - {rightExp}");
                }
            }
            if (typeOfItem == "cheap")
            {
                if (leftCheap >= rightCheap)
                {
                    Console.WriteLine($"Left - {leftCheap}");
                }
                else
                {
                    Console.WriteLine($"Right - {rightCheap}");
                }
            }
        }
    }
}