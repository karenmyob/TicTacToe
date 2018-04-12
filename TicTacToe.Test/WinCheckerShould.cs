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
            _winChecker = new WinChecker();
            _board = new Board();
        }

        [Fact]
        public void IndentifyANonWin()
        {
            _board
                .AddMove(1, 1, "X")
                .AddMove(2, 1, "X")
                .AddMove(3, 3, "O");
                                           
            bool didWin = _winChecker.DidWin(_board);
            Assert.False(didWin);
        }

        [Fact]
        public void IndentifyANonWin2()
        {
            _board
                .AddMove(1, 1, "X")
                .AddMove(2, 1, "X")
                .AddMove(1, 2, "X")
                .AddMove(2, 3, "X");
            
            bool result = _winChecker.DidWin(_board);
            Assert.False(result);
        }

        [Fact]
        public void IndentifyARightToLeftDiagonalWin()
        {
            _board
                .AddMove(3, 1, "X")
                .AddMove(2, 2, "X")
                .AddMove(1, 3, "X");

            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }

        [Fact]
        public void IndentifyALeftToRightDiagonalWin()
        {
            _board
                .AddMove(1, 1, "X")
                .AddMove(2, 2, "X")
                .AddMove(3, 3, "X");
            
            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }

        [Fact]
        public void IndentifyAHorizontalWin()
        {
            _board
                .AddMove(1, 3, "X")
                .AddMove(2, 2, "X")
                .AddMove(3, 3, "X")
                .AddMove(2, 3, "X");

            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }

        [Fact]
        public void IndentifyAHorizontalWinForO()
        {
            _board
                .AddMove(1, 3, "O")
                .AddMove(2, 2, "O")
                .AddMove(3, 3, "O")
                .AddMove(2, 3, "O");

            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }

        [Fact]
        public void IndentifyAVerticalWin()
        {
            _board
                .AddMove(1, 3, "X")
                .AddMove(2, 2, "X")
                .AddMove(2, 1, "X")
                .AddMove(2, 3, "X");
            bool result = _winChecker.DidWin(_board);
            Assert.True(result);
        }
    }
}