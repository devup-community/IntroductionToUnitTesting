using IntroductionToUnitTesting.Functions;
using Xunit;

namespace IntroductionToUnitTesting.Tests
{
    public class AdditionTests
    {
        [Fact]
        public void AddTwoNumbers_WhenWeAddTwoNumbers_ShouldReturnTheNumbersAddedTogether()
        {
            // Arrange
            var number1 = 1;
            var number2 = 2;

            // Act
            var result = Addition.AddTwoNumbers(number1, number2);

            //Assert
            var expectedResult = 3;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void AddTwoNumbers_WhenWeAddTwoDecimalNumbers_ShouldReturnValueOfNumbersAddedTogether()
        {
            // Arrange
            var number1 = 1.5;
            var number2 = 2.5;

            // Act
            var result = Addition.AddTwoNumbers(number1, number2);

            //Assert
            var expectedResult = 4;
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3, 3.5, 6.5)]
        [InlineData(2.5, 5, 7.5)]
        [InlineData(3, 3.5, 6.5)]
        [InlineData(43654634634, 3.5, 43654634637.5)]
        public void AddTwoNumbers_WhenWeAddThreeDecimalNumbers_ShouldReturnValueOfNumbersAddedTogether(double number1, double number2, double expectedResult)
        {
            // Act
            var result = Addition.AddTwoNumbers(number1, number2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
