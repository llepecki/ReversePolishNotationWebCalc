using Lepecki.Playground.Camlc.Engine.Tokens;
using NUnit.Framework;
using System.Collections.Generic;

namespace Lepecki.Playground.Camlc.Engine.Test.Tokens
{
    [TestFixture(TestOf = typeof(NegationOperatorToken))]
    public class NegateOperatorTokenTest
    {
        [TestCase(3, ExpectedResult = -3)]
        public decimal OperatorShouldPushCorrectResultToStack(decimal a)
        {
            var stack = new Stack<decimal>();
            stack.Push(a);

            var operatorToken = new NegationOperatorToken();
            operatorToken.PushOrCalculate(stack);

            return stack.Pop();
        }
    }
}
