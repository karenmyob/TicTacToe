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
        public void AddPlayerMove()
        {            
            _board.AddMove(1, 2, "X");
            
            var expectedBoard = new string[3,3];
            expectedBoard[0, 1] = "X";

            Assert.Equal(expectedBoard, _board.Moves);
        }

        [Fact]
        public void GetXMoves()
        {
            
        }
    }
}