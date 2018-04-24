namespace TicTacToe.Test
{
    public class MockValidator : InputValidatorInterface
    {
        public bool IsValid(string input)
        {
            return true;
        }
    }
}