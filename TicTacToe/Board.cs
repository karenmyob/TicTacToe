using System.Collections.Generic;

namespace TicTacToe
{
    public class Board : BoardInterface
    {
        public string[,] Moves { get;}
        private bool _quit;
        public int MoveCount { get; private set; }
        private readonly OutputWriterInterface _outputWriter;
        private readonly GameEngineResponses _gameMessages= new GameEngineResponses();

        public Board(OutputWriterInterface outputWriter)
        {
            _outputWriter = outputWriter;
            MoveCount = 0;
            Moves = new string[3,3];
            Initialise();
        }

        public BoardInterface AddMove(int x,int y, string token)
        {
            Moves[x-1, y-1] = token;
            MoveCount += 1;
            return this;
        }
        
        public List<Move> GetMoves(string symbol)
        {
            var moves = new List<Move>();
            for (var i = 0; i < Moves.GetLength(0); i++)
            {
                for (var j = 0; j < Moves.GetLength(1); j++)
                {
                    if (Moves[i, j] == symbol)
                        moves.Add(new Move(i, j));
                }
            }

            return moves;
        }

        private void Initialise()
        {
            for (int i = 0; i < Moves.GetLength(0); i++)
            {
                for (int j = 0; j < Moves.GetLength(1); j++)
                {
                    Moves[i, j] = ".";
                }
            }
        }

        public void QuitGame()
        {
            _quit = true;
        }

        public bool IsQuit()
        {
            if (_quit)
                _outputWriter.Write(_gameMessages.GetQuitMessage());
            return _quit;
        }

        public bool IsFull()
        {
            if (MoveCount==9)
                _outputWriter.Write(_gameMessages.GetBoardFullMessage());      
            
            return MoveCount == 9;
        }

        public bool DidWin()
        {
            var winChecker = new WinChecker();
            var won = winChecker.DidWin(this);
            if(won)
                _outputWriter.Write(_gameMessages.GetWinMessageAndBoard(this));
            return won;
        }
    }
}