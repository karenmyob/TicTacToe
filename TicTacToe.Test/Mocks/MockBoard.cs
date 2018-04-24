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
            MoveCount += 1;
            return this;
        }

        public List<Move> GetMoves(string symbol)
        {
            throw new System.NotImplementedException();
        }

        public void QuitGame()
        {
            throw new System.NotImplementedException();
        }

        public bool IsQuit()
        {
            return false;
        }

        public bool IsFull()
        {
            return false;
        }

        public bool DidWin()
        {
            return true;
        }

        public void SetQuit()
        {
            _quit = true;
        }

        public void SetFull()
        {
            _full = true;
        }

        public void SetWin()
        {
            _win = true;
        }
    }
}