namespace TicTacToe
{
    public class CommandValidator : InputValidator
    {
        public bool IsValid(string input)
        {
            return input == "q";
        }
    }
}