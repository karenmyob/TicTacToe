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

            var executionDictionary = new Dictionary<InputValidatorInterface, InputHandlerInterface>
            {
                {new CommandValidator(), new CommandHandler(outputHandler)},
                {new PositionValidator(), new PositionHandler(outputHandler)},
                {new InvalidValidator(), new InvalidHandler(outputHandler)}

            };

            var gameEngine = new GameEngine(outputHandler, inputReader, executionDictionary);
            gameEngine.RunGame();
            Assert.Equal("Player 1 enter a coord x,y to place your X or enter 'q' to give up: " +
                         "Move Accepted, here's the current board:\nX..\n...\n...\nInvalid..." +
                         "\nMove Accepted, here's the current board:\nX..\n...\n...\nPlayer  1 " +
                         "enter a coord x,y to place your X or en"
                         
                , outputHandler.ToDisplay);
        }
    }
}
