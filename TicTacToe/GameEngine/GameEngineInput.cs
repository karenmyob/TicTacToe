using System.Collections.Generic;

namespace TicTacToe
{
    public class GameEngineInput
    {
        private readonly OutputWriterInterface _outputWriter;
        private readonly GameEngineResponses _gameEngineResponses = new GameEngineResponses();

        public GameEngineInput(OutputWriterInterface outputWriter)
        {
            _outputWriter = outputWriter;
        }

        public void GetInput(InputReaderInterface inputReaderInterface, Dictionary<InputValidatorInterface,InputHandlerInterface>  executionHandler, Board board)
        {
            _outputWriter.Write(_gameEngineResponses.GetInstruction("X"));
            var input = inputReaderInterface.ReadInput();

            foreach (var inputValidator in executionHandler.Keys)
            {
                if (inputValidator.IsValid(input))
                {
                    executionHandler[inputValidator].Execute(input, board);
                    break;
                }
            }

        }
    }
}