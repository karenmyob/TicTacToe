using System.Collections.Generic;

namespace TicTacToe
{
    public interface InputHandlerInterface
    {
        void Execute(string input, Board board);
    }
}