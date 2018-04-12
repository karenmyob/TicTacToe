using System.Text.RegularExpressions;
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

    public class NameValidator : InputValidator
    {
        public bool IsValid(string input)
        {
            var regex = new Regex("^[A-Za-z0-9 ]*$");
            return regex.IsMatch(input)&& input.Length>0 && input.Length<14;
        }
    }
}