using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class WinChecker
    {
        private int NumberInARowToWin = 3;
        public bool DidWin(List<Move> moves)
        {
            if (CheckDiagonal(moves)||CheckHorizontal(moves))
                return true;
            return false;
        }

        private bool CheckHorizontal(List<Move> moves)
        {
            throw new System.NotImplementedException();
        }

        private bool CheckDiagonal(List<Move> moves)
        {
            var diagonalMoveFromTopLeft = GenerateFirstDiagonal();
            var diagonalMoveFromTopRight = GenerateSecondDiagonal();
            
            if (PlayerMadeAllRequiredMoves(moves, diagonalMoveFromTopLeft) 
                || PlayerMadeAllRequiredMoves(moves, diagonalMoveFromTopRight))
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
        
        private bool PlayerMadeAllRequiredMoves<T>(IEnumerable<T> allPlayerMoves, IEnumerable<T> requiredWinningMoves)
        {
            return requiredWinningMoves.All(i=>allPlayerMoves.Contains(i));
        }
    }
}