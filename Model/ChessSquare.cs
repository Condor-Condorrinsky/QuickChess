using QuickChess.Model.Pieces;

namespace QuickChess.Model
{
    public class ChessSquare
    {
        public BoardPiece Piece { get; set; }

        public ChessSquare (BoardPiece piece)
        {
            this.Piece = piece;
        }

        public bool IsOccupied ()
        {
            PieceFactory pf = new PieceFactory();

            if (Piece.Equals(pf.GetEmptyPiece())) return false;
            return true;
        }
    }
}