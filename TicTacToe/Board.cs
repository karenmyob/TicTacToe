using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        public List<Move> xTokens { get; private set; }
        public List<Move> oTokens { get; private set; }

        public Board()
        {
            xTokens = new List<Move>();
            oTokens = new List<Move>();   
        }

        public void AddXToken(Move move)
        {
            xTokens.Add(move);
        }

        public void AddYToken(Move move)
        {
            oTokens.Add(move);
        }
    }
}