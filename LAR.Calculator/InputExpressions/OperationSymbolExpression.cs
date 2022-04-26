using LAR.Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.InputExpressions
{
    public class OperationSymbolExpression : InputExpression
    {
        public OperationEnum Operation { get; set; }

        public OperationSymbolExpression(OperationEnum operation)
        {
            Operation = operation;
        }
    }
}
