using LAR.Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAR.Calculator.UserPrompter
{
    public class UserPrompterContext
    {
        public UserPrompterState State { get; set; }

        public OperationContext OperationContext { get; set; }

        public UserPrompterContext()
        {
            State = new InitialState();
        }

        public void PromptUser()
        {
            State.PromptUser();
        }

        public void EvaluateStateAndPromptUser()
        {
            if (State.ShouldMoveForward(OperationContext))
            {
                State = State.GetNextState();
                State.PromptUser();
            }
            else
            {
                State.PromptUserWithError();
            }
        }
    }
}
