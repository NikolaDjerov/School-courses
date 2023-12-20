using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_text_editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty; 
            Stack<string> states = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split();
                if (commands[0] == "1")
                {
                    states.Push(text);
                    text += commands[1];
                }
                if (commands[0] == "2")
                {
                    states.Push(text);
                    int count = int.Parse(commands[1]);
                    text = text.Substring(0, text.Length - count);
                }
                if (commands[0] == "3")
                {
                    int index = int.Parse(commands[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                if (commands[0] == "4")
                {
                    text = states.Pop();
                }
            }
        }
    }
}
