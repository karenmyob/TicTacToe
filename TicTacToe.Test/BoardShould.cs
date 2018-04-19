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
        private readonly OutputWriterInterface _outputWriter;

        public BoardShould()
        {
            _outputWriter = new OutputHandlerForTesting();
            _board =  new Board(_outputWriter);
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
            _board.AddMove(1, 1, "R");
            _board.AddMove(3, 3, "R");
            
            var expected = new List<Move> {new Move(0,0),new Move(2,2)};
            var result = _board.GetMoves("R");
            Assert.Equal(expected,result);
        }

        [Fact]
        public void Quit()
        {
            _board.QuitGame();
            Assert.True(_board.isQuit());
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
            _board.AddMove(1, 1, "X");
            bool result = _board.isFull();
            Assert.False(result);
        }

        [Fact]
        public void ReturnIfBoardIsFull()
        {
            _board.AddMove(1, 1, "X");
            _board.AddMove(1, 2, "X");
            _board.AddMove(1, 3, "X");
            
            _board.AddMove(2, 1, "X");
            _board.AddMove(2, 2, "X");
            _board.AddMove(2, 3, "X");
            
            _board.AddMove(3, 1, "X");
            _board.AddMove(3, 2, "O");
            _board.AddMove(3, 3, "X");
            bool result = _board.isFull();
            Assert.True(result);
        }

        [Fact]
        public void IdentifyAWin()
        {
            _board.AddMove(1, 1, "X");
            _board.AddMove(2, 2, "X");
            _board.AddMove(3, 3, "X");
            
            Assert.True(_board.DidWin());
        }
        
    }
}