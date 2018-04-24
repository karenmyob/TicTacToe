using System.Collections.Generic;
using System.Net.Http;

namespace TicTacToe
{
    public class GameEngine
    {
        private readonly InputReaderInterface _inputReader;
        private readonly OutputWriterInterface _outputWriter;
        private readonly Dictionary<InputValidatorInterface, InputHandlerInterface> _executioner;
        private readonly GameEngineResponses _gameEngineResponses = new GameEngineResponses();
        private readonly BoardInterface _board;

        public GameEngine(OutputWriterInterface outputWriter, InputReaderInterface inputReader, Dictionary<InputValidatorInterface, InputHandlerInterface> executioner, BoardInterface board)
        {
            _outputWriter = outputWriter;
            _inputReader = inputReader;
            _executioner = executioner;
            _board = board;
        }

        public void RunGame()
        {
            //var _board= new Board(_outputWriter);
            var inputEngine = new GameEngineInput(_outputWriter);
            var isGameOver = false;
            var numOfMoves = _board.MoveCount;
            _outputWriter.Write(_gameEngineResponses.GetWelcomeMessage(_board));
            
           do
            {
                while(_board.MoveCount== numOfMoves) //until a move is accepted
                    inputEngine.GetInput(_inputReader, _executioner, _board);
                numOfMoves = _board.MoveCount;

                isGameOver = _board.IsQuit() || _board.DidWin()|| _board.IsFull();
            } while (!isGameOver);
            
            
        }
    }
}