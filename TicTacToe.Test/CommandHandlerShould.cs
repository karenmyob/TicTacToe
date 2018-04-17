using Xunit;

namespace TicTacToe.Test
{
    public class CommandHandlerShould
    {      
        [Fact]
        public void GetTheQuitMessage()
        {
            OutputHandlerForTesting outputHandlerForTesting = new OutputHandlerForTesting();
            CommandHandler inputHandler = new CommandHandler(outputHandlerForTesting);
            inputHandler.Execute("q",new Board()); 
            Assert.Equal("You quit the game\n",outputHandlerForTesting.toDisplay);
            
        }
    }

    public class PositionHandlerShould
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