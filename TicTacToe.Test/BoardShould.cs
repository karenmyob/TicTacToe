using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TicTacToe.Test
{
    public class BoardShould
    {
        private readonly Board _board;

        public BoardShould()
        {
            _board =  new Board();
        }
        
        [Fact]
        public void HaveAnInitialBlankState()
        {
            Assert.Equal(_board.Moves, new string[3,3]);           
        }

        [Fact]
        public void AddPlayerMoves()
        {            
            var move1 = new Move(1,2);
            _board.AddMove(move1, "X");
            
            var expectedBoard = new string[3,3];
            expectedBoard[move1.x, move1.y] = "X";

            Assert.Equal(expectedBoard, _board.Moves);
        }
    }
}