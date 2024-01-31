using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace falling_rocks
{
    public class Rock
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }
        private char[] Representation =
              new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ',' };
        private Random random = new Random();
        public Rock(int x)
        {
            this.X = x;
            this.Y = 0;
            this.Symbol = Representation[random.Next(0, Representation.Length)];
        }
    }
}
