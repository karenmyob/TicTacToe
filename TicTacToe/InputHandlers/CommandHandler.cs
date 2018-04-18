using System.Collections.Generic;

namespace TicTacToe
{
    public class CommandHandler : InputHandlerInterface
    {
        private readonly OutputWriterInterface _outputHandler;

        public CommandHandler(OutputWriterInterface outputHandler)
        {
            this._outputHandler = outputHandler;
        }
        
        public Board Execute(string input, Board board)
        {
            var messageHandler = new GameEngineResponses();
            _outputHandler.Write(messageHandler.GetQuitMessage());
            board.QuitGame();
            return board;
        }

    }
}