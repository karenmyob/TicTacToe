using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class PositionValidator : InputValidator
    {
        public bool IsValid(string input)
        {
            Regex format = new Regex("^q$|^[1-3],[1-3]$");
            return format.IsMatch(input);
        }
    }
}