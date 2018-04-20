namespace TicTacToe.Test
{
    public class OutputHandlerForTesting : OutputWriterInterface
    {
        public string ToDisplay ="";
        public void Write(string displayItem)
        {
            ToDisplay += displayItem;
        }
    }
}