using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
