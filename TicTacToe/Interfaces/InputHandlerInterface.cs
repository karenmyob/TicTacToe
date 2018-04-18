using System.Collections.Generic;

namespace TicTacToe
{
    public interface InputHandlerInterface
    {
        Board Execute(string input, Board board);
    }
}