using System.Collections.Generic;

namespace TicTacToe
{
    public class UserInputHandler
    {
        //public void GetInput(InputReader inputReader, InputValidator inputValidator, InputHandler inputHandler, Board board)
        public void GetInput(InputReader inputReader, Dictionary<InputValidator,InputHandler>  executionHandler, Board board)
        {
            var input = inputReader.ReadInput();
            var flag = true;

            foreach (var inputValidator in executionHandler.Keys)
            {
                if (inputValidator.IsValid(input))
                {
                    flag = false;
                    executionHandler[inputValidator].Execute(input, board,inputReader,executionHandler);
                }
            }
            if(flag)
                GetInput(inputReader, executionHandler, board); 
        }
    }
}