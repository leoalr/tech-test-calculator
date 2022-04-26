using LAR.Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.UserPrompter
{
    public class SecondOperandState : UserPrompterState
    {
        public override bool IsFinalState { get { return true; } }

        public static string StatePromptMessage = Environment.NewLine + "Good!" + Environment.NewLine +
                "Please type an operand number and press <enter>." + Environment.NewLine +
                "Operand number: ";

        public static string StateErrorMessage = Environment.NewLine +
            "The operand must be a number." + Environment.NewLine;

        public override UserPrompterState GetNextState()
        {
            throw new NotImplementedException();
        }

        public override void PromptUser()
        {
            Console.Write(StatePromptMessage);
        }

        public override void PromptUserWithError()
        {
            Console.Write(StateErrorMessage + StatePromptMessage);
        }

        public override bool ShouldMoveForward(OperationContext operationContext)
        {
            return operationContext.FirstOperand.HasValue && operationContext.Operation != null;
        }
    }
}
