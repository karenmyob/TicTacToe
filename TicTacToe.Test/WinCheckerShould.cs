using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class WinCheckerShould
    {
        [Fact]
        public void IndentifyAWin()
        {
            var winChecker = new WinChecker();
            var move1 = new Move(1,1);
            var move2 = new Move(2,1);
            var moves = new List<Move>{move1,move2};
            bool result = winChecker.DidWin(moves);
        }
    }

    public class WinChecker
    {
        public bool DidWin(List<Move> moves)
        {
            throw new System.NotImplementedException();
        }
    }
}