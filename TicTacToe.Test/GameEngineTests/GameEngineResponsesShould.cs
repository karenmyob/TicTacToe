using System.Collections.Generic;
using Xunit;

namespace TicTacToe.Test
{
    public class MessageHandlerShould
    {   
        
        private readonly Board _board;
        private readonly GameEngineResponses _gameEngineResponses;

        public MessageHandlerShould()
        {
            _board =  new Board();
            _gameEngineResponses = new GameEngineResponses();
        }
        [Fact]
        public void ReturnWelcomeMessage()
        {
            var result = _gameEngineResponses.GetWelcomeMessage(_board);           
            var boardRenderer = new BoardRenderer(_board);
            
            Assert.Equal("Welcome to Tic Tac Toe!\n\nHere's the current board:\n\n"+boardRenderer.ToText(),result);
        }
        
        [Fact]
        public void ReturnInstructionWithPlayerNameX()
        {
            var result = _gameEngineResponses.GetInstruction("X");
            Assert.Equal("Player 1 enter a coord x,y to place your X or enter 'q' to give up: ",result);
        }
        
        [Fact]
        public void ReturnInstructionWithPlayerNameO()
        {
            var result = _gameEngineResponses.GetInstruction("O");
            Assert.Equal("Player 2 enter a coord x,y to place your O or enter 'q' to give up: ",result);
        }

        [Fact]
        public void ReturnAcceptedMoveMessage()
        {
            _board.AddMove(1, 1, "X");
            var boardRenderer = new BoardRenderer(_board);
            var result = _gameEngineResponses.GetAcceptedMoveMessageAndBoard(_board);
            Assert.Equal("Move Accepted, here's the current board:\n"+boardRenderer.ToText(),result);
            
        }

        [Fact]
        public void ReturnMessageForTakenSpace()
        {
            var result = _gameEngineResponses.GetMoveTakenMessage();
            Assert.Equal("Oh no, a piece is already at this place! Try again...\n",result);
        }

        [Fact]
        public void ReturnWinMessage()
        {
            var result = _gameEngineResponses.GetWinMessageAndBoard(_board);
            var renderer = new BoardRenderer(_board);
            Assert.Equal("Move accepted, well done you've won the game!\n\n"+renderer.ToText(),result);

        }
        [Fact]
        public void ReturnMessageForInvalidInput()
        {
            var result = _gameEngineResponses.GetInvalidMessage();
            Assert.Equal("Invalid...\n",result);
        }

        [Fact]
        public void ReturnQuitMessage()
        {
            var result = _gameEngineResponses.GetQuitMessage();
            Assert.Equal("You quit the game\n",result);
        }
    }
}