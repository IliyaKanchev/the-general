using NUnit.Framework;
using System;
using TheGeneralCore;

namespace TheGeneralNUnit
{
    [TestFixture()]
    public class OperationSuccessCalculatorTest
    {
        private IOperationSuccessCalculator _calc;

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
        public void TestAttackFalure()
        {
            int x = 100;
            int y = 100;
            bool expected = ExpectedAttackSuccesful(x, y);
            bool calculated = _calc.IsAttackSuccesful(x, y);

            Console.WriteLine("# attack falure: x: {0}, y: {1}, expected: {2}, calculated: {3}", x, y, expected, calculated);
            Assert.AreEqual(expected, calculated);
        }

        [Test()]
        public void TestAttackSuccess()
        {
            int x = 7;
            int y = 8;
            bool expected = ExpectedAttackSuccesful(x, y);
            bool calculated = _calc.IsAttackSuccesful(x, y);

            Console.WriteLine("# attack success: x: {0}, y: {1}, expected: {2}, calculated: {3}", x, y, expected, calculated);
            Assert.AreEqual(expected, calculated);
        }

        [Test()]
        public void TestDefendFailure()
        {
            int x = 100;
            int y = 100;
            bool expected = ExpectedDefenceSuccesful(x, y);
            bool calculated = _calc.IsDefenceSuccesful(x, y);

            Console.WriteLine("# defend falure: x: {0}, y: {1}, expected: {2}, calculated: {3}", x, y, expected, calculated);
            Assert.AreEqual(expected, calculated);
        }

        [Test()]
        public void TestDefendSuccess()
        {
            int x = 5;
            int y = 5;
            bool expected = ExpectedDefenceSuccesful(x, y);
            bool calculated = _calc.IsDefenceSuccesful(x, y);

            Console.WriteLine("# defend success: x: {0}, y: {1}, expected: {2}, calculated: {3}", x, y, expected, calculated);
            Assert.AreEqual(expected, calculated);
        }
    }
}
