namespace TicTacToe
{
    public class Move
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}