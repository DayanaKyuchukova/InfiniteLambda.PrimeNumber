using InfiniteLambda.PrimeNumber.Service.Interfaces;

namespace InfiniteLambda.PrimeNumber.Service.Services
{
    public class PrimeNumberService : IPrimeNumberService
    {
        public bool CheckWhetherPrimeNumber(int number)
            => IsPrimeNumber(number);

        public int GetNextPrimeNumber(int number)
        {
            while (!IsPrimeNumber(number))
            {
                number++;
            }

            return number;
        }

        private bool IsPrimeNumber(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
