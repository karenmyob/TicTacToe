using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        public List<Move> xTokens { get; set; }
        public List<Move> yTokens { get; set; }

        public Board()
        {
            xTokens = new List<Move>();
            yTokens = new List<Move>();   
        }

        public void AddPlayer1Move(Move move)
        {
            xTokens.Add(move);
        }

        public void AddPlayer2Move(Move move)
        {
            yTokens.Add(move);
        }
    }
}