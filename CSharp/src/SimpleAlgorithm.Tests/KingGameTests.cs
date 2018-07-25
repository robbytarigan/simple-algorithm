using Xunit;

namespace SimpleAlgorithm.Tests
{
    public class KingGameTests
    {
        private KingGame _game;

        public KingGameTests()
        {
            _game = new KingGame();
        }

        [Theory]
        [InlineData(3, 3, 2)]
        [InlineData(10, 1, 10)]
        [InlineData(6, 2, 5)]
        public void ReleasedNumber_should_give_correct_number(short p, short w, short expected)
        {            
            var result = _game.ReleasedNumber(p, w);
            Assert.Equal(expected, result);
        }
    }
}
