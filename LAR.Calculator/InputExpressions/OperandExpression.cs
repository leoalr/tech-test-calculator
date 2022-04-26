using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.InputExpressions
{
    public class OperandExpression : InputExpression
    {
        public int Operand { get; set; }

        public OperandExpression(int operand)
        {
            Operand = operand;
        }
    }
}
