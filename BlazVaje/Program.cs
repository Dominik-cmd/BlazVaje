using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazVaje
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            int z = x;
            x = y;
            y = z;
            Console.WriteLine("X {0}, Y {1}", x, y);
            Console.Read();
        }
    }
}
