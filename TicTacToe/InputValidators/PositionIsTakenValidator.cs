namespace TicTacToe
{
    public class PositionIsTakenValidator : InputValidatorInterface
    {
        private readonly OutputWriterInterface _outputWriterInterface;
        private readonly PositionValidator _positionValidator = new PositionValidator();
        private readonly Board _board;
        private readonly StringSplitter _stringSplitter = new StringSplitter();
        private readonly GameEngineResponses _gameEngineResponses = new GameEngineResponses();
        public PositionIsTakenValidator(Board board, OutputWriterInterface outputWriterInterface)
        {
            _board = board;
            _outputWriterInterface = outputWriterInterface;
        }

        public bool IsValid(string input)
        {
            var x = _stringSplitter.GetX(input);
            var y = _stringSplitter.GetY(input);
            if (!_positionValidator.IsValid(input)) 
                return false;
            if (_board.Moves[x-1, y-1] == ".")
                return false;
            _outputWriterInterface.Write(_gameEngineResponses.GetMoveTakenMessage());
            return true;

        }
    }
}