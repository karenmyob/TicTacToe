using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class BoardShould
    {
        [Fact]
        public void HaveAnInitialBlankState()
        {
            var board = new Board();
            Assert.Equal(board.Player1Moves,new List<Move>());
            Assert.Equal(board.Player2Moves, new List<Move>());
            Assert.Equal(board.AllMoves, new List<Move>());
            
        }

    }

    public class Board
    {
        public List<Move> Player1Moves { get; set; }
        public List<Move> Player2Moves { get; set; }
        public List<Move> AllMoves { get; set; }

        public Board()
        {
            Player1Moves = new List<Move>();
            Player2Moves = new List<Move>();
            AllMoves = new List<Move>();
            
        }
    }
}