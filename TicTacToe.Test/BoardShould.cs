using System.Collections.Generic;
using System.Linq;
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
            
        }

        [Fact]
        public void AddFirstPlayerMove()
        {
            var board = new Board();
            var move1 = new Move(1,2);
            var move2 = new Move(2,3);
            board.AddPlayer1Move(move1);
            board.AddPlayer1Move(move2);
            Assert.Equal(new List<Move>{move1,move2},board.Player1Moves );
        }
    }

    public class Board
    {
        public List<Move> Player1Moves { get; set; }
        public List<Move> Player2Moves { get; set; }

        public Board()
        {
            Player1Moves = new List<Move>();
            Player2Moves = new List<Move>();   
        }

        public void AddPlayer1Move(Move move)
        {
            throw new System.NotImplementedException();
        }
    }
}