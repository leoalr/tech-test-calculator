using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.Operations
{
    public static class OperationFactory
    {
        public static IOperation CreateOperation(OperationEnum operation)
        {
            return operation switch
            {
                OperationEnum.Sum => new SumOperation(),
                OperationEnum.Subtraction => new SubtractionOperation(),
                _ => null,
            };
        }
    }
}
