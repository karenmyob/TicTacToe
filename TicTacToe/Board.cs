namespace TicTacToe
{
    public class Board
    {
        public string[,] Moves { get; private set; }

        public Board()
        {
            Moves = new string[3,3];
        }

        public void AddMove(Move move, string token)
        {
            Moves[move.x, move.y] = token;
        }
    }
}