
namespace TheGeneralCore
{

    public class OperationSuccessCalculator : IOperationSuccessCalculator
    {

        public bool IsAttackSuccesful(int x, int y)
        {
            if ((x + y - 5) % 2 == 0) return true;

            return false;
        }

        public bool IsDefenceSuccesful(int x, int y)
        {
            if ((x * y - 5) % 2 == 0) return true;

            return false;
        }
    }
}
