using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TicTacToe.Test
{
    public class FakeInputHandler : InputHandler
    {
        private readonly UserInputHandlerShould inputHandlerTest;
        
        public FakeInputHandler(UserInputHandlerShould testClass)
        {
            inputHandlerTest = testClass;
        }

        public void Execute(string input)
        {
            inputHandlerTest.inputHandlerWasCalled = true;
        }
    }
    
    
    public class UserInputHandlerShould
    {
        public bool inputHandlerWasCalled;


        [Fact]
        public void GetValidMoveFromUser()
        {
            TestUserInputReader inputReader = new TestUserInputReader("1,1");
            InputValidator inputValidator = new PositionValidator();
            
            var inputHandler = new UserInputHandler();
            var fakeInputHandler = new FakeInputHandler(this);
            inputHandlerWasCalled = false;
            inputHandler.GetInput(inputReader, inputValidator, fakeInputHandler);
            
            Assert.Equal(0, inputReader.ReadIndex());
            Assert.True(inputHandlerWasCalled);
        }
        [Fact]
        public void GetUserMoveUntilValid()
        {
            var orderedInputList = new List<string> {"j", ",2,2", "82,2", "1,1"};
            TestUserInputReader inputReader = new TestUserInputReader(orderedInputList);
            InputValidator inputValidator = new PositionValidator();
            
            var inputHandler = new UserInputHandler();
            var fakeInputHandler = new FakeInputHandler(this);
            inputHandlerWasCalled = false;

            inputHandler.GetInput(inputReader, inputValidator, fakeInputHandler);

            Assert.Equal(3, inputReader.ReadIndex());
            Assert.True(inputHandlerWasCalled);
        }
    }
}