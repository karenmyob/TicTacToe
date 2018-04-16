using System;

namespace TicTacToe
{
    public class OutputToConsole : OutputHandlerInterface
    {
        public void Write(string displayItem)
        {
            Console.WriteLine(displayItem);
        }
    }
}