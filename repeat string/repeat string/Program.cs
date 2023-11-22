using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        string NewText(string text, double n) 
        {
            string result = "";
            for(int i = 0; i < n; i++)
            {
                result = result + text;  
            }
            return result;
             Console.Write(result);
        }

    }
}
