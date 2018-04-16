using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputHandler inputHandler = new UserInputHandler();
            var executionDictionary = new Dictionary<InputValidatorInterface,InputHandlerInterface>
            {
                {new CommandValidator(), new CommandHandler(new OutputToConsole())},
                {new PositionValidator(), new PositionHandler(new OutputToConsole())}
         
            };
            
         
                //inputHandler.GetInput(new ConsoleReader(),executionDictionary, board);
                
           
        }
    }
}
