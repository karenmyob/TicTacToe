namespace TicTacToe
{
    public class PositionIsTakenHandler : InputHandlerInterface
    {
        private readonly OutputWriterInterface _outputWriter;
        private readonly GameEngineResponses _gameEngineResponses = new GameEngineResponses();

        public PositionIsTakenHandler(OutputWriterInterface outputWriter)
        {
            _outputWriter = outputWriter;
        }

        public void Execute(string input, Board board)
        {
            _outputWriter.Write(_gameEngineResponses.GetMoveTakenMessage());
        }
    }
}