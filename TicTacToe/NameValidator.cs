using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class NameValidator : InputValidator
    {
        public bool IsValid(string input)
        {
            var regex = new Regex("^[A-Za-z0-9 ]*$");
            return regex.IsMatch(input)&& input.Length>0 && input.Length<14;
        }
    }
}