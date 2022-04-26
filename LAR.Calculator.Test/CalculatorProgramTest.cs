using LAR.Calculator.InputExpressions;
using LAR.Calculator.UserPrompter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAR.Calculator.Test
{
    public class CalculatorProgramTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenTheApplicationStarts_TheUserIsPromptedForAnOperand()
        {
            var sut = new CalculatorProgram();
            var output = new StringWriter();
            Console.SetOut(output);

            sut.Start();

            Assert.AreEqual(InitialState.StatePromptMessage, output.ToString());
            
        }

        [Test]
        public void WhenTheUserEntersANumericValue_TheUserIsPromptedForAnOperation([Random(1)]int input)
        {
            var numericValueString = input.ToString();
            var sut = new CalculatorProgram();
            var inputReader = new StringReader(numericValueString);
            Console.SetIn(inputReader);
            var outputWriter = new StringWriter();
            Console.SetOut(outputWriter);

            sut.RunRoutine();

            Assert.AreEqual(FirstOperandState.StatePromptMessage, outputWriter.ToString());
        }

        [TestCase("P")]
        [TestCase("+")]
        [TestCase("-")]
        [TestCase("S")]
        [TestCase("*")]
        public void WhenTheUserEntersANonNumericValueForTheFirstOperand_HeReceivesAnErrorMessageAndHeIsPromptedAgain(string input)
        {
            var sut = new CalculatorProgram();
            var inputReader = new StringReader(input);
            Console.SetIn(inputReader);
            var outputWriter = new StringWriter();
            Console.SetOut(outputWriter);

            sut.RunRoutine();

            Assert.AreEqual(InitialState.StateErrorMessage + InitialState.StatePromptMessage, outputWriter.ToString());
        }

        [TestCase(5487, "+")]
        [TestCase(12, "-")]
        public void WhenTheUserEntersAnOperatorSymbolAfterEnteringTheFirstOperand_HeIsPromptedForAnOperandNumber(int firstOperand, string input)
        {
            var sut = new CalculatorProgram();
            sut.InputExpressions.Add(new OperandExpression(firstOperand));
            var inputReader = new StringReader(input);
            Console.SetIn(inputReader);
            var outputWriter = new StringWriter();
            Console.SetOut(outputWriter);

            sut.RunRoutine();

            Assert.AreEqual(OperationSymbolState.StatePromptMessage,
                outputWriter.ToString());
        }
    }
}
