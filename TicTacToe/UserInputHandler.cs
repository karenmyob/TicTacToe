using System.Collections.Generic;

namespace TicTacToe
{
    public class UserInputHandler
    {
        MessageHandler _messageHandler = new MessageHandler();
        public void GetInput(InputReader inputReader, Dictionary<InputValidator,InputHandler>  executionHandler, Board board)
        {
            var input = inputReader.ReadInput();
            var invaidFlag = true;

            foreach (var inputValidator in executionHandler.Keys)
            {
                if (inputValidator.IsValid(input))
                {
                    invaidFlag = false;
                    executionHandler[inputValidator].Execute(input, board,inputReader,executionHandler);
                }
            }

            if (invaidFlag)
            {
                //invalid Message
                GetInput(inputReader, executionHandler, board);
            }
        }
    }
}