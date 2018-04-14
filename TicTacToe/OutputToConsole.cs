using System;

namespace TicTacToe
{
    public class OutputToConsole : Output
    {
        public void CreateOutput(string displayItem)
        {
            Console.WriteLine(displayItem);
        }
    }
}