using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class WinCheckerShould
    {
        private readonly WinChecker _winChecker;
        private Board _board;

        public WinCheckerShould()
        {
            _winChecker =  new WinChecker();
            _board = new Board();
        }
        
        [Fact]
        public void IndentifyANonWin()
        {
            var move1 = new Move(1,1);
            var move2 = new Move(2,1);
            _board.AddMove(move1,"X");
            _board.AddMove(move2,"X");
            bool result = _winChecker.DidWin(_board);
            Assert.False(result);
        }
        [Fact]
        public void IndentifyANonWin2()
        {
            _board=new Board();
            var move1 = new Move(1,1);
            var move2 = new Move(2,1);
            var move3 = new Move(1,2);
            var move4 = new Move(2,3);
            _board.AddMove(move1,"X");
            _board.AddMove(move2,"X");
            _board.AddMove(move3,"X");
            _board.AddMove(move4,"X");
            bool result = _winChecker.DidWin(_board);
            Assert.False(result);
        }
        
        [Fact]
        public void IndentifyARightToLeftDiagonalWin()
        {
            var move1 = new Move(1,1);
            var move2 = new Move(2,2);
            var move3 = new Move(3,3);
            _board.AddMove(move1,"X");
            _board.AddMove(move2,"X");
            _board.AddMove(move3,"X");
            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }
        
        [Fact]
        public void IndentifyALeftToRightDiagonalWin()
        {
            var move1 = new Move(1,3);
            var move2 = new Move(2,2);
            var move3 = new Move(3,1);
            var move4 = new Move(2,3);
            _board.AddMove(move1,"X");
            _board.AddMove(move2,"X");
            _board.AddMove(move3,"X");
            _board.AddMove(move4,"X");
            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }
        [Fact]
        public void IndentifyAHorizontalWin()
        { 
            var move1 = new Move(1,3);
            var move2 = new Move(2,2);
            var move3 = new Move(3,3);
            var move4 = new Move(2,3);
            _board.AddMove(move1,"X");
            _board.AddMove(move2,"X");
            _board.AddMove(move3,"X");
            _board.AddMove(move4,"X");
            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }
        [Fact]
        public void IndentifyAVerticalWin()
        {
            var move1 = new Move(1,3);
            var move2 = new Move(2,2);
            var move3 = new Move(2,1);
            var move4 = new Move(2,3);
            _board.AddMove(move1,"X");
            _board.AddMove(move2,"X");
            _board.AddMove(move3,"X");
            _board.AddMove(move4,"X");
            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }
    }
}