using Xunit;

namespace Lab02UnitTesting.Tests
{
    public class DepositHandlerTests
    {
        [Fact]
        public void Can_add_two_decimals()
        {
            // Arrange
            decimal inputOne = (decimal)243.43;
            decimal inputTwo = (decimal)6.58;

            // Act
            decimal result = UnitTesting.Program.DepositHandler(inputOne);

            // Assert
            Assert.Equal((decimal)250.01, result);
        }

    }
}
