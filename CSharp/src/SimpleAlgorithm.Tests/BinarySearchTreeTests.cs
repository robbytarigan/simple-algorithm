using Xunit;

namespace SimpleAlgorithm.Tests
{
    public class BinarySearchTreeTests
    {
        private readonly Node n1;
        private readonly Node n3;
        private readonly Node n2;   

        public BinarySearchTreeTests()
        {
            n1 = new Node(1, null, null);
            n3 = new Node(3, null, null);
            n2 = new Node(2, n1, n3);
        }

        [Theory]
        [InlineData(true, 3)]
        [InlineData(false, 30)]
        public void Contains_should_return_correct_value(bool expected, int value)
        {
            var result = BinarySearchTree.Contains(n2, value);
            Assert.Equal(expected, result);
        }
    }
}
