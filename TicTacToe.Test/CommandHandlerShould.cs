using System;
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
            inputHandler.Execute("q",new Board()); //I have no idea how to test this
            
        }
    }

    public class CommandHandler : InputHandler
    {
        private Output _outputType { get;}

        public CommandHandler(Output outputType)
        {
            this._outputType = outputType;
        }
        
        public void Execute(string input, Board board)
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

    public class OutputToConsole : Output
    {
        public void CreateOutput(string displayItem)
        {
            Console.WriteLine(displayItem);
        }
    }

    public class MoveHandlerShould
    {
        [Fact]
        public void AcceptAMove()
        {
            var outputForTesting = new OutputForTesting();
            var inputHandler = new MoveHandler(outputForTesting);
            inputHandler.Execute("1,3",new Board()); //I have no idea how to test this
        }

    }

    public class MoveHandler : InputHandler
    {
        private Output _output;
        public MoveHandler(Output outputType)
        {
            _output = outputType;
        }

        public void Execute(string input, Board board)
        {
            var x = GetX(input);
            var y = GetY(input);

            board.AddMove(x, y, "X");
        }

        private int GetY(string input)
        {
            var parts = input.Split(",");
            return Int32.Parse(parts[1]);
        }

        private int GetX(string input)
        {
            var parts = input.Split(",");
            return Int32.Parse(parts[0]);
        }
    }
}