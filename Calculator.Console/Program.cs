using System;

namespace Calculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            int result = 0;
            char operationChoice = '\0';

            Menu(ref operationChoice);

            switch (operationChoice)
            {
                case '+':
                    {
                        IntroduceOperands(ref a, ref b);
                        var calculator = new Engine.Calculator();
                        result = calculator.Add(a, b);
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Upss... Invalid or unimplemented operation.");
                        break;
                    }
            }

            System.Console.WriteLine("Result: " + result);
        }

        private static void Menu(ref char operationChoice)
        {
            do
            {
                System.Console.WriteLine("Plese select operation:");
                System.Console.WriteLine("+ (Adding)");

                char.TryParse(System.Console.ReadLine(), out operationChoice);
            } while (operationChoice == '\0');
        }

        private static void IntroduceOperands(ref int a, ref int b)
        {
            System.Console.WriteLine("Plese introduce operand a:");
            int.TryParse(System.Console.ReadLine(), out a);
            System.Console.WriteLine("Plese introduce operand b:");
            int.TryParse(System.Console.ReadLine(), out b);
        }
    }
}
