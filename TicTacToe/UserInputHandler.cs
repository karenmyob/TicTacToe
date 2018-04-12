namespace TicTacToe
{
    public class UserInputHandler
    {
        public string GetInput(InputReader inputReader, InputValidator inputValidator)
        {
            var input = inputReader.ReadInput();
            if (inputValidator.IsValid(input))
                return input;
            
            return GetInput(inputReader, inputValidator); 
        }
    }
}