using Xunit;

namespace TicTacToe.Test
{
    public class MoveValidatorShould
    {
        [Theory]
        [InlineData("q")]
        public void AcceptValidPostions(string input)
        {
            var moveValidator = new MoveValidator();
            var result = moveValidator.IsValid(input);
            Assert.True(result);
        }
        
        [Theory]
        [InlineData("31,1")]
        [InlineData("1,2.")]
        [InlineData("qq")]
        [InlineData("4,1")]
        public void DeclineInvalidPostions(string input)
        {
            var moveValidator = new MoveValidator();
            var result = moveValidator.IsValid(input);
            Assert.False(result);
        }
    }

    public class MoveValidator : InputValidator
    {
        public bool IsValid(string input)
        {
            return input == "q";
        }
    }
}