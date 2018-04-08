using System;
using Xunit;

namespace TicTacToe.Test
{
    public class MoveShould
    {
        [Fact]
        public void HaveAnXValue()
        {
            var move = new Move(1,2);
            Assert.Equal(1,move.x);
            Assert.Equal(2,move.y);
        }
    }
}