namespace TicTacToe
{
    public class CommandValidator : InputValidatorInterface
    {
        public bool IsValid(string input)
        {
            return input == "q";
        }
    }
}