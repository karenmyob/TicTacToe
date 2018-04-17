using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        public string[,] Moves { get;}
        private bool _quit; //false by default
        public int MoveCount { get; private set; }

        public Board()
        {
            MoveCount = 0;
            Moves = new string[3,3];
            Initialise();
        }

        public Board AddMove(int x,int y, string token)
        {
            Moves[x-1, y-1] = token;
            MoveCount += 1;
            return this;
        }
        
        public List<Move> GetMoves(string symbol)
        {
            var moves = new List<Move>();
            for (var i = 0; i < Moves.GetLength(0); i++)
            {
                for (var j = 0; j < Moves.GetLength(1); j++)
                {
                    if (Moves[i, j] == symbol)
                        moves.Add(new Move(i, j));
                }
            }

            return moves;
        }

        public void Initialise()
        {
            for (int i = 0; i < Moves.GetLength(0); i++)
            {
                for (int j = 0; j < Moves.GetLength(1); j++)
                {
                    Moves[i, j] = ".";
                }
            }
        }

        public void QuitGame()
        {
            _quit = true;
        }

        public bool isQuit()
        {
            return _quit;
        }

        public bool isFull()
        {
            return MoveCount == 9;
        }
    }
}