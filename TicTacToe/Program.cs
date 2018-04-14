using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputHandler inputHandler = new UserInputHandler();
            var executionDictionary = new Dictionary<InputValidator,InputHandler>
            {
                {new CommandValidator(), new CommandHandler(new OutputToConsole())},
                {new PositionValidator(), new PositionHandler(new OutputToConsole())}
         
            };
            
            inputHandler.GetInput(new ConsoleReader(),executionDictionary,new Board() );
        }
    }
}
