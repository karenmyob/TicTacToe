using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace TicTacToe.Test
{
    public class GameEngineShould
    {
        [Fact]
        public void RunGame()
        {
            var outputHandler = new OutputHandlerForTesting();
            var listOfUserMoves = new List<string> {"not quit","nq","quit"};
            var inputReader = new TestUserInputReader(listOfUserMoves);
            var  board = new MockBoard();

            var executionDictionary = new Dictionary<InputValidatorInterface, InputHandlerInterface>
            {
                {new MockValidator(), new MockHandler()}
            };

            var gameEngine = new GameEngine(outputHandler, inputReader, executionDictionary,board);;
            gameEngine.RunGame();
            Assert.Equal(inputReader.ReadIndex(), 2);
        }
    }
}
