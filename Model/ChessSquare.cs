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

        public ChessSquare (int row, int column, BoardPiece piece)
        {
            if (row < 0 || column < 0) throw new ArgumentOutOfRangeException("Coordinate values cannot be negative");

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