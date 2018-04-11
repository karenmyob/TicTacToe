using System;

namespace TicTacToe
{
    public class BoardRenderer
    {
        private Board board;
        public BoardRenderer(Board board)
        {
            this.board = board;
        }
        public string ToText()
        {
            var boardString = "";
            var boardArray = board.Moves;
            for (int i = 0; i < boardArray.GetLength(0); i++)
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardString += boardArray[j, i];
                }

                boardString += "\n";
            }
            return boardString;
        }
    }
}