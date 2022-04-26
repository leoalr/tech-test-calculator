using LAR.Calculator.InputExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.Interpreters
{
    public class InputInterpreter
    {
        public List<IInterpreter> Interpreters { get; set; }

        public InputInterpreter()
        {
            Interpreters = new List<IInterpreter>();
            Interpreters.Add(new OperandInterpreter());
            Interpreters.Add(new OperationSymbolInterpreter());
        }

        public InputExpression Interpret(string input)
        {
            InputExpression interpretedExpression = null;

            foreach (var interpreter in Interpreters)
            {
                interpretedExpression = interpreter.Interpret(input);
                if (interpretedExpression != null)
                    break;
            }

            return interpretedExpression;
        }
    }
}
