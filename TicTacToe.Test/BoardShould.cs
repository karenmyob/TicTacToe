using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TicTacToe.Test
{
    public class BoardShould
    {
        [Fact]
        public void HaveAnInitialBlankState()
        {
            var board = new Board();
            Assert.Equal(board.Moves, new string[3,3]);           
        }

        [Fact]
        public void AddPlayerMoves()
        {
            var board = new Board();
            
            var move1 = new Move(1,2);
            board.AddMove(move1, "X");
            
            var expectedBoard = new string[3,3];
            expectedBoard[move1.x, move1.y] = "X";

            Assert.Equal(expectedBoard, board.Moves);
        }
    }
}