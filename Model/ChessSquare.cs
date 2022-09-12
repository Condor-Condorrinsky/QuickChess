using QuickChess.Model.Pieces;

namespace QuickChess.Model
{
    public class ChessSquare
    {
        public Coordinates Coords { get; set; }
        public BoardPiece Piece { get; set; }

        public ChessSquare (Coordinates coords, BoardPiece piece)
        {
            this.Coords = coords;
            this.Piece = piece;
        }

        public ChessSquare (uint row, uint column, BoardPiece piece)
        {
            this.Coords = new Coordinates(row, column);
            this.Piece = piece;
        }

        public bool IsOccupied ()
        {
            PieceFactory pf = new PieceFactory();

            if (Piece.Equals(pf.GetDefaultPiece())) return false;
            return true;
        }
    }
}