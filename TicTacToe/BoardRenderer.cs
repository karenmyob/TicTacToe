using System;

namespace TicTacToe
{
    public class BoardRenderer
    {
        private readonly BoardInterface _board;
        public BoardRenderer(BoardInterface board)
        {
            this._board = board;
        }
        public string ToText()
        {
            var boardString = "";
            var boardArray = _board.Moves;
            for (var i = 0; i < boardArray.GetLength(0); i++)
            {
                for (var j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardString += boardArray[j, i];
                }

                boardString += "\n";
            }
            return boardString;
        }
    }
}