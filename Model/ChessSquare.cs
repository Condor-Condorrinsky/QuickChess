using QuickChess.Model.Pieces;

namespace QuickChess.Model
{
    public class ChessSquare
    {
        public uint Row { get; set; }
        public uint Column { get; set; }
        public BoardPiece? Piece { get; set; }

        public ChessSquare (uint row, uint column)
        {
            this.Row = row;
            this.Column = column;
            this.Piece = null;
        }

        public ChessSquare (uint row, uint column, BoardPiece piece)
        {
            this.Row = row;
            this.Column = column;
            this.Piece = piece;
        }

        public bool IsOccupied ()
        {
            if (Piece == null) return false;
            return true;
        }
    }
}