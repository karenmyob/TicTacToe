using System;
using System.Collections.Generic;

namespace TicTacToe
{
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