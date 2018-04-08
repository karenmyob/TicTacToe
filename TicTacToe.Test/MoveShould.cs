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

    public class Move
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}