using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.Operations
{
    public class SumOperation : IOperation
    {
        public int Execute(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
