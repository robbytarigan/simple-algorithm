using Xunit;

namespace SimpleAlgorithm.Tests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("Deleveled", true)]
        [InlineData("Del", false)]
        [InlineData("Telet", true)]
        [InlineData("Teet", true)]
        public void Should_return_correct_palindrome(string value, bool expected)
        {            
            var result = Palindrome.IsPalindrome(value);
            Assert.Equal(expected, result);
        }
    }
}
