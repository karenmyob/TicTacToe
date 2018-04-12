using Xunit;

namespace TicTacToe.Test
{
    public class MessageHandlerShould
    {    
        [Fact]
        public void ReturnWelcomeMessage()
        {
            var messageHandler = new MessageHandler();
            var board = new Board();
            
            string result = messageHandler.GetWelcomeMessage(board);           
            var boardRenderer = new BoardRenderer(board);
            
            Assert.Equal("Welcome to Tic Tac Toe!\n\nHere's the current board:\n\n"+boardRenderer.ToText(),result);
        }
        
        [Fact]
        public void ReturnInstructionWithPlayerName()
        {
            var messageHandler = new MessageHandler();
            string result = messageHandler.GetInstruction("X");
            Assert.Equal("Player 1 enter a coord x,y to place your X or enter 'q' to give up: ",result);
        }

        [Fact]
        public void ReturnAcceptedMoveMessage()
        {
            
        }
    }

    public class MessageHandler
    {
        public string GetWelcomeMessage(Board board)
        {
            var boardRenderer = new BoardRenderer(board);
            return "Welcome to Tic Tac Toe!\n\nHere's the current board:\n\n"+boardRenderer.ToText();
        }

        public string GetInstruction(string symbol)
        {
            var player = "Player ";
            
            if (symbol == "X")
                player += "1";
            if(symbol == "O")
                player += "2";

            return player + " enter a coord x,y to place your X or enter 'q' to give up: ";
        }
    }
}