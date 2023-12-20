using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string>queue = new Queue<string>();
            while (true)
            {
                queue.Enqueue(name);
                name = Console.ReadLine();              
                if (name == "Paid")
                {               
                    while(queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else if (name == "End")
                {
                    queue.Enqueue(name);
                }
            }

            Console.WriteLine($"{queue.Count}people remaining");
            
        }
        
    }
}
