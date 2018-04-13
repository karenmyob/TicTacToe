using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace TicTacToe.Test
{
    public class UserInputHandlerShould
    {
        [Fact]
        public void GetMoveFromUser()
        {
            InputReader inputReader = new TestUserInputReader("1,1");
            InputValidator inputValidator = new PositionValidator();
            
            var inputHandler = new UserInputHandler();
            var result = inputHandler.GetInput(inputReader, inputValidator);
            
        }
    }

    public class UserInputHandler
    {
        public string GetInput(InputReader inputReader, InputValidator inputValidator)
        {
            var input = inputReader.ReadInput();
            if (inputValidator.IsValid(input))
                return input;
            
            return GetInput(inputReader, inputValidator); //ask dan how to test recursion
            //maybe further composition and take from a library of inputs
        }
    }
}