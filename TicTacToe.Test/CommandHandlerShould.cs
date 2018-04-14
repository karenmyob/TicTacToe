using System;
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
            var inputHandler = new PositionHandler(outputForTesting);
            //inputHandler.Execute("1,3",new Board()); //I have no idea how to test this
        }

    }

    public class PositionHandler : InputHandler
    {
        private readonly WinChecker _winChecker = new WinChecker();
        private readonly MessageHandler _messageHandler= new MessageHandler();
        private readonly Output _output;
        public PositionHandler(Output outputType)
        {
            _output = outputType;
        }

        public void Execute(string input, Board board, InputReader inputReader, Dictionary<InputValidator,InputHandler>  executionHandler) //add a count in execute aswell
        {
            var symbols = new List<string> {"X", "O"};
            var c = symbols.Count;
            
            var x = GetX(input);
            var y = GetY(input);
            
            var index = c % (symbols.Count);
            c += 1;
            board.AddMove(x, y, symbols[index]);

            if (_winChecker.DidWin(board)) //implement board.isFull()
                _output.CreateOutput(_messageHandler.GetWinMessageAndBoard(board));
            else
            {
                new UserInputHandler().GetInput(inputReader,executionHandler,board);
            }



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