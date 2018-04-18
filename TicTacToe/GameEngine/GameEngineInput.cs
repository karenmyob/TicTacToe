using System.Collections.Generic;

namespace TicTacToe
{
    public class GameEngineInput
    {
        GameEngineResponses _gameEngineResponses = new GameEngineResponses();
        public Board GetInput(InputReaderInterface inputReaderInterface, Dictionary<InputValidatorInterface,InputHandlerInterface>  executionHandler, Board board)
        {
            var input = inputReaderInterface.ReadInput();
            //var invaidFlag = true;

            foreach (var inputValidator in executionHandler.Keys)
            {
                if (inputValidator.IsValid(input))
                {
                    //invaidFlag = false;
                    board = executionHandler[inputValidator].Execute(input, board);
                }
            }

            // Jordan: Is this running gameplay??
         /*   if (invaidFlag) //create an invalid execution method
            {
                //invalid Message
                GetInput(inputReaderInterface, executionHandler, board);
            }*/

            return board;
        }
    }
}