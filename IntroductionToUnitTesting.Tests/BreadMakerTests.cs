using System;
using System.Collections.Generic;
using System.Text;
using IntroductionToUnitTesting.Functions;
using Xunit;

namespace IntroductionToUnitTesting.Tests
{
    public class BreadMakerTests
    {
        [Fact]
        public void MakeSimpleBread_WhenWeGiveNoIngredients_ShouldReturnNoBread()
        {
            //Arrange 
            var ingredients = new Ingredients()
            {
                Flour = 0,
                Salt = 0,
                Water = 0,
                Yeast = 0
            };

            var breadCount = BreadMaker.MakeBread(ingredients);

            var expectedResult = 0;
            Assert.Equal(expectedResult, breadCount);
        }

        [Fact]
        public void MakeSimpleBread_WhenWeGiveIngredientsForOneBread_ShouldReturnOneBread()
        {
            //Arrange 
            var ingredients = new Ingredients()
            {
                Flour = 1,
                Salt = 1,
                Water = 1,
                Yeast = 1
            };

            var breadCount = BreadMaker.MakeBread(ingredients);

            var expectedResult = 1;
            Assert.Equal(expectedResult, breadCount);
        }

        [Fact]
        public void MakeSimpleBread_WhenWeGiveIngredientsForTwoBread_ShouldReturnTwoBread()
        {
            //Arrange 
            var ingredients = new Ingredients()
            {
                Flour = 2,
                Salt = 2,
                Water = 2,
                Yeast = 2
            };

            var breadCount = BreadMaker.MakeBread(ingredients);

            var expectedResult = 2;
            Assert.Equal(expectedResult, breadCount);
        }
    }
}
