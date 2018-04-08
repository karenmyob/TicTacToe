using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToe.Tests
{
    [TestClass]
    public class BoardShould
    {
        [TestMethod]
        public void AddPlayerMove()
        {
            var board = new Board();
            board.AddMove();
        }
    }

    public class Board
    {
        public void AddMove()
        {
            throw new System.NotImplementedException();
        }
    }
}
