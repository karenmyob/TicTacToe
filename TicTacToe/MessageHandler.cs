using System.Collections.Generic;

namespace TicTacToe
{
    public class MessageHandler
    {
        public string GetWelcomeMessage(Board board)
        {
            var boardRenderer = new BoardRenderer(board);
            return "Welcome to Tic Tac Toe!\n\nHere's the current board:\n\n"+boardRenderer.ToText();
        }

        public string GetInstruction(string symbol)
        {
            var player = "Player ";
            
            switch (symbol)
            {
                case "X":
                    player += "1";
                    break;
                case "O":
                    player += "2";
                    break;
            }

            return player + " enter a coord x,y to place your "+symbol+" or enter 'q' to give up: ";
        }

        public string GetAcceptedMoveMessageAndBoard(Board board)
        {
            var boardRenderer = new BoardRenderer(board);
            return "Move Accepted, here's the current board:\n"+boardRenderer.ToText();
        }

        public string GetMoveTakenMessage()
        {
            return "Oh no, a piece is already at this place! Try again...\n";
        }

        public string GetWinMessageAndBoard(Board board)
        {
            var renderer = new BoardRenderer(board);
            return "Move accepted, well done you've won the game!\n\n" + renderer.ToText();
        }

        public string GetInvalidMessage()
        {
            return "Invalid...\n";
        }

        public string GetQuitMessage()
        {
            return "You quit the game\n";
        }
    }
}