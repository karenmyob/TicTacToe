namespace TicTacToe.Test
{
    public class OutputHandlerForTesting : OutputWriterInterface
    {
        public string toDisplay ="";
        public void Write(string displayItem)
        {
            toDisplay += displayItem;
        }
    }
}