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

        public GameEngine(OutputWriterInterface outputWriter, InputReaderInterface inputReader, Dictionary<InputValidatorInterface, InputHandlerInterface> executioner)
        {
            this._outputWriter = outputWriter;
            this._inputReader = inputReader;
            this._executioner = executioner;
        }

        public void RunGame()
        {
            var board= new Board(_outputWriter);
            var inputEngine = new GameEngineInput(_outputWriter);
            var isGameOver = false;
            var numOfMoves = board.MoveCount;
            _outputWriter.Write(_gameEngineResponses.GetWelcomeMessage(board));
            
           do
            {
                while(board.MoveCount== numOfMoves) //until a move is accepted
                    inputEngine.GetInput(_inputReader, _executioner, board);
                numOfMoves = board.MoveCount;

                isGameOver = board.IsQuit() || board.DidWin()|| board.IsFull();
            } while (!isGameOver);
            
            
        }
    }
}