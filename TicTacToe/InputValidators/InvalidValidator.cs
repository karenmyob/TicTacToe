namespace TicTacToe
{
    public class InvalidValidator : InputValidatorInterface
    {
        public bool IsValid(string input)
        {
            return true;
        }
    }
}