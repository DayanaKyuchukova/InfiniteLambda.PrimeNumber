using InfiniteLambda.PrimeNumber.Api.Controllers;
using InfiniteLambda.PrimeNumber.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace InfiniteLambda.PrimeNumber.UnitTests.Controllers
{
    public class PrimeNumberControllerTests
    {
        private readonly PrimeNumberController primeNumberController;
        private readonly Mock<IPrimeNumberService> primeNumberService;

        public PrimeNumberControllerTests()
        {
            this.primeNumberService = new Mock<IPrimeNumberService>();
            this.primeNumberController = new PrimeNumberController(this.primeNumberService.Object);
        }

        [Fact]
        public void IsPrimeNumber_ShouldInvokeIsPrimeNumber()
        {
            // Arrange
            this.primeNumberService.Setup(e => e.CheckWhetherPrimeNumber(It.IsAny<int>()))
                .Returns(It.IsAny<bool>());

            // Act
            var result = primeNumberController.IsPrimeNumber(It.IsAny<int>());

            // Assert
            Assert.IsType<OkObjectResult>(result);
            this.primeNumberService.Verify(x => x.CheckWhetherPrimeNumber(It.IsAny<int>()), Times.Once());
        }

        [Fact]
        public void GetNextPrimeNumber_ShouldInvokeGetNextPrimeNumber()
        {
            // Arrange
            this.primeNumberService.Setup(e => e.GetNextPrimeNumber(It.IsAny<int>()))
                .Returns(It.IsAny<int>());

            // Act
            var result = primeNumberController.GetNextPrimeNumber(It.IsAny<int>());

            // Assert
            Assert.IsType<OkObjectResult>(result);
            this.primeNumberService.Verify(x => x.GetNextPrimeNumber(It.IsAny<int>()), Times.Once());
        }
    }
}
