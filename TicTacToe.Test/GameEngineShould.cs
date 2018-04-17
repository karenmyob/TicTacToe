using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TicTacToe.Test
{
    public class GameEngineShould
    {
        [Fact]
        public void RunGame()
        {
            var gameEngine = new GameEngine();
            var outputHandler = new OutputHandlerForTesting();
            var inputReader = new TestUserInputReader();
            gameEngine.RunGame(outputHandler);
        }
    }

    public class GameEngine
    {
        public void RunGame(OutputHandlerInterface outputHandler)
        {
            throw new System.NotImplementedException();
        }
    }
}