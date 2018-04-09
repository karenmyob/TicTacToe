using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        public List<Move> Player1Moves { get; set; }
        //public IReadOnlyList<Move> Player1Moves => _player1Moves;
        public List<Move> Player2Moves { get; set; }

        public Board()
        {
            Player1Moves = new List<Move>();
            Player2Moves = new List<Move>();   
        }

        public void AddPlayer1Move(Move move)
        {
            Player1Moves.Add(move);
        }

        public void AddPlayer2Move(Move move)
        {
            Player2Moves.Add(move);
        }
    }
}