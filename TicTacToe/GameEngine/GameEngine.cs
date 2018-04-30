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
            var inputEngine = new GameEngineInput(_outputWriter);
            var isGameOver = false;
            _outputWriter.Write(_gameEngineResponses.GetWelcomeMessage(_board));
            
           do
            {
                inputEngine.GetInput(_inputReader, _executioner, _board);

                isGameOver = _board.IsQuit() || _board.DidWin()|| _board.IsFull();
            } while (!isGameOver);
            
            
        }
    }
}