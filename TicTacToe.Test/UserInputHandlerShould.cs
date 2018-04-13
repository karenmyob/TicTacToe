using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TicTacToe.Test
{
    public class UserInputHandlerShould
    {
        [Fact]
        public void GetValidMoveFromUser()
        {
            InputReader inputReader = new TestUserInputReader("1,1");
            InputValidator inputValidator = new PositionValidator();
            
            var inputHandler = new UserInputHandler();
            var result = inputHandler.GetInput(inputReader, inputValidator);
            Assert.Equal("1,1",result);
            
        }
        [Fact]
        public void GetInvalidMoveFromUser()
        {
            var orderedInputList = new List<string> {"j", ",2,2", "2,2", "1,1"};
            InputReader inputReader = new TestUserInputReader(orderedInputList);
            InputValidator inputValidator = new PositionValidator();
            
            var inputHandler = new UserInputHandler();
            var result = inputHandler.GetInput(inputReader, inputValidator);
            Assert.Equal("2,2",result);
            
        }
    }
}