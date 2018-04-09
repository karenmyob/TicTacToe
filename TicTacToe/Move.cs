using System;

namespace TicTacToe
{
    public class Move //: IComparable<Move>
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Move))
            {
                var move = (Move) obj;
                return move.x == this.x && move.y == this.y;
            }
            return base.Equals(obj);
        }
                
       /* public int CompareTo(Move other)
        {
            return x.CompareTo(other.x);
        }*/

    }
}