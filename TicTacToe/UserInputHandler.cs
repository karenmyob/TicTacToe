namespace TicTacToe
{
    public class UserInputHandler
    {
        public void GetInput(InputReader inputReader, InputValidator inputValidator, InputHandler inputHandler)
        {
            var input = inputReader.ReadInput();
            if (inputValidator.IsValid(input))
                inputHandler.Execute(input);
            else
                GetInput(inputReader, inputValidator, inputHandler); 
        }
    }
}