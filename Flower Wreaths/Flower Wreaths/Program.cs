using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Wreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] roses = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> liliesStack = new Stack<int>(lilies);
            Queue<int> rosesQueue = new Queue<int>(roses);

            int wreaths = 0;
            int flowersLeft = 0;
            int operations = liliesStack.Count();
            for (int i = 0; i < operations; i++)
            {
                int lilie = liliesStack.Peek();
                int rose = rosesQueue.Peek();
                if (lilie + rose == 15)
                {
                    wreaths++;
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                }
                else if (lilie + rose > 15)
                {
                    while (true)
                    {
                        lilie -= 2;
                        if (lilie + rose == 15)
                        {
                            wreaths++;
                            liliesStack.Pop();
                            rosesQueue.Dequeue();
                            break;
                        }
                        else if (lilie + rose < 15)
                        {
                            flowersLeft += lilie + rose;
                            liliesStack.Pop();
                            rosesQueue.Dequeue();
                            break;
                        }
                    }
                }
                else
                {
                    flowersLeft += lilie + rose;
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                }
            }
            if (flowersLeft >= 15)
            {
                var leftOvers = flowersLeft / 15;
                wreaths += leftOvers;
            }
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
