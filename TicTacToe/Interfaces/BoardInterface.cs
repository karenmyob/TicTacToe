using System.Collections.Generic;

namespace TicTacToe
{
    public interface BoardInterface
    {
        string[,] Moves { get;}
        int MoveCount { get;}

        BoardInterface AddMove(int x, int y, string token);
        List<Move> GetMoves(string symbol);
        void QuitGame();
        bool IsQuit();
        bool IsFull();
        bool DidWin();

    }
}