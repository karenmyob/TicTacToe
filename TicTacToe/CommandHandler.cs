using System.Collections.Generic;

namespace TicTacToe
{
    public class CommandHandler : InputHandler
    {
        private Output _outputType;

        public CommandHandler(Output outputType)
        {
            this._outputType = outputType;
        }
        
        public void Execute(string input, Board board, InputReader inputReader, Dictionary<InputValidator,InputHandler>  executionHandler)
        {
            var messageHandler = new MessageHandler();
            _outputType.CreateOutput(messageHandler.GetQuitMessage());
        }

    }
}