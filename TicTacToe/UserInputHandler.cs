namespace TicTacToe
{
    public class UserInputHandler
    {
        public void GetInput(InputReader inputReader, InputValidator inputValidator, InputHandler inputHandler, Board board)
        {
            var input = inputReader.ReadInput();
            if (inputValidator.IsValid(input))
                inputHandler.Execute(input,board);
            else
                GetInput(inputReader, inputValidator, inputHandler, board); 
        }
    }
}