namespace QuickChess.Model
{
    public class ChessSquare
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsLegalNextMove { get; set; }

        public ChessSquare (int row, int column)
        {
            Row = row;
            Column = column;
            IsOccupied = false;
            IsLegalNextMove = false;
        }

        public ChessSquare (int row, int column, bool isOccupied)
        {
            Row = row;
            Column = column;
            IsOccupied = isOccupied;
            IsLegalNextMove = false;
        }

        public ChessSquare (int row, int column, bool isOccupied, bool isLegalNextMove)
        {
            Row = row;
            Column = column;
            IsOccupied = isOccupied;
            IsLegalNextMove = isLegalNextMove;
        }
    }
}