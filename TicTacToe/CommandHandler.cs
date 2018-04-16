using System.Collections.Generic;

namespace TicTacToe
{
    public class CommandHandler : InputHandlerInterface
    {
        private readonly OutputHandlerInterface _outputHandler;

        public CommandHandler(OutputHandlerInterface outputHandler)
        {
            this._outputHandler = outputHandler;
        }
        
        public void Execute(string input, Board board)
        {
            var messageHandler = new MessageHandler();
            _outputHandler.Write(messageHandler.GetQuitMessage());
            board.QuitGame();
        }

    }
}