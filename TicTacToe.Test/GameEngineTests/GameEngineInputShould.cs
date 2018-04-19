using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TicTacToe.Test
{
    public class GameEngineInputShould
    {
        public bool TriggerWasCalled;
        private readonly OutputWriterInterface _outputWriter;

        public GameEngineInputShould()
        {
            _outputWriter = new OutputHandlerForTesting();
        }


        [Fact]
        public void GetValidMoveFromUser()
        {
 
            TestUserInputReader inputReader = new TestUserInputReader("1,1");
            
            var inputHandler = new GameEngineInput(_outputWriter);
            var fakeInputHandler = new FakeInputHandler(this);
            TriggerWasCalled = false;
            
            var executionDictionary = new Dictionary<InputValidatorInterface,InputHandlerInterface>()
            {
                {new CommandValidator(), fakeInputHandler},
                {new PositionValidator(), fakeInputHandler}
         
            };
            inputHandler.GetInput(inputReader, executionDictionary, new Board(_outputWriter));
            
            Assert.Equal(0, inputReader.ReadIndex());
            Assert.True(TriggerWasCalled);
        }
        [Fact]
        public void GetUserMoveUntilValid()
        {
            var orderedInputList = new List<string> {"j", ",2,2", "82,2", "1,1"};
            TestUserInputReader inputReader = new TestUserInputReader(orderedInputList);
            InputValidatorInterface inputValidatorInterface = new PositionValidator();
            
            var inputHandler = new GameEngineInput(_outputWriter);
            var fakeInputHandler = new FakeInputHandler(this);
            TriggerWasCalled = false;
            
            var executionDictionary = new Dictionary<InputValidatorInterface,InputHandlerInterface>()
            {
                {new CommandValidator(), fakeInputHandler},
                {new PositionValidator(), fakeInputHandler}
         
            };
            
            inputHandler.GetInput(inputReader, executionDictionary, new Board(_outputWriter));

            Assert.Equal(3, inputReader.ReadIndex());
            Assert.True(TriggerWasCalled);
        }
    }
}