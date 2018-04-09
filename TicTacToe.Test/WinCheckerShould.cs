using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class WinCheckerShould
    {
        [Fact]
        public void IndentifyANonWin()
        {
            var winChecker = new WinChecker();
            var move1 = new Move(1,1);
            var move2 = new Move(2,1);
            var moves = new List<Move>{move1,move2};
            bool result = winChecker.DidWin(moves);
            Assert.False(result);
        }
        [Fact]
        public void IndentifyARightToLeftDiagonalWin()
        {
            var winChecker = new WinChecker();
            var move1 = new Move(1,1);
            var move2 = new Move(2,2);
            var move3 = new Move(2,2);
            var moves = new List<Move>{move1,move2,move3};
            bool result = winChecker.DidWin(moves);
            Assert.True(result);
        }
    }

    public class WinChecker
    {
        public bool DidWin(List<Move> moves)
        {
            return false;
        }
    }
}