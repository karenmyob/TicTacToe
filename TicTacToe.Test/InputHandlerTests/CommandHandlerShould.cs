using Xunit;

namespace TicTacToe.Test
{
    public class CommandHandlerShould
    {   
        private readonly OutputWriterInterface _outputWriter = new OutputHandlerForTesting();
        [Fact]
        public void GetTheQuitMessage()
        {
            OutputHandlerForTesting outputHandlerForTesting = new OutputHandlerForTesting();
            CommandHandler inputHandler = new CommandHandler(outputHandlerForTesting);
            inputHandler.Execute("q",new Board(_outputWriter)); 
            Assert.Equal("You quit the game\n",outputHandlerForTesting.ToDisplay);
            
        }
    }
}