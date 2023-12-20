using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] currentState = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            for(int i = 0; i < currentState.Length; i++)
            {
                while (currentState[i] < 4 && people  > 0)
                {
                    currentState[i]++;
                    people--;
                }
            }
            if(people == 0 && currentState[currentState.Length - 1] != 4)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine($"{String.Join(" ", currentState)}");
            }
            else if (currentState[currentState.Length-1] == 4 && people > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine($"{String.Join(" ", currentState)}");
            }
            else
            {
                Console.WriteLine($"{String.Join(" ", currentState)}");
            }
        }
    }
}
