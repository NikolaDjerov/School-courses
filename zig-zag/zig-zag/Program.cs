using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zig_zag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr= new int[n];
            int[] secondArr= new int[n];

            for(int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
                if(i%2==0)
                {
                    secondArr[i-1] = arr[0];
                    firstArr[i-1] = arr[1];
                }
                else
                {
                    secondArr[i-1]= arr[1];
                    firstArr[i-1]= arr[0];
                }
            }
        }
    }
}
