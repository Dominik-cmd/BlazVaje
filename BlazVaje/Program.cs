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
            List<string> myStrings = new List<string>(new string[] {"First", "Second", "Third", "Fourth"});
            List<int> myInts = new List<int>();
    

            for (int i = 0; i <= 3; i++)
            {
                Console.Write("Enter the {0} number: ", myStrings[i]);
                myInts.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Write(myInts.Average());
            Console.Read();
        }
    }
}
