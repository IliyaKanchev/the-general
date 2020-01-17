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

        private bool ExpectedInRange(int x, int y)
        {
            return (0 <= x && x <= 200) && (0 <= y && y <= 300);
        }

        private bool ExpectedAttackSuccesful(int x, int y)
        {
            return ((x + y - 5) % 2 == 0) && ExpectedInRange(x, y);
        }

        private bool ExpectedDefenceSuccesful(int x, int y)
        {
            return ((x * y - 5) % 2 == 0) && ExpectedInRange(x, y);
        }

        [Test()]
        public void TestAttack()
        {
            int x = 100;
            int y = 100;
            bool expected = ExpectedAttackSuccesful(x, y);

            Assert.AreEqual(expected, _calc.IsAttackSuccesful(x, y));
        }

        [Test()]
        public void TestDefend()
        {
            int x = 100;
            int y = 100;
            bool expected = ExpectedDefenceSuccesful(x, y);

            Assert.AreEqual(expected, _calc.IsDefenceSuccesful(x, y));
        }
    }
}
