using Xunit;

namespace TicTacToe.Test
{
    public class CommandHandlerShould
    {
        public bool TriggerWasCalled;
            
        [Fact]
        public void GetTheQuitMessage()
        {
            TriggerWasCalled = false;
            OutputForTesting outputForTesting = new OutputForTesting();
            CommandHandler inputHandler = new CommandHandler(outputForTesting);
            //inputHandler.Execute("q",new Board()); //I have no idea how to test this
            
        }
    }

    public class OutputForTesting : Output
    {
        public void CreateOutput(string displayItem)
        {
        }
    }

    public class MoveHandlerShould
    {
        [Fact]
        public void AcceptAMove()
        {
            var outputForTesting = new OutputForTesting();
            var inputHandler = new PositionHandler(outputForTesting);
            //inputHandler.Execute("1,3",new Board()); //I have no idea how to test this
        }

    }
}