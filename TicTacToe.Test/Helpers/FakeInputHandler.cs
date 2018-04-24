using System.Collections.Generic;

namespace TicTacToe.Test
{
    public class FakeInputHandler : InputHandlerInterface
    {
        private readonly GameEngineInputShould _inputTest;
        
        public FakeInputHandler(GameEngineInputShould testClass)
        {
            _inputTest = testClass;
        }

        public void Execute(string input, BoardInterface board)
        {
            _inputTest.TriggerWasCalled = true;
        }
    }
}