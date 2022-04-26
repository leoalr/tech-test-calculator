using LAR.Calculator.InputExpressions;
using LAR.Calculator.Interpreters;
using LAR.Calculator.Operations;
using LAR.Calculator.UserPrompter;
using System;
using System.Collections.Generic;

namespace LAR.Calculator
{
    public class CalculatorProgram
    {
        public UserPrompterContext UserPrompter { get; set; }
        public List<InputExpression> InputExpressions { get; set; }
        private readonly InputInterpreter InputInterpreter;

        public CalculatorProgram()
        {
            UserPrompter = new UserPrompterContext();
            InputExpressions = new List<InputExpression>();
            InputInterpreter = new InputInterpreter();
        }

        public void Execute()
        {
            Start();
            while (true)
            {
                RunRoutine();
            }
        }

        public void Start()
        {
            UserPrompter.PromptUser();
        }

        public void RunRoutine()
        {
            var inputExpression = InputInterpreter.Interpret(Console.ReadLine());

            if (inputExpression != null)
            {
                InputExpressions.Add(inputExpression);
            }

            UserPrompter.OperationContext = OperationContextBuilder.TryToBuild(InputExpressions);

            UserPrompter.EvaluateStateAndPromptUser();
        }
    }
}
