using System.Collections.Generic;

namespace TicTacToe
{
    public class GameEngine
    {
        private InputReaderInterface inputReader;
        private OutputWriterInterface outputWriter;
        private Dictionary<InputValidatorInterface, InputHandlerInterface> executioner;

        public GameEngine(OutputWriterInterface outputWriter, InputReaderInterface inputReader, Dictionary<InputValidatorInterface, InputHandlerInterface> executioner)
        {
            this.outputWriter = outputWriter;
            this.inputReader = inputReader;
            this.executioner = executioner;
        }

        public void RunGame()
        {
            var board= new Board();
            var inputEngine = new GameEngineInput();

            var playerWon = false;
            var isGameOver = false;
            
            do
            {
                board = inputEngine.GetInput(inputReader, executioner, board);
                var quit = board.isQuit();
                //playerWon = // add a winchecker to the board
                var boardFull = board.isFull();
                
                isGameOver = quit || playerWon || boardFull;
            } while (!isGameOver);
            
            
            throw new System.NotImplementedException();
        }
    }
}