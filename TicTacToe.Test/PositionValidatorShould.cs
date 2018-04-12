using System.ComponentModel.DataAnnotations;
using Xunit;

namespace TicTacToe.Test
{
    public class PositionValidatorShould
    {
        [Theory]
        [InlineData("1,1")]
        [InlineData("1,2")]
        [InlineData("q")]
        public void AcceptValidPostions(string input)
        {
            var positionValidator = new PositionValidator();
            var result = positionValidator.IsValid(input);
            Assert.True(result);
        }
    }
}