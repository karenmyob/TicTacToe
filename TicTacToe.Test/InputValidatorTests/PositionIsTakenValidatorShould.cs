using Xunit;

namespace TicTacToe.Test
{
    public class PositionIsTakenValidatorShould
    {
        [Fact]
        public void ValidateIfAPositionIsValidButTaken()
        {
            var board = new Board(new OutputHandlerForTesting());
            board.AddMove(1, 1, "X");
            var positionIsTakenValidator = new PositionIsTakenValidator(board);
            Assert.True(positionIsTakenValidator.IsValid("1,1"));
            
        }
        [Fact]
        public void ValidateIfAPositionIsValidButNotTaken()
        {
            var board = new Board(new OutputHandlerForTesting());
            board.AddMove(1, 1, "x");
            var positionIsTakenValidator = new PositionIsTakenValidator(board);
            Assert.False(positionIsTakenValidator.IsValid("1,2"));
            
        }
    }
}