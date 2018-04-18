using Xunit;

namespace TicTacToe.Test
{
    public class PositionHandlerShould
    {
        [Fact]
        public void AcceptAMove()
        {
            var outputForTesting = new OutputHandlerForTesting();
            var inputHandler = new PositionHandler(outputForTesting);
            var board = new Board();
            inputHandler.Execute("1,3",board);
            Assert.Equal(1,board.MoveCount);
        }

    }
}