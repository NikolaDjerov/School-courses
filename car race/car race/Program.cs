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
            List<int> firstNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> newList = new List<int>();
            List<int> maxList = new List<int>();
            List<int> lastList = new List<int>();
            int firstNum = 0;
            int secondNum = 0;
            int last = 0;
            int previous = 0;
            if (firstNumber.Count > secondNumber.Count)
            {
                maxList = firstNumber;
            }
            else
            {
                maxList = secondNumber;
                maxList.Reverse();
            }
            for (int i = 0; i < maxList.Count; i++)
            {
                last = maxList[maxList.Count - 1];
                previous = maxList[maxList.Count - 2];
            }
            for (int i = 0; i < firstNumber.Count; i++)
            {
                newList.Add(firstNumber[i]);
            }
            newList.Remove(previous);
            newList.Remove(last);

            for (int i = 0; i < secondNumber.Count; i++)
            {
                newList.Add(secondNumber[i]);
            }
            if (previous > last)
            {
                firstNum = last;
                secondNum = previous;
            }
            else
            {
                secondNum = last;
                firstNum = previous;
            }
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] > firstNum && newList[i] < secondNum)
                {
                    lastList.Add(newList[i]);
                }
            }
            lastList.Sort();
            Console.WriteLine(string.Join(" ", lastList));
        }
    }
}
