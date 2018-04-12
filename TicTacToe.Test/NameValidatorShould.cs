using Xunit;

namespace TicTacToe.Test
{
    public class NameValidatorShould
    {
        [Theory]
        [InlineData("james")]
        [InlineData("kerry mayn")]
        [InlineData("james23")]
        [InlineData("q")]
        public void AcceptValidNames(string input)
        {
            var positionValidator = new NameValidator();
            var result = positionValidator.IsValid(input);
            Assert.True(result);
        }
        
        [Theory]
        [InlineData("31,1")]
        [InlineData("oo.rp")]
        [InlineData("")]
        [InlineData("ssjdhsnfkieksl")]
        public void DeclineInvalidNames(string input)
        {
            var positionValidator = new NameValidator();
            var result = positionValidator.IsValid(input);
            Assert.False(result);
        }
    }
}