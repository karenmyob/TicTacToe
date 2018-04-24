using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class PositionValidator : InputValidatorInterface
    {
        public bool IsValid(string input)
        {
            var format = new Regex("^[1-3],[1-3]$");
            return format.IsMatch(input);
        }
    }
}