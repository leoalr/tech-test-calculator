using LAR.Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.UserPrompter
{
    public class InitialState : UserPrompterState
    {
        public override string StatePromptMessage
        {
            get
            {
                return "This is a calculator." + Environment.NewLine +
                        "Please type an operand number and press <enter>." + Environment.NewLine +
                        "Operand number: ";
            }
            protected set { }
        }

        public override string StateErrorMessage
        {
            get
            {
                return Environment.NewLine +
                    "The operand must be a number." + Environment.NewLine;
            }
            protected set { }
        }

        public override bool ShouldMoveForward(OperationContext operationContext)
        {
            return operationContext.FirstOperand.HasValue;
        }

        public override UserPrompterState GetNextState()
        {
            return new FirstOperandState();
        }
    }
}
