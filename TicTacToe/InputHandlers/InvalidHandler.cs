using System.Collections.Generic;

namespace TicTacToe
{
    public class InvalidHandler : InputHandlerInterface
    {
        private readonly InputReaderInterface _inputReader;
        private readonly Dictionary<InputValidatorInterface, InputHandlerInterface> _executionHandler;
        

        public InvalidHandler(InputReaderInterface inputReader, Dictionary<InputValidatorInterface, InputHandlerInterface> executionHandler)
        {
            _inputReader = inputReader;
            _executionHandler = executionHandler;
        }

        public Board Execute(string input, Board board)
        {
            var gameEngineInput = new GameEngineInput();
            return gameEngineInput.GetInput(_inputReader, _executionHandler, board);
        }
    }
}