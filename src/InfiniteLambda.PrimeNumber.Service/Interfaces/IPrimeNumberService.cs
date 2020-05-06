namespace InfiniteLambda.PrimeNumber.Service.Interfaces
{
    public interface IPrimeNumberService
    {
        bool CheckWhetherPrimeNumber(int number);

        int GetNextPrimeNumber(int number);
    }
}
