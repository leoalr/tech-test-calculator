using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.Operations
{
    public class OperationContext
    {
        public int? FirstOperand { get; set; }

        public int? SecondOperand { get; set; }

        public IOperation Operation { get; set; }

        public int ExecuteOperation()
        {
            if (!FirstOperand.HasValue || !SecondOperand.HasValue)
                throw new InvalidOperationException("Both operands must have values to execute the operation.");

            return Operation.Execute(FirstOperand.Value, SecondOperand.Value);
        }
    }
}
