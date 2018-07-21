using Xunit;

namespace SimpleAlgorithm.Tests
{
    public class TrainCompositionTests
    {
        [Fact]
        public void Should_attach_and_detach_correctly()
        {
            int wagon1 = 7, wagon2 = 13;

            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(wagon1);
            tree.AttachWagonFromLeft(wagon2);

            Assert.Equal(wagon1, tree.DetachWagonFromRight()); // 7 
            Assert.Equal(wagon2, tree.DetachWagonFromLeft()); // 13
        }
    }
}
