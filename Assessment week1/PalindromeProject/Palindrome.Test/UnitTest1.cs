using Palindrome.Library;
using System;
using Xunit;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abc")]
        [InlineData("")] // this test should return true if length = 0
        [InlineData("racecaR")]
        [InlineData("race. Car*")]
        public void isPalindromeShouldReturnTrueOrFalse(string words)
        {
            //arange
            var c = new PalindromeClass();

            //act
            var result = c.IsPalindrome(words);

            //assert
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void ShouldRemoveNonAlphabetChar()
        {
            //arrange
            var c = new PalindromeClass();

            //act
            string word = c.RemoveNonAlphabetChar("race. Car");

            //assert
            Assert.Equal("raceCar", word);
        }
    }
}
