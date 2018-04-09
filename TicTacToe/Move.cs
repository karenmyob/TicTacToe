namespace TicTacToe
{
    public class Move
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Move))
            {
                var move = (Move) obj;
                return move.X == this.X && move.Y == this.Y;
            }
            return base.Equals(obj);
        }
    }
}