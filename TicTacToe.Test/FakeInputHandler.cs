namespace TicTacToe.Test
{
    public class FakeInputHandler : InputHandler
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