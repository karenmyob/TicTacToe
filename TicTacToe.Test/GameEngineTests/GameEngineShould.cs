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
            var listOfUserMoves = new List<string> {"1,1", "2,2", "3,3"};
            var inputReader = new TestUserInputReader(listOfUserMoves);
            var  board = new MockBoard();

            var executionDictionary = new Dictionary<InputValidatorInterface, InputHandlerInterface>
            {
                {new CommandValidator(), new CommandHandler(outputHandler)},
                {new InvalidValidator(), new PositionIsTakenHandler(outputHandler)},
                {new PositionValidator(), new PositionHandler(outputHandler)},
                {new InvalidValidator(), new InvalidHandler(outputHandler)}

            };

            var gameEngine = new GameEngine(outputHandler, inputReader, executionDictionary,board);;
            gameEngine.RunGame();
            Assert.Equal("Player 1 enter a coord x,y to place your X or enter 'q' to give up: " 
                         
                , outputHandler.ToDisplay);
        }
    }
}
