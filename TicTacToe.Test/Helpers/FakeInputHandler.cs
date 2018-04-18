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

        public Board Execute(string input, Board board)
        {
            _inputTest.TriggerWasCalled = true;
            return board;
        }
    }
}