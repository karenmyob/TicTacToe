using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TicTacToe.Test
{
    public class UserInputHandlerShould
    {
        public void GetMoveFromUser()
        {
            InputReader inputReader;
            InputValidator inputValidator;
            
            var inputHandler = new UserInputHandler();
            var result = inputHandler.GetInput(inputReader,inputValidator)
            Assert.True(result);
        }
    }

    public class UserInputHandler
    {
        public bool GetInput(InputReader inputReader, InputValidator inputValidator)
        {
            throw new System.NotImplementedException();
        }
    }
}