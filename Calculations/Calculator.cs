using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
