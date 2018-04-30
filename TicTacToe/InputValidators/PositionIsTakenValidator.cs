namespace TicTacToe
{
    public class PositionIsTakenValidator : InputValidatorInterface
    {
        private readonly PositionValidator _positionValidator = new PositionValidator();
        private readonly Board _board;
        private readonly StringSplitter _stringSplitter = new StringSplitter();
        public PositionIsTakenValidator(Board board)
        {
            _board = board;
        }

        public bool IsValid(string input)
        {
            if (!_positionValidator.IsValid(input)) 
                return false;
            var x = _stringSplitter.GetX(input);
            var y = _stringSplitter.GetY(input);
            
            return _board.Moves[x-1, y-1] != ".";
        }
    }
}