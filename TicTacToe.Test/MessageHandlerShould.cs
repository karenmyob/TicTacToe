using Xunit;

namespace TicTacToe.Test
{
    public class MessageHandlerShould
    {    
        [Fact]
        public void ReturnWelcomeMessage()
        {
            var messageHandler = new MessageHandler();
            string result = messageHandler.GetWelcomeMessage();
            Assert.Equal("Welcome to Tic Tac Toe!",result);

        }
    }

    public class MessageHandler
    {
        public string GetWelcomeMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}