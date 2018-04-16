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
            OutputHandlerForTesting outputHandlerForTesting = new OutputHandlerForTesting();
            CommandHandler inputHandler = new CommandHandler(outputHandlerForTesting);
            //inputHandler.Execute("q",new Board()); //I have no idea how to test this
            
        }
    }

    public class OutputHandlerForTesting : OutputHandlerInterface
    {
        //public display
        public void Write(string displayItem)
        {
            //ljkjlkkl
        }
    }

    public class MoveHandlerShould
    {
        [Fact]
        public void AcceptAMove()
        {
            var outputForTesting = new OutputHandlerForTesting();
            var inputHandler = new PositionHandler(outputForTesting);
            //inputHandler.Execute("1,3",new Board()); //I have no idea how to test this
        }

    }
}