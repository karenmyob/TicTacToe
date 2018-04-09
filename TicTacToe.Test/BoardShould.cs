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
            Assert.Equal(board.xTokens,new List<Move>());
            Assert.Equal(board.yTokens, new List<Move>());
            
        }

        [Fact]
        public void AddPlayerMoves()
        {
            var board = new Board();
            var move1 = new Move(1,2);
            var move2 = new Move(2,3);
            var move3 = new Move(3,3);
            board.AddPlayer1Move(move1);
            board.AddPlayer1Move(move2);
            board.AddPlayer2Move(move3);
            Assert.Equal(new List<Move>{move1,move2},board.xTokens );
        }
    }
}