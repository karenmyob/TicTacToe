using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        public string[,] Moves { get; private set; }

        public Board()
        {
            Moves = new string[3,3];
        }

        public Board AddMove(int x,int y, string token)
        {
            Moves[x-1, y-1] = token;

            return this;
        }
        
        public List<Move> GetMoves(string symbol)
        {
            var moves = new List<Move>();
            for (var i = 0; i < Moves.GetLength(0); i++)
            {
                for (var j = 0; j < Moves.GetLength(1); j++)
                {
                    if (Moves[i, j] == symbol)
                        moves.Add(new Move(i, j));
                }
            }

            return moves;
        }
    }
}