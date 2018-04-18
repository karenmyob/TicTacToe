using System;
using System.Dynamic;

namespace TicTacToe
{
    public class ConsoleReader : InputReaderInterface
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}