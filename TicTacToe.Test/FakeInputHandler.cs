using System.Collections.Generic;

namespace TicTacToe.Test
{
    public class FakeInputHandler : InputHandlerInterface
    {
        private readonly UserInputHandlerShould inputHandlerTest;
        
        public FakeInputHandler(UserInputHandlerShould testClass)
        {
            inputHandlerTest = testClass;
        }

        public void Execute(string input, Board board)
        {
            inputHandlerTest.TriggerWasCalled = true;
        }
    }
}