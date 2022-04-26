using LAR.Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.UserPrompter
{
    public class FirstOperandState : UserPrompterState
    {
        public static string StatePromptMessage = Environment.NewLine + "Great! Now, please type the operation symbol: ";

        public static string StateErrorMessage = Environment.NewLine +
            "The operation symbol must be '+' or '-'." + Environment.NewLine;

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
