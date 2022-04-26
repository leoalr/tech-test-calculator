using LAR.Calculator.InputExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.Interpreters
{
    public interface IInterpreter
    {
        InputExpression Interpret(string input);
    }
}
