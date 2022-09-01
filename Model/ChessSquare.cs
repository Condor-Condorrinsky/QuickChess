using QuickChess.Model.Pieces;

namespace QuickChess.Model
{
    public class ChessSquare
    {
        public uint Row { get; set; }
        public uint Column { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsLegalNextMove { get; set; }
        // Allowed to be null in case the tile is empty (no piece is present on the square).
        public BoardPiece? CurrPiece { get; set; }

        public ChessSquare (uint row, uint column)
        {
            Row = row;
            Column = column;
            IsOccupied = false;
            IsLegalNextMove = false;
        }

        public ChessSquare (uint row, uint column, bool isOccupied)
        {
            Row = row;
            Column = column;
            IsOccupied = isOccupied;
            IsLegalNextMove = false;
        }

        public ChessSquare (uint row, uint column, bool isOccupied, bool isLegalNextMove)
        {
            Row = row;
            Column = column;
            IsOccupied = isOccupied;
            IsLegalNextMove = isLegalNextMove;
        }
    }
}