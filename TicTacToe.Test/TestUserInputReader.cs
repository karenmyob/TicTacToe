using System;

namespace TicTacToe.Test
{
    public class TestUserInputReader : InputReader
    {
        private readonly string _fakeUserInput;

        public TestUserInputReader(string fakeUserInput)
        {
            _fakeUserInput = fakeUserInput;
        }
        public string ReadInput()
        {
            return _fakeUserInput;
        }
    }
}