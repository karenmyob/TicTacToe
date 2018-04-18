using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEngineInput input = new GameEngineInput();
            var executionDictionary = new Dictionary<InputValidatorInterface,InputHandlerInterface>
            {
                {new CommandValidator(), new CommandHandler(new ConsoleWriter())},
                {new PositionValidator(), new PositionHandler(new ConsoleWriter())},
                {new InvalidValidator(), new InvalidHandler(new ConsoleWriter())}
         
            };
            
         
                //inputHandler.GetInput(new ConsoleReader(),executionDictionary, board);
                
           
        }
    }
}
