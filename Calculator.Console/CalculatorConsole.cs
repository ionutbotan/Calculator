using System;

namespace Calculator.Console
{
    public class CalculatorConsole
    {
        private readonly IConsole _console;

        public CalculatorConsole(IConsole console)
        {
            _console = console;
        }

        public void Start()
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

        private char GetOperation()
        {
            char tempChar;
            char.TryParse(_console.ReadLine(), out tempChar);
            return tempChar;
        }

        private void ShowMenu()
        {
            _console.WriteLine("Please select operation:");
            _console.WriteLine("+ (Adding)");
        }

        private static int IntroduceOperand(char operand)
        {
            System.Console.WriteLine("Plese introduce operand " + operand + ":");
            int.TryParse(System.Console.ReadLine(), out int a);
            return a;
        }
    }
}