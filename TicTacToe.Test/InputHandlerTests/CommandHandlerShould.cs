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
}