using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worm_and_holes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wormSize = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
            List<int> holeSize = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
            while(wormSize.Count >= 0)
            {
                if(wormSize.Count > 0)
                {

                }
            }
            if(wormSize.Count < 0)
            {

            }
        }
    }
}
