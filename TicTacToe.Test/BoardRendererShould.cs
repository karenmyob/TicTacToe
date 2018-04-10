using System.Linq;
using Xunit;

namespace TicTacToe.Test
{
    public class BoardRendererShould
    {
        [Fact]
        public void ReturnEmptyBoard()
        {
            var board = new Board();
            board.Initialise();
            var renderer = new BoardRenderer();
            var stringBoard = renderer.ConvertToPrintableString(board);
            var expectedString = "...\n...\n...\n";
            Assert.Equal(expectedString, stringBoard);
        }

        [Fact]
        public void ReturnFilledBoard()
        {
            var board = new Board();
            board.Initialise();
            board
                .AddMove(1, 1, "X")
                .AddMove(1, 3, "O")
                .AddMove(2, 2, "X")
                .AddMove(3, 3, "O");

            var renderer = new BoardRenderer();
            var stringBoard = renderer.ConvertToPrintableString(board);
            var expectedString = "X..\n.X.\nO.O\n";
            Assert.Equal(expectedString, stringBoard);
        }
    }

    public class BoardRenderer
    {
        public string ConvertToPrintableString(Board board)
        {
            var boardString = "";
            var boardArray = board.Moves;
            for (int i = 0; i < boardArray.GetLength(0); i++)
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardString += boardArray[j, i];
                }

                boardString += "\n";
            }

            return boardString;
        }
    }
}