using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board(new ConsoleWriter());
            
            var executionDictionary = new Dictionary<InputValidatorInterface,InputHandlerInterface>
            {
                {new CommandValidator(), new CommandHandler(new ConsoleWriter())},
                {new PositionIsTakenValidator(board), new PositionIsTakenHandler(new ConsoleWriter())},
                {new PositionValidator(), new PositionHandler(new ConsoleWriter())},
                {new InvalidValidator(), new InvalidHandler(new ConsoleWriter())}
         
            };
            
         
            var gameEngine = new GameEngine(new ConsoleWriter(), new ConsoleReader(), executionDictionary,board);
            gameEngine.RunGame();
                
           
        }
    }
}
