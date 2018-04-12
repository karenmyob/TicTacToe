using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class MessageHandlerShould
    {   
        
        private readonly Board _board;
        private readonly MessageHandler _messageHandler;

        public MessageHandlerShould()
        {
            _board =  new Board();
            _messageHandler = new MessageHandler();
        }
        [Fact]
        public void ReturnWelcomeMessage()
        {
            var result = _messageHandler.GetWelcomeMessage(_board);           
            var boardRenderer = new BoardRenderer(_board);
            
            Assert.Equal("Welcome to Tic Tac Toe!\n\nHere's the current board:\n\n"+boardRenderer.ToText(),result);
        }
        
        [Fact]
        public void ReturnInstructionWithPlayerNameX()
        {
            var result = _messageHandler.GetInstruction("X");
            Assert.Equal("Player 1 enter a coord x,y to place your X or enter 'q' to give up: ",result);
        }
        
        [Fact]
        public void ReturnInstructionWithPlayerNameO()
        {
            var result = _messageHandler.GetInstruction("O");
            Assert.Equal("Player 2 enter a coord x,y to place your O or enter 'q' to give up: ",result);
        }

        [Fact]
        public void ReturnAcceptedMoveMessage()
        {
            _board.AddMove(1, 1, "X");
            var boardRenderer = new BoardRenderer(_board);
            var result = _messageHandler.GetAcceptedMoveMessageAndBoard(_board);
            Assert.Equal("Move Accepted, here's the current board:\n"+boardRenderer.ToText(),result);
            
        }

        [Fact]
        public void ReturnMessageForTakenSpace()
        {
            var result = _messageHandler.GetMoveTakenMessage();
            Assert.Equal("Oh no, a piece is already at this place! Try again...\n",result);
        }

        [Fact]
        public void ReturnWinMessage()
        {
            var result = _messageHandler.GetWinMessageAndBoard(_board);
            var renderer = new BoardRenderer(_board);
            Assert.Equal("Move accepted, well done you've won the game!\n\n"+renderer.ToText(),result);

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

            return player + " enter a coord x,y to place your "+symbol+" or enter 'q' to give up: ";
        }

        public string GetAcceptedMoveMessageAndBoard(Board board)
        {
            var boardRenderer = new BoardRenderer(board);
            return "Move Accepted, here's the current board:\n"+boardRenderer.ToText();
        }

        public string GetMoveTakenMessage()
        {
            return "Oh no, a piece is already at this place! Try again...\n";
        }

        public string GetWinMessageAndBoard(Board board)
        {
            var renderer = new BoardRenderer(new Board());
            return "Move accepted, well done you've won the game!\n\n" + renderer.ToText();
        }
    }
}