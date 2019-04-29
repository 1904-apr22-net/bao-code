using Palindrome.Library;
using System;
using Xunit;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abc")]
        [InlineData("")]
        [InlineData("racecaR")]
        [InlineData("race. Car*")]
        public void isPalindromeShouldReturnTrueOrFalse(string words)
        {
            //arange
            var c = new palindrome();

            //act
            var result = c.isPalindrome(words);

            //assert
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void ShouldRemoveNonAlphabetChar()
        {
            //arrange
            var c = new palindrome();

            //act
            string word = c.removeNonAlphabetChar("race. Car");

            //assert
            Assert.Equal("raceCar", word);
        }
    }
}
