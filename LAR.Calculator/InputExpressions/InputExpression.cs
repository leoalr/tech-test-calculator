using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.InputExpressions
{
    public class InputExpression
    {
        public string Input { get; set; }

        public InputExpression() { }

        public InputExpression(string input)
        {
            Input = input;
        }
    }
}
