using System;

namespace Calculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            char operationChoice;

            do
            {
                ShowMenu();
                operationChoice = GetOperation();
            } while (operationChoice == '\0');

            switch (operationChoice)
            {
                case '+':
                    {
                        var calculator = new Engine.Calculator();
                        int result = calculator.Sum(IntroduceOperand('a'), IntroduceOperand('b'));
                        ShowAsResult(result);
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Upss... Invalid or unimplemented operation.");
                        break;
                    }
            }
        }

        private static void ShowAsResult(int result)
        {
            System.Console.WriteLine("Result: " + result);

        }

        private static char GetOperation()
        {
            char tempChar;
            char.TryParse(System.Console.ReadLine(), out tempChar);
            return tempChar;
        }

        private static void ShowMenu()
        {
            System.Console.WriteLine("Plese select operation:");
            System.Console.WriteLine("+ (Adding)");
        }

        private static int IntroduceOperand(char operand)
        {
            System.Console.WriteLine("Plese introduce operand " + operand + ":");
            int.TryParse(System.Console.ReadLine(), out int a);
            return a;
        }
    }
}
