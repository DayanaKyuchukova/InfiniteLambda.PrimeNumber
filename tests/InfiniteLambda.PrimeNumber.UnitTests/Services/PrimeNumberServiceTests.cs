using InfiniteLambda.PrimeNumber.Service.Services;
using Xunit;

namespace InfiniteLambda.PrimeNumber.UnitTests.Services
{
    public class PrimeNumberServiceTests
    {
        private readonly PrimeNumberService primeNumberService;

        public PrimeNumberServiceTests()
        {
            this.primeNumberService = new PrimeNumberService();
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(4, false)]
        public void CheckWhetherPrimeNumber_ShouldEqual(int number, bool expectedResult)
        {
            // Act
            var result = primeNumberService.CheckWhetherPrimeNumber(number);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(4, true)]
        public void CheckWhetherPrimeNumber_ShouldNotEqual(int number, bool expectedResult)
        {
            // Act
            var result = primeNumberService.CheckWhetherPrimeNumber(number);

            // Assert
            Assert.NotEqual(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        [InlineData(4, 5)]
        public void GetNextPrimeNumber_ShouldNextPrimeNumber(int number, int nextPrimeNumber)
        {
            // Act
            var result = primeNumberService.GetNextPrimeNumber(number);

            // Assert
            Assert.Equal(nextPrimeNumber, result);
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 3)]
        [InlineData(4, 6)]
        public void GetNextPrimeNumber_ShouldNotNextPrimeNumber(int number, int nextPrimeNumber)
        {
            // Act
            var result = primeNumberService.GetNextPrimeNumber(number);

            // Assert
            Assert.NotEqual(nextPrimeNumber, result);
        }
    }
}
