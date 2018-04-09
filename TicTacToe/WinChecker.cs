using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading;

namespace TicTacToe
{
    public class WinChecker
    {
        private int NumberInARowToWin = 3;
        public bool DidWin(List<Move> moves)
        {
            if (CheckDiagonal(moves)||CheckStraight(moves))
                return true;
            return false;
        }

        private bool CheckStraight(List<Move> moves)
        {
            var yValues= FlattenToYValues(moves);
            var xValues = FlattenToXValues(moves);
            return CheckEnoughInARowToWin(yValues) || CheckEnoughInARowToWin(xValues);
        }

        private bool CheckEnoughInARowToWin(List<int> values)
        {
            values.Sort();
            var countOfMovesInARow = Reset();
            for (var i = 1; i < values.Count; i++)
            {
                if (values[i] == values[i - 1])
                    countOfMovesInARow += 1;
                else
                {
                    countOfMovesInARow = Reset();
                }

                if (countOfMovesInARow == NumberInARowToWin - 1)
                    return true;
            }

            return false;
        }

        private static int Reset()
        {
            return 0;
        }

        private List<int> FlattenToXValues(List<Move> moves)
        {
            var xValues = new List<int>();
            foreach (var move in moves)
            {
                xValues.Add(move.x);
            }

            return xValues;
        }

        private List<int> FlattenToYValues(List<Move> moves)
        {
            var yValues = new List<int>();
            foreach (var move in moves)
            {
                yValues.Add(move.y);
            }

            return yValues;
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