using System;
using Xunit;

namespace TicTacToe.Test
{
    public class MoveShould
    {
        [Fact]
        public void HaveAnXAndYValue()
        {
            var move = new Move(1,2);
            Assert.Equal(1,move.X);
            Assert.Equal(2,move.Y);
        }

        [Fact]
        public void EqualToAnEqualMove()
        {
            var move = new Move(1,2);
            var move2 = new Move(1,2);
            Assert.True(move.Equals(move2));
            Assert.Equal(move, move2);

        }
        [Fact]
        public void NotEqualToDifferentMove()
        {
            var move = new Move(2,2);
            var move2 = new Move(1,2);
            Assert.False(move.Equals(move2));
            Assert.NotEqual(move, move2);
        }
    }
}