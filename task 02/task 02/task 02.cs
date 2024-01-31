using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> steel = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); ;
            Queue<int> carbon = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); ;
            int totalNumberOfSwords = 0;
            steel.Peek();
            carbon.Peek();
            if(steel.Peek() + carbon.Peek() == 70)
            {
                totalNumberOfSwords++;
                steel.Pop();
                carbon.Dequeue();
                Console.WriteLine("Gladius");
            }
            if (steel.Peek() + carbon.Peek() == 80)
            {
                totalNumberOfSwords++;
                steel.Pop();
                carbon.Dequeue();
                Console.WriteLine("Shamshir");
            }
            if (steel.Peek() + carbon.Peek() == 90)
            {
                totalNumberOfSwords++;
                steel.Pop();
                carbon.Dequeue();
                Console.WriteLine("Katana");
            }
            if (steel.Peek() + carbon.Peek() == 110)
            {
                totalNumberOfSwords++;
                steel.Pop();
                carbon.Dequeue();
                Console.WriteLine("Sabre");
            }
            if (steel.Peek() + carbon.Peek() == 150)
            {
                totalNumberOfSwords++;
                steel.Pop();
                carbon.Dequeue();
                Console.WriteLine("Broadsword");
            }
            if(totalNumberOfSwords <= 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            else
            {
                Console.WriteLine($"You have forged {totalNumberOfSwords} swords.");
            }
            Console.WriteLine($"Steel left: {steel}");
            Console.WriteLine($"Carbon left: {carbon}");
        }
    }
}
