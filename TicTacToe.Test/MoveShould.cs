using System;
using System.Collections.Generic;
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

        [Fact]
        public void SortByXValue()
        {
            var move = new Move(2,2);
            var move2 = new Move(1,2);
            var move3= new Move(3,2);
            var moveList = new List<Move> {move, move2, move3};
            var expected = new List<Move> {move2, move, move3};
            moveList.Sort();
            Assert.Equal(moveList,expected);
        }
    }
}