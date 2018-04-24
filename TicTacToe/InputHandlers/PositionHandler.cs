using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class PositionHandler : InputHandlerInterface
    {
        private readonly WinChecker _winChecker = new WinChecker();
        private readonly GameEngineResponses _gameEngineResponses= new GameEngineResponses();
        private readonly OutputWriterInterface _outputHandler;
        private readonly StringSplitter _stringSplitter = new StringSplitter();
        
        public PositionHandler(OutputWriterInterface outputHandler)
        {
            _outputHandler = outputHandler;
        }

        public void Execute(string input, BoardInterface board)
        {
            var symbols = new List<string> {"X", "O"};
            
            var x = _stringSplitter.GetX(input);
            var y = _stringSplitter.GetY(input);
            
            var index = board.MoveCount % (symbols.Count);
            board.AddMove(x, y, symbols[index]);
            if(!board.DidWin())
                _outputHandler.Write(_gameEngineResponses.GetAcceptedMoveMessageAndBoard(board));

        }

    }
}