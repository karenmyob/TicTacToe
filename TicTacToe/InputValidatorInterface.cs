namespace TicTacToe
{
    public interface InputValidatorInterface
    {
        bool IsValid(string input);

    }

    public class InvalidValidator : InputValidatorInterface
    {
        public bool IsValid(string input)
        {
            return true;
        }
    }
}