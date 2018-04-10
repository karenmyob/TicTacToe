using Xunit;

namespace TicTacToe.Test
{
    public class BoardRendererShould
    {
        [Fact]
        public void ReturnBoard()
        {
            var board = new Board();
            board
                .AddMove(1, 1, "X")
                .AddMove(1, 3, "O")
                .AddMove(2, 2, "X")
                .AddMove(3, 3, "O");

            var renderer = new BoardRenderer();
            var stringBoard= renderer.ConvertToPrintableString(board);
            var expectedString = "X..\n.X.\nO.O";
            Assert.Equal(expectedString,stringBoard);

        }
    }

    public class BoardRenderer
    {
        public string ConvertToPrintableString(Board board)
        {
            throw new System.NotImplementedException();
        }
    }
}