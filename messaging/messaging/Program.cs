using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();
            string message = Console.ReadLine();
            for (int i = 0; i < num.Count; i++)
            {
                int number = num[i];
                int index = CalculateIndex(number);
                char currentChar = GetCharFromMessage(index, message);
                Console.Write(currentChar);
                int realIndex = CalculateRealIndex(index, message);
                string newMessage = message.Remove(realIndex, 1);
                message = newMessage;
            }
            Console.WriteLine();
        }

        static int CalculateIndex(int number)
        {
            int index = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                index += currentNumber;
                number /= 10;
            }
            return index;
        }
        static char GetCharFromMessage(int index, string message)
        {
            int countIndex = 0;
            for (int i = 0; i < index; i++)
            {
                countIndex++;
                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }
            char currentChar = message[countIndex];
            return currentChar;
        }
        static int CalculateRealIndex(int index, string message)
        {
            int countIndex = 0;
            for (int i = 0; i < index; i++)
            {
                countIndex++;
                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }
            return countIndex;
        }
    }
}
