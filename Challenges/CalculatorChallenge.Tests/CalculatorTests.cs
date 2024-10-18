using CalculatorChallenge;

namespace CalculatorChallenge.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-5, 3, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(1.5, 2.5, 4)]
        public void Calculator_Add_ShouldReturnCorrectSum(double x, double y, double expected)
        {
            // Act
            double result = _calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(3, 5, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(1.5, 2.5, -1)]
        public void Calculator_Subtract_ShouldReturnCorrectDifference(double x, double y, double expected)
        {
            // Act
            double result = _calculator.Subtract(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(0, 3, 0)]
        [InlineData(-2, -3, 6)]
        [InlineData(1.5, 2, 3)]
        public void Calculator_Multiply_ShouldReturnCorrectProduct(double a, double b, double expected)
        {
            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(0, 3, 0)]
        [InlineData(7.5, 2.5, 3)]
        public void Calculator_Divide_ShouldReturnCorrectQuotient(double a, double b, double expected)
        {
            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculator_Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}