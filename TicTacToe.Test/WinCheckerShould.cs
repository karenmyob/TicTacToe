using System.Collections.Generic;
using System.Linq;
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
            var move3 = new Move(3,3);
            var moves = new List<Move>{move1,move2,move3};
            bool result = winChecker.DidWin(moves);
            Assert.True(result);
        }
    }

    public class WinChecker
    {
        private int NumberInARowToWin = 3;
        public bool DidWin(List<Move> moves)
        {
            if (CheckDiagonal(moves))
                return true;
            return false;
        }

        private bool CheckDiagonal(List<Move> moves)
        {
            var diagonalMoveFromTopLeft = GenerateFirstDiagonal();
            var diagonalMoveFromTopRight = GenerateSecondDiagonal();
            
            if (PlayerMadeAllRequiredWinningMoves(moves, diagonalMoveFromTopLeft) 
                || PlayerMadeAllRequiredWinningMoves(moves, diagonalMoveFromTopRight))
                return true;
            return false;

        }

        private List<Move> GenerateSecondDiagonal()
        {
            var movesToWin =  new List<Move>();
            for (var i = 1; i <= NumberInARowToWin; i++)
            {
                movesToWin.Add(new Move(i, i));
            }
            return movesToWin;
        }

        private List<Move> GenerateFirstDiagonal()
        {
            var movesToWin =  new List<Move>();
            for (var i = 1; i <= NumberInARowToWin; i++)
            {
                movesToWin.Add(new Move(i, NumberInARowToWin+1-i));
            }
            return movesToWin;
        }
        
        private bool PlayerMadeAllRequiredWinningMoves<T>(IEnumerable<T> allPlayerMoves, IEnumerable<T> requiredWinningMoves)
        {
            return requiredWinningMoves.All(i=>allPlayerMoves.Contains(i));
        }
    }
}