using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Sdk;

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
        public void GetMoves()
        {
            var board = new Board();
            board.AddMove(1, 1, "R");
            board.AddMove(3, 3, "R");
            
            var expected = new List<Move> {new Move(0,0),new Move(2,2)};
            var result = board.GetMoves("R");
            Assert.Equal(expected,result);
        }

        [Fact]
        public void Quit()
        {
            var board = new Board();
            board.QuitGame();
            Assert.True(board.isQuit());
        }

        [Fact]
        public void Initialise()
        {
            _board.Initialise();
            var expected = new string[,] {{".", ".", "."}, {".", ".", "."}, {".", ".", "."}};
            Assert.Equal(expected, _board.Moves);
        }

        [Fact]
        public void ReturnIfBoardIsNotFull()
        {
            var board = new Board();
            board.AddMove(1, 1, "X");
            bool result = board.isFull();
            Assert.False(result);
        }

        [Fact]
        public void ReturnIfBoardIsFull()
        {
            var board = new Board();
            board.AddMove(1, 1, "X");
            board.AddMove(1, 2, "X");
            board.AddMove(1, 3, "X");
            
            board.AddMove(2, 1, "X");
            board.AddMove(2, 2, "X");
            board.AddMove(2, 3, "X");
            
            board.AddMove(3, 1, "X");
            board.AddMove(3, 2, "O");
            board.AddMove(3, 3, "X");
            bool result = board.isFull();
            Assert.True(result);
        }

        [Fact]
        public void IdentifyAWin()
        {
            var board = new Board();
            board.AddMove(1, 1, "X");
            board.AddMove(2, 2, "X");
            board.AddMove(3, 3, "X");
            
            Assert.True(board.DidWin());
        }
        
    }
}