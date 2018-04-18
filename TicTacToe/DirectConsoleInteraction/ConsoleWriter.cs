using System;

namespace TicTacToe
{
    public class ConsoleWriter : OutputWriterInterface
    {
        public void Write(string displayItem)
        {
            Console.Write(displayItem);
        }
    }
}