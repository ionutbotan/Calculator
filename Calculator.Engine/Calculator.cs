using System;

namespace Calculator.Engine
{
    public class Calculator
    {
        public int Sum(int firstOperand, int secondOperand)
        {
            long result = (long)firstOperand + secondOperand;
            if (result > int.MaxValue || result < int.MinValue)
                throw new ResultOutOfBound();

            return (int)result;
        }
        public class ResultOutOfBound : Exception { };
    }

}
