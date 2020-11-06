using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //making the same calculation in 3 different ways:

            int a = 5, b = 5;
            //string concratination using the plus sign
            Console.WriteLine(a + " + " + b + " = " + (a + b));

            //using the $ (the easiest way)
            Console.WriteLine($"{a} + {b} = {a + b}");

            //and using arguments
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b ));

            //read key from the console
            Console.Read();
        }
    }
}
