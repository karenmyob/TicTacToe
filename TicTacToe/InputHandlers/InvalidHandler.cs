using System.Collections.Generic;

namespace TicTacToe
{
    public class InvalidHandler : InputHandlerInterface
    {
        private readonly GameEngineResponses _gameEngineResponses = new GameEngineResponses();
        private readonly OutputWriterInterface _outputWriter;
        

        public InvalidHandler(OutputWriterInterface outputWriter)
        {
            _outputWriter = outputWriter;
        }

        public void Execute(string input, Board board)
        {
            _outputWriter.Write(_gameEngineResponses.GetInvalidMessage());
            
        }
    }
}