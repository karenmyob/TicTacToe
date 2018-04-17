using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class PositionHandler : InputHandlerInterface
    {
        private readonly WinChecker _winChecker = new WinChecker();
        private readonly MessageHandler _messageHandler= new MessageHandler();
        private readonly OutputHandlerInterface _outputHandler;
        
        public PositionHandler(OutputHandlerInterface outputHandler)
        {
            _outputHandler = outputHandler;
        }

        public Board Execute(string input, Board board) //add a count in execute aswell
        {
            var symbols = new List<string> {"X", "O"};
            var c = symbols.Count;
            
            var x = GetX(input);
            var y = GetY(input);
            
            var index = c % (symbols.Count);
            c += 1;
            board.AddMove(x, y, symbols[index]);  /// YOU MIGHT NEED TO PASS IN THE OUTPUT HANDLER SO THE BOARD KNOWS HOW TO OUTPUT
            _outputHandler.Write(_messageHandler.GetAcceptedMoveMessageAndBoard(board));
            return board;

            /*
            if (_winChecker.DidWin(board)) //implement board.isFull()
                _outputHandler.Write(_messageHandler.GetWinMessageAndBoard(board));
            else
            {
                new UserInputHandler().GetInput(inputReader,executionHandler,board);
            }
            */



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