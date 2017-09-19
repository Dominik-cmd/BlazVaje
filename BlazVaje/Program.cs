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
            Console.Write("Enter a digit: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                    for (int j = 0; j <= 3; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("{0} ", num);
                        }
                        else
                        {
                            Console.Write("{0}", num);
                        }
                    }
                Console.WriteLine();
            }
            Console.ReadKey();

            //List<string> myStrings = new List<string>(new string[] {"First", "Second", "Third", "Fourth"});
            //List<int> myInts = new List<int>();
    

            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.Write("Enter the {0} number: ", myStrings[i]);
            //    myInts.Add(Convert.ToInt32(Console.ReadLine()));
            //}

            //Console.Write(myInts.Average());
            //Console.Read();
        }
    }
}
