using System.Linq;
using Xunit;

namespace TicTacToe.Test
{
    public class BoardRendererShould
    {
        private readonly Board _board;
        private readonly OutputWriterInterface _outputWriter;
        
        public BoardRendererShould()
        {
            _outputWriter = new OutputHandlerForTesting();
            _board = new Board(_outputWriter);
            
        }
        
        [Fact]
        public void ReturnEmptyBoard()
        {
            _board.Initialise();
            var renderer = new BoardRenderer(_board);
            var stringBoard = renderer.ToText();
            var expectedString = "...\n...\n...\n";
            Assert.Equal(expectedString, stringBoard);
        }

        [Fact]
        public void ReturnFilledBoard()
        {
            _board.Initialise();
            _board
                .AddMove(1, 1, "X")
                .AddMove(1, 3, "O")
                .AddMove(2, 2, "X")
                .AddMove(3, 3, "O");

            var renderer = new BoardRenderer(_board);
            var stringBoard = renderer.ToText();
            var expectedString = "X..\n.X.\nO.O\n";
            Assert.Equal(expectedString, stringBoard);
        }
        
    }
}