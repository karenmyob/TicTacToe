using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputHandler inputHandler = new UserInputHandler();
            var executionDictionary = new Dictionary<InputValidator,InputHandler>()
            {
                {new CommandValidator(), new CommandHandler(),},
                {new PositionValidator(), fakeInputHandler}
         
            };
            inputHandler.GetInput(new ConsoleReader(), );
        }
    }
}
