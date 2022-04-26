using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.Operations
{
    public interface IOperation
    {
        int Execute(int firstOperand, int secondOperand);
    }
}
