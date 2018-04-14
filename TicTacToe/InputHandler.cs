using System.Collections.Generic;

namespace TicTacToe
{
    public interface InputHandler
    {
        void Execute(string input, Board board, InputReader inputReader, Dictionary<InputValidator,InputHandler>  executionHandler);
    }
}