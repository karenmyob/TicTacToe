using Xunit;

namespace TicTacToe.Test
{
    public class MoveValidatorShould
    {
        [Theory]
        [InlineData("q")]
        public void AcceptValidPostions(string input)
        {
            var commmandValidator = new CommandValidator();
            var result = commmandValidator.IsValid(input);
            Assert.True(result);
        }
        
        [Theory]
        [InlineData("31,1")]
        [InlineData("1,2.")]
        [InlineData("qq")]
        [InlineData("4,1")]
        public void DeclineInvalidPostions(string input)
        {
            var commandValidator = new CommandValidator();
            var result = commandValidator.IsValid(input);
            Assert.False(result);
        }
    }
}