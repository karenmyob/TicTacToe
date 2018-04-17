using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TicTacToe.Test
{
    public class GameEngineShould
    {
        [Fact]
        public void RunGame()
        {
            var outputHandler = new OutputHandlerForTesting();
            var inputReader = new TestUserInputReader("1,1");
            
            var gameEngine = new GameEngine(outputHandler,inputReader);
            
            gameEngine.RunGame();
        }
    }

    public class GameEngine
    {
        private InputReaderInterface inputHandler;
        private OutputHandlerInterface outputHandler;

        public GameEngine(OutputHandlerInterface outputHandler, InputReaderInterface inputHandler)
        {
            this.outputHandler = outputHandler;
            this.inputHandler = inputHandler;
        }

        public void RunGame()
        {
            var board= new Board();
            var inputHandler = new UserInputHandler();
            
            
            var quit = false;
            var playerWon = false;
            var boardFull = false;
            var isGameOver = false;
            
            do
            {
             
                
                isGameOver = quit || playerWon || boardFull;
            } while (!isGameOver);
            
            
            throw new System.NotImplementedException();
        }
    }
}