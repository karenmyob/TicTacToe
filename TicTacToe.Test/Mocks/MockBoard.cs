using System.Collections.Generic;

namespace TicTacToe.Test
{
    public class MockBoard : BoardInterface
    {
        public string[,] Moves { get; } = {{".", "X", "."}, {".", "X", "."}, {".", "X", "."}};
        public int MoveCount { get; private set; } = 0;
        private bool _quit = false;
        private bool _full = false;
        private bool _win = false;



        public BoardInterface AddMove(int x, int y, string token)
        {
            return this;
        }

        public List<Move> GetMoves(string symbol)
        {
            throw new System.NotImplementedException();
        }

        public void QuitGame()
        {
            _quit = true;
        }

        public bool IsQuit()
        { 
            return _quit;
        }

        public bool IsFull()
        {
            return _full;
        }

        public bool DidWin()
        {
            return _win;
        }

    }
}