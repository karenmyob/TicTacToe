using Xunit;

namespace TicTacToe.Test
{
    public class PositionHandlerShould
    {
        private readonly OutputWriterInterface _outputWriter;

        public PositionHandlerShould()
        {
            _outputWriter = new OutputHandlerForTesting();
        }
        [Fact]
        public void AcceptAMove()
        {
            var outputForTesting = new OutputHandlerForTesting();
            var inputHandler = new PositionHandler(outputForTesting);
            var board = new Board(_outputWriter);
            inputHandler.Execute("1,3",board);
            Assert.Equal(1,board.MoveCount);
        }

    }
}