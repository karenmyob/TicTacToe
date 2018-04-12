using System;
using System.Collections.Generic;

namespace TicTacToe.Test
{
    public class TestUserInputReader : InputReader
    {
        private int _index = -1;
        private readonly List<string> _fakeUserInputList = new List<string>();

        public TestUserInputReader(string fakeUserInput)
        {
            _fakeUserInputList.Add(fakeUserInput);
        }

        public TestUserInputReader(List<string> inputList)
        {
            _fakeUserInputList = inputList;
        }
        public string ReadInput()
        {
            _index += 1;
            return _fakeUserInputList[_index];
        }
    }
}