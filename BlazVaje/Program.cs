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
            int x;
            Console.WriteLine("Enter a number X: ");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Enter a number Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            int z;
            Console.WriteLine("Enter a number Z: ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x * y * z);
            Console.Read();
        }
    }
}
