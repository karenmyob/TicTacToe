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
            
            //var gameEngine = new GameEngine(outputHandler,inputReader);
            
           // gameEngine.RunGame();
            //Assert.Equal();
        }
    }
}