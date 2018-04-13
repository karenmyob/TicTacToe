using System;
using System.Dynamic;

namespace TicTacToe
{
    public class ConsoleReader : InputReader
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}