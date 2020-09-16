using System;
using System.Collections.Generic;
using System.Text;
using IntroductionToUnitTesting.Functions;
using Xunit;

namespace IntroductionToUnitTesting.Tests
{
    public class SubtractionTests
    {
        [Fact]
        public void SubtractTwoNumbers_WhenWeSubtractTwoNumbers_ShouldReturnTheNumbersSubtractedFromEachOther()
        {
            // Arrange
            var number1 = 2;
            var number2 = 1;

            // Act
            var result = Subtraction.SubtractTwoNumbers(number1, number2);

            //Assert
            var expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SubtractTwoNumbers_WhenWeSubtractTwoDecimalNumbers_ShouldReturnTheNumbersSubtractedFromEachOther()
        {
            // Arrange
            var number1 = 2.5;
            var number2 = 1.3;

            // Act
            var result = Subtraction.SubtractTwoNumbers(number1, number2);

            //Assert
            var expectedResult = 1.2;
            Assert.Equal(expectedResult, result);
        }
    }
}
