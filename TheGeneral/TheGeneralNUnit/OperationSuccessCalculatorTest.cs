using NUnit.Framework;
using System;
using TheGeneralCore;

namespace TheGeneralNUnit
{
    [TestFixture()]
    public class OperationSuccessCalculatorTest
    {
        private OperationSuccessCalculator _calc;

        public OperationSuccessCalculatorTest()
        {
            _calc = new OperationSuccessCalculator();
        }

        [Test()]
        public void TestAttack()
        {
            Console.WriteLine("Hello World!");
        }

        [Test()]
        public void TestDefend()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
