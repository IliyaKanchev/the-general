
namespace TheGeneralCore
{

    public class OperationSuccessCalculator : IOperationSuccessCalculator
    {
        // I think this also should apply to the attack/defence calculation.
        private bool IsInRange(int x, int y)
        {
            return (0 <= x && x <= 200) && (0 <= y && y<= 300);
        }

        public bool IsAttackSuccesful(int x, int y)
        {
            return ((x + y - 5) % 2 == 0) && IsInRange(x, y);
        }

        public bool IsDefenceSuccesful(int x, int y)
        {
            return ((x * y - 5) % 2 == 0) && IsInRange(x, y);
        }
    }
}
