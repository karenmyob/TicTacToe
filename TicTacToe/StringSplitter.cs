using System;

namespace TicTacToe
{
    public class StringSplitter
    {
        public int GetY(string input) // put in string spliter object
        {
            var parts = input.Split(",");
            return Int32.Parse(parts[1]);
        }

        public int GetX(string input)
        {
            var parts = input.Split(",");
            return Int32.Parse(parts[0]);
        }
    }
}