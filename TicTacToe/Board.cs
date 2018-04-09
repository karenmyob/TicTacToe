using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        public List<Move> Player1Moves { get; set; }
        public List<Move> Player2Moves { get; set; }
        public string[,] Moves { get; private set; }

        public Board()
        {
            Moves = new string[3,3];
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

        public void AddMove(Move move, string token)
        {
            Moves[move.x, move.y] = token;
        }
    }
}