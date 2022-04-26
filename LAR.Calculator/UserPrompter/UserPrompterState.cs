using LAR.Calculator.Operations;
using System;

namespace LAR.Calculator.UserPrompter
{
    public abstract class UserPrompterState
    {
        public abstract string StatePromptMessage { get; protected set; }
        public abstract string StateErrorMessage { get; protected set; }

        public virtual bool IsFinalState { get { return false; } private set { } }

        public void PromptUser()
        {
            Console.Write(StatePromptMessage);
        }

        public void PromptUserWithError()
        {
            Console.Write(StateErrorMessage + StatePromptMessage);
        }

        public void AnswerUser(string calcResult)
        {
            Console.Write(string.Format(StatePromptMessage, calcResult));
        }

        public abstract bool ShouldMoveForward(OperationContext operationContext);

        public abstract UserPrompterState GetNextState();
    }
}