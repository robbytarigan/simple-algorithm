using Xunit;

namespace SimpleAlgorithm.Tests
{
    public class UserInputTests
    {
        [Theory]
        [InlineData("Test2", 'T', 'e', 's', 't', '2')]
        [InlineData("Tesx2", 'T', 'e', 's', 'x', '2')]
        [InlineData("1est2", '1', 'e', 's', 't', '2')]
        [InlineData("")]
        public void TextInput_accepts_all_characters(string expected, params char[] values)
        {
            var input = new TextInput();

            foreach (var value in values)
            {
                input.Add(value);
            }

            var result = input.GetValue();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2", 'T', 'e', 's', 'x', '2')]
        [InlineData("12", '1', 'e', 's', 't', '2')]
        [InlineData("10", '1', 'a', '0')]
        [InlineData("")]
        public void NumuericInput_accepts_numeric_characters_only(string expected, params char[] values)
        {
            var input = new NumericInput();

            foreach (var value in values)
            {
                input.Add(value);
            }

            var result = input.GetValue();

            Assert.Equal(expected, result);
        }
    }
}
