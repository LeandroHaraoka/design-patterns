using LegacyCodesExample;
using LegacyCodesExample.Adapters;
using Moq;
using System;
using Xunit;

namespace LegacyCodeExample.Tests
{
    public class ServiceTest
    {
        [Fact]
        public void Should_execute_calculus()
        {
            // Arrange
            var complexFinancialCalculusMock = new Mock<IComplexFinancialCalculus>();

            complexFinancialCalculusMock
                .Setup(x => x.Calculate(
                    It.IsAny<decimal>(), It.IsAny<decimal>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .Returns(1m);

            var service = new ClientService(complexFinancialCalculusMock.Object);
            
            // Act
            service.Execute();

            // Assert
            complexFinancialCalculusMock
                .Verify(x => x.Calculate(
                    It.IsAny<decimal>(), It.IsAny<decimal>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()), Times.Once);
        }
    }
}
