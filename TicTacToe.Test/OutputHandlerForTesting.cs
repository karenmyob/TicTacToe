namespace TicTacToe.Test
{
    public class OutputHandlerForTesting : OutputHandlerInterface
    {
        public string toDisplay ="";
        public void Write(string displayItem)
        {
            toDisplay += displayItem;
        }
    }
}