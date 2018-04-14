using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class CommandHandlerShould
    {
        public bool TriggerWasCalled;
            
        [Fact]
        public void GetTheQuitMessage()
        {
            TriggerWasCalled = false;
            OutputForTesting outputForTesting = new OutputForTesting();
            CommandHandler inputHandler = new CommandHandler(outputForTesting);
            //inputHandler.Execute("q",new Board()); //I have no idea how to test this
            
        }
    }

    public class CommandHandler : InputHandler
    {
        private Output _outputType { get;}

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

    public class OutputForTesting : Output
    {
        public void CreateOutput(string displayItem)
        {
        }
    }

    public class MoveHandlerShould
    {
        [Fact]
        public void AcceptAMove()
        {
            var outputForTesting = new OutputForTesting();
            var inputHandler = new PositionHandler(outputForTesting);
            //inputHandler.Execute("1,3",new Board()); //I have no idea how to test this
        }

    }
}