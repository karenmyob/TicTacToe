using Xunit;

namespace TicTacToe.Test
{
    public class PositionIsTakenValidatorShould
    {
        [Fact]
        public void ValidateIfAPositionIsValidButTaken()
        {
            var board = new Board(new OutputHandlerForTesting());
            board.AddMove(1, 1, "x");
            var positionIsTakenValidator = new PositionIsTakenValidator(board, new OutputHandlerForTesting());
            
        }
    }

    public class PositionIsTakenValidator : InputValidatorInterface
    {
        private readonly OutputWriterInterface _outputWriterInterface;
        private readonly PositionValidator _positionValidator = new PositionValidator();
        private readonly Board _board;
        public PositionIsTakenValidator(Board board, OutputWriterInterface outputWriterInterface)
        {
            _board = board;
            _outputWriterInterface = outputWriterInterface;
        }

        public bool IsValid(string input)
        {
            if (_positionValidator.IsValid(input))
            {
                if()
            }
        }
    }
}