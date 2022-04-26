using LAR.Calculator.InputExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.Interpreters
{
    public class OperandInterpreter : IInterpreter
    {
        public InputExpression Interpret(string input)
        {
            try
            {
                int parsedInput = int.Parse(input);
                return new OperandExpression(parsedInput);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
