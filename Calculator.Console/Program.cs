using System;

namespace Calculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            new CalculatorConsole(new RealConsole()).Start();
        }
    }
}
