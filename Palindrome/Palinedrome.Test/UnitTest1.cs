using palindrome.Library;
using System;
using Xunit;

namespace Palinedrome.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abc", "hello", "madam")]
        [InlineData("")]
        [InlineData("racecaR","nurses run")]
        public void isPalindromeShouldReturnTrueOrFalse(string words, params string[] values)
        {
            //arange
            var c = new palindrome();


        }

        [Fact]

    }
}
