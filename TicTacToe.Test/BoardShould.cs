using System;
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
            Assert.Equal(_board.Moves, new string[,]{{".", ".", "."}, {".", ".", "."}, {".", ".", "."}});           
        }

        [Fact]
        public void AddPlayerMove()
        {            
            _board.AddMove(1, 2, "X");
            
            var expectedBoard = new string[,]{{".", ".", "."}, {".", ".", "."}, {".", ".", "."}};
            expectedBoard[0, 1] = "X";

            Assert.Equal(expectedBoard, _board.Moves);
        }

        [Fact]
        public void GetXMoves()
        {
            
        }

        [Fact]
        public void Initialise()
        {
            _board.Initialise();
            var expected = new string[,] {{".", ".", "."}, {".", ".", "."}, {".", ".", "."}};
            Assert.Equal(expected, _board.Moves);
        }
    }
}