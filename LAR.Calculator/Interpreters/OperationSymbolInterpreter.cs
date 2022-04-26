using LAR.Calculator.InputExpressions;
using LAR.Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.Interpreters
{
    public class OperationSymbolInterpreter : IInterpreter
    {
        public InputExpression Interpret(string input)
        {
            return input switch
            {
                "+" => new OperationSymbolExpression(OperationEnum.Sum),
                "-" => new OperationSymbolExpression(OperationEnum.Subtraction),
                _ => null,
            };
        }
    }
}
