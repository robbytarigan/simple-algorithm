using Xunit;

namespace SimpleAlgorithm.Tests
{
    public class SortedSearchTests
    {
        [Theory]
        [InlineData(2, 4, 1, 3, 5, 7)]
        [InlineData(3, 6, 1, 3, 5, 7)]
        [InlineData(0, 4, null)]
        public void Count_should_count_number_less_than_correctly(int expected, int lessThan, params int[] args)
        {
            var result = SortedSearch.CountNumbers(args, lessThan);
            Assert.Equal(expected, result);
        }
    }
}
