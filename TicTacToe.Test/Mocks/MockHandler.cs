namespace TicTacToe.Test
{
    public class MockHandler : InputHandlerInterface
    {
        public void Execute(string input, BoardInterface board)
        {
            if(input == "quit")
                board.QuitGame();
            
        }
    }
}