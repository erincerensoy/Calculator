using Calculations;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();
            Console.WriteLine(c.Add(3, 4));

            Console.ReadLine();
        }
    }
}
