using LAR.Calculator.InputExpressions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LAR.Calculator.Operations
{
    public static class OperationContextBuilder
    {
        public static OperationContext TryToBuild(List<InputExpression> inputExpressions)
        {
            OperationContext operationContext = null;

            if (inputExpressions == null || inputExpressions.Count == 0)
                return operationContext;

            operationContext = new OperationContext();

            DefineOperation(operationContext, inputExpressions);

            DefineOperands(operationContext, inputExpressions);

            return operationContext;
        }

        private static void DefineOperation(OperationContext operationContext, List<InputExpression> inputExpressions)
        {
            OperationSymbolExpression operationSymbolExpression = inputExpressions.Find(ie => ie is OperationSymbolExpression) 
                as OperationSymbolExpression;

            if (operationSymbolExpression != null)
            {
                operationContext.Operation = OperationFactory.CreateOperation(operationSymbolExpression.Operation);
            }
        }

        private static void DefineOperands(OperationContext operationContext, List<InputExpression> inputExpressions)
        {
            var operandExpressions = inputExpressions.Where(ie => ie is OperandExpression).Select(ie => ie as OperandExpression);

            if (operandExpressions == null || operandExpressions.Count() == 0)
                return;

            if (operandExpressions.Count() == 1)
                operationContext.FirstOperand = operandExpressions.First().Operand;

            if (operandExpressions.Count() > 1)
                operationContext.SecondOperand = operandExpressions.Skip(1).First().Operand;
        }
    }
}