using Xunit;

namespace IntroductionToUnitTesting.Tests
{
    public class AdditionTests
    {
        [Fact]
        public void TestMethod_WhenInputIsTest_ShouldReturnThisResult()
        {
            // Arrange
            var input = "test";

            // Act
            var result = TestMethod(input);

            //Assert
            var expectedResult = "result";
            Assert.Equal(expectedResult, result);
        }
    }
}
