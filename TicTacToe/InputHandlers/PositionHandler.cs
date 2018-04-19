﻿using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class PositionHandler : InputHandlerInterface
    {
        private readonly WinChecker _winChecker = new WinChecker();
        private readonly GameEngineResponses _gameEngineResponses= new GameEngineResponses();
        private readonly OutputWriterInterface _outputHandler;
        
        public PositionHandler(OutputWriterInterface outputHandler)
        {
            _outputHandler = outputHandler;
        }

        public void Execute(string input, Board board)
        {
            var symbols = new List<string> {"X", "O"};
            var c = symbols.Count;
            
            var x = GetX(input);
            var y = GetY(input);
            
            var index = c % (symbols.Count);
            board.AddMove(x, y, symbols[index]);
            if(!board.DidWin())
                _outputHandler.Write(_gameEngineResponses.GetAcceptedMoveMessageAndBoard(board));

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