using QuickChess.Model.Pieces;
using System.Collections.Generic;

namespace QuickChess.Model
{
    public class ChessBoard
    {
        public int Size { get; set; }
        public ChessSquare[,] Grid { get; set; }

        public ChessBoard (int size)
        {
            this.Size = size;
            this.Grid = new ChessSquare[size, size];

            for (uint i = 0; i < size; i++)
            {
                for (uint j = 0; j < size; j++)
                {
                    Grid[i, j] = new ChessSquare(i, j);
                }
            }
        }

        // Should belong to View but it's a temporary solution
        public void printBoard ()
        {
            for (uint i = 0; i < Size; i++)
            {
                for (uint j = 0; j < Size; j++)
                {
                    
                }
            }
        }

        private IDictionary<BoardPiece, string> getListOfPieces ()
        {
            IDictionary<BoardPiece, string> dict = new Dictionary<BoardPiece, string>();
            dict.Add(new Knight(), "N");

            return dict;
        }
    }
}